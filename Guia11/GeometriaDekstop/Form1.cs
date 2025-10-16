using System.Drawing.Drawing2D;
using System.Windows.Forms;
using GeometriaModels.Models;
using GeometriaModels.Servicio;

namespace GeometriaDekstop;

public partial class Form1 : Form
{
    FigurasService _figurasService;

    public Form1(FigurasService figurasService)
    {
        InitializeComponent();
        _figurasService = figurasService;
        lvwInicializar();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        tbAlto.Clear();
        tbAncho.Clear();
        tbRadio.Clear();
        tbArea.Clear();
        //_figurasService.AddFigura(new RectanguloModel { Largo = 1 });
    }


    #region lvw redibujado
    public void lvwInicializar()
    {
        lvwFiguras.View = View.Tile;
        lvwFiguras.FullRowSelect = true;
        lvwFiguras.HideSelection = false;
        lvwFiguras.OwnerDraw = true;
        lvwFiguras.TileSize = new Size(300, 100);
        lvwFiguras.BackColor = Color.WhiteSmoke;
        lvwFiguras.BorderStyle = BorderStyle.None;
        lvwFiguras.DrawItem += lvwFiguras_DrawItem;
        lvwFiguras.SelectedIndexChanged += lvwFiguras_SelectedIndexChanged;
    }

    private GraphicsPath RoundedRect(Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(bounds.Location, size);
        GraphicsPath path = new GraphicsPath();

        path.AddArc(arc, 180, 90);

        arc.X = bounds.Right - diameter;
        path.AddArc(arc, 270, 90);

        arc.Y = bounds.Bottom - diameter;

        path.AddArc(arc, 0, 90);

        arc.X = bounds.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
    private void lvwFiguras_DrawItem(object sender, DrawListViewItemEventArgs e)
    {
        var rect = e.Bounds;

        Color backColor = e.Item.Selected ? Color.LightBlue : Color.White;
        Color borderColor = e.Item.Selected ? Color.DodgerBlue : Color.LightGray;

        using (var brush = new SolidBrush(backColor))
        using (var pen = new Pen(borderColor, 2))
        {
            int radius = 10;
            var path = RoundedRect(rect, radius);
            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawPath(pen, path);
        }

        string text = e.Item.Text;
        var fontTitle = new Font("Segoe UI", 10, FontStyle.Bold);
        var fontSub = new Font("Segoe UI", 9, FontStyle.Regular);

        e.Graphics.DrawString(text, fontTitle, Brushes.Black, rect.X + 10, rect.Y + 10);

        int offsetY = 30;
        foreach (ListViewItem.ListViewSubItem sub in e.Item.SubItems)
        {
            if (sub == e.Item.SubItems[0]) continue;
            e.Graphics.DrawString(sub.Text, fontSub, Brushes.DimGray, rect.X + 10, rect.Y + offsetY);
            offsetY += 18;
        }
    }
    private void lvwFiguras_SelectedIndexChanged(object sender, EventArgs e)
    {
        lvwFiguras.Invalidate();
    }
    #endregion

    private void button2_Click(object sender, EventArgs e)
    {
        if (radioRectangulo.Checked)
        {
            double largo = Convert.ToDouble(tbAlto.Text);
            double alto = Convert.ToDouble(tbAlto.Text);
            _figurasService.AddFigura(new RectanguloModel { Largo = largo, Ancho = alto });
            MessageBox.Show("se creo un rectangulo model");
        }
        else if (radioCirculo.Checked)
        {
            double radio = Convert.ToDouble(tbAlto.Text);
            _figurasService.AddFigura(new CirculoModel { Radio = radio });
            MessageBox.Show("se creo un circulo model");
        }
        else
        {
            MessageBox.Show("seleccione un tipo");
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        List<FiguraModel> figuras = _figurasService.GetAll();
        lvwFiguras.Items.Clear();

        foreach (var figura in figuras)
        {
            ListViewItem item = null;

            if (figura is CirculoModel c)
            {
                item = new ListViewItem($"Círculo #{c.Id}");
                item.SubItems.Add($"Área: {c.Area:F2}");
                item.SubItems.Add($"Radio: {c.Radio:F2}");
            }
            else if (figura is RectanguloModel r)
            {
                item = new ListViewItem($"Rectángulo #{r.Id}");
                item.SubItems.Add($"Área: {r.Area:F2}");
                item.SubItems.Add($"Ancho: {r.Ancho:F2}, Largo: {r.Largo:F2}");
            }

            if (item != null)
            {
                item.Tag = figura;
                lvwFiguras.Items.Add(item);
            }
        }
    }
}


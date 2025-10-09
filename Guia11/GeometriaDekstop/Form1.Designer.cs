namespace GeometriaDekstop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            tbRadio = new TextBox();
            textBox3 = new TextBox();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioCirculo = new RadioButton();
            radioRectangulo = new RadioButton();
            groupBox3 = new GroupBox();
            lvwFiguras = new ListView();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(380, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 0;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la figura";
            // 
            // button2
            // 
            button2.Location = new Point(380, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 10;
            button2.Text = "Confirmar Registro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(248, 102);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 23);
            tbRadio.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(248, 69);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(100, 23);
            tbAlto.TabIndex = 7;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(248, 29);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 137);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 105);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 72);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Alto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Ancho";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioCirculo);
            groupBox2.Controls.Add(radioRectangulo);
            groupBox2.Location = new Point(25, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(145, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Figura";
            // 
            // radioCirculo
            // 
            radioCirculo.AutoSize = true;
            radioCirculo.Location = new Point(20, 64);
            radioCirculo.Name = "radioCirculo";
            radioCirculo.Size = new Size(63, 19);
            radioCirculo.TabIndex = 1;
            radioCirculo.TabStop = true;
            radioCirculo.Text = "Circulo";
            radioCirculo.UseVisualStyleBackColor = true;
            // 
            // radioRectangulo
            // 
            radioRectangulo.AutoSize = true;
            radioRectangulo.Location = new Point(20, 31);
            radioRectangulo.Name = "radioRectangulo";
            radioRectangulo.Size = new Size(85, 19);
            radioRectangulo.TabIndex = 0;
            radioRectangulo.TabStop = true;
            radioRectangulo.Text = "Rectangulo";
            radioRectangulo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lvwFiguras);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(12, 196);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(485, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // lvwFiguras
            // 
            lvwFiguras.Location = new Point(6, 22);
            lvwFiguras.Name = "lvwFiguras";
            lvwFiguras.Size = new Size(342, 176);
            lvwFiguras.TabIndex = 2;
            lvwFiguras.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            button4.Location = new Point(386, 96);
            button4.Name = "button4";
            button4.Size = new Size(75, 41);
            button4.TabIndex = 1;
            button4.Text = "Eliminar registro";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(386, 37);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 0;
            button3.Text = "Actualizar listado";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private GroupBox groupBox3;
        private Button button4;
        private Button button3;
        public TextBox tbRadio;
        public TextBox textBox3;
        public TextBox tbAlto;
        public TextBox tbAncho;
        public RadioButton radioCirculo;
        public RadioButton radioRectangulo;
        public ListView lvwFiguras;
    }
}

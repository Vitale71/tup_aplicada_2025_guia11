using System.Runtime.Versioning;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;

public class FigurasListDAL : IFigurasDAL
{
    List<FiguraModel> Figuras = new();
    int Id = 1;

    public FiguraModel Add(FiguraModel figura)
    {
        if (figura.Id > 0) return null;

        figura.Id = GenId();
        Figuras.Add(figura);
        return figura;
    }

    public List<FiguraModel> GetALL()
    {
        return Figuras;
    }

    public FiguraModel? GetById(int id)
    {
        /*return (from f in figuras
                 where f.Id == id
                 select f).FirstOrDefault();*/
        return Figuras.Where(p => p.Id == id).FirstOrDefault();
    }

    public void Remove(int id)
    {
        var figura = GetById(id);
        if (figura != null)
        {
            Figuras.Remove(figura);
        }
    }

    public FiguraModel? Save(FiguraModel entity) //tambien se llama update
    {
        entity.Id = GenId();
        Figuras.Add(entity);
        return entity;
        /*var F = GetById(entity.Id);
        if (F == null) { return null; }
        if (F.GetType() != entity.GetType()) { return null; }
        if (entity is RectanguloModel r)
        {
            fr = F as RectanguloModel;
            fr.Area = r.Area;
            fr.Ancho = r.Ancho;
            fr.Largo = r.Largo;
        }*/

    }

    protected int? GenId()
    {
        return (from f in Figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
    }
}


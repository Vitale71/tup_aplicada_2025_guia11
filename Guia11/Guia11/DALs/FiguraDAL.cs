using System.Runtime.Versioning;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;

public class FiguraDAL
{
    List<FiguraModel> Figuras = new();
    
    public FiguraModel GetById(int id)
    {
        return Figuras.Where(p => p.Id = id).FirstOrDefault();
    }


    public FiguraModel Save(FiguraModel entity)
    {
        var F = GetById(entity.Id);
        if (F == null) { return null; }
        if (F.GetType() != entity.GetType()) { return null; }
        if (entity is RectanguloModel r)
        {
            fr = F as RectanguloModel;
            fr.Area = r.Area;
            fr.Ancho = r.Ancho;
            fr.Largo = r.Largo;
        }
    }
}


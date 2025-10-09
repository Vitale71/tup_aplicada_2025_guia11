using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.DALs;
using GeometriaModels.Models;

namespace GeometriaModels.Servicio;

public class FigurasService
{
    IFigurasDAL figuraDAL;
    public FigurasService(IFigurasDAL figurasDAL)
    {
        figuraDAL = figurasDAL;
    }
    public List<FiguraModel?> GetAll()
    {
        return figuraDAL.GetALL();
    }

    public FiguraModel GetById(int id)
    {
        return figuraDAL.GetById(id);
    }

    public FiguraModel AddFigura(FiguraModel nueva)
    {
        return figuraDAL.Add(nueva);
    }
}

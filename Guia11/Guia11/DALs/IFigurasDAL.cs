using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.DALs
{
    public interface IFigurasDAL
    {
        public List<FiguraModel> GetALL();
        public FiguraModel GetById(int id);
        public FiguraModel Add(FiguraModel figura);
        public void Remove(int id);
        public FiguraModel Save(FiguraModel entity); //tambien se llama Update
    }
}
/* Public FiguraModel GetById(int id) 
 * { return ( From f in figruas where f.Id = id Select f).FirstOrDefault();  }
 * 
 * return Figuras.Where(p=>p.Id=id).FirstOrDefault();  
 * 
 * 
 * Public FiguraModel Save(FiguraModel*/
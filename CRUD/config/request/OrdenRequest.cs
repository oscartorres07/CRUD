using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.config.request
{
    public class OrdenRequest
    {
        public string cliente {get; set;}
        public string descripcion { get; set;}
        public DateTime fecha { get; set;}
        public bool estado { get; set; }
    }
}

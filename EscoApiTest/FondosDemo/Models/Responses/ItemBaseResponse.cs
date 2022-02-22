using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models.Responses
{
    public class ItemResponse
    {
        //string descripcion { get; set; }
        //bool estaAnulado { get; set; }
    }

    public class ItemBaseResponse : ItemBase
    {
        /// <summary>
        /// Indica si la entidad esta anulada
        /// </summary>
        public bool EstaAnulado { get; set; }
    }

    public class ItemBaseTablaSistemaResponse : ItemBase
    {
        /// <summary>
        /// Codigo de la entidad
        /// </summary>
        public long Codigo { get; set; }

        public string Descripcion_Id 
        {
            get
            {
                return $"{Descripcion} ({IdEntidad})";
            }
        }
    }

    public class ItemBase
    {
        /// <summary>
        /// Descripcion de la entidad
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Codigo de interfaz de la entidad
        /// </summary>
        public string IdEntidad { get; set; }
    }

    public class ItemTexto : ItemBase
    {
        /// <summary>
        /// Codigo de la entidad
        /// </summary>
        public string Codigo { get; set; }
    }

    public class ItemTextoBase
    {
        /// <summary>
        /// Codigo de la entidad
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Descripcion de la entidad
        /// </summary>
        public string Descripcion { get; set; }
    }
}

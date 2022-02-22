using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models
{
    public class ESCOException : System.Exception
    {
        public string EscoMessage { get; set; }
        public string EscoCode { get; set; }
        public List<string> Sugerencias { get; set; }
        public ESCOException() { }
        public ESCOException(string msg, string cod) : base(msg)
        {
            EscoMessage = msg;
            EscoCode = cod;
            Sugerencias = new List<string>();
        }
        public ESCOException(System.Exception ex)
        {
            EscoMessage = ex.Message;
            Sugerencias = new List<string>();
        }
    }
}

namespace EscoApiTest.FondosDemo.Models.Responses
{
    public class InsertUpdateDeleteResponse
    {
        public long codigo { get; set; }
        public string descripcion { get; set; }
        public ESCOException exception { get; set; }
    }
}

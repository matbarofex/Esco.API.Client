namespace EscoApiTest.FondosDemo.Models.Responses.PagedData {
    public interface IPagingParams {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}
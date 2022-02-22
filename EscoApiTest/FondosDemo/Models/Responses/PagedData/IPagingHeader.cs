namespace EscoApiTest.FondosDemo.Models.Responses.PagedData {
    public interface IPagingHeader {
        int PageNumber { get; }
        int PageSize { get; }
        int TotalItems { get; }
        int TotalPages { get; }

        string ToJson();
    }
}
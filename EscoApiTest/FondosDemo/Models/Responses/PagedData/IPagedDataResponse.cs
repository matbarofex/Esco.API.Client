using System.Collections.Generic;

namespace EscoApiTest.FondosDemo.Models.Responses.PagedData {
    /// <summary>
    /// Contract that define behavior of esco pagination.
    /// </summary>
    /// <typeparam name="T">Type of a given collection.</typeparam>
    public interface IPagedDataResponse<T> {
        /// <summary>
        /// Data to show
        /// </summary>
        IEnumerable<T> Data { get; }
        /// <summary>
        /// To know if there is a next page.
        /// </summary>
        bool HasNextPage { get; }
        /// <summary>
        /// To know if there is a previous page.
        /// </summary>
        bool HasPreviousPage { get; }
        /// <summary>
        /// Retrieve the number of the next page.
        /// </summary>
        int NextPageNumber { get; }
        /// <summary>
        /// Current number page.
        /// </summary>
        int PageNumber { get; }
        /// <summary>
        /// Page size number.
        /// </summary>
        int PageSize { get; }
        /// <summary>
        /// number of the previous page.
        /// </summary>
        int PreviousPageNumber { get; }
        /// <summary>
        /// Total number of elements in the base collection.
        /// </summary>
        int TotalItems { get; }
        /// <summary>
        /// Total number of pages.
        /// </summary>
        int TotalPages { get; }
        /// <summary>
        /// Abstract for the info.
        /// </summary>
        /// <returns></returns>
        IPagingHeader GetHeader();
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using EscoApiTest.FondosDemo.Models.Responses.PagedData;

namespace EscoApiTest.FondosDemo.Responses.Settings
{
    public interface IPageList<T> {
        /// <summary>
        /// Resultados de la consulta
        /// </summary>
        IEnumerable<T> data { get; set; }

        bool HasPreviousPage { get; set; }
        bool HasNextPage { get; set; }
        int NextPageNumber { get; set; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
        int PreviousPageNumber { get; set; }
        int TotalPages { get; set; }
        int TotalItems { get; set; }
        IPagingHeader GetHeader { get; }
    }
}

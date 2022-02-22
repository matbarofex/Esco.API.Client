using System;
using System.Collections.Generic;
using System.Text;
using EscoApiTest.FondosDemo.Models.Responses.PagedData;

namespace EscoApiTest.FondosDemo.Responses.Settings {
    public class PagedList<T> : IPageList<T> {
        /// <summary>
        /// Resultados de la consulta
        /// </summary>
        public IEnumerable<T> data { get; set; }

        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int NextPageNumber { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int PreviousPageNumber { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public IPagingHeader GetHeader { 
            get => new PagingHeader(TotalItems, PageNumber, PageSize, TotalPages);
        }
    }
}

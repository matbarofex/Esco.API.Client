using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EscoApiTest.FondosDemo.Models.Responses.PagedData {
    /// <summary>
    /// Class that implements the paging of large volumes of data. This should not apply to all endpoints. 
    /// It should only be applied to those who, due to the volume of data that it returns, need it to maintain an acceptable performance standard. 
    /// The idea is to leave the performance in the hands of the customers. It can also be applied for views with grids.
    /// It is important to note that paging is done in MEMORY, not in the DB, that is, 
    /// it returns ALL THE OBJECTS in the database each time it is called and paging in memory.
    /// </summary>
    /// <typeparam name="T">Type of a given collection.</typeparam>
    public abstract class PagedDataResponse<T> : IPagedDataResponse<T> {
        /// <summary>
        /// Constructor for class.
        /// </summary>
        /// <param name="data">Data. Must be Quereyable object.</param>
        /// <param name="pageNumber">number of pages.</param>
        /// <param name="pageSize">page size number.</param>
        public PagedDataResponse(IEnumerable<T> data, int pageNumber, int pageSize) {
            TotalItems = data.Count();
            PageNumber = pageNumber;
            PageSize = pageSize;
            Data = data
                            .Skip(pageSize * (pageNumber - 1))
                            .Take(pageSize)
                            .ToList();
        }

        /// <summary>
        /// Solo utilizar cuando la paginacion se hace en SQL
        /// </summary>
        /// <param name="data"></param>
        public PagedDataResponse(IEnumerable<T> data)
        {
            Data = data;
        }

        /// <summary>
        /// Total number of elements in the base collection.
        /// </summary>
        public virtual int TotalItems { get; set; }
        /// <summary>
        /// Current number page.
        /// </summary>
        public virtual  int PageNumber { get; set; }
        /// <summary>
        /// Page size number.
        /// </summary>
        public virtual  int PageSize { get; set; }
        /// <summary>
        /// Data to show.
        /// </summary>
        public virtual IEnumerable<T> Data { get; set; }
        /// <summary>
        /// Total number of pages.
        /// </summary>
        public virtual int TotalPages =>
              (int)Math.Ceiling(this.TotalItems / (double)this.PageSize);
        public virtual bool HasPreviousPage => this.PageNumber > 1;
        /// <summary>
        /// To know if there is a next page.
        /// </summary>
        public virtual bool HasNextPage => this.PageNumber < this.TotalPages;
        /// <summary>
        /// Retrieve the number of the next page.
        /// </summary>
        public virtual int NextPageNumber =>
               this.HasNextPage ? this.PageNumber + 1 : this.TotalPages;
        /// <summary>
        /// number of the previous page.
        /// </summary>
        public virtual int PreviousPageNumber =>
               this.HasPreviousPage ? this.PageNumber - 1 : 1;
        /// <summary>
        /// Abstract for the info.
        /// </summary>
        /// <returns></returns>
        public virtual IPagingHeader GetHeader() {
            return new PagingHeader(
                 TotalItems, PageNumber,
                 PageSize, TotalPages);
        }
    }

    public class PagingHeader : IPagingHeader {
        public PagingHeader(
           int totalItems, int pageNumber, int pageSize, int totalPages) {
            TotalItems = totalItems;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPages = totalPages;
        }

        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }

        public string ToJson() => JsonConvert.SerializeObject(this,
                                    new JsonSerializerSettings {
                                        ContractResolver = new
                                            CamelCasePropertyNamesContractResolver()
                                    });

    }
    public class PagingParams : IPagingParams {
        //[DefaultValue(1)]
        /// <summary>
        /// Número de página a mostrar.
        /// </summary>
        public int PageNumber { get; set; } = 1;
        //[DefaultValue(10)]
        /// <summary>
        /// Cantidad de registros por página.
        /// </summary>
        public int PageSize { get; set; } = 5;

        //public PagingParams() {
        //    PageNumber = 1;
        //    PageSize = 10;
        //}

    }
}

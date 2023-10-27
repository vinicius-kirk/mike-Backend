using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Shared.ResponseApi
{
    public class PagedApiResponse<T>
    {
        public bool Success { get; set; }
        public IEnumerable<T> Data { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public string ErrorMessage { get; set; }
    }
}

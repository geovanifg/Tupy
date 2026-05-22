//using System.Collections.Generic;

//namespace Tupy
//{
//    public class PagedResponse<TModel> : ExecutionResponse
//    {
//        public IEnumerable<TModel> Model { get; set; }

//        public int PageSize { get; set; }

//        public int PageNumber { get; set; }

//        public int ItemsCount { get; set; }

//        public int PageCount
//        {
//            get
//            {
//                int result = 1;

//                if (ItemsCount > PageSize)
//                {
//                    var pages = ((decimal)ItemsCount / PageSize);

//                    // Obter a parte inteira das páginas
//                    result = (int)pages;

//                    // Se a variável das páginas for maior do que o resultado, então acrescentar mais uma página, pois existe fração
//                    if (pages > result)
//                        result++;
//                }
//                return result;
//            }
//        }

//        public PagedResponse() : base()
//        {
//        }

//        public PagedResponse(string errorMessage) : base(false, errorMessage)
//        {
//        }
//    }
//}
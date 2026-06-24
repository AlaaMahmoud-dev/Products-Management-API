using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsPresentation
{
    internal static class clsGlobal
    {
        public static HttpClient Client = new HttpClient();
        static clsGlobal()
        {
            Client.BaseAddress = new Uri("http://localhost:5168/api/Products/");
        }
    }
}

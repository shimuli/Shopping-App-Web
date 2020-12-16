using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_App
{
    public static class StaticDetails
    {
        public static string ApiBaseUrl = "https://localhost:44326/";
        public static string ShoppingPath = ApiBaseUrl + "api/v1/shopping";
        public static string InventoryPath = ApiBaseUrl + "api/v1/inventory";

    }
}

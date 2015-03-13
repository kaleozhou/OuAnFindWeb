using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "RetailSalesSo",
                url: "RetailSales/So/{SearchKey}/{page}",
                defaults: new { controller = "RetailSales", action = "So", SearchKey = UrlParameter.Optional, page = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "HotelList",
                url: "RetailSales/HotelList/{page}",
                defaults: new { controller = "RetailSales", action = "HotelList", page = UrlParameter.Optional }
            );
            
            routes.MapRoute(
               name: "contractManagerList1",
               url: "RetailSalesManage/{action}/{id}/{rid}",
               defaults: new { controller = "RetailSalesManage", action = "index", id = UrlParameter.Optional, rid = UrlParameter.Optional }
               );
            routes.MapRoute(
                name: "contractManagerList",
                url: "RetailSalesManage/{action}/{id}",
                defaults: new { controller = "RetailSalesManage", action = "index", id = UrlParameter.Optional }
            );
           /*
            routes.MapRoute(
               name: "tickManage",
               url: "RetailSalesManage/{action}/{id}",
               defaults: new { controller = "RetailSalesManage", action = "TickManage", id = UrlParameter.Optional }
           );*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{page}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional, page = UrlParameter.Optional }
            );
         
        }
    }
}
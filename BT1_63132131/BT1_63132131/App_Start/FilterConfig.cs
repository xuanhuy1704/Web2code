﻿using System.Web;
using System.Web.Mvc;

namespace BT1_63132131
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
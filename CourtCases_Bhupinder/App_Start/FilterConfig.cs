﻿using System.Web;
using System.Web.Mvc;

namespace CourtCases_Bhupinder
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

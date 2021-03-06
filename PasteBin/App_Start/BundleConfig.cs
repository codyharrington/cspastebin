﻿using System.Web;
using System.Web.Optimization;

namespace PasteBin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/*.css", "~/Content/highlight/default.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                       "~/Scripts/*.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}

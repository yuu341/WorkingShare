using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace WorkingShare
{
    public class BundleConfig
    {
        // バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862 を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery/jquery.unobtrusive*",
                "~/Scripts/jquery/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout/knockout-{version}.js",
                "~/Scripts/knockout/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angularjs/angular.js",
                "~/Scripts/angularjs/angular-animate.js",
                "~/Scripts/angularjs/angular-aria.js",
                "~/Scripts/angularjs/angular-cookies.js",
//                "~/Scripts/angularjs/angular-csp.css",
                "~/Scripts/angularjs/angular-loader.js",
                "~/Scripts/angularjs/angular-message-format.js",
                "~/Scripts/angularjs/angular-messages.js",
                "~/Scripts/angularjs/angular-mocks.js",
                "~/Scripts/angularjs/angular-resource.js",
                "~/Scripts/angularjs/angular-route.js",
                "~/Scripts/angularjs/angular-sanitize.js",
                "~/Scripts/angularjs/angular-scenario.js",
                "~/Scripts/angularjs/angular-touch.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/sammy-{version}.js",
                "~/Scripts/app/common.js",
                "~/Scripts/app/app.datamodel.js",
                "~/Scripts/app/app.viewmodel.js",
                "~/Scripts/app/home.viewmodel.js",
                "~/Scripts/app/_run.js"));

            // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
            // できたら、http://modernizr.com にあるビルド ツールを使用して、必要なテストのみを選択します。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap/bootstrap.js",
                "~/Scripts/respond/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/normalize.css",
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css",
                 "~/Content/Foundation.css",
                 "~/Content/Layout.css",
                 "~/Content/Object.css"
                 ));


            bundles.Add(new StyleBundle("~/Content/UIParts/Menu").Include(
                 "~/Content/Menu.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/UIParts/Menu").Include(
                 "~/Scripts/menu.js"
                ));
        }
    }
}

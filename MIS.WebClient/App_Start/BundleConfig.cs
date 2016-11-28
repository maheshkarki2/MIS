using System.Web.Optimization;

namespace MIS.WebClient
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
          

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                                                                       "~/Content/bootstrap.css",
                                                                       "~/Content/bootstrap-theme.css",
                                                                       "~/Content/bootstrap-overrides.css",
                                                                       "~/Content/font-awesome.css"
                            ));




            bundles.Add(new StyleBundle("~/Content/kendoui").Include(
                                                                     "~/Content/kendo-ui/kendo.default.min.css",
                                                                     "~/Content/kendo-ui/kendo.common.min.css"

                            ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                                                                     "~/Scripts/jquery-{version}.js",
                                                                     "~/Scripts/jquery.maskedinput.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                                                                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                                                                      "~/Scripts/angular.js",
                                                                      "~/Scripts/angular-ui-router.js",
                                                                      "~/Scripts/angular-ui/ui-bootstrap.js",
                                                                      "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                                                                      "~/Scripts/angular-lodash/lodash.js",
                                                                      "~/Scripts/angular-loadingbar/loading-bar.js",
                                                                      "~/Scripts/angular-ngcookie/ng-cookie.js",
                                                                      "~/Scripts/angular-modal/angular-modal-service.js",
                                                                      "~/Scripts/angular-animate/angular-animate.min.js",
                                                                      "~/Scripts/angular-local-storage/angular-local-storage.min.js",
                                                                      "~/Scripts/jszip/jszip.min.js",
                                                                      "~/Scripts/angular-resource.js",
                                                                      "~/Scripts/angular-resource.min.js",
                                                                      "~/Scripts/ngStorage.min.js",
                                                                      "~/Scripts/Chart.min.js",
                                                                      "~/Scripts/angular-chart.min.js"
                            ));

            bundles.Add(new ScriptBundle("~/bundles/angular/controllers").Include(
                                                                             
                                                                              //authentication
                                                                              //"~/Scripts/app/authentication/controllers/loginController.js",
                                                                              "~/scripts/app/login/loginController.js",
                                                                               "~/scripts/app/dashboard/DashboardController.js",
                                                                               "~/scripts/app/products/productsController.js",
                                                                                "~/scripts/app/products/productDetailsController.js",
                                                                                "~/scripts/app/customers/customersControllers.js",
                                                                               "~/scripts/app/purchaseHistory/PurchasHistoryController.js"                      ));
            bundles.Add(new ScriptBundle("~/bundles/angular/services").Include(
                                                                             "~/Scripts/app/shared/services/salesService.js",
                                                                             "~/Scripts/app/shared/services/dashBoardService.js"


                          ));
            bundles.Add(new ScriptBundle("~/bundles/angular/directives").Include(

                                                                          "~/Scripts/app/Shared/Directives/numbersOnly.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular/app").Include(
                                                                          "~/Scripts/app/app.js",
                                                                          "~/Scripts/app/routes.js"));

     
            //Uncomment When Filters are Available
           
            bundles.Add(new ScriptBundle("~/bundles/angular/kendo").Include(
                                                                            "~/Scripts/kendo-ui/kendo.all.min.js",
                                                                            "~/Scripts/kendo-ui/kendo.angular.min.js"));
        }
    }
}
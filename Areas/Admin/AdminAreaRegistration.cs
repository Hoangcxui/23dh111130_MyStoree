using System.Web.Mvc;

namespace _23dh111130_MyStore.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName => "Admin";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "Admin_default",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "_23dh111130_MyStore.Areas.Admin.Controllers" } // Specify the Admin controller namespace
            );
        }
    }

}
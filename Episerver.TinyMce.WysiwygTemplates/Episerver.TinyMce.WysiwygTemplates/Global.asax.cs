using System.Web.Http;
using System.Web.Mvc;

namespace Episerver.TinyMce.WysiwygTemplates
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                "DefaultServiceApi",
                "api/{controller}/{action}/{id}",
                new { action = "Index", id = RouteParameter.Optional });

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}
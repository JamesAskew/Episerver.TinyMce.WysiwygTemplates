using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Episerver.TinyMce.WysiwygTemplates.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace Episerver.TinyMce.WysiwygTemplates.Controllers
{
    public class TinyMceTemplatesApiController : ApiController
    {
        private readonly IContentLoader _contentLoader;

        public TinyMceTemplatesApiController()
        {
            this._contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
        }

        [HttpGet]
        public HttpResponseMessage Index()
        {
            var startPage = this._contentLoader.Get<StartPage>(ContentReference.StartPage);

            var templates = startPage.WysiwygTemplates?.Select(x => new { title = x.Title.ToString(), description = x.Description.ToString(), content = x.Content.ToHtmlString() }).ToList();
            var returnMessage = Request.CreateResponse(HttpStatusCode.OK, templates);

            return returnMessage;
        }
    }
}
using EPiServer.Core;

namespace Episerver.TinyMce.WysiwygTemplates.Models
{
    public class TinyMceTemplateModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public XhtmlString Content { get; set; }
    }
}
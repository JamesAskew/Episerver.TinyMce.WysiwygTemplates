using EPiServer.Core;

namespace Episerver.TinyMce.WysiwygTemplates.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}

using EPiServer.Editor;
using EPiServer.Shell;
using Episerver.TinyMce.WysiwygTemplates.Models.Pages;

namespace Episerver.TinyMce.WysiwygTemplates.Business.UIDescriptors
{
    /// <summary>
    /// Describes how the UI should appear for <see cref="ContainerPage"/> content.
    /// </summary>
    [UIDescriptorRegistration]
    public class ContainerPageUIDescriptor : UIDescriptor<ContainerPage>
    {
        public ContainerPageUIDescriptor()
            : base(ContentTypeCssClassNames.Container)
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}

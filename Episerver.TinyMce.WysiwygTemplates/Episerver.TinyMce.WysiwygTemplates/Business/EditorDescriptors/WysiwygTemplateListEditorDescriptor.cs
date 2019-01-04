using System;
using System.Collections.Generic;
using Episerver.TinyMce.WysiwygTemplates.Models;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace Episerver.TinyMce.WysiwygTemplates.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(IList<TinyMceTemplateModel>))]
    public class WysiwygTemplateListEditorDescriptor : CollectionEditorDescriptor<TinyMceTemplateModel>
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            this.GridDefinition.ExcludedColumns.Add(nameof(TinyMceTemplateModel.Content));
            base.ModifyMetadata(metadata, attributes);
        }
    }
}
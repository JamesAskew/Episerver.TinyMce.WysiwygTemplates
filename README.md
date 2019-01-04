# Episerver.TinyMce.WysiwygTemplates

Add Tiny Mce Templates to an Episerver site which can be edited by a CMS user. 

Most examples of this functionality use static html templates which would be difficult to manage in real world websites. 
This code allows users to setup their own templates from within the CMS. 
Access could be restricted to certain users or groups, or templates could be restricted to certain pages or blocks.

## Main Files
The [final commit](https://github.com/JamesAskew/Episerver.TinyMce.WysiwygTemplates/commit/c0fd65100378748bd0bb6886a85203e1c7fc44ee) contains the all the changes required to get this working. The two main files are:
- ExtendedTinyMceInitialization.cs
- TinyMceTemplatesApiController.cs

### ExtendedTinyMceInitialization.cs
This adds the template button to the WYSIWYG toolbar and points it to an API controller.

### TinyMceTemplatesApiController.cs
This retrieves the templates from the Start page and returns them in the correct format. 

Typically the Templates would go in a site settings page which would be injected as a singleton, hence the need for the controller.

## Other Interesting Files
- TinyMceTemplateModel.cs
- WysiwygTemplateListEditorDescriptor.cs
- WysiwygTemplateListProperty.cs

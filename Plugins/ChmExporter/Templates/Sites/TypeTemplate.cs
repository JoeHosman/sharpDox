﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 11.0.0.0
//  
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SharpDox.Plugins.Chm.Templates.Sites
{
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.Collections.Generic;
    using SharpDox.Model.Repository;
    using SharpDox.Plugins.Chm.Templates.Strings;
    using SharpDox.Sdk.Config;
    using SharpDox.UML;
    using MarkdownSharp;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class TypeTemplate : TypeTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n<html>\r\n    <head>\r\n        <title>");
            
            #line 15 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Name));
            
            #line default
            #line hidden
            this.Write(@"</title>
        <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/reset.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"">
        <script src=""js/jquery.js"" type=""text/javascript""></script>
        
        <script type=""text/javascript"">
            $(document).ready(function() {
                
            });
        </script>

    </head>
    <body>
		<div id=""header"">
			<h2 class=""type-title"">");
            
            #line 30 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Name));
            
            #line default
            #line hidden
            this.Write("</h2>\r\n\t\t\t<span class=\"namespace-title\">");
            
            #line 31 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Namespace.Fullname));
            
            #line default
            #line hidden
            this.Write("</span>\r\n\t\t</div>\r\n\t\t<div id=\"subheader\">\r\n\t\t\t<a href=\"");
            
            #line 34 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDRepository.ProjectInfo.ProjectName.Replace(" ", "")));
            
            #line default
            #line hidden
            this.Write("-Index.html\">Start</a> > <a href=\"");
            
            #line 34 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Namespace.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 34 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Namespace.Fullname));
            
            #line default
            #line hidden
            this.Write("</a> > <a href=\"");
            
            #line 34 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 34 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Name));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t\t</div>\r\n\t\t\r\n\t\t<div id=\"content\">\r\n\r\n\t\t\t<h3 class=\"box-title\">");
            
            #line 39 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Syntax));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t<div class=\"syntax-box\">\r\n\t\t\t\t");
            
            #line 41 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(WebUtility.HtmlEncode(SDType.Syntax)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t</div>\r\n\r\n\t\t\t");
            
            #line 44 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.BaseTypes.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 45 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Basetype));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"list-box\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 48 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var baseType in SDType.BaseTypes) { 
						if(baseType.IsProjectStranger) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<li>");
            
            #line 50 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(baseType.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t\t");
            
            #line 51 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<li><a href=\"");
            
            #line 52 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(baseType.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 52 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(baseType.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t\t");
            
            #line 53 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t");
            
            #line 54 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 57 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 59 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.ImplementedInterfaces.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 60 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Implements));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"list-box\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 63 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var implementedInterface in SDType.ImplementedInterfaces) {
						if(implementedInterface.IsProjectStranger) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<li>");
            
            #line 65 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(implementedInterface.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t\t");
            
            #line 66 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<li><a href=\"");
            
            #line 67 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(implementedInterface.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 67 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(implementedInterface.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t\t");
            
            #line 68 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t");
            
            #line 69 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 72 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 74 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 var language = SDType.Documentation.ContainsKey(CurrentLanguage) ? CurrentLanguage : "default";
			if(SDType.Documentation.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 77 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].Summary.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 78 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Summary));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 80 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDType.Documentation[language].Summary.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 82 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 84 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].Remarks.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 85 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Remarks));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 87 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDType.Documentation[language].Remarks.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 89 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 91 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].Example.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 92 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Example));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 94 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDType.Documentation[language].Example.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 96 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 98 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].Returns.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 99 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Returns));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 101 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDType.Documentation[language].Returns.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 103 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 105 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].Exceptions.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 106 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Exceptions));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 108 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var exception in SDType.Documentation[language].Exceptions) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<p>");
            
            #line 109 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Key));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t\t\t\t\t<div class=\"inline\">\r\n\t\t\t\t\t\t\t\t");
            
            #line 111 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(exception.Value.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
            
            #line 113 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 115 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 117 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].Params.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 118 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Parameters));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 120 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var parameter in SDType.Documentation[language].Params) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<p>");
            
            #line 121 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Key));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t\t\t\t\t<div class=\"inline\">\r\n\t\t\t\t\t\t\t\t");
            
            #line 123 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(parameter.Value.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
            
            #line 125 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 127 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t");
            
            #line 129 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Documentation[language].TypeParams.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 130 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.TypeParameters));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t\t");
            
            #line 132 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var typeParameter in SDType.Documentation[language].TypeParams) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<p>");
            
            #line 133 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeParameter.Key));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t\t\t\t\t<div class=\"inline\">\r\n\t\t\t\t\t\t\t\t");
            
            #line 135 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(typeParameter.Value.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
            
            #line 137 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 139 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 141 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 143 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.Uses.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 144 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Uses));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"list-box\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 147 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var use in SDType.Uses) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<li><a href=\"");
            
            #line 148 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(use.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 148 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(use.Name));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t");
            
            #line 149 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 152 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 154 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 if(SDType.UsedBy.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 155 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.UsedBy));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"list-box\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 158 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 foreach(var used in SDType.UsedBy) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<li><a href=\"");
            
            #line 159 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(used.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 159 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(used.Name));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t");
            
            #line 160 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 163 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 165 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
	if(!SDType.IsClassDiagramEmpty()) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<div class=\"diagram-box\">\r\n\t\t\t\t\t<img class=\"diagram-image\" src=\"diagrams/");
            
            #line 167 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Guid));
            
            #line default
            #line hidden
            this.Write(".png\"/>\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 169 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</div>\r\n    </body>\r\n</html>\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 174 "S:\Github\sharpDox\Plugins\ChmExporter\Templates\Sites\TypeTemplate.tt"
 
public SDRepository SDRepository { get; set; }
public SDType SDType { get; set; } 
public string CurrentLanguage { get; set; }
public IStrings Strings { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class TypeTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}

﻿using System.IO;

namespace SharpDox.Plugins.Html.Steps
{
    public class PreBuildStep : Step
    {
        public override void ProcessStep(HtmlExporter htmlExporter)
        {
            htmlExporter.ExecuteOnStepProgress(0);
            htmlExporter.ExecuteOnStepMessage(htmlExporter.HtmlStrings.CreatingFolders);

            CreateFolder(htmlExporter.OutputPath, "namespace");
            CreateFolder(htmlExporter.OutputPath, "type");
            CreateFolder(htmlExporter.OutputPath, "constructor");
            CreateFolder(htmlExporter.OutputPath, "method");
            CreateFolder(htmlExporter.OutputPath, "field");
            CreateFolder(htmlExporter.OutputPath, "property");
            CreateFolder(htmlExporter.OutputPath, "event");
            CreateFolder(htmlExporter.OutputPath, "article");
            CreateFolder(htmlExporter.OutputPath, "nav");

            htmlExporter.CurrentStep = new CreateNavigationStep();
        }

        public static void CreateFolder(string path, string name)
        {
            if (!Directory.Exists(Path.Combine(path, name)))
            {
                Directory.CreateDirectory(Path.Combine(path, name));
            }
        }
    }
}

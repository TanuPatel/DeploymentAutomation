using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AnalysisServices.Tabular;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using Microsoft.Build.BuildEngine;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;

namespace SSASDeployment
{
    class BuildProject
    {
        public static void Main(string[] args)
        {
            /***************** Code to Build the Solution in local GitHub directory ************************/
            /*
            string projectFilePath = Path.Combine(@"C:\Buyplan\TabularCubes\Buyplan BR\Buyplan BR\Buyplan BR.smproj");
            // Instantiate a new FileLogger to generate build log
            FileLogger logger = new FileLogger();
            ProjectCollection pc = new ProjectCollection();            
            Dictionary<string, string> globalProperty = new Dictionary<string, string>();
            globalProperty.Add("OutputPath", @"c:\Users\ftarann\Documents\Temp");
            globalProperty.Add("Configuration", "Deployment");
            //globalProperty.Add("Platform", "Any CPU");
            BuildRequestData buildRequest = new BuildRequestData(projectFilePath, globalProperty, "4.0", new string[] { "Build" }, null);
            BuildParameters bp = new BuildParameters(pc);
            bp.Loggers = new List<ILogger> { logger }.AsEnumerable();
            try
            {
                BuildResult buildResult = BuildManager.DefaultBuildManager.Build(bp, buildRequest);
                // A SIMPLE WAY TO CHECK THE RESULT
                if (buildResult.OverallResult == BuildResultCode.Success)
                {
                    pc.UnregisterAllLoggers();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            */
            SQLDeployment sql = new SQLDeployment();
            sql.publishChanges();
            //SSISDeploymentCode ssis = new SSISDeploymentCode();
            //string res = ssis.SSIS_Deploy();
            //DeploymentCode ssas = new DeploymentCode();
            //ssas.SSASDeploymentCode();
            

        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using System.Data.SqlClient;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using Microsoft.SqlServer.Dac;

namespace SSASDeployment
{
    class SQLDeployment
    {
        public void publishChanges()
        {
            string dacpacPath = @"C:\Program Files (x86)\Jenkins\workspace\FirstDeploymentProject\SQLTestProject\SQLTestProject\bin\Debug\SQLTestProject.dacpac";
            string dacProfilePath = @"C:\Program Files (x86)\Jenkins\workspace\FirstDeploymentProject\SQLTestProject\SQLTestProject\Dev.publish.xml";
            var dp = DacPackage.Load(dacpacPath);
            var dbDeployOptions = new DacDeployOptions();
            dbDeployOptions.BlockOnPossibleDataLoss = false;
            //dbDeployOptions.SqlCommandVariableValues.
            //Load DacProfile from sql project
            DacProfile d = new DacProfile();
            d = DacProfile.Load(dacProfilePath);
            //var p = new PublishOptions();                       
            //p.GenerateDeploymentScript = true;
            //p.DatabaseScriptPath = "";             
            var dbServices = new DacServices(d.TargetConnectionString);
            dbServices.Deploy(dp, d.TargetDatabaseName, true, dbDeployOptions);

        }
        
    }
}

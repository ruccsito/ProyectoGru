using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGruService.WfsServiceReference;
using System.IO;

namespace ProyectoGruService.WFS
{
    class WFSService
    {
        public Job StartJob(string input, string output)
        {
            WfcJmServicesClient client = new WfcJmServicesClient();

            // Armar el workflow. Reemplazamos el path del destino en el XML.
            string workflowTemplate = @"C:\Users\julioar\DotNet\ProyectoGru\ProyectoGruService\SupportFiles\Workflow_Transcode.xml";
            string workflow = File.ReadAllText(workflowTemplate);
            workflow = workflow.Replace("%TRANSCODE_OUTPUT%", output);

            Job job = new Job();

            try
            {
                job = client.QueueJobByWorkflow(workflow.ToString(), input, output);

                // Alternative Solution: Store the workflow in WFS and queue it by referencing the workflow's Guid
                // var workflowGuid = StoreWorkflowTemplate(workflow, true); // store workflow template first
                // Queue a Job using workflowguid.
                // var job = _client.QueueJobByWorkflowGuid(workflowGuid, mediaAsset, output, SourceFileType.SingleFile); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to Queue Job." + Environment.NewLine + ex.Message);
                return null;
            }
            return job;
        }
    }
}

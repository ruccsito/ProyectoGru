using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGruService.WFS;
using ProyectoGruService.WfsServiceReference;
using System.Threading;

namespace ProyectoGruService
{
    class Program
    {
        static void Main(string[] args)
        {
            WfcJmServicesClient client = new WfcJmServicesClient();
            WFSService wfs = new WFSService();

            string input = @"\\filesba.foxinc.com\Ardome\Test_Orch\Minion\In\BolivianFolkloricDance.mpg";
            string output = @"\\filesba.foxinc.com\Ardome\Test_Orch\Minion\Out\";
            bool completed = false;

            Job job = wfs.StartJob(input, output);

            if (job != null)
            {
                while (!completed)
                {
                    job = client.GetJob(job.Guid, true);

                    Console.WriteLine("Status : " + job.Status);
                    Console.WriteLine("Tasks : " + job.Task.Length);
                    int c = 0;

                    foreach (var task in job.Task)
                    {
                        Console.WriteLine("Task " + c + " status: " + task.TaskStatus);
                        c += 1;
                    }
                    Thread.Sleep(20000);
                    Console.Clear();
                }
            }
        }
    }
}

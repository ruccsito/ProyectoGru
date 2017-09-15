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
            string input = @"\\filesba.foxinc.com\Ardome\Test_Orch\Minion\In\BolivianFolkloricDance.mpg";
            string output = @"\\filesba.foxinc.com\Ardome\Test_Orch\Minion\Out\";

            // Traer de la DB el Trabajo, elegir el transcode y mandarle los datos de input, output y type.
            // Crear Transcode : ITranscode que reciba WFSService o FFMPEGService y llame a StartJob();
        }
    }
}

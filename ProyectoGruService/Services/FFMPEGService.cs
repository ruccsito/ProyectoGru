using ProyectoGruService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoGruService.Services
{
    public class FFMPEGService : ITranscode
    {
        private static TrabajosRepo tr;

        public void StartJob(Trabajo t)
        {
            tr = new TrabajosRepo(); 

            //Crear Task que ejecute el FFMPEG
            //Poner el job en "En Proceso"
            //Esperar que termine la task, buscar la forma de evaluar la salida y actualizar de nuevo el job con Completo o Fallido

            Console.WriteLine("Creando un job FFMPEG para " + t.sourceFile);
            tr.UpdateStatus(t, "En proceso");

            // Do actual job.
            Thread.Sleep(60000);

            tr.UpdateStatus(t, "Completo");

            Console.WriteLine("Job completo para " + t.sourceFile + Environment.NewLine);

        }
    }
}

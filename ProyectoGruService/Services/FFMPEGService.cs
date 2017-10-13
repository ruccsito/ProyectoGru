using ProyectoGruService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmergenceGuardian.FFmpeg;
using System.IO;

namespace ProyectoGruService.Services
{
    public class FFMPEGService : ITranscode
    {
        public void StartJob(Trabajo t)
        {
            //Crear Task que ejecute el FFMPEG
            //Poner el job en "En Proceso"
            //Esperar que termine la task, buscar la forma de evaluar la salida y actualizar de nuevo el job con Completo o Fallido

            CompletionStatus status = new CompletionStatus();
            TrabajosRepo tr = new TrabajosRepo(); 

            Console.WriteLine("Creando un job FFMPEG para " + t.sourceFile);
            tr.UpdateStatus(t, "En proceso");

            try
            {
                FFmpegConfig.FFmpegPath = @"C:\Sandbox\ffmpeg.exe";
                FFmpegOptions fo = new FFmpegOptions(t);

                if (File.Exists(t.targetFile))
                        File.Delete(t.targetFile);

                string parameters = string.Format(@"-i {0} -vf scale={1}:{2} -acodec {3} -ab {4} -vcodec {5} -x264-params ""nal-hrd=cbr"" -b:v {6} -bufsize 2M {7}", 
                                                    t.sourceFile, t.width, t.height, fo.audioCodec, fo.audioBitrate, fo.videoCodec, fo.videoBitrate, t.targetFile);
                                                                                                   
                FFmpegProcess f = new FFmpegProcess();
                status = f.RunFFmpeg(parameters);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            tr.UpdateStatus(t, status.ToString());

            Console.WriteLine("Job completo para " + t.sourceFile + Environment.NewLine);
        }
    }
}

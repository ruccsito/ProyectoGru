using ProyectoGruService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGruService
{
    public class Transcode
    {
        private ITranscode transcoder;

        public Transcode()
        {

        }

        public void Start(Trabajo t, ITranscode tr)
        {
            transcoder = tr;

            Task job = Task.Factory.StartNew( () => {
                    transcoder.StartJob(t);
                });

            job.Wait();
        }
    }
}

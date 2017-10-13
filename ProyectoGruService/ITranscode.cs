using ProyectoGruService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGruService
{
    public interface ITranscode
    {
        void StartJob(Trabajo t);
    }
}

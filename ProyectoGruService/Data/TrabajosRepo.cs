using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ProyectoGruService.Data
{
    public class TrabajosRepo
    {
        private ProyectoEntities db = new ProyectoEntities();

        public TrabajosRepo()
        {
        }

        public IEnumerable<Trabajo> GetByStatus(string status)
        {
            return db.Trabajos.Where(t => t.transcodeStatus == status).ToList();
        }
        public void UpdateStatus(Trabajo trabajo, string status)
        {
            trabajo.transcodeStatus = status;
            db.Entry(trabajo).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
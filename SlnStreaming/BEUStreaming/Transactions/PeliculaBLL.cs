using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUStreaming.Transactions
{
   public class PeliculaBLL
    {
        //BLL Bussiness Logic Layer
        //Capa de Logica del Negocio

        public static void Create(Pelicula p)
        {
            using (ServicioStreamEntities db = new ServicioStreamEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Pelicula.Add(p);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static Pelicula Get(int? id)
        {
            ServicioStreamEntities db = new ServicioStreamEntities();
            return db.Pelicula.Find(id);
        }

        public static void Update(Pelicula pelicula)
        {
            using (ServicioStreamEntities db = new ServicioStreamEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Pelicula.Attach(pelicula);
                        db.Entry(pelicula).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Delete(int? id)
        {
            using (ServicioStreamEntities db = new ServicioStreamEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Pelicula pelicula = db.Pelicula.Find(id);
                        db.Entry(pelicula).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<Pelicula> List()
        {
            ServicioStreamEntities db = new ServicioStreamEntities();
          

            return db.Pelicula.ToList();

            
        }


        private static List<Pelicula> GetAlumnos(string criterio)
        {
           
            ServicioStreamEntities db = new ServicioStreamEntities();
            return db.Pelicula.Where(x => x.nombre_pelicula.ToLower().Contains(criterio)).ToList();
        }

        private static Pelicula GetPelicula(string nombre)
        {
            ServicioStreamEntities db = new ServicioStreamEntities();
            return db.Pelicula.FirstOrDefault(x => x.nombre_pelicula == nombre);
      

    }
}
}

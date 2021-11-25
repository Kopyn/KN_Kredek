using MaciejKopinskiLab6ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Services
{
    public class ManufacturerService : IManufacturerService
    {
        /// <summary>
        /// method to delete manufacturer of given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id, DataBaseContext context)
        {
            var manufacturerToDelete = context.Manufacturers.ToList().Where(m => m.Id.Equals(id)).SingleOrDefault();
            if (manufacturerToDelete == null)
                return false;

            context.Manufacturers.Remove(manufacturerToDelete);
            context.SaveChanges();
            return true;
        }

        /// <summary>
        /// method to get all manufacturers
        /// </summary>
        /// <returns></returns>
        public List<Manufacturer> Get(DataBaseContext context)
        {
            return context.Manufacturers.ToList();
        }

        /// <summary>
        /// method to add new manufacturer
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        public int Post(Manufacturer manufacturer, DataBaseContext context)
        {
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
            return 0;
        }

        /// <summary>
        /// method to modify manufacturer of given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        public bool Put(int id, Manufacturer manufacturer, DataBaseContext context)
        {
            var manufacturerToUpdate = context.Manufacturers.ToList().Where(m => m.Id.Equals(id)).SingleOrDefault();
            if (manufacturerToUpdate == null)
                return false;

            manufacturerToUpdate.Name = manufacturer.Name;
            context.SaveChanges();

            return true;
        }
    }
}

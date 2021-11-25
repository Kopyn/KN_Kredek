using MaciejKopinskiLab6ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Services
{
    public class GuitarService : IGuitarService
    {
        /// <summary>
        /// method to delete guitar of given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id, DataBaseContext context)
        {
            var guitarToDelete = context.Guitars.ToList().Where(g => g.Id.Equals(id)).SingleOrDefault();

            if (guitarToDelete == null)
                return false;

            context.Guitars.Remove(guitarToDelete);
            context.SaveChanges();
            return true;
        }

        /// <summary>
        /// method to get all guitars
        /// </summary>
        /// <returns></returns>
        public List<Guitar> Get(DataBaseContext context)
        {
            return context.Guitars.ToList();
        }

        /// <summary>
        /// method to add new guitar
        /// </summary>
        /// <param name="guitar"></param>
        /// <returns></returns>
        public int Post(Guitar guitar, DataBaseContext context)
        {
            int id = 0;
            if(context.Guitars.ToList().Count() != 0)
            {
                id = context.Guitars.ToList().Max(g => g.Id) + 1;
            }
            context.Guitars.Add(guitar);
            context.SaveChanges();
            return id;
        }

        /// <summary>
        /// method to edit given guitar
        /// </summary>
        /// <param name="id"></param>
        /// <param name="guitar"></param>
        /// <returns></returns>
        public bool Put(int id, Guitar guitar, DataBaseContext context)
        {
            var guitarToUpdate = context.Guitars.ToList().Where(g => g.Id.Equals(id)).SingleOrDefault();

            if (guitarToUpdate == null)
                return false;

            guitarToUpdate.ManufacturerId = guitar.ManufacturerId;
            guitarToUpdate.Model = guitar.Model;
            guitarToUpdate.Type = guitar.Type;
            guitarToUpdate.BasketId = guitar.BasketId;
            context.SaveChanges();
            return true;
        }
    }
}

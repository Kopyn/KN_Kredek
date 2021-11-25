using MaciejKopinskiLab6ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Services
{
    public interface IManufacturerService
    {
        /// <summary>
        /// returns all manufacturers
        /// </summary>
        /// <returns></returns>
        List<Manufacturer> Get(DataBaseContext context);

        /// <summary>
        /// adds new manufacturer
        /// </summary>
        /// <param name="guitar"></param>
        /// <returns></returns>
        int Post(Manufacturer manufacturer, DataBaseContext context);

        /// <summary>
        /// modifies manufacturer of given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        bool Put(int id, Manufacturer manufacturer, DataBaseContext context);

        /// <summary>
        /// deletes manufacturer of given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id, DataBaseContext context);
    }
}

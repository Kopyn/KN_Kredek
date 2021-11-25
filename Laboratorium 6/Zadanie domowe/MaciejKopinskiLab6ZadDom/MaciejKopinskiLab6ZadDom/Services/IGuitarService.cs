using MaciejKopinskiLab6ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Services
{
    public interface IGuitarService
    {
        /// <summary>
        /// returns all guitars
        /// </summary>
        /// <returns></returns>
        List<Guitar> Get(DataBaseContext context);

        /// <summary>
        /// adds new guitar
        /// </summary>
        /// <param name="guitar"></param>
        /// <returns></returns>
        int Post(Guitar guitar, DataBaseContext context);

        /// <summary>
        /// modifies guitar of given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="guitar"></param>
        /// <returns></returns>
        bool Put(int id, Guitar guitar, DataBaseContext context);

        /// <summary>
        /// deletes guitar of given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id, DataBaseContext context);

    }
}

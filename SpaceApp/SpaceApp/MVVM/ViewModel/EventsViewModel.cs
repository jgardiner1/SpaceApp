using SpaceApp.MVVM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpaceApp.MVVM.ViewModel
{
    internal class EventsViewModel
    {

        public EventsViewModel() 
        {
            
        }

        public async Task InitialiseAsync()
        {
            await GetData();
        }

        static async Task GetData()
        {
            try
            {
                AstronomyAPI api = new AstronomyAPI();
                string data = await api.GetPlanetaryData();
                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

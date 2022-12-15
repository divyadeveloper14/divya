using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECAD_eApps_Interview;
using ECAD_eApps_Interview.Models;
using Microsoft.Extensions.Logging;

namespace ECAD_eApps_Interview.Services
{
   public class DiagramServices : IDiagramService
    {
        List<Circle> coordinates = new List<Circle>();
        private readonly ILogger<IDiagramService> _logger;
        public List<Circle> GetCoordinates(int item)
        {
            int count = 1;
            _logger.LogInformation("Get Coordinates" + item);
            GetInterval(item, out double interval, out double angleInterval);
            try
            {
                //To form circle, angle to be more than 6 degree
                if (interval < 2 * Math.PI)
                {
                    for (interval = angleInterval; interval <= Constants.DEGREE; interval += angleInterval)
                    {
                        Circle coordinate = new Circle();
                        coordinate.Name = "DI_" + count;
                        coordinate.X = Constants.RADIUS * Math.Cos(interval);
                        coordinate.Y = Constants.RADIUS * Math.Sin(interval);
                        coordinates.Add(coordinate);
                        count++;
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while fetching Coordinates" + ex);
            }
            return coordinates;
        }

        private void GetInterval(int item, out double interval, out double angleInterval)
        {
                _logger.LogInformation("GetInterval");
           
                interval = Constants.INTERVAL;
                angleInterval = Constants.DEGREE / item;
            
        }
        
    }
}

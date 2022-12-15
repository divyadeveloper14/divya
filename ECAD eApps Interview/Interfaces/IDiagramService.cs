using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECAD_eApps_Interview.Models;

namespace ECAD_eApps_Interview.Services
{
   public interface IDiagramService
    {
       public List<Circle> GetCoordinates(int item);
    }
}

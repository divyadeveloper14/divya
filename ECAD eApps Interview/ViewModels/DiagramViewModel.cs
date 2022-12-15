using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECAD_eApps_Interview;
using ECAD_eApps_Interview.Services;
using Microsoft.Extensions.Logging;
using ECAD_eApps_Interview.Models;

namespace ECAD_eApps_Interview.ViewModels
{
    public class DiagramViewModel
    {
        public readonly IDiagramService _diagram;
        public readonly ILogger<DiagramServices> _logger;
        int index = 1;
       
        public DiagramViewModel(IDiagramService diagram, ILogger<DiagramServices> logger)
        {
            _diagram = diagram;
            _logger = logger;
            DefaultLoadDiagram();
        }

        public List<Circle> DefaultLoadDiagram()
        {
            List<Circle> coordinates = new List<Circle>();
            coordinates =  _diagram.GetCoordinates(6);
            return coordinates;
        }
        
        public List<Circle> FormCircle(int items)
        {
            List<Circle> coordinates = new List<Circle>();
            coordinates = _diagram.GetCoordinates(items);
            return coordinates;
        }
    }
}



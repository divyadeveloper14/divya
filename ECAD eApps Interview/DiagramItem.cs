using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ECAD_eApps_Interview
{
   public class DiagramItem : INotifyPropertyChanged
   {
      private DiagramModel diagramModel;
      public DiagramItem(string name)
      {
         diagramModel = new DiagramModel
         {
            Name = name,
         };

         Name = name ?? throw new ArgumentNullException(nameof(name));
      }

      public override string ToString()
      {
         return Name;
      }

      public string Name
      {
         get { return diagramModel.Name; }
         set
         {
            if (diagramModel.Name != value)
            {
               diagramModel.Name = value;
               OnPropertyChanged();
            }
         }
      }

      public event PropertyChangedEventHandler PropertyChanged;
      protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
   }
}

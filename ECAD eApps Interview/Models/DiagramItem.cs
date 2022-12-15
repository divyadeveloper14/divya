using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ECAD_eApps_Interview
{
   public class DiagramItem : INotifyPropertyChanged
   {
        private string _name;
        private double _x, _y;
      public DiagramItem()
      {
            _name = string.Empty;
            _x = 0;
            _y = 0;
      }

    public override string ToString()
      {
         return Name;
      }

      public string Name
      {
         get { return _name; }
         set
         {
            if (_name != value)
            {
               _name = value;
               OnPropertyChanged();
            }
         }
      }

        public double X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                if (_y != value)
                {
                    _y = value;
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

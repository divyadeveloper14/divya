using System.Collections.ObjectModel;
using System.Windows;

namespace ECAD_eApps_Interview
{
   /// <summary>
   /// Interaction logic for DiagramView.xaml
   /// </summary>
   public partial class DiagramView : Window
   {
      private int index = 0;

      public DiagramView()
      {
         InitializeComponent();
         DataContext = this;

         Items.Add(new DiagramItem("DI_" + index++));
         Items.Add(new DiagramItem("DI_" + index++));
         Items.Add(new DiagramItem("DI_" + index++));
         Items.Add(new DiagramItem("DI_" + index++));
         Items.Add(new DiagramItem("DI_" + index++));
      }

      public ObservableCollection<DiagramItem> Items { get; } = new ObservableCollection<DiagramItem>();

      private void Button_Click(object sender, RoutedEventArgs e)
      {
         Items.Add(new DiagramItem("DI_" + index++));
      }
   }
}

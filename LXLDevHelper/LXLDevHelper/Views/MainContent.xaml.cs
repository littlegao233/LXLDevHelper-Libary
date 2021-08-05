using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel
namespace LXLDevHelper.Views
{
    /// <summary>
    /// MainContent.xaml 的交互逻辑
    /// </summary>
    public partial class MainContent : UserControl
    {
        public static ViewModels.MainContentViewModel Data=new();
        public ViewModels.LXLFunction CurrentFunction = new();
        public MainContent()
        {
            InitializeComponent();
            //ClassListBox.ItemsSource
            DataContext = Data;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ModernWpf.MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(Data));
        }
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).IsEnabled = false;
        }

        private void ClassListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //FuncListBox.ItemsSource = CurrentFunction;
            ((ViewModels.MainContentViewModel)DataContext).CurrentFunc = (ObservableCollection<ViewModels.LXLFunction>)ClassListBox.SelectedItem;
        }
    }
}

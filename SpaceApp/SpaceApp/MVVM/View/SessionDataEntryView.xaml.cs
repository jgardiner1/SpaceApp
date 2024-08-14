using SpaceApp.MVVM.ViewModel;
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
using System.Windows.Shapes;

namespace SpaceApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for SessionDataEntryView.xaml
    /// </summary>
    public partial class SessionDataEntryView : Window
    {
        public SessionDataEntryView(SessionDataEntryViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}

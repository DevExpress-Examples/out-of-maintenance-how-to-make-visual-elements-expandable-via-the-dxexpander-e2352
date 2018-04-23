using System.Windows;
using DevExpress.Xpf.Core;

namespace DXExpander_CreatingAndUsing {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ThemeManager.ApplicationThemeName = "Office2007Blue";
            gridControl1.DataSource = 
                new nwindDataSetTableAdapters.CustomerReportsTableAdapter().GetData();
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            expander.IsExpanded = !expander.IsExpanded;
        }
        private void rbAzure_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null) return;
            if (rbAzure.IsChecked == true)
                ThemeManager.ApplicationThemeName = "DeepBlue";
        }
        private void rbGray_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null) return;
            if (rbGray.IsChecked == true)
                ThemeManager.ApplicationThemeName = "LightGray";
        }
        private void rbOfficeBlack_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null) return;
            if (rbOfficeBlack.IsChecked == true)
                ThemeManager.ApplicationThemeName = "Office2007Black";
        }
        private void rbOfficeBlue_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null) return;
            if (rbOfficeBlue.IsChecked == true)
                ThemeManager.ApplicationThemeName = "Office2007Blue";
        }
        private void rbOfficeSilver_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null) return;
            if (rbOfficeSilver.IsChecked == true)
                ThemeManager.ApplicationThemeName = "Office2007Silver";
        }
    }
}

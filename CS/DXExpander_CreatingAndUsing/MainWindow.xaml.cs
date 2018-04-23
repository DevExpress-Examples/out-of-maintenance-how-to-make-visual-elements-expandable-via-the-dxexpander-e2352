using System.Windows;
using DevExpress.Xpf.Core;
using System.Collections.ObjectModel;

namespace DXExpander_CreatingAndUsing {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            this.DataContext = new MyViewModel();
            ApplicationThemeHelper.ApplicationThemeName = "Office2016White";

        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            expander.IsExpanded = !expander.IsExpanded;
        }
        private void rbAzure_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null)
                return;
            if (rbAzure.IsChecked == true)
                ApplicationThemeHelper.ApplicationThemeName = "Office2016White";
        }
        private void rbGray_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null)
                return;
            if (rbGray.IsChecked == true)
                ApplicationThemeHelper.ApplicationThemeName = "LightGray";
        }
        private void rbOfficeBlack_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null)
                return;
            if (rbOfficeBlack.IsChecked == true)
                ApplicationThemeHelper.ApplicationThemeName = "Office2007Black";
        }
        private void rbOfficeBlue_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null)
                return;
            if (rbOfficeBlue.IsChecked == true)
                ApplicationThemeHelper.ApplicationThemeName = "Office2007Blue";
        }
        private void rbOfficeSilver_Checked(object sender, RoutedEventArgs e) {
            if (gridControl1 == null)
                return;
            if (rbOfficeSilver.IsChecked == true)
                ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver";
        }
    }

    public partial class Person {
        public Person() {

        }
        public Person(int i) {
            FirstName = "FirstName" + i;
            LastName = "LastName" + i;
            Age = i * 10;

        }

        string _firstName;
        public string LastName { get; set; }
        int _age;

        public string FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
            }
        }

        public int Age {
            get { return _age; }
            set { _age = value; }
        }
    }
    public partial class MyViewModel {
        public MyViewModel() {
            CreateList();
        }

        public ObservableCollection<Person> ListPerson { get; set; }

        void CreateList() {
            ListPerson = new ObservableCollection<Person>();

            for (int i = 0; i < 10; i++) {
                Person p = new Person(i);
                ListPerson.Add(p);
            }
        }
    }
}

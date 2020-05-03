using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestDataGridPluralsight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public ObservableCollection<string> Sexes
        {
            get { return (ObservableCollection<string>)GetValue(SexesProperty); }
            set { SetValue(SexesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Sexes.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SexesProperty =
            DependencyProperty.Register("Sexes", typeof(ObservableCollection<string>), typeof(MainWindow), new PropertyMetadata(null));


        public ObservableCollection<Person> Persons {get { return (ObservableCollection<Person>)GetValue(PersonsProperty); }set { SetValue(PersonsProperty, value); }}
        public static readonly DependencyProperty PersonsProperty =
            DependencyProperty.Register("Persons", typeof(ObservableCollection<Person>), typeof(MainWindow), new PropertyMetadata(null));


        public MainWindow()
        {
            InitializeComponent();
            loadPersons();
            loadsexes();
        }

        
        private void loadPersons()
        {
            Persons = new ObservableCollection<Person>() { new Person("uno", "maschio"), new Person("una", "femmina") };
        }

        private void loadsexes()
        {
            Sexes = new ObservableCollection<string>() { "maschio", "femmina","altro","non risponde" };
        }

    }
}

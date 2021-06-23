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

namespace Lab4_zad1_w62952
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student student;
        public List<Student> ListaStudentow {get; set;}

        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student(){ imie="Jan", nazwisko="Kowalski", NrIndeksu=1234, wydział="KIS"},
                new Student(){ imie="Anna", nazwisko="Nowak", NrIndeksu=4321, wydział="KIS"},
                new Student(){ imie="Michal", nazwisko="Jacek", NrIndeksu= 4562, wydział="KIS"},
                new Student(){ imie="Test", nazwisko="Test", NrIndeksu=77777,wydział="BUM"},
            };

            InitializeComponent();

            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie") } );
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nr indeksu", Binding= new Binding("NrIndeksu") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydział") } );
            
            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;

        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if(dialog.ShowDialog()==true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
                ListaStudentow.Remove((Student)dgStudent.SelectedItem);
            dgStudent.Items.Refresh();


        }
    }
}

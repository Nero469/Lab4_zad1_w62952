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
using System.Text.RegularExpressions;
namespace Lab4_zad1_w62952
{
    /// <summary>
    /// Logika interakcji dla klasy StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public Student student;

        public StudentWindow(Student student = null)
        {
            InitializeComponent();

            if (student != null)
            {
                textBox1.Text = student.imie;
                textBox2.Text = student.nazwisko;
                textBox3.Text = student.NrIndeksu.ToString();
                textBox4.Text = student.wydział;
            }
            this.student = student ?? new Student();

        }

        public StudentWindow()
        {
            InitializeComponent();
           
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(textBox2.Text, @"^\p{Lu}\p{Ll}{1,20}$") ||
                !Regex.IsMatch(textBox3.Text, @"^\p{Lu}\p{Ll}{1,}$") ||
                !Regex.IsMatch(textBox4.Text, @"^[0-9]{5}$")) 
            {
                //uzupelnij kod
                //MessageBox.Show("Podano niepoprawne dane", "uwaga");
                student.imie = textBox1.Text;
                student.nazwisko = textBox2.Text;
                student.NrIndeksu = int.Parse(textBox3.Text);
                student.wydział = textBox4.Text;
                this.DialogResult = true;
                return;
            }
            else
            {
                MessageBox.Show("dobre");
            }


        }  

    }
}

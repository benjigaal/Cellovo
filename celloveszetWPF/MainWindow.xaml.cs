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
using System.IO;

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Cellovo> cellovok = new List<Cellovo>();
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("lovesek.csv");
            while (!sr.EndOfStream)
            {
                cellovok.Add(new Cellovo(sr.ReadLine()));
            }
            sr.Close();
            DataGrid1.ItemsSource = cellovok;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string nev = TextBox1.Text;
            int l1 = Convert.ToInt32(TextBox2.Text);
            bool l1text;
            int l2 = Convert.ToInt32(TextBox3.Text);
            bool l2text;
            int l3 = Convert.ToInt32(TextBox4.Text);
            bool l3text;
            int l4 = Convert.ToInt32(TextBox5.Text);
            bool l4text;
            if ( l1 >= 0  && l1 <= 99)
            {
                l1text = true;
            }
            else
            {
                l1text = false;
            }
            if (l2 >= 0 && l2 <= 99)
            {
                l2text = true;
            }
            else
            {
                l2text = false;
            }
            if (l3 >= 0 && l3 <= 99)
            {
                l3text = true;
            }
            else
            {
                l3text = false;
            }
            if (l4 >= 0 && l4 <= 99)
            {
                l4text = true;
            }
            else
            {
                l4text = false;
            }
            
            if (l1text == true && l2text == true && l3text == true && l4text == true) 
            {
                cellovok.Add(new Cellovo($"{TextBox1.Text};{TextBox2.Text};{TextBox3.Text};{TextBox4.Text};{TextBox5.Text}"));
                DataGrid1.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nem megfelelő értékek!");
            }  
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("lovesek2.csv");
                sw.WriteLine("Név, Elsőlövés, Másodiklövés, Harmadiklövés, Negyediklövés");
                for (int i = 0; i < cellovok.Count; i++)
                {
                    sw.WriteLine(cellovok[i].ToString());
                }
                sw.Close();
                MessageBox.Show("A mentés sikeresen megtörtént!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
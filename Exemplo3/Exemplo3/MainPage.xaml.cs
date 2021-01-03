using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using System.Threading;



namespace Exemplo3
{

    

    public partial class MainPage : ContentPage
    {



        Random rnd = new Random();


        int num1; 
        int num2;
        int a;
        int b;
        

        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
        public MainPage()
        {
            InitializeComponent();

            num1 = rnd.Next(10000, 99999);
            num2 = rnd.Next(10000, 99999);
            //if file exists not
            File.WriteAllText(fileName, Convert.ToString(num1) + " " + Convert.ToString(num2));


            string[] lines = File.ReadAllLines(fileName);
           


            string line = lines[0];
                string[] parts = line.Split(' ');
                 a = int.Parse(parts[0]);
                 b = int.Parse(parts[1]);

           

            Toolbar.IconImageSource = ImageSource.FromResource("Exemplo3.resources.start.png");

            output.Text = "1º numero: " + Convert.ToString(a);
            output2.Text = "2º numero: " + Convert.ToString(b);

        }

       

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            a++;
            b--;
           
            File.WriteAllText(fileName, Convert.ToString(a) + "  " + Convert.ToString(b));

            output.Text = "1º numero: " + Convert.ToString(a);
            output2.Text = "2º numero: " + Convert.ToString(b);
        }

    }
}

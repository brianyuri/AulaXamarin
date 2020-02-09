using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula1
{
    
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            Image.Source
                //http://dontpad.com/xamarinformsproway

        }
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            List<string> nomes = new List<string>();
            nomes.Add(Nome.Text);
            List.Item
        }

        public void Entry_Focused(object sender, FocusEventArgs e)
        {
            

        }
    }
}

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

namespace ByteDecoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ByteInput_KeyUp(object sender, KeyEventArgs e)
        {
            string byteString = ByteInput.Text;
            try
            {
                string[] byteStringArr = byteString.Split(" ");
                byte[] byteArray = new byte[1000];

                for (int i = 0; i < byteStringArr.Length; i++)
                {
                    byteArray[i] = byte.Parse(byteStringArr[i]);

                }
                string convertedString = Encoding.UTF8.GetString(byteArray);
                DecodedOutput.Text = convertedString;
            }
            catch(Exception err)
            {
                Console.WriteLine("[ERROR] " + e);
                DecodedOutput.Text = "Error converting byte";
            }
            
        }
    }
}

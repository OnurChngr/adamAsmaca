using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    public partial class Form1 : Form
    {
        char[] alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
        string[] sehirler = { "Ağrı", "Van", "Muş", "İzmir", "Burdur", "Ankara", "Sakarya" };
        int rastgele;
        string sehir;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyunBas_Click(object sender, EventArgs e)
        {
                       
            rastgele = r.Next(0,7);
            sehir=sehirler[rastgele];
            for (int i = 0; i < alfabe.Length; i++)
            {
                Button btn = new Button();
             //   btn.Name = alfabe[i].ToString();
                btn.Text = alfabe[i].ToString();
                btn.Width = 30;
                btn.Height = 30;
               // btn.Click += HarfButton_Click;
               flowLayoutPanel1.Controls.Add(btn);
            }

            for (int i = 0; i <sehir.Length; i++)
            {
                TextBox txt = new TextBox();            
                txt.Width = 25;
                txt.Height = 25;
                flowLayoutPanel2.Controls.Add(txt);
            }

            
        }
    }
}

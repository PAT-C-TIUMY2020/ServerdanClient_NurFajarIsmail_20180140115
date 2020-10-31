using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P2_115;

namespace Client_NurFajarIsmail_20180140115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new
           ChannelFactory<IMatematika>(bind, "http://localhost:1909");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);
            Console.ReadLine();
            Koordinat objk = new Koordinat();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // label7.Text =  hasilTambah.ToString();
           // label8.Text = "3 - 2 = " + hasilKurang.ToString();
           // label9.Text = "2 x 2 = " + hasilKali.ToString();
           // label10.Text = "2 / 2 = " + hasilBagi.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModulGhiFile;
namespace ThietKeControl
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        bool co = true;
        private void btnStart_click(object sender, EventArgs e)
        {
            if(co)
            {
                timer1.Start();
                btnStart.Text = "Stop";
                co = false;
            }
            else
            {
                timer1.Stop();
                btnStart.Text = "Start";
                co = true;
            }
        }
        
        private void btnLap_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            String gio = lbGio.Text;
            String dau1 = label2.Text;
            String phut = lbPhut.Text;
            String dau2 = label4.Text;
            String giay = lbGiay.Text;
            String miligiay = lbMiliGiay.Text;
            String chuoi = gio + " " + dau1 + " " + phut + " " + dau2 + " " + giay+" "+ miligiay;
            //label1.Text = chuoi;
            //timer1.Start();
            GHIFILE a = new GHIFILE();
            a.GhiFile(chuoi);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int miligiay = int.Parse(lbMiliGiay.Text);
            int giay = int.Parse(lbGiay.Text);
            int phut = int.Parse(lbPhut.Text);
            int gio = int.Parse(lbGio.Text);
            miligiay++;
            
            if(miligiay > 100)
            {
                miligiay = 0;
                giay++;
            }
            if(giay>59)
            {
                giay = 0;
                phut++;
            }
            if (phut > 59)
            {
                phut = 0;
                gio++;
            }
            if(gio>23)
            {
                gio = 0;
                phut = 0;
                giay = 0;
                miligiay = 0;
            }
            if (miligiay < 10)
                lbMiliGiay.Text = "0" + miligiay;
            else
                lbMiliGiay.Text =  miligiay + "";

            if (giay < 10)
                lbGiay.Text = "0" + giay;
            else
                lbGiay.Text = giay + "";

            if (phut < 10)
                lbPhut.Text = "0" + phut;
            else
                lbPhut.Text = phut + "";

            if (gio < 10)
                lbGio.Text = "0" + gio;
            else
                lbGio.Text = gio + "";
        }
    }
}

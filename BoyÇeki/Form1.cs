using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoyÇeki
{
    public partial class Frm1 : Form
    {
        private double yas;
        private double IdealCeki;
        private double ferq1;
        private double ferq;
        public Frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbBoy.Text.Length>0)
            {
                double boy = Convert.ToDouble(lbBoy.Text);
                double ceki = Convert.ToDouble(LbKilo.Text);
                hesabla(boy, ceki);
            }
           else
            {
                MessageBox.Show("daxil edin");
            }

        }
        void hesabla(double boy ,double ceki)
        {
            double yekun = ceki / (boy * boy);

            if(yekun >0 && yekun <18.4)
            {
                MessageBox.Show("Zayifsiniz" + "\n" + Kiloferqihesabla(boy, yekun,ceki));
            }
            else if ( yekun>18.5 && yekun <24.9)
            {
                MessageBox.Show(" Cekiniz Normaldir");
            }
            else if( yekun >25 && yekun <29.9)
            {
                MessageBox.Show(" Cekiniz COXDUR" + "\n"+ Kiloferqihesabla(boy, yekun, ceki));
                Kiloferqihesabla(boy,yekun,ceki);
            }
            else if(yekun >30 && yekun <34.9)
            {
                MessageBox.Show(" 1 Cekiniz COXDUR"+ "\n"+ Kiloferqihesabla(boy, yekun, ceki));
                Kiloferqihesabla(boy, yekun, ceki);
                
            }
            else if(yekun> 35 && yekun <44.9)
            {
                MessageBox.Show("  2 Cekiniz COXDUR" + "\n"+ Kiloferqihesabla(boy, yekun, ceki));
                Kiloferqihesabla(boy, yekun, ceki);
            }
            else
            {
                MessageBox.Show("  3 Cekiniz COXDUR" + "\n"+ Kiloferqihesabla(boy, yekun, ceki));
                Kiloferqihesabla(boy, yekun, ceki);
            }

        }
        string Kiloferqihesabla( double boy , double yekun, double kilo)
        {
            double yas;
            yas = Convert.ToDouble(textBox3.Text);
            IdealCeki = ((boy*100) - 100 + yas / 10) * 0.9;
            ferq = kilo - IdealCeki;

            ferq1 = IdealCeki - kilo;
            if(kilo>IdealCeki)
            {
                return (ferq + " : kq ariqlamalisiz");
            }
            else
            {
                return (ferq + " : kq almalisiz");
            }
        }

        private void Frm1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int gs_puan = 0;
        int fb_puan = 0;
        int bs_puan = 0;
        int ts_puan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);
            sonuc_1.Text = a.ToString();
            sonuc_2.Text = b.ToString();
            sonuc_3.Text = c.ToString();
            sonuc_4.Text = d.ToString();

            if (Convert.ToInt32(sonuc_1.Text)> Convert.ToInt32(sonuc_2.Text))
            {
                gs_puan += 3;
                gs.Text = gs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_1.Text) < Convert.ToInt32(sonuc_2.Text))
            {
                fb_puan += 3;
                fb.Text = fb_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_1.Text) == Convert.ToInt32(sonuc_2.Text))
            {
                gs_puan += 1;
                fb_puan += 1;
                gs.Text = gs_puan.ToString();
                fb.Text = fb_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_3.Text)> Convert.ToInt32(sonuc_4.Text))
            {
                bs_puan += 3;
                bs.Text = bs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_3.Text) < Convert.ToInt32(sonuc_4.Text))
            {
                ts_puan += 3;
                ts.Text = ts_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_3.Text) == Convert.ToInt32(sonuc_4.Text))
            {
                bs_puan += 1;
                ts_puan += 1;
                bs.Text = bs_puan.ToString();
                ts.Text = ts_puan.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);
            sonuc_5.Text = a.ToString();
            sonuc_6.Text = b.ToString();
            sonuc_7.Text = c.ToString();
            sonuc_8.Text = d.ToString();

            if (Convert.ToInt32(sonuc_5.Text) > Convert.ToInt32(sonuc_6.Text))
            {
                gs_puan += 3;
                gs.Text = gs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_5.Text) < Convert.ToInt32(sonuc_6.Text))
            {
                bs_puan+= 3;
                bs.Text = bs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_5.Text) == Convert.ToInt32(sonuc_6.Text))
            {
                gs_puan += 1;
                bs_puan += 1;
                gs.Text = gs_puan.ToString();
                bs.Text = bs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_7.Text) > Convert.ToInt32(sonuc_8.Text))
            {
                fb_puan += 3;
                fb.Text = fb_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_7.Text) < Convert.ToInt32(sonuc_8.Text))
            {
                ts_puan += 3;
                ts.Text = ts_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_7.Text) == Convert.ToInt32(sonuc_8.Text))
            {
                fb_puan += 1;
                ts_puan += 1;
                fb.Text = fb_puan.ToString();
                ts.Text = ts_puan.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);
            sonuc_9.Text = a.ToString();
            sonuc_10.Text = b.ToString();
            sonuc_11.Text = c.ToString();
            sonuc_12.Text = d.ToString();

            if (Convert.ToInt32(sonuc_9.Text) > Convert.ToInt32(sonuc_10.Text))
            {
                gs_puan += 3;
                gs.Text = gs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_9.Text) < Convert.ToInt32(sonuc_10.Text))
            {
                ts_puan += 3;
                ts.Text = ts_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_9.Text) == Convert.ToInt32(sonuc_10.Text))
            {
                gs_puan += 1;
                ts_puan += 1;
                gs.Text = gs_puan.ToString();
                ts.Text = ts_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_11.Text) > Convert.ToInt32(sonuc_12.Text))
            {
                bs_puan += 3;
                bs.Text = bs_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_11.Text) < Convert.ToInt32(sonuc_12.Text))
            {
                fb_puan += 3;
                fb.Text = fb_puan.ToString();
            }
            if (Convert.ToInt32(sonuc_11.Text) == Convert.ToInt32(sonuc_12.Text))
            {
                bs_puan += 1;
                fb_puan += 1;
                fb.Text = fb_puan.ToString();
                bs.Text = bs_puan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((gs_puan > fb_puan) && (gs_puan>bs_puan) && (gs_puan > ts_puan))
            {
                samp.Text = "GALATASARAY";
            }
            if ((fb_puan > gs_puan) && (fb_puan > bs_puan) && (fb_puan > ts_puan))
            {
                samp.Text = "FENERBAHÇE";
            }
            if ((ts_puan > gs_puan) && (ts_puan > bs_puan) && (ts_puan > fb_puan))
            {
                samp.Text = "TRABZONSPOR";
            }
            if ((bs_puan > gs_puan) && (bs_puan > ts_puan) && (bs_puan > fb_puan))
            {
                samp.Text = "BURSASPOR";
            }
        }
    }
}
/*
 if (Convert.ToInt32(gs.Text) > Convert.ToInt32(fb.Text) && 
                Convert.ToInt32(gs.Text) > Convert.ToInt32(bs.Text) && 
                Convert.ToInt32(gs.Text) >Convert.ToInt32(ts.Text))
            {
                samp.Text = "GALATASARAY";
            }
            if (Convert.ToInt32(fb.Text) > Convert.ToInt32(gs.Text) &&
               Convert.ToInt32(fb.Text) > Convert.ToInt32(bs.Text) &&
               Convert.ToInt32(fb.Text) > Convert.ToInt32(ts.Text))
            {
                samp.Text = "FENERBAHÇE";
            }
            if (Convert.ToInt32(ts.Text) > Convert.ToInt32(gs.Text) &&
                Convert.ToInt32(ts.Text) > Convert.ToInt32(bs.Text) &&
                Convert.ToInt32(ts.Text) > Convert.ToInt32(fb.Text))
            {
                samp.Text = "TRABZONSPOR";
            }
            if (Convert.ToInt32(bs.Text) > Convert.ToInt32(gs.Text) &&
                Convert.ToInt32(bs.Text) > Convert.ToInt32(ts.Text) &&
                Convert.ToInt32(bs.Text) > Convert.ToInt32(fb.Text))
            {
                samp.Text = "BURSASPOR";
            }
*/
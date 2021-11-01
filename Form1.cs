using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESLAM
{
    public partial class Form1 : Form
    {
        Timer tt = new Timer();
        PictureBox picBox = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ff = new OpenFileDialog();
            ff.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ff.Multiselect = true;
            if (ff.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in ff.FileNames)
                {
                    lstBox.Items.Add(f);
                }
            }
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Single.Checked && lstBox.SelectedItems.Count > 0)
            {
                tt.Stop();
                pnl.Controls.Clear();
                pnl.Controls.Add(picBox);
                lstBox.SelectionMode = SelectionMode.One;
                picBox.Size = pnl.Size;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = Image.FromFile(lstBox.GetItemText(lstBox.SelectedItem));
            }
            if (Multi.Checked && lstBox.SelectedItems.Count > 0)
            {
                pnl.Controls.Clear();
                int x = 0, y = 0;
                foreach (object it in lstBox.SelectedItems)
                {
                    PictureBox picsw = new PictureBox();
                    picsw.Size = new Size(150, 150);
                    picsw.Location = new Point(x, y);
                    picsw.Image = Image.FromFile(it.ToString());
                    picsw.SizeMode = PictureBoxSizeMode.StretchImage;
                    pnl.Controls.Add(picsw);
                    if (x > 470)
                    {
                        x = 0;
                        y += 155;
                    }
                    else
                    {
                        x += 155;
                    }
                }

            }
        }

        private void Single_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            tt.Stop();
            Multi.Checked = false;
            SlideShow.Checked = false;
        }

        private void SlideShow_Click(object sender, EventArgs e)
        {
            cnt = 0;
            pnl.Controls.Clear();
            Multi.Checked = false;
            Single.Checked = false;
            if (SlideShow.Checked && lstBox.Items.Count > 0)
            {
                tt.Interval = 100;
                tt.Tick += new EventHandler(start_func);
                tt.Start();
            }
            else
            {
                tt.Stop();
            }
        }

        int cnt = 0;
        void start_func(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(picBox);
            picBox.Size = pnl.Size;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Image = Image.FromFile(lstBox.GetItemText(lstBox.Items[cnt]));
            label.Text = Path.GetFileName(lstBox.GetItemText(lstBox.Items[cnt++]));
            if (lstBox.Items.  Count <= cnt)
            {
                cnt = 0; 
            }

        }

        private void Multi_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            SlideShow.Checked = false;
            Single.Checked = false;
            tt.Stop();
            lstBox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}

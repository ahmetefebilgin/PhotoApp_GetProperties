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

namespace PhotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pbxFoto.ImageLocation = openFileDialog1.FileName;

            tbx1.Text = openFileDialog1.SafeFileName;
            //tbx2.Text=openFileDialog1.
            //tbx3.Text=
            //tbx4.Text=

            try
            {
                string imagePath = pbxFoto.ImageLocation;
                using (var fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var image = Image.FromStream(fileStream, false, false))
                    {
                        var height = image.Height;
                        var width = image.Width;
                        tbx2.Text = width.ToString();
                        tbx3.Text = height.ToString();
                        var size = fileStream.Length.ToString();

                        tbx4.Text = (size + " byte");
                        var tip = fileStream.GetType();

                        //var size = image.Size;

                        //tbx4.Text = size;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Lütfen bir resim dosyası seçin");

            }

            
           
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }


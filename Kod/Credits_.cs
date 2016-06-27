using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Kodowanie
{
    public partial class Credits_ : Form
    {
        public Credits_()
        {
            InitializeComponent();
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // Form3 f = new Form3();


            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Kodowanie.Resources.bd.jpg");
            Bitmap image = new Bitmap(myStream);
            Pictures foto = new Pictures();
           // foto.ClientSize = new Size(image.Width, image.Height);
           // PictureBox pb = new PictureBox();
           // pb.Image = image;
           // pb.Dock = DockStyle.Fill;
           // foto.Controls.Add(pb);
           //foto.BackgroundImage = System.Drawing.Bitmap.FromFile(@"C:\Users\EF\My Documents\Visual Studio 2012\Projects\Kodowanie\Kodowanie\Resources\bd.jpg");
          // foto.BackgroundImage = image;
           foto.BackgroundImage = System.Drawing.Bitmap.FromStream(myStream);
           foto.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("mailto:falinski.e@gmail.com");
            Process.Start(sInfo);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Kodowanie.Resources.mb.jpg");
            Bitmap image = new Bitmap(myStream);
            Pictures foto = new Pictures();
            foto.BackgroundImage = System.Drawing.Bitmap.FromStream(myStream);
            //foto.BackgroundImage = System.Drawing.Bitmap.FromFile(@"C:\Users\EF\My Documents\Visual Studio 2012\Projects\Kodowanie\Kodowanie\Resources\mb.jpg");
            foto.Show();

            
        }
    }
}

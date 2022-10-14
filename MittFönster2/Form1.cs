using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittFönster2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool unnecessary = false;

            if (unnecessary)
            {

                DialogResult resultat;
                resultat = MessageBox.Show(
                    "Vill du ha en katt?",
                    "Katt?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Hand
                    );

                if (resultat != DialogResult.Yes)
                {
                    MessageBox.Show(
                        "Buuuuuuuuuuuuu!!!",
                        "Buu!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                    return;
                }
            }

            string imageURL = "https://cataas.com/cat";

            Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageURL);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
            }

            Form1.ActiveForm.BackgroundImage = image;
            Form1.ActiveForm.Width = image.Width;
            Form1.ActiveForm.Height = image.Height;

        }
    }
}

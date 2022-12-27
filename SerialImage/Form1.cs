using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialImage
{
    public partial class Form1 : Form
    {
        Bitmap srcImageBitmap;
        Bitmap dstImageBitmap;
        Binarisator binarisator = new Binarisator();
        int threshold = 125;
       
        string[] portNames = new string[0];
        public Form1()
        {
            InitializeComponent();
            portNames = SerialPort.GetPortNames();
            comPortsSelect.Items.AddRange(portNames);
            if (comPortsSelect.Items.Count > 0)
            {
                comPortsSelect.SelectedIndex = 0;
            }
            trackBar1.Value = threshold;
            baudrateSelect.SelectedIndex = 8;
        }

        private void loadImg_Click(object sender, EventArgs e)
        {

           if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                srcImageBitmap = (Bitmap)Image.FromFile(openImageDialog.FileName);
                srcImage.Image = srcImageBitmap;
                dstImageBitmap = binarisator.Binarise(srcImageBitmap, threshold);
                destImage.Image = dstImageBitmap;
                sendBtn.Enabled = true;
                trackBar1.Enabled = true;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            byte[] imageData = new byte[128 * 64];
            int index = 0;
            for (int y = 0; y < dstImageBitmap.Height; y++)
            {
                for (int x = 0; x < dstImageBitmap.Width; x++)
                {
                    Color pixelColor = dstImageBitmap.GetPixel(x, y);
                    imageData[index] = pixelColor.R == 0 ? (byte)'0' : (byte)'1';
                    index++;
                }
            }

            if (toFileCheckBox.Checked)
            {
                var file = File.Create(openImageDialog.FileName.Remove(openImageDialog.FileName.Length - 4) + ".txt");
                file.Write(imageData, 0, imageData.Length);
                file.Close();
                return;
            }

            
            
            SendData(imageData);
       
        }
        private async void SendData(byte[] data)
        {
            var selIndex = comPortsSelect.SelectedIndex;
            var baudIndex = baudrateSelect.SelectedIndex;
            SerialPort serialPort = new SerialPort(comPortsSelect.Items[selIndex].ToString(), Int32.Parse(baudrateSelect.Items[baudIndex].ToString()));
            serialPort.Open();
            serialPort.Write(data, 0, data.Length);
            serialPort.Close();
            MessageBox.Show("Данные отправлены!");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            threshold = (int)Math.Ceiling((double)trackBar1.Value);
            dstImageBitmap = binarisator.Binarise(srcImageBitmap, threshold);
            destImage.Image = dstImageBitmap;
        }
    }
}

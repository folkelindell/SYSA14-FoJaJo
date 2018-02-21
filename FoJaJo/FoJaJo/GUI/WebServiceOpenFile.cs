using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FoJaJo.Controller;
using FoJaJo.DAL;

namespace FoJaJo.GUI
{
    public partial class webServiceOpenFile : UserControl
    {
        WebServiceController1 wc = new WebServiceController1();

        public webServiceOpenFile()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                txtBox.Text = "";
                string strFilePath = openFile.InitialDirectory + openFile.FileName;
                string fileText = wc.OpenFile(strFilePath);
                txtBox.Text = fileText+"\n\n"+strFilePath;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnShowPlayers_Click(object sender, EventArgs e)
        {
            dataGridPlayers.DataSource = null;
            dataGridPlayers.DataSource = wc.GetAllPlayers();
        }
    }
}

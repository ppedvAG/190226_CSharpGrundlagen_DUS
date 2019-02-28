using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dateisystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 3 Varianten
            #region Variante mit einem FileStream
            //FileStream stream = new FileStream("demo.txt", FileMode.Create);
            //// Zeichenkette zu einem Bytearray verarbeiten:
            //byte[] data = Encoding.Default.GetBytes(textBoxInhalt.Text);
            //stream.Write(data, 0, data.Length);
            //stream.Flush();
            //stream.Close(); 
            #endregion

            #region Variante mit einem StreamReader/Writer
            //StreamWriter sw = new StreamWriter("demo.txt"); // Lesen: StreamReader
            //sw.WriteLine(textBoxInhalt.Text);
            //sw.Flush();
            //sw.Close(); 
            #endregion



            // Ordner:
            //Directory.GetFiles("C:\\")
            //foreach (string file in Directory.GetFiles("C:\\")
            //{
            //    if(Path.GetExtension(file) == ".exe")

            //}
            //FolderBrowserDialog dlg = new FolderBrowserDialog();
            //dlg.ShowDialog();

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Textdokument | *.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Datein:
                File.WriteAllText(dlg.FileName, textBoxInhalt.Text);
                // Features:
                // File.Exists
                File.SetCreationTime(dlg.FileName, new DateTime(1856, 11, 11, 23, 52, 12));
                MessageBox.Show("Datei wurde erfolgreich gespeichert !!!");
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Na welche Datei willst du denn öffnen ?????";
            dlg.Filter = "Textdokument | *.txt";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxInhalt.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1) Close()
            Close();
            // 2) Allgemein:
            // Environment.Exit(0);
        }
    }
}

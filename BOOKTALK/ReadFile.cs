using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.IO; //open file txt
using Microsoft.Office.Interop.Word; //read word


namespace BOOKTALK
{

    public partial class ReadFile : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        SpeechSynthesizer speech = new SpeechSynthesizer();

        public ReadFile()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            open.Filter = "Text|*.txt|Word|*doc|word|*docx";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = open.FileName;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //word
            string path = open.FileName;
            string exten = System.IO.Path.GetExtension(path);
            if (exten == ".doc" || exten == ".docx")
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Document doc = word.Documents.Open(path, Type.Missing, false);
                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();
                IDataObject data = Clipboard.GetDataObject();
                string sText = data.GetData(DataFormats.UnicodeText).ToString();
                speech.SpeakAsync(sText);
            }
            if (exten == ".txt")
            {
                speech.Volume = tbarVolume.Value;
                string sText = File.ReadAllText(open.FileName);
                speech.SpeakAsync(sText);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            speech.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            speech.Resume();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }





    }
}

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

namespace BOOKTALK
{
    public partial class ReadText : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();

        public ReadText()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            speech.Volume = tbarVolume.Value;
            speech.SpeakAsync(txtText.Text);
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
            Application.Exit();
        }

    }
}

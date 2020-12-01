using System.Text;
using System.Windows.Forms;

namespace ContextualizerHelper
{
    internal partial class SettingsForm_ContextualizerHelper : Form
    {


        #region Get and Set Options

        public bool KeepLeft { get; set; }
        public bool KeepWords { get; set; }
        public bool KeepRight { get; set; }

       #endregion



        public SettingsForm_ContextualizerHelper(bool l, bool w, bool r)
        {
            InitializeComponent();

            KeepLeftCheckbox.Checked = l;
            KeepRightCheckbox.Checked = r;
            KeepWordsCheckbox.Checked = w;

        }






        

        private void OKButton_Click(object sender, System.EventArgs e)
        {

            KeepLeft = KeepLeftCheckbox.Checked;
            KeepRight = KeepRightCheckbox.Checked;
            KeepWords = KeepWordsCheckbox.Checked;

            this.DialogResult = DialogResult.OK;
        }
    }
}

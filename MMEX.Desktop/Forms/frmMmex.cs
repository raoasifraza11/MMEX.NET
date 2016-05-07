using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMEX.Common.Resources.Constants;
using MMEX.Common.Data.Business.Managers;
using MMEX.Desktop.Costants;

namespace MMEX.Desktop.Forms
{
    public partial class frmMmex : Form
    {
        public frmMmex()
        {
            InitializeComponent();
        }

        public OptionLocalMngr _OptionLocalMngr { get; set; }
        public static readonly string _MmexIniPath = constPathDsktp.MmexIni();

        private void frmMmex_Load(object sender, EventArgs e)
        {
            _OptionLocalMngr = new OptionLocalMngr(_MmexIniPath);

            Assembly asm = Assembly.LoadFrom("MMEX.Common.Resources.dll");
            System.IO.Stream file = asm.GetManifestResourceStream("MMEX.Common.Resources.Logos.mmex.png");
            pictureBox1.Image = Image.FromStream(file);
            cbShowNextTime.Checked = _OptionLocalMngr.ShowBeginForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(constWeblink.WebSite);
        }

        private void cbShowNextTime_CheckedChanged(object sender, EventArgs e)
        {
            _OptionLocalMngr.ShowBeginForm = cbShowNextTime.Checked;
        }
    }
}

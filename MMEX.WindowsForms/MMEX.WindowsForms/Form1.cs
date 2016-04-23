using Data.Business.Managers;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEX.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public AccountManager _AccountMgr { get; set; }
        public string DbPath = "C:\\xxx.db";

        private void button1_Click(object sender, EventArgs e)
        {
            _AccountMgr = new AccountManager(DbPath);

            Account acc = new Account();
            acc.Name = "Prova";
            acc.Type = "Checking";
            acc.Status = "Open";
            acc.Favorite = "Yes";
            acc.Currency = 2;

            _AccountMgr.SaveAccount(acc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _AccountMgr = new AccountManager(DbPath);
            MessageBox.Show(_AccountMgr.GetAccounts().FirstOrDefault().Name);
        }
    }
}

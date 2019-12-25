using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtLoginUsername.Text == txtLoginPassword.Text)
            {
                
                History Rec = new History();
                Rec.Action = "Login";
                Rec.ActionTime = DateTime.Now;
                Rec.Description = txtLoginUsername.Text;
                Context db = new Context();
                db.Histories.Add(Rec);
                db.SaveChanges();
                pnlHistory.Visible = true;
                GrpLogin.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            using (Context cnx = new Context())
            {
                History Rec = new History { Action = "Logout", ActionTime = DateTime.Now };
                cnx.Histories.Add(Rec);
                cnx.SaveChanges();
                Close();
            }
        }

        private void btnRefreshHistoryList_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
            using(Context cnx = new Context())
            {
                var his = cnx.Histories;
                foreach(var Rec in his)
                {
                    if(Rec.Description!=null) lstHistory.Items.Add(Rec.Description);
                }
            }
        }

        private void btnClearHistoryList_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

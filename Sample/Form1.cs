﻿using System;
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
        public string ActionFlag = "";

        public Form1()
        {
            InitializeComponent();
        }

       public void RefreshUserList()
        {
            using(Context cnx = new Context())
            {
                if(cnx.Users.Any())
                {
                    List<User> UserList = cnx.Users.Where(x => x.Id > 0).ToList();
                    grdUserList.DataSource = UserList;
                }
                
            }
            lblUserId.Text="";
            txtEditUsername.Text = "";
            txtEditPassword.Text = "";
            txtEditMobile.Text = "";
            txtEditName.Text = "";
            txtEditEmail.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using(Context cnx = new Context())
            {
                if (cnx.Users.Where(z => z.UserName == txtLoginUsername.Text & z.Password == txtLoginPassword.Text).Any())
                {

                    History Rec = new History();
                    Rec.Action = "Login";
                    Rec.ActionTime = DateTime.Now;
                    Rec.Description = txtLoginUsername.Text;
                    Context db = new Context();
                    db.Histories.Add(Rec);
                    db.SaveChanges();
                    pnlHistory.Visible = false;
                    pnlUserPanel.Visible = true;
                    GrpLogin.Visible = false;
                    RefreshUserList();
                }
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
            RefreshUserList();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            switch (ActionFlag)
            {
                case "New": 
                    using (Context cnx = new Context())
                    {
                        User NewUser = new User();
                        NewUser.UserName = txtEditUsername.Text;
                        NewUser.Password = txtEditPassword.Text;
                        NewUser.Mobile = txtEditMobile.Text;
                        NewUser.Name = txtEditName.Text;
                        NewUser.Email = txtEditEmail.Text;
                        cnx.Users.Add(NewUser);
                        cnx.SaveChanges();
                    }
                    break;
                case "Update":
                    using (Context cnx = new Context())
                    {
                        int Index = Convert.ToInt32(lblUserId.Text);
                        User NewUser = cnx.Users.Where(x => x.Id == Index).First();
                        NewUser.UserName = txtEditUsername.Text;
                        NewUser.Password = txtEditPassword.Text;
                        NewUser.Mobile = txtEditMobile.Text;
                        NewUser.Name = txtEditName.Text;
                        NewUser.Email = txtEditEmail.Text;
                        cnx.SaveChanges();
                    }
                    break;
            }
            ActionFlag = "";
            pnlInputData.Enabled = false;
            RefreshUserList();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            ActionFlag = "New";
            pnlInputData.Enabled = true;
            lblUserId.Text = "";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            ActionFlag = "Update";
            pnlInputData.Enabled = true;
            using(Context cnx = new Context())
            {
                if(cnx.Users.Any())
                {
                    int Index = Convert.ToInt32(grdUserList.CurrentRow.Cells["Id"].Value);
                    User UpdateUser = cnx.Users.Where(x => x.Id == Index).First();
                    txtEditUsername.Text = UpdateUser.UserName;
                    txtEditPassword.Text = UpdateUser.Password;
                    txtEditMobile.Text = UpdateUser.Mobile;
                    txtEditName.Text = UpdateUser.Name;
                    txtEditEmail.Text= UpdateUser.Email;
                    lblUserId.Text = UpdateUser.Id.ToString();
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            using (Context cnx = new Context())
            {
                if (cnx.Users.Any())
                {
                    int Index = Convert.ToInt32(grdUserList.CurrentRow.Cells["Id"].Value);
                    User UpdateUser = cnx.Users.Where(x => x.Id == Index).First();
                    DialogResult Res = MessageBox.Show(UpdateUser.UserName + "\n" +
                    UpdateUser.Password + "\n" +
                    UpdateUser.Mobile + "\n" +
                    UpdateUser.Name + "\n" +
                    UpdateUser.Email + "\n","Delete User",MessageBoxButtons.YesNo,MessageBoxIcon.Information
                        );
                    if(Res== DialogResult.Yes)
                    {
                        cnx.Users.Remove(UpdateUser);
                        cnx.SaveChanges();
                    }
                }
            }
            RefreshUserList();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            ActionFlag = "";
            pnlInputData.Enabled = false;
            RefreshUserList();
        }

        private void grdUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Log = "";
            using (Context cnx = new Context())
            {
                int Index = Convert.ToInt32(2);
                var Rep = cnx.Users.Join(cnx.Histories,
                            U => U.Id,
                            H => H.UserId,
                            (U, H) => new
                            {
                                UserId = U.Id,
                                Action = H.Action,
                                Date = H.ActionTime
                            }).Where(x => x.UserId == Index);
                
                foreach(var item in Rep)
                {
                    Log += item.Action + "-" + item.Date + "\n";
                }
            }
            MessageBox.Show(Log);
        }
    }
}

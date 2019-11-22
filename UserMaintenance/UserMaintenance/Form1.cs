using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            
            labelLast.Text = Resource1.FullName;
            btnAdd.Text = Resource1.Add;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

            btnFileSa.Text = Resource1.FIleSave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtLast.Text,
                
            };
            users.Add(u);
        }

        private void btnFileSa_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var item in users)
                {
                    
                    sw.Write(item.ID);
                    sw.Write(";");
                    sw.Write(item.FullName);
                    sw.WriteLine();
                }


            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var del = from x in users
                      where x.ID.ToString() == listBox1.SelectedValue.ToString()
                      select x;
            users.Remove(del.FirstOrDefault());
        }
    }
}

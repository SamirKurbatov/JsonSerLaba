using JsonSerLaba.DBCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSerLaba
{
    public partial class FormShowJuri : Form
    {
        public FormShowJuri()
        {
            InitializeComponent();
        }

        private void FormShowJuri_Load(object sender, EventArgs e)
        {
            int number = 1;

            foreach (var i in MainForm.JuriList)
            {
                User user = DbConst.Model.Users.Find(i);
                UserControlJuri userControl = new UserControlJuri();
                userControl.Fill(user, number);
                flowLayoutPanel1.Controls.Add(userControl);
                number++;
            }
        }
    }
}

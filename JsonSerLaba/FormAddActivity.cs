using JsonSerLaba.DBCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSerLaba
{
    public partial class FormAddActivity : Form
    {
        private List<int> juriIds = new List<int>();

        public FormAddActivity()
        {
            InitializeComponent();
        }

        private void FormAddActivity_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DbConst.Model.Events.ToList();
            usersBindingSource.DataSource = DbConst.Model.Users.Where(x => x.RoleID == 1).ToList();
            userBindingSource2.DataSource = DbConst.Model.Users.Where(x => x.RoleID == 2).ToList();
        }

        private void burttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddJuri_Click(object sender, EventArgs e)
        {
            int id = (int)juriComboBox.SelectedValue;
            if (juriIds.Contains(id))
            {
                juriIds.Add(id);
                MessageBox.Show($"Пользватель с ID - {juriComboBox.SelectedValue} добавлен!");
                return;
            }
            MessageBox.Show("Нельзя добавлять одного и того же Жюри");
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Заполните поле название!");
                return;
            }

            try
            {
                Convert.ToInt32(dayTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В поле день должно стоять целочисленное значение!");
                return;
            }

            if (juriIds.Count == 0)
            {
                MessageBox.Show("Добавьте хотябы одного члена жюри!");
                return;
            }

            Activity activity = new Activity
            {
                Title = titleTextBox.Text,
                EventPlanID = (int)eventPlanIDComboBox.SelectedValue,
                Day = Convert.ToInt32(dayTextBox.Text),
                StartedAt = dateTimePicker1.Value.TimeOfDay,
                ModeratorID = (int)moderatorComboBox.SelectedValue,
                GroupsJury = JsonSerializer.Serialize(juriIds)
            };

            DbConst.Model.Activities.Add(activity);
            try
            {
                DbConst.Model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Close();
        }
    }
}

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



namespace WinForm_todolist_2nd_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Todo newTodo = new Todo();
            newTodo.Title = txtBoxTask.Text;
            newTodo.Category = Convert.ToInt32(cmbPriority.SelectedValue.ToString());
            bool retorno = con.insertTodo(newTodo);
            if (!retorno)
            {
                MessageBox.Show(con.mensagem);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            // Remove the selected task from the list box
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            // Edit the selected task in the list box
            if (listBoxTasks.SelectedIndex != -1)
            {
                string currentTask = listBoxTasks.SelectedItem.ToString();
                txtBoxTask.Text = currentTask; // Load selected task into the TextBox
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex); // Remove it from the list
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCBCategorias();
        }

        public void listaCBCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listCategories();
            cmbPriority.DataSource = tabelaDados;
            cmbPriority.DisplayMember = "name";
            cmbPriority.ValueMember = "category_id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (var task in listBoxTasks.Items)
                {
                    writer.WriteLine(task.ToString());
                }
            }

            MessageBox.Show("Tasks saved successfully!");
        }

        private void listBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Determine the color based on the task priority
            string task = listBoxTasks.Items[e.Index].ToString();
            string priority = task.Split(':')[0];

            bool isCompleted = task.EndsWith("(Completed)");

            Color color;
            switch (priority)
            {
                case "Low": color = Color.Green; break;
                case "Medium": color = Color.Blue; break;
                case "High": color = Color.Orange; break;
                case "Urgent": color = Color.Red; break;
                default: color = Color.Black; break;
            }

            Font font = isCompleted ? new Font(e.Font, FontStyle.Strikeout) : e.Font;

            // Draw the background and text
            e.DrawBackground();
            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(task, Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void btnMarkAsCompleted_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxTasks.SelectedIndex;
            if (selectedIndex != -1)
            {
                string task = listBoxTasks.Items[selectedIndex].ToString();
                if (!task.EndsWith("(Checked)"))
                {
                    listBoxTasks.Items[selectedIndex] = task + " (Checked)";
                }
            }
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Dewan
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
       
        public MainForm()
        {
            InitializeComponent();
            instance=this;
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:/Text/TextFile1.txt");
            StringBuilder builder = new StringBuilder();
            string line = reader.ReadLine();
            while (line != null)
            {
                int first = line.IndexOf(',');
                string name = line.Substring(0, first);
                int Last = line.LastIndexOf(',');
                string modria = line.Substring(Last+1);
                comboBoxDept.Items.Add(name+"_"+modria);
                line = reader.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxDept.SelectedIndex > -1)
            {
                if (name_of_dep.Items.Count < 4)
                {

                    object item = comboBoxDept.SelectedItem;
                    name_of_dep.Items.Add(item);
                    comboBoxDept.Items.Remove(item);    


                }
                else
                {
                    string message = " !!!! لقد تجاوزت الحد المسموح ";
                    MessageBox.Show(message);
                }
            }
            else
            {
                string message = "الرجاء اختيار جهة المراسلة ";
                MessageBox.Show(message);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
             
            Form2 form2=new Form2();
            string[] arr = new string[name_of_dep.Items.Count];

            if (name_of_dep.Items.Count >= 1)
            {
                string[] FirstDept = name_of_dep.Items[0].ToString().Split('_');
                form2.first_dep.Text = FirstDept[0];
                form2.id_1.Text = FirstDept[1];
                form2.history_1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                      // this
            }
            if (name_of_dep.Items.Count>=2)
            {
                string[] dept = name_of_dep.Items[1].ToString().Split('_');
                form2.secand_dep.Text = dept[0];
                form2.id_2.Text = dept[1];
                form2.time_2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                
            }
            if (name_of_dep.Items.Count >= 3)
            {
                string[] dept = name_of_dep.Items[2].ToString().Split('_');
                form2.label20.Text = dept[1];
                form2.label21.Text = dept[0];
                form2.label40.Text = DateTime.Now.ToString("yyyy-MM-dd");
               
            }
            if (name_of_dep.Items.Count >= 4)
            {
                string[] dept = name_of_dep.Items[3].ToString().Split('_');
                form2.label29.Text = dept[1];
                form2.label30.Text = dept[0];
              form2.label41.Text = DateTime.Now.ToString("yyyy-MM-dd");
               
            }
            if (name_of_dep.Items.Count < 1)
            {
                string message = " !!!!قم باختيار المديريات المطلوبة";
                MessageBox.Show(message);
            }
            if (name_of_dep.Items.Count != 0)
                form2.ShowDialog();

        } 
    }

    
}

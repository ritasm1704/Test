using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst;

namespace Test
{
    public partial class DeleteInspectorForm : Form
    {
        public DeleteInspectorForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string number = inspectorNumber.Text;
            Servise servise = new Servise();

            bool flag = false;

            List<Inspector> insp = servise.GetInspectors();

            foreach (var i in insp)
            {
                if (i.InspectorNumber == number)
                {
                    flag = true;
                    inspectorNumber.Clear();
                    numberError.Visible = false;
                    inspectorNumber.BackColor = Color.White;
                    servise.DeleteInspector(number);
                    MessageBox.Show("Инспектор " + i.ToString() + " удален");
                }
            }

            if (!flag)
            {
                numberError.Visible = true;
                inspectorNumber.BackColor = Color.FromArgb(209, 183, 186);
                inspectorNumber.Clear();
            }
        }
    }
}

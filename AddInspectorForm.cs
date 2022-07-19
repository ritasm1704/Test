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
    public partial class AddInspectorForm : Form
    {
        public AddInspectorForm()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = inspectorName.Text;
            string number = inspectorNumber.Text;
            bool flag1 = true;
            bool flag2 = true;

            Servise servise = new Servise();

            if (name == "")
            {
                nameError.Visible = true;
                inspectorName.BackColor = Color.FromArgb(209, 183, 186);
                inspectorName.Clear();
                flag1 = false;
            }

            if (number == "")
            {
                numberError.Visible = true;
                inspectorNumber.BackColor = Color.FromArgb(209, 183, 186);
                inspectorNumber.Clear();
                flag2 = false;
            }


            int count = 0;
            foreach (var symbol in name)
            {
                if (!(symbol >= 'А' && symbol <= 'я' || symbol == 'Ё' || symbol == 'ё'))
                {
                    if (symbol == '.')
                    {
                        count++;
                    }
                    else
                    {
                        nameError.Visible = true;
                        inspectorName.BackColor = Color.FromArgb(209, 183, 186);
                        inspectorName.Clear();
                        flag1 = false;
                        break;
                    }
                }
            }

            if(count > 2)
            {
                nameError.Visible = true;
                inspectorName.BackColor = Color.FromArgb(209, 183, 186);
                inspectorName.Clear();
                flag1 = false;
            }

            if(flag1)
            {
                nameError.Visible = false;
                inspectorName.BackColor = Color.White;
            }

            List<Inspector> insp = servise.GetInspectors();

            foreach (var i in insp)
            {
                if (i.InspectorNumber == number)
                {
                    numberError.Visible = true;
                    inspectorNumber.BackColor = Color.FromArgb(209, 183, 186);
                    inspectorNumber.Clear();
                    flag2 = false;
                    break;
                }
            }

            foreach (var symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    numberError.Visible = true;
                    inspectorNumber.BackColor = Color.FromArgb(209, 183, 186);
                    inspectorNumber.Clear();
                    flag2 = false;
                    break;
                }
            }

            if (flag2)
            {
                numberError.Visible = false;
                inspectorNumber.BackColor = Color.White;
            }

            if (flag1 && flag2)
            {
                Inspector inspector = new Inspector
                {
                    InspectorName = name,
                    InspectorNumber = number
                };

                servise.AddInspector(inspector);
                inspectorName.Clear();
                inspectorNumber.Clear();
                nameError.Visible = false;
                numberError.Visible = false;
                inspectorName.BackColor = Color.White;
                inspectorNumber.BackColor = Color.White;
                MessageBox.Show("Инспектор " + inspector.ToString() + " добавлен");
            }
        }
    }
}

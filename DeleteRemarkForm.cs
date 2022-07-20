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
    public partial class DeleteRemarkForm : Form
    {
        Remark remark;
        public DeleteRemarkForm(Remark remark)
        {
            InitializeComponent();
            this.remark = remark;

            if (remark == null)
            {
                warningNull.Visible = true;
            }
            else
            {
                warning.Visible = true;
                remarkText.Text = this.remark.ToString();
                remarkText.Visible = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (remark != null)
            {
                Servise servise = new Servise();
                servise.DeleteRemark(remark);
                this.Close();
            }

            this.Close();
        }
    }
}

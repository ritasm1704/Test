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
    public partial class EditRemarkForm : Form
    {
        Remark remark;
        public EditRemarkForm(Remark remark)
        {
            InitializeComponent();
            this.remark = remark;

            remarkName.Text = remark.RemarkStr;
            comment.Text = remark.Comment;
            date.Value = remark.DateOfFix;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Remark rem = new Remark
            {
                RemarkId = remark.RemarkId,
                RemarkStr = remarkName.Text,
                Comment = comment.Text,
                InspectionId = remark.InspectionId,
                DateOfFix = date.Value
            };

            Servise servise = new Servise();
            servise.EditRemark(rem);
            this.Close();
        }
    }
}

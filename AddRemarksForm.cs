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
    public partial class AddRemarksForm : Form
    {
        private int inspectionId;
        public AddRemarksForm(int inspectionId)
        {
            InitializeComponent();
            this.inspectionId = inspectionId;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Remark rem = new Remark
            {
                RemarkStr = remarkName.Text,
                Comment = comment.Text,
                InspectionId = inspectionId,
                DateOfFix = date.Value
            };

            Servise servise = new Servise();
            servise.AddRemark(rem);
            this.Close();
        }
    }
}

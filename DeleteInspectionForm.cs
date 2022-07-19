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
    public partial class DeleteInspectionForm : Form
    {
        Inspection inspection = null;
        public DeleteInspectionForm(Inspection inspection)
        {
            InitializeComponent();
            this.inspection = inspection;

            if (inspection == null)
            {
                
                warningNull.Visible = true;
            }
            else
            {
                warning.Visible = true;
                inspectionText.Text = this.inspection.ToString();
                inspectionText.Visible = true;

            }

            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (inspection != null)
            {
                Servise servise = new Servise();
                servise.DeleteInspection(inspection.InspectionId);
                this.Close();
            } else
            {
                this.Close();
            }
        }
    }
}

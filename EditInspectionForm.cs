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
    public partial class EditInspectionForm : Form
    {
        Inspection inspection;
        public EditInspectionForm(Inspection inspection)
        {
            InitializeComponent();
            this.inspection = inspection;

            inspectionName.Text = this.inspection.InspectionName;
            date.Value = this.inspection.Date;
            comment.Text = this.inspection.Comment;

            Servise servise = new Servise();
            List<Inspector> inspectorsList = servise.GetInspectors();

            inspectors.DataSource = inspectorsList;
            for (int i = 0; i < inspectorsList.Count; i++)
            {
                if (inspectorsList[i].InspectorId == this.inspection.InspectorId)
                {
                    inspectors.SelectedIndex = i;
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Inspection newInspection = new Inspection()
            {
                InspectionId = this.inspection.InspectionId,
                InspectionName = inspectionName.Text,
                Date = date.Value,
                InspectorName = (inspectors.SelectedItem as Inspector).ToString(),
                InspectorId = (inspectors.SelectedItem as Inspector).InspectorId,
                Comment = comment.Text
            };

            Servise servise = new Servise();
            servise.EditInspection(newInspection);
            this.Close();
        }
    }
}

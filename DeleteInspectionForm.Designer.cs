namespace Test
{
    partial class DeleteInspectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.inspectionText = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.warningNull = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.inspectionText);
            this.panel1.Controls.Add(this.warning);
            this.panel1.Controls.Add(this.warningNull);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 211);
            this.panel1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(116)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(134)))), ((int)(((byte)(191)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(159, 149);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Ok";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // inspectionText
            // 
            this.inspectionText.AutoSize = true;
            this.inspectionText.Location = new System.Drawing.Point(45, 114);
            this.inspectionText.Name = "inspectionText";
            this.inspectionText.Size = new System.Drawing.Size(0, 13);
            this.inspectionText.TabIndex = 3;
            this.inspectionText.Visible = false;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.warning.ForeColor = System.Drawing.Color.Maroon;
            this.warning.Location = new System.Drawing.Point(23, 57);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(377, 20);
            this.warning.TabIndex = 2;
            this.warning.Text = "Вы уверены что хотите удалить эту инспекцию?";
            this.warning.Visible = false;
            // 
            // warningNull
            // 
            this.warningNull.AutoSize = true;
            this.warningNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.warningNull.ForeColor = System.Drawing.Color.Maroon;
            this.warningNull.Location = new System.Drawing.Point(23, 77);
            this.warningNull.Name = "warningNull";
            this.warningNull.Size = new System.Drawing.Size(171, 20);
            this.warningNull.TabIndex = 1;
            this.warningNull.Text = "Выберите инспекцию";
            this.warningNull.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 52);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Удаление инспекции";
            // 
            // DeleteInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteInspectionForm";
            this.Text = "DeleteInspectionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label inspectionText;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label warningNull;
    }
}
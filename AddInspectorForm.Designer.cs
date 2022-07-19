
namespace Test
{
    partial class AddInspectorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameError = new System.Windows.Forms.Label();
            this.numberError = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.inspectorNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inspectorName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.nameError);
            this.panel1.Controls.Add(this.numberError);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.inspectorNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inspectorName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 212);
            this.panel1.TabIndex = 0;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Maroon;
            this.nameError.Location = new System.Drawing.Point(63, 37);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(136, 13);
            this.nameError.TabIndex = 7;
            this.nameError.Text = "Неверный формат имени";
            this.nameError.Visible = false;
            // 
            // numberError
            // 
            this.numberError.AutoSize = true;
            this.numberError.ForeColor = System.Drawing.Color.Maroon;
            this.numberError.Location = new System.Drawing.Point(63, 80);
            this.numberError.Name = "numberError";
            this.numberError.Size = new System.Drawing.Size(117, 13);
            this.numberError.TabIndex = 6;
            this.numberError.Text = "Некорректный номер";
            this.numberError.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(139)))), ((int)(((byte)(100)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(74)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(66, 141);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(161, 27);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // inspectorNumber
            // 
            this.inspectorNumber.Location = new System.Drawing.Point(66, 96);
            this.inspectorNumber.Name = "inspectorNumber";
            this.inspectorNumber.Size = new System.Drawing.Size(161, 20);
            this.inspectorNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // inspectorName
            // 
            this.inspectorName.Location = new System.Drawing.Point(66, 53);
            this.inspectorName.Name = "inspectorName";
            this.inspectorName.Size = new System.Drawing.Size(161, 20);
            this.inspectorName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(139)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 34);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление инспектора";
            // 
            // AddInspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 212);
            this.Controls.Add(this.panel1);
            this.Name = "AddInspectorForm";
            this.Text = "AddInspectorForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox inspectorNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inspectorName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberError;
        private System.Windows.Forms.Label nameError;
    }
}
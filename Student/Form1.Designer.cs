namespace Student
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.dob_input = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(203, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(235, 22);
            this.id.TabIndex = 5;
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(203, 66);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(235, 22);
            this.name_input.TabIndex = 6;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(203, 153);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(235, 22);
            this.address.TabIndex = 7;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "IT",
            "Nursing",
            "Electricity",
            "Admin",
            "MLT",
            "Agriculture"});
            this.department.Location = new System.Drawing.Point(203, 110);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(235, 24);
            this.department.TabIndex = 8;
            // 
            // dob_input
            // 
            this.dob_input.CustomFormat = "dd/MM/yyyy";
            this.dob_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob_input.Location = new System.Drawing.Point(203, 197);
            this.dob_input.Name = "dob_input";
            this.dob_input.Size = new System.Drawing.Size(235, 22);
            this.dob_input.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(203, 253);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(118, 29);
            this.save.TabIndex = 10;
            this.save.Text = "Save Object";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(339, 253);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(118, 29);
            this.show.TabIndex = 11;
            this.show.Text = "Show Objects";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(58, 295);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(399, 204);
            this.list.TabIndex = 13;
            this.list.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 529);
            this.Controls.Add(this.list);
            this.Controls.Add(this.show);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dob_input);
            this.Controls.Add(this.department);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.DateTimePicker dob_input;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.RichTextBox list;
    }
}


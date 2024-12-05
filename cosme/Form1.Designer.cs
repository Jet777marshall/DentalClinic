namespace cosme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dlist = new System.Windows.Forms.Button();
            this.btn_Mist = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_lg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PATIENTNO = new System.Windows.Forms.TextBox();
            this.PATIENTNAME = new System.Windows.Forms.TextBox();
            this.PROCEDURE = new System.Windows.Forms.TextBox();
            this.DOCTOR = new System.Windows.Forms.TextBox();
            this.ROOM = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.APPOINTMENT = new System.Windows.Forms.DateTimePicker();
            this.TIME = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btn_dlist);
            this.flowLayoutPanel1.Controls.Add(this.btn_Mist);
            this.flowLayoutPanel1.Controls.Add(this.btn_about);
            this.flowLayoutPanel1.Controls.Add(this.btn_lg);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 713);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dlist
            // 
            this.btn_dlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_dlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dlist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlist.ForeColor = System.Drawing.Color.White;
            this.btn_dlist.Image = ((System.Drawing.Image)(resources.GetObject("btn_dlist.Image")));
            this.btn_dlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dlist.Location = new System.Drawing.Point(3, 167);
            this.btn_dlist.Name = "btn_dlist";
            this.btn_dlist.Size = new System.Drawing.Size(172, 47);
            this.btn_dlist.TabIndex = 22;
            this.btn_dlist.Text = "DOCTOR\'S ";
            this.btn_dlist.UseVisualStyleBackColor = false;
            this.btn_dlist.Click += new System.EventHandler(this.btn_dlist_Click);
            // 
            // btn_Mist
            // 
            this.btn_Mist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Mist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mist.ForeColor = System.Drawing.Color.White;
            this.btn_Mist.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mist.Image")));
            this.btn_Mist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mist.Location = new System.Drawing.Point(3, 220);
            this.btn_Mist.Name = "btn_Mist";
            this.btn_Mist.Size = new System.Drawing.Size(172, 47);
            this.btn_Mist.TabIndex = 23;
            this.btn_Mist.Text = "MIDICINE";
            this.btn_Mist.UseVisualStyleBackColor = false;
            this.btn_Mist.Click += new System.EventHandler(this.btn_Mist_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(3, 273);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(172, 47);
            this.btn_about.TabIndex = 25;
            this.btn_about.Text = "PRICE LIST";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_lg
            // 
            this.btn_lg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lg.ForeColor = System.Drawing.Color.White;
            this.btn_lg.Image = ((System.Drawing.Image)(resources.GetObject("btn_lg.Image")));
            this.btn_lg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lg.Location = new System.Drawing.Point(3, 326);
            this.btn_lg.Name = "btn_lg";
            this.btn_lg.Size = new System.Drawing.Size(172, 47);
            this.btn_lg.TabIndex = 26;
            this.btn_lg.Text = "LOG OUT";
            this.btn_lg.UseVisualStyleBackColor = false;
            this.btn_lg.Click += new System.EventHandler(this.btn_lg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Experience the Power of Beautification\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 208);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Procedure";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Appointment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Room";
            // 
            // PATIENTNO
            // 
            this.PATIENTNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PATIENTNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PATIENTNO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATIENTNO.Location = new System.Drawing.Point(735, 124);
            this.PATIENTNO.Name = "PATIENTNO";
            this.PATIENTNO.Size = new System.Drawing.Size(235, 26);
            this.PATIENTNO.TabIndex = 9;
            // 
            // PATIENTNAME
            // 
            this.PATIENTNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PATIENTNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PATIENTNAME.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATIENTNAME.Location = new System.Drawing.Point(325, 161);
            this.PATIENTNAME.Name = "PATIENTNAME";
            this.PATIENTNAME.Size = new System.Drawing.Size(235, 26);
            this.PATIENTNAME.TabIndex = 10;
            // 
            // PROCEDURE
            // 
            this.PROCEDURE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PROCEDURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PROCEDURE.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCEDURE.Location = new System.Drawing.Point(325, 203);
            this.PROCEDURE.Name = "PROCEDURE";
            this.PROCEDURE.Size = new System.Drawing.Size(235, 26);
            this.PROCEDURE.TabIndex = 11;
            // 
            // DOCTOR
            // 
            this.DOCTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DOCTOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DOCTOR.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOCTOR.Location = new System.Drawing.Point(325, 241);
            this.DOCTOR.Name = "DOCTOR";
            this.DOCTOR.Size = new System.Drawing.Size(235, 26);
            this.DOCTOR.TabIndex = 14;
            // 
            // ROOM
            // 
            this.ROOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ROOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ROOM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROOM.Location = new System.Drawing.Point(325, 287);
            this.ROOM.Name = "ROOM";
            this.ROOM.Size = new System.Drawing.Size(235, 26);
            this.ROOM.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(614, 156);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(636, 542);
            this.flowLayoutPanel2.TabIndex = 16;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 533);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(218, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(373, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 46);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(218, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 47);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(373, 501);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(139, 47);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_get
            // 
            this.btn_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.ForeColor = System.Drawing.Color.White;
            this.btn_get.Image = ((System.Drawing.Image)(resources.GetObject("btn_get.Image")));
            this.btn_get.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_get.Location = new System.Drawing.Point(976, 109);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(174, 41);
            this.btn_get.TabIndex = 21;
            this.btn_get.Text = "GET INFO";
            this.btn_get.UseVisualStyleBackColor = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // APPOINTMENT
            // 
            this.APPOINTMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPOINTMENT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.APPOINTMENT.Location = new System.Drawing.Point(325, 372);
            this.APPOINTMENT.Name = "APPOINTMENT";
            this.APPOINTMENT.Size = new System.Drawing.Size(121, 26);
            this.APPOINTMENT.TabIndex = 22;
            this.APPOINTMENT.Value = new System.DateTime(2024, 2, 13, 0, 52, 0, 0);
            // 
            // TIME
            // 
            this.TIME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TIME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIME.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIME.Location = new System.Drawing.Point(325, 326);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(121, 26);
            this.TIME.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 713);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.APPOINTMENT);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.ROOM);
            this.Controls.Add(this.DOCTOR);
            this.Controls.Add(this.PROCEDURE);
            this.Controls.Add(this.PATIENTNAME);
            this.Controls.Add(this.PATIENTNO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PATIENTNO;
        private System.Windows.Forms.TextBox PATIENTNAME;
        private System.Windows.Forms.TextBox PROCEDURE;
        private System.Windows.Forms.TextBox DOCTOR;
        private System.Windows.Forms.TextBox ROOM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dlist;
        private System.Windows.Forms.Button btn_Mist;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_lg;
        private System.Windows.Forms.DateTimePicker APPOINTMENT;
        private System.Windows.Forms.TextBox TIME;
    }
}


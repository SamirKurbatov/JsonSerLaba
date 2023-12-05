namespace JsonSerLaba
{
    partial class FormAddActivity
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
            this.components = new System.ComponentModel.Container();
            this.burttonBack = new System.Windows.Forms.Button();
            this.buttonAddJuri = new System.Windows.Forms.Button();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.eventPlanIDComboBox = new System.Windows.Forms.ComboBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.moderatorComboBox = new System.Windows.Forms.ComboBox();
            this.juriComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // burttonBack
            // 
            this.burttonBack.Location = new System.Drawing.Point(42, 28);
            this.burttonBack.Name = "burttonBack";
            this.burttonBack.Size = new System.Drawing.Size(75, 23);
            this.burttonBack.TabIndex = 0;
            this.burttonBack.Text = "Назад";
            this.burttonBack.UseVisualStyleBackColor = true;
            this.burttonBack.Click += new System.EventHandler(this.burttonBack_Click);
            // 
            // buttonAddJuri
            // 
            this.buttonAddJuri.Location = new System.Drawing.Point(408, 284);
            this.buttonAddJuri.Name = "buttonAddJuri";
            this.buttonAddJuri.Size = new System.Drawing.Size(75, 23);
            this.buttonAddJuri.TabIndex = 1;
            this.buttonAddJuri.Text = "добавить";
            this.buttonAddJuri.UseVisualStyleBackColor = true;
            this.buttonAddJuri.Click += new System.EventHandler(this.buttonAddJuri_Click);
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(196, 345);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(174, 32);
            this.buttonAddActivity.TabIndex = 2;
            this.buttonAddActivity.Text = "Добавить активность";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "План события";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "День";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Начало мер.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Модератор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Жюри";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(234, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Добавление новой активности";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(249, 134);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 11;
            // 
            // eventPlanIDComboBox
            // 
            this.eventPlanIDComboBox.DataSource = this.eventBindingSource;
            this.eventPlanIDComboBox.DisplayMember = "Title";
            this.eventPlanIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDComboBox.FormattingEnabled = true;
            this.eventPlanIDComboBox.Location = new System.Drawing.Point(249, 165);
            this.eventPlanIDComboBox.Name = "eventPlanIDComboBox";
            this.eventPlanIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.eventPlanIDComboBox.TabIndex = 12;
            this.eventPlanIDComboBox.ValueMember = "ID";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(249, 192);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // moderatorComboBox
            // 
            this.moderatorComboBox.DataSource = this.usersBindingSource;
            this.moderatorComboBox.DisplayMember = "Surname";
            this.moderatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moderatorComboBox.FormattingEnabled = true;
            this.moderatorComboBox.Location = new System.Drawing.Point(249, 257);
            this.moderatorComboBox.Name = "moderatorComboBox";
            this.moderatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.moderatorComboBox.TabIndex = 15;
            this.moderatorComboBox.ValueMember = "ID";
            // 
            // juriComboBox
            // 
            this.juriComboBox.DataSource = this.userBindingSource2;
            this.juriComboBox.DisplayMember = "Surname";
            this.juriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.juriComboBox.FormattingEnabled = true;
            this.juriComboBox.Location = new System.Drawing.Point(249, 286);
            this.juriComboBox.Name = "juriComboBox";
            this.juriComboBox.Size = new System.Drawing.Size(121, 21);
            this.juriComboBox.TabIndex = 16;
            this.juriComboBox.ValueMember = "ID";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(JsonSerLaba.DBCon.Event);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(JsonSerLaba.DBCon.User);
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(JsonSerLaba.DBCon.User);
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.juriComboBox);
            this.Controls.Add(this.moderatorComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.eventPlanIDComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.buttonAddJuri);
            this.Controls.Add(this.burttonBack);
            this.Name = "FormAddActivity";
            this.Text = "FormAddActivity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button burttonBack;
        private System.Windows.Forms.Button buttonAddJuri;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox eventPlanIDComboBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox moderatorComboBox;
        private System.Windows.Forms.ComboBox juriComboBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource2;
    }
}
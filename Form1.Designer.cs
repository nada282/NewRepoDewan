namespace Dewan
{
    partial class MainForm
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
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.choose_to_send = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.send_to = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.name_of_dep = new System.Windows.Forms.ListBox();
            this.print = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(264, 78);
            this.comboBoxDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(392, 24);
            this.comboBoxDept.TabIndex = 0;
            // 
            // choose_to_send
            // 
            this.choose_to_send.AutoSize = true;
            this.choose_to_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_to_send.Location = new System.Drawing.Point(64, 81);
            this.choose_to_send.Name = "choose_to_send";
            this.choose_to_send.Size = new System.Drawing.Size(149, 25);
            this.choose_to_send.TabIndex = 1;
            this.choose_to_send.Text = "اختر جهة المراسلة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(345, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "الرجاء اختيار 4 مديريات كحد اقصى";
            // 
            // send_to
            // 
            this.send_to.AutoSize = true;
            this.send_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_to.Location = new System.Drawing.Point(64, 267);
            this.send_to.Name = "send_to";
            this.send_to.Size = new System.Drawing.Size(118, 29);
            this.send_to.TabIndex = 4;
            this.send_to.Text = "المرسل اليه:";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(868, 399);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(156, 38);
            this.exit.TabIndex = 5;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_of_dep
            // 
            this.name_of_dep.BackColor = System.Drawing.Color.AntiqueWhite;
            this.name_of_dep.FormattingEnabled = true;
            this.name_of_dep.ItemHeight = 16;
            this.name_of_dep.Location = new System.Drawing.Point(264, 267);
            this.name_of_dep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_of_dep.Name = "name_of_dep";
            this.name_of_dep.Size = new System.Drawing.Size(231, 84);
            this.name_of_dep.TabIndex = 6;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.AntiqueWhite;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(264, 395);
            this.print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(129, 44);
            this.print.TabIndex = 7;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(691, 75);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.name_of_dep);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.send_to);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choose_to_send);
            this.Controls.Add(this.comboBoxDept);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الرئيسية";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label choose_to_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label send_to;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox name_of_dep;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button btnAdd;
    }
}


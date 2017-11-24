namespace WouldYouRather
{
    partial class Form_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Base));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_wyr = new System.Windows.Forms.Label();
            this.button_C1 = new System.Windows.Forms.Button();
            this.button_C2 = new System.Windows.Forms.Button();
            this.label_qA1 = new System.Windows.Forms.Label();
            this.label_qA2 = new System.Windows.Forms.Label();
            this.label_times1 = new System.Windows.Forms.Label();
            this.label_times2 = new System.Windows.Forms.Label();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.Khaki;
            this.panel_Header.Controls.Add(this.label_wyr);
            this.panel_Header.Location = new System.Drawing.Point(3, 25);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(471, 41);
            this.panel_Header.TabIndex = 0;
            // 
            // label_wyr
            // 
            this.label_wyr.AutoSize = true;
            this.label_wyr.BackColor = System.Drawing.Color.Transparent;
            this.label_wyr.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wyr.Location = new System.Drawing.Point(143, 9);
            this.label_wyr.Name = "label_wyr";
            this.label_wyr.Size = new System.Drawing.Size(194, 25);
            this.label_wyr.TabIndex = 4;
            this.label_wyr.Text = "Would you rather";
            // 
            // button_C1
            // 
            this.button_C1.BackColor = System.Drawing.Color.IndianRed;
            this.button_C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_C1.FlatAppearance.BorderSize = 0;
            this.button_C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C1.Location = new System.Drawing.Point(3, 65);
            this.button_C1.Name = "button_C1";
            this.button_C1.Size = new System.Drawing.Size(240, 195);
            this.button_C1.TabIndex = 1;
            this.button_C1.Tag = "";
            this.button_C1.Text = "Choice 1";
            this.button_C1.UseVisualStyleBackColor = false;
            this.button_C1.Click += new System.EventHandler(this.button_C1_Click);
            // 
            // button_C2
            // 
            this.button_C2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_C2.FlatAppearance.BorderSize = 0;
            this.button_C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C2.Location = new System.Drawing.Point(242, 65);
            this.button_C2.Name = "button_C2";
            this.button_C2.Size = new System.Drawing.Size(232, 195);
            this.button_C2.TabIndex = 2;
            this.button_C2.Text = "Choice 2";
            this.button_C2.UseVisualStyleBackColor = false;
            this.button_C2.Click += new System.EventHandler(this.button_C2_Click);
            // 
            // label_qA1
            // 
            this.label_qA1.AutoSize = true;
            this.label_qA1.BackColor = System.Drawing.Color.IndianRed;
            this.label_qA1.Font = new System.Drawing.Font("Segoe UI Emoji", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qA1.ForeColor = System.Drawing.Color.Transparent;
            this.label_qA1.Location = new System.Drawing.Point(21, 110);
            this.label_qA1.Name = "label_qA1";
            this.label_qA1.Size = new System.Drawing.Size(153, 74);
            this.label_qA1.TabIndex = 3;
            this.label_qA1.Text = "0.0%";
            this.label_qA1.Visible = false;
            // 
            // label_qA2
            // 
            this.label_qA2.AutoSize = true;
            this.label_qA2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_qA2.Font = new System.Drawing.Font("Segoe UI Emoji", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qA2.ForeColor = System.Drawing.Color.Transparent;
            this.label_qA2.Location = new System.Drawing.Point(250, 110);
            this.label_qA2.Name = "label_qA2";
            this.label_qA2.Size = new System.Drawing.Size(153, 74);
            this.label_qA2.TabIndex = 4;
            this.label_qA2.Text = "0.0%";
            this.label_qA2.Visible = false;
            // 
            // label_times1
            // 
            this.label_times1.AutoSize = true;
            this.label_times1.BackColor = System.Drawing.Color.IndianRed;
            this.label_times1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_times1.ForeColor = System.Drawing.Color.Transparent;
            this.label_times1.Location = new System.Drawing.Point(93, 183);
            this.label_times1.Name = "label_times1";
            this.label_times1.Size = new System.Drawing.Size(14, 15);
            this.label_times1.TabIndex = 5;
            this.label_times1.Text = "0";
            this.label_times1.Visible = false;
            // 
            // label_times2
            // 
            this.label_times2.AutoSize = true;
            this.label_times2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_times2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_times2.ForeColor = System.Drawing.Color.Transparent;
            this.label_times2.Location = new System.Drawing.Point(338, 183);
            this.label_times2.Name = "label_times2";
            this.label_times2.Size = new System.Drawing.Size(14, 15);
            this.label_times2.TabIndex = 6;
            this.label_times2.Text = "0";
            this.label_times2.Visible = false;
            // 
            // button_Minimize
            // 
            this.button_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Minimize.Location = new System.Drawing.Point(430, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(22, 25);
            this.button_Minimize.TabIndex = 7;
            this.button_Minimize.Text = "-";
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Next
            // 
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Next.Location = new System.Drawing.Point(381, 0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(22, 25);
            this.button_Next.TabIndex = 8;
            this.button_Next.Text = ">";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Close
            // 
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Close.Location = new System.Drawing.Point(452, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(22, 25);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "x";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Add
            // 
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Add.Location = new System.Drawing.Point(406, 0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(22, 25);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timer_Animation
            // 
            this.timer_Animation.Interval = 50;
            this.timer_Animation.Tick += new System.EventHandler(this.timer_Animation_Tick);
            // 
            // Form_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(477, 263);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.label_times2);
            this.Controls.Add(this.label_times1);
            this.Controls.Add(this.label_qA2);
            this.Controls.Add(this.label_qA1);
            this.Controls.Add(this.button_C2);
            this.Controls.Add(this.button_C1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Would you rather";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button button_C1;
        private System.Windows.Forms.Button button_C2;
        private System.Windows.Forms.Label label_wyr;
        private System.Windows.Forms.Label label_qA1;
        private System.Windows.Forms.Label label_qA2;
        private System.Windows.Forms.Label label_times1;
        private System.Windows.Forms.Label label_times2;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timer_Animation;
    }
}


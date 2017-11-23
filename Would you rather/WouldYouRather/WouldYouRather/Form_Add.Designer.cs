namespace WouldYouRather
{
    partial class Form_Add
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
            this.textBox_C2 = new System.Windows.Forms.TextBox();
            this.textBox_C1 = new System.Windows.Forms.TextBox();
            this.panel_Add = new System.Windows.Forms.Panel();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label_C2 = new System.Windows.Forms.Label();
            this.label_C1 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_C2
            // 
            this.textBox_C2.Location = new System.Drawing.Point(83, 62);
            this.textBox_C2.Name = "textBox_C2";
            this.textBox_C2.Size = new System.Drawing.Size(176, 20);
            this.textBox_C2.TabIndex = 1;
            this.textBox_C2.TextChanged += new System.EventHandler(this.textBox_C2_TextChanged);
            // 
            // textBox_C1
            // 
            this.textBox_C1.Location = new System.Drawing.Point(83, 18);
            this.textBox_C1.Name = "textBox_C1";
            this.textBox_C1.Size = new System.Drawing.Size(176, 20);
            this.textBox_C1.TabIndex = 0;
            this.textBox_C1.TextChanged += new System.EventHandler(this.textBox_C1_TextChanged);
            // 
            // panel_Add
            // 
            this.panel_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_Add.Controls.Add(this.button_Confirm);
            this.panel_Add.Controls.Add(this.label_C2);
            this.panel_Add.Controls.Add(this.label_C1);
            this.panel_Add.Controls.Add(this.textBox_C1);
            this.panel_Add.Controls.Add(this.textBox_C2);
            this.panel_Add.Location = new System.Drawing.Point(3, 25);
            this.panel_Add.Name = "panel_Add";
            this.panel_Add.Size = new System.Drawing.Size(276, 131);
            this.panel_Add.TabIndex = 2;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Confirm.Enabled = false;
            this.button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Confirm.Location = new System.Drawing.Point(184, 94);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 4;
            this.button_Confirm.Text = "Add";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label_C2
            // 
            this.label_C2.AutoSize = true;
            this.label_C2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C2.Location = new System.Drawing.Point(14, 65);
            this.label_C2.Name = "label_C2";
            this.label_C2.Size = new System.Drawing.Size(57, 15);
            this.label_C2.TabIndex = 3;
            this.label_C2.Text = "Choice 2";
            // 
            // label_C1
            // 
            this.label_C1.AutoSize = true;
            this.label_C1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C1.Location = new System.Drawing.Point(14, 21);
            this.label_C1.Name = "label_C1";
            this.label_C1.Size = new System.Drawing.Size(57, 15);
            this.label_C1.TabIndex = 2;
            this.label_C1.Text = "Choice 1";
            // 
            // button_Close
            // 
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Close.Location = new System.Drawing.Point(257, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(22, 25);
            this.button_Close.TabIndex = 10;
            this.button_Close.Text = "x";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(282, 159);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Add";
            this.panel_Add.ResumeLayout(false);
            this.panel_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_C2;
        private System.Windows.Forms.TextBox textBox_C1;
        private System.Windows.Forms.Panel panel_Add;
        private System.Windows.Forms.Label label_C1;
        private System.Windows.Forms.Label label_C2;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Button button_Close;
    }
}
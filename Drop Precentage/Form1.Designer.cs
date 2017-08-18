namespace Drop_Precentage
{
    partial class FormMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAveragePercentage = new System.Windows.Forms.Label();
            this.lblYourPercentage = new System.Windows.Forms.Label();
            this.cbDropped = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Controls.Add(this.tbInput, 0, 0);
            this.tlpMain.Controls.Add(this.btnAdd, 0, 1);
            this.tlpMain.Controls.Add(this.btnClear, 3, 1);
            this.tlpMain.Controls.Add(this.lblAveragePercentage, 2, 0);
            this.tlpMain.Controls.Add(this.lblYourPercentage, 3, 0);
            this.tlpMain.Controls.Add(this.cbDropped, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(359, 87);
            this.tlpMain.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMain.SetColumnSpan(this.tbInput, 2);
            this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInput.Location = new System.Drawing.Point(3, 3);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(172, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(270, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAveragePercentage
            // 
            this.lblAveragePercentage.AutoSize = true;
            this.lblAveragePercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAveragePercentage.Location = new System.Drawing.Point(181, 0);
            this.lblAveragePercentage.Name = "lblAveragePercentage";
            this.lblAveragePercentage.Size = new System.Drawing.Size(83, 43);
            this.lblAveragePercentage.TabIndex = 3;
            this.lblAveragePercentage.Text = "Average";
            this.lblAveragePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourPercentage
            // 
            this.lblYourPercentage.AutoSize = true;
            this.lblYourPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYourPercentage.Location = new System.Drawing.Point(270, 0);
            this.lblYourPercentage.Name = "lblYourPercentage";
            this.lblYourPercentage.Size = new System.Drawing.Size(86, 43);
            this.lblYourPercentage.TabIndex = 4;
            this.lblYourPercentage.Text = "Your";
            this.lblYourPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDropped
            // 
            this.cbDropped.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.cbDropped, 2);
            this.cbDropped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDropped.Location = new System.Drawing.Point(92, 46);
            this.cbDropped.Name = "cbDropped";
            this.cbDropped.Size = new System.Drawing.Size(172, 38);
            this.cbDropped.TabIndex = 5;
            this.cbDropped.Text = "Dropped";
            this.cbDropped.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 87);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drop Percentage";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAveragePercentage;
        private System.Windows.Forms.Label lblYourPercentage;
        private System.Windows.Forms.CheckBox cbDropped;
    }
}


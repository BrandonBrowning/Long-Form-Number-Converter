namespace Long_Form_Number_Converter
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
            this.txtUnsignedInt = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnConvertUInt = new System.Windows.Forms.Button();
            this.btnConvertString = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnsignedInt
            // 
            this.txtUnsignedInt.Location = new System.Drawing.Point(12, 12);
            this.txtUnsignedInt.Name = "txtUnsignedInt";
            this.txtUnsignedInt.Size = new System.Drawing.Size(136, 20);
            this.txtUnsignedInt.TabIndex = 0;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 38);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(776, 20);
            this.txtString.TabIndex = 1;
            // 
            // btnConvertUInt
            // 
            this.btnConvertUInt.Location = new System.Drawing.Point(154, 10);
            this.btnConvertUInt.Name = "btnConvertUInt";
            this.btnConvertUInt.Size = new System.Drawing.Size(75, 23);
            this.btnConvertUInt.TabIndex = 2;
            this.btnConvertUInt.Text = "Convert";
            this.btnConvertUInt.UseVisualStyleBackColor = true;
            this.btnConvertUInt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnConvertInt_MouseUp);
            // 
            // btnConvertString
            // 
            this.btnConvertString.Location = new System.Drawing.Point(794, 36);
            this.btnConvertString.Name = "btnConvertString";
            this.btnConvertString.Size = new System.Drawing.Size(75, 23);
            this.btnConvertString.TabIndex = 3;
            this.btnConvertString.Text = "Convert";
            this.btnConvertString.UseVisualStyleBackColor = true;
            this.btnConvertString.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnConvertString_MouseUp);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 109);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvertString);
            this.Controls.Add(this.btnConvertUInt);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtUnsignedInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnsignedInt;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnConvertUInt;
        private System.Windows.Forms.Button btnConvertString;
        private System.Windows.Forms.Label lblOutput;
    }
}


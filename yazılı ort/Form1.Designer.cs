namespace yazılı_ort
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
            this.lblnot3 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.btnOrt = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "not1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "not2";
            // 
            // lblnot3
            // 
            this.lblnot3.AutoSize = true;
            this.lblnot3.Location = new System.Drawing.Point(53, 122);
            this.lblnot3.Name = "lblnot3";
            this.lblnot3.Size = new System.Drawing.Size(28, 13);
            this.lblnot3.TabIndex = 2;
            this.lblnot3.Text = "not3";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(161, 14);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 20);
            this.txtNot1.TabIndex = 3;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(161, 70);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 20);
            this.txtNot2.TabIndex = 5;
            // 
            // btnOrt
            // 
            this.btnOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrt.Location = new System.Drawing.Point(66, 196);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(75, 33);
            this.btnOrt.TabIndex = 6;
            this.btnOrt.Text = "ort";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(156, 151);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(65, 25);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "sonuc";
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(161, 119);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(100, 20);
            this.txtNot3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 299);
            this.Controls.Add(this.txtNot3);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOrt);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.lblnot3);
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
        private System.Windows.Forms.Label lblnot3;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Button btnOrt;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtNot3;
    }
}


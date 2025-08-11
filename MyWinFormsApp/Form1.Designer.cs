
namespace MyWinFormsApp
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(318, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên của bạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChao
            // 
            this.btnChao.Location = new System.Drawing.Point(318, 156);
            this.btnChao.Name = "btnChao";
            this.btnChao.Size = new System.Drawing.Size(75, 23);
            this.btnChao.TabIndex = 2;
            this.btnChao.Text = "Chào!";
            this.btnChao.UseVisualStyleBackColor = true;
            this.btnChao.Click += new System.EventHandler(this.btnChao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChao;
    }
}


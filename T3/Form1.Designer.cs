namespace T3
{
    partial class FrmClient
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
            this.labYourS = new System.Windows.Forms.Label();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.labServerS = new System.Windows.Forms.Label();
            this.labYourResult = new System.Windows.Forms.Label();
            this.txtYourS = new System.Windows.Forms.TextBox();
            this.txtServerS = new System.Windows.Forms.TextBox();
            this.txtYourR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labYourS
            // 
            this.labYourS.AutoSize = true;
            this.labYourS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYourS.Location = new System.Drawing.Point(120, 60);
            this.labYourS.Name = "labYourS";
            this.labYourS.Size = new System.Drawing.Size(145, 25);
            this.labYourS.TabIndex = 0;
            this.labYourS.Text = "Your Selection:";
            // 
            // btnKeo
            // 
            this.btnKeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeo.Location = new System.Drawing.Point(123, 187);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(110, 50);
            this.btnKeo.TabIndex = 2;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBua
            // 
            this.btnBua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBua.Location = new System.Drawing.Point(297, 187);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(110, 50);
            this.btnBua.TabIndex = 3;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBao.Location = new System.Drawing.Point(479, 187);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(110, 50);
            this.btnBao.TabIndex = 4;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // labServerS
            // 
            this.labServerS.AutoSize = true;
            this.labServerS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labServerS.Location = new System.Drawing.Point(120, 126);
            this.labServerS.Name = "labServerS";
            this.labServerS.Size = new System.Drawing.Size(162, 25);
            this.labServerS.TabIndex = 5;
            this.labServerS.Text = "Server Selection:";
            // 
            // labYourResult
            // 
            this.labYourResult.AutoSize = true;
            this.labYourResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYourResult.Location = new System.Drawing.Point(120, 334);
            this.labYourResult.Name = "labYourResult";
            this.labYourResult.Size = new System.Drawing.Size(118, 25);
            this.labYourResult.TabIndex = 7;
            this.labYourResult.Text = "Your Result:";
            // 
            // txtYourS
            // 
            this.txtYourS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourS.Location = new System.Drawing.Point(297, 60);
            this.txtYourS.Multiline = true;
            this.txtYourS.Name = "txtYourS";
            this.txtYourS.Size = new System.Drawing.Size(100, 25);
            this.txtYourS.TabIndex = 8;
            // 
            // txtServerS
            // 
            this.txtServerS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerS.Location = new System.Drawing.Point(297, 126);
            this.txtServerS.Multiline = true;
            this.txtServerS.Name = "txtServerS";
            this.txtServerS.Size = new System.Drawing.Size(100, 25);
            this.txtServerS.TabIndex = 9;
            // 
            // txtYourR
            // 
            this.txtYourR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourR.Location = new System.Drawing.Point(244, 334);
            this.txtYourR.Multiline = true;
            this.txtYourR.Name = "txtYourR";
            this.txtYourR.Size = new System.Drawing.Size(100, 25);
            this.txtYourR.TabIndex = 10;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 425);
            this.Controls.Add(this.txtYourR);
            this.Controls.Add(this.txtServerS);
            this.Controls.Add(this.txtYourS);
            this.Controls.Add(this.labYourResult);
            this.Controls.Add(this.labServerS);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.labYourS);
            this.Name = "FrmClient";
            this.Text = "Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClient_FormClosing);
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labYourS;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Label labServerS;
        private System.Windows.Forms.Label labYourResult;
        private System.Windows.Forms.TextBox txtYourS;
        private System.Windows.Forms.TextBox txtServerS;
        private System.Windows.Forms.TextBox txtYourR;
    }
}


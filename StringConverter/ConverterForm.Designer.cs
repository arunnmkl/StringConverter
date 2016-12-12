namespace StringConverter
{
    partial class ConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm));
            this.lblString = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtHashKey = new System.Windows.Forms.TextBox();
            this.lblStringHashKey = new System.Windows.Forms.Label();
            this.lnkConvertedString = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.flpEncrypt = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkError = new System.Windows.Forms.LinkLabel();
            this.flpEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(11, 43);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(160, 13);
            this.lblString.TabIndex = 0;
            this.lblString.Text = "String To Be(Encrypt or Decrypt)";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(195, 43);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(330, 110);
            this.txtString.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtString, "Double click to select all text.");
            this.txtString.DoubleClick += new System.EventHandler(this.txtString_DoubleClick);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(450, 166);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.toolTip.SetToolTip(this.btnDecrypt, "Click to get the Decrypted string.");
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtHashKey
            // 
            this.txtHashKey.Location = new System.Drawing.Point(195, 10);
            this.txtHashKey.Name = "txtHashKey";
            this.txtHashKey.Size = new System.Drawing.Size(330, 20);
            this.txtHashKey.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtHashKey, "Add your hash string key.");
            // 
            // lblStringHashKey
            // 
            this.lblStringHashKey.AutoSize = true;
            this.lblStringHashKey.Location = new System.Drawing.Point(11, 10);
            this.lblStringHashKey.Name = "lblStringHashKey";
            this.lblStringHashKey.Size = new System.Drawing.Size(83, 13);
            this.lblStringHashKey.TabIndex = 3;
            this.lblStringHashKey.Text = "String Hash Key";
            // 
            // lnkConvertedString
            // 
            this.lnkConvertedString.AutoSize = true;
            this.lnkConvertedString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkConvertedString.Location = new System.Drawing.Point(3, 0);
            this.lnkConvertedString.Name = "lnkConvertedString";
            this.lnkConvertedString.Size = new System.Drawing.Size(86, 13);
            this.lnkConvertedString.TabIndex = 5;
            this.lnkConvertedString.TabStop = true;
            this.lnkConvertedString.Text = "Converted String";
            this.toolTip.SetToolTip(this.lnkConvertedString, "Click to copy text in clipboard.");
            this.lnkConvertedString.Visible = false;
            this.lnkConvertedString.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkConvertedString.Click += new System.EventHandler(this.lnkConvertedString_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Information";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(369, 166);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.toolTip.SetToolTip(this.btnEncrypt, "Click to get the Encrypted string.");
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(288, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.toolTip.SetToolTip(this.btnReset, "Click to get the Decrypted string.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flpEncrypt
            // 
            this.flpEncrypt.AutoScroll = true;
            this.flpEncrypt.AutoSize = true;
            this.flpEncrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpEncrypt.Controls.Add(this.lnkConvertedString);
            this.flpEncrypt.Controls.Add(this.lnkError);
            this.flpEncrypt.Location = new System.Drawing.Point(11, 199);
            this.flpEncrypt.Name = "flpEncrypt";
            this.flpEncrypt.Size = new System.Drawing.Size(132, 13);
            this.flpEncrypt.TabIndex = 6;
            // 
            // lnkError
            // 
            this.lnkError.AutoSize = true;
            this.lnkError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkError.LinkColor = System.Drawing.Color.Red;
            this.lnkError.Location = new System.Drawing.Point(95, 0);
            this.lnkError.Name = "lnkError";
            this.lnkError.Size = new System.Drawing.Size(34, 13);
            this.lnkError.TabIndex = 6;
            this.lnkError.TabStop = true;
            this.lnkError.Text = "Error";
            this.lnkError.Visible = false;
            this.lnkError.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(544, 225);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtHashKey);
            this.Controls.Add(this.lblStringHashKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.flpEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Converter";
            this.Load += new System.EventHandler(this.ConverterForm_Load);
            this.flpEncrypt.ResumeLayout(false);
            this.flpEncrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtHashKey;
        private System.Windows.Forms.Label lblStringHashKey;
        private System.Windows.Forms.LinkLabel lnkConvertedString;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flpEncrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.LinkLabel lnkError;
        private System.Windows.Forms.Button btnReset;
    }
}


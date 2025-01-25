namespace MegaDesk
{
    partial class MainMenu
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
            this.addNewQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuoteBtn
            // 
            this.addNewQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuoteBtn.Location = new System.Drawing.Point(12, 12);
            this.addNewQuoteBtn.Name = "addNewQuoteBtn";
            this.addNewQuoteBtn.Size = new System.Drawing.Size(146, 44);
            this.addNewQuoteBtn.TabIndex = 0;
            this.addNewQuoteBtn.Text = "&Add New Quote";
            this.addNewQuoteBtn.UseVisualStyleBackColor = true;
            this.addNewQuoteBtn.Click += new System.EventHandler(this.AddNewQuoteBtn_Click);
            // 
            // viewQuotesBtn
            // 
            this.viewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesBtn.Location = new System.Drawing.Point(12, 62);
            this.viewQuotesBtn.Name = "viewQuotesBtn";
            this.viewQuotesBtn.Size = new System.Drawing.Size(146, 44);
            this.viewQuotesBtn.TabIndex = 1;
            this.viewQuotesBtn.Text = "&View Quotes";
            this.viewQuotesBtn.UseVisualStyleBackColor = true;
            this.viewQuotesBtn.Click += new System.EventHandler(this.DisplayQuoteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(12, 162);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(146, 44);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesBtn.Location = new System.Drawing.Point(12, 112);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(146, 44);
            this.searchQuotesBtn.TabIndex = 2;
            this.searchQuotesBtn.Text = "&Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 307);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.viewQuotesBtn);
            this.Controls.Add(this.addNewQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "MegaDesk - Nathaniel Dunham";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteBtn;
        private System.Windows.Forms.Button viewQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
    }
}


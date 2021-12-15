
namespace _01_Uygulama
{
    partial class Form3
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
            this.lvAdres = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbKisiler = new System.Windows.Forms.ListBox();
            this.rbIlce = new System.Windows.Forms.RadioButton();
            this.rbSehir = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lvAdres
            // 
            this.lvAdres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAdres.FullRowSelect = true;
            this.lvAdres.GridLines = true;
            this.lvAdres.HideSelection = false;
            this.lvAdres.Location = new System.Drawing.Point(297, 64);
            this.lvAdres.Margin = new System.Windows.Forms.Padding(4);
            this.lvAdres.Name = "lvAdres";
            this.lvAdres.Size = new System.Drawing.Size(721, 434);
            this.lvAdres.TabIndex = 27;
            this.lvAdres.UseCompatibleStateImageBehavior = false;
            this.lvAdres.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sehir";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlçe";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Detay";
            this.columnHeader3.Width = 296;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(670, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 30);
            this.txtSearch.TabIndex = 26;
            // 
            // lbKisiler
            // 
            this.lbKisiler.FormattingEnabled = true;
            this.lbKisiler.ItemHeight = 25;
            this.lbKisiler.Location = new System.Drawing.Point(13, 13);
            this.lbKisiler.Margin = new System.Windows.Forms.Padding(4);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(275, 479);
            this.lbKisiler.TabIndex = 25;
            // 
            // rbIlce
            // 
            this.rbIlce.AutoSize = true;
            this.rbIlce.Location = new System.Drawing.Point(461, 17);
            this.rbIlce.Margin = new System.Windows.Forms.Padding(4);
            this.rbIlce.Name = "rbIlce";
            this.rbIlce.Size = new System.Drawing.Size(99, 29);
            this.rbIlce.TabIndex = 29;
            this.rbIlce.TabStop = true;
            this.rbIlce.Text = "İlçe Ara";
            this.rbIlce.UseVisualStyleBackColor = true;
            // 
            // rbSehir
            // 
            this.rbSehir.AutoSize = true;
            this.rbSehir.Location = new System.Drawing.Point(317, 14);
            this.rbSehir.Margin = new System.Windows.Forms.Padding(4);
            this.rbSehir.Name = "rbSehir";
            this.rbSehir.Size = new System.Drawing.Size(115, 29);
            this.rbSehir.TabIndex = 28;
            this.rbSehir.TabStop = true;
            this.rbSehir.Text = "Sehir Ara";
            this.rbSehir.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 509);
            this.Controls.Add(this.lvAdres);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbKisiler);
            this.Controls.Add(this.rbIlce);
            this.Controls.Add(this.rbSehir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAdres;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbKisiler;
        private System.Windows.Forms.RadioButton rbIlce;
        private System.Windows.Forms.RadioButton rbSehir;
    }
}

namespace form1
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
            this.fnlbl = new System.Windows.Forms.Label();
            this.snlbl = new System.Windows.Forms.Label();
            this.dobdtpr = new System.Windows.Forms.Label();
            this.cylbl = new System.Windows.Forms.Label();
            this.fntb = new System.Windows.Forms.TextBox();
            this.sntb = new System.Windows.Forms.TextBox();
            this.dobdtp = new System.Windows.Forms.DateTimePicker();
            this.cycmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Showbtn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Delbtn = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlbl.Location = new System.Drawing.Point(62, 71);
            this.fnlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(61, 13);
            this.fnlbl.TabIndex = 0;
            this.fnlbl.Text = "Firstname";
            // 
            // snlbl
            // 
            this.snlbl.AutoSize = true;
            this.snlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snlbl.Location = new System.Drawing.Point(62, 98);
            this.snlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.snlbl.Name = "snlbl";
            this.snlbl.Size = new System.Drawing.Size(56, 13);
            this.snlbl.TabIndex = 1;
            this.snlbl.Text = "Surname";
            // 
            // dobdtpr
            // 
            this.dobdtpr.AutoSize = true;
            this.dobdtpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobdtpr.Location = new System.Drawing.Point(62, 131);
            this.dobdtpr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobdtpr.Name = "dobdtpr";
            this.dobdtpr.Size = new System.Drawing.Size(33, 13);
            this.dobdtpr.TabIndex = 2;
            this.dobdtpr.Text = "DOB";
            // 
            // cylbl
            // 
            this.cylbl.AutoSize = true;
            this.cylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cylbl.Location = new System.Drawing.Point(62, 165);
            this.cylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cylbl.Name = "cylbl";
            this.cylbl.Size = new System.Drawing.Size(46, 13);
            this.cylbl.TabIndex = 3;
            this.cylbl.Text = "County";
            // 
            // fntb
            // 
            this.fntb.Location = new System.Drawing.Point(152, 71);
            this.fntb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(151, 20);
            this.fntb.TabIndex = 4;
            // 
            // sntb
            // 
            this.sntb.Location = new System.Drawing.Point(152, 98);
            this.sntb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sntb.Name = "sntb";
            this.sntb.Size = new System.Drawing.Size(151, 20);
            this.sntb.TabIndex = 5;
            // 
            // dobdtp
            // 
            this.dobdtp.Location = new System.Drawing.Point(152, 131);
            this.dobdtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dobdtp.Name = "dobdtp";
            this.dobdtp.Size = new System.Drawing.Size(151, 20);
            this.dobdtp.TabIndex = 6;
            // 
            // cycmb
            // 
            this.cycmb.FormattingEnabled = true;
            this.cycmb.Location = new System.Drawing.Point(152, 158);
            this.cycmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cycmb.Name = "cycmb";
            this.cycmb.Size = new System.Drawing.Size(151, 21);
            this.cycmb.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Showbtn
            // 
            this.Showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showbtn.Location = new System.Drawing.Point(116, 206);
            this.Showbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(80, 43);
            this.Showbtn.TabIndex = 9;
            this.Showbtn.Text = "Show DB";
            this.Showbtn.UseVisualStyleBackColor = true;
            this.Showbtn.Click += new System.EventHandler(this.Showbtn_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 288);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(334, 122);
            this.dgv.TabIndex = 10;
            // 
            // Delbtn
            // 
            this.Delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbtn.Location = new System.Drawing.Point(262, 206);
            this.Delbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(93, 43);
            this.Delbtn.TabIndex = 11;
            this.Delbtn.Text = "Delete PK from DB";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(215, 223);
            this.txtnum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(36, 26);
            this.txtnum.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "PK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adding and Deleting from DB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cycmb);
            this.Controls.Add(this.dobdtp);
            this.Controls.Add(this.sntb);
            this.Controls.Add(this.fntb);
            this.Controls.Add(this.cylbl);
            this.Controls.Add(this.dobdtpr);
            this.Controls.Add(this.snlbl);
            this.Controls.Add(this.fnlbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DATABASE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnlbl;
        private System.Windows.Forms.Label snlbl;
        private System.Windows.Forms.Label dobdtpr;
        private System.Windows.Forms.Label cylbl;
        private System.Windows.Forms.TextBox fntb;
        private System.Windows.Forms.TextBox sntb;
        private System.Windows.Forms.DateTimePicker dobdtp;
        private System.Windows.Forms.ComboBox cycmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Showbtn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


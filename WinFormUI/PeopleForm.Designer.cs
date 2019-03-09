namespace WinFormUI
{
    partial class PeopleForm
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
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.labelNameF = new System.Windows.Forms.Label();
            this.labelNameL = new System.Windows.Forms.Label();
            this.listPeople = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textNameF = new System.Windows.Forms.TextBox();
            this.textNameL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(32, 31);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(136, 26);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Add Person";
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(226, 31);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(131, 26);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "List People";
            // 
            // labelNameF
            // 
            this.labelNameF.AutoSize = true;
            this.labelNameF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameF.Location = new System.Drawing.Point(33, 75);
            this.labelNameF.Name = "labelNameF";
            this.labelNameF.Size = new System.Drawing.Size(86, 20);
            this.labelNameF.TabIndex = 2;
            this.labelNameF.Text = "First Name";
            // 
            // labelNameL
            // 
            this.labelNameL.AutoSize = true;
            this.labelNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameL.Location = new System.Drawing.Point(33, 146);
            this.labelNameL.Name = "labelNameL";
            this.labelNameL.Size = new System.Drawing.Size(86, 20);
            this.labelNameL.TabIndex = 3;
            this.labelNameL.Text = "Last Name";
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.Location = new System.Drawing.Point(231, 84);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(207, 238);
            this.listPeople.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(37, 219);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 42);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Person";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(37, 280);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(126, 42);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh List";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textNameF
            // 
            this.textNameF.Location = new System.Drawing.Point(37, 98);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(126, 20);
            this.textNameF.TabIndex = 0;
            // 
            // textNameL
            // 
            this.textNameL.Location = new System.Drawing.Point(37, 169);
            this.textNameL.Name = "textNameL";
            this.textNameL.Size = new System.Drawing.Size(126, 20);
            this.textNameL.TabIndex = 1;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 365);
            this.Controls.Add(this.textNameL);
            this.Controls.Add(this.textNameF);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listPeople);
            this.Controls.Add(this.labelNameL);
            this.Controls.Add(this.labelNameF);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelAdd);
            this.Name = "PeopleForm";
            this.Text = "SQLite Demo Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelNameF;
        private System.Windows.Forms.Label labelNameL;
        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textNameF;
        private System.Windows.Forms.TextBox textNameL;
    }
}


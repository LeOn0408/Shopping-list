
namespace Shopping_list
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.create = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.openList = new System.Windows.Forms.Button();
            this.addPosition = new System.Windows.Forms.RichTextBox();
            this.list = new System.Windows.Forms.RichTextBox();
            this.getNet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(291, 89);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(126, 55);
            this.create.TabIndex = 3;
            this.create.Text = "Создать новый список";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Enabled = false;
            this.log.Location = new System.Drawing.Point(13, 435);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(404, 25);
            this.log.TabIndex = 4;
            this.log.Text = "";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(291, 398);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 31);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить товар";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // openList
            // 
            this.openList.Location = new System.Drawing.Point(291, 28);
            this.openList.Name = "openList";
            this.openList.Size = new System.Drawing.Size(126, 55);
            this.openList.TabIndex = 6;
            this.openList.Text = "Список покупок";
            this.openList.UseVisualStyleBackColor = true;
            this.openList.Click += new System.EventHandler(this.openList_Click);
            // 
            // addPosition
            // 
            this.addPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPosition.Location = new System.Drawing.Point(13, 398);
            this.addPosition.Name = "addPosition";
            this.addPosition.Size = new System.Drawing.Size(272, 31);
            this.addPosition.TabIndex = 8;
            this.addPosition.Text = "";
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(13, 28);
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.list.Size = new System.Drawing.Size(272, 400);
            this.list.TabIndex = 7;
            this.list.Text = "";
            this.list.TextChanged += new System.EventHandler(this.list_TextChanged);
            // 
            // getNet
            // 
            this.getNet.Location = new System.Drawing.Point(291, 151);
            this.getNet.Name = "getNet";
            this.getNet.Size = new System.Drawing.Size(126, 55);
            this.getNet.TabIndex = 9;
            this.getNet.Text = "Получить из сети";
            this.getNet.UseVisualStyleBackColor = true;
            this.getNet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 461);
            this.Controls.Add(this.getNet);
            this.Controls.Add(this.addPosition);
            this.Controls.Add(this.list);
            this.Controls.Add(this.openList);
            this.Controls.Add(this.add);
            this.Controls.Add(this.log);
            this.Controls.Add(this.create);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(440, 500);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(440, 500);
            this.Name = "Home";
            this.Text = "Shopping list";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button openList;
        public System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.RichTextBox addPosition;
        public System.Windows.Forms.RichTextBox list;
        private System.Windows.Forms.Button getNet;
    }
}


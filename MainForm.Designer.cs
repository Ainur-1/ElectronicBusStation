
namespace ElectronicBusStation
{
    partial class MainForm
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
            this.RouteData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyButton = new System.Windows.Forms.Button();
            this.RouteNum = new System.Windows.Forms.Label();
            this.RoutNums = new System.Windows.Forms.ComboBox();
            this.Num = new System.Windows.Forms.Label();
            this.numTic = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RouteData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTic)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteData
            // 
            this.RouteData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RouteData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RouteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteData.Location = new System.Drawing.Point(48, 44);
            this.RouteData.Name = "RouteData";
            this.RouteData.RowHeadersWidth = 51;
            this.RouteData.RowTemplate.Height = 24;
            this.RouteData.Size = new System.Drawing.Size(676, 162);
            this.RouteData.TabIndex = 0;
            this.RouteData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignOutItem});
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.профильToolStripMenuItem.Text = "Профиль";
            // 
            // SignOutItem
            // 
            this.SignOutItem.Name = "SignOutItem";
            this.SignOutItem.Size = new System.Drawing.Size(224, 26);
            this.SignOutItem.Text = "Выйти";
            this.SignOutItem.Click += new System.EventHandler(this.SignOutItem_Click);
            // 
            // buyButton
            // 
            this.buyButton.AutoSize = true;
            this.buyButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.ForeColor = System.Drawing.Color.Red;
            this.buyButton.Location = new System.Drawing.Point(519, 272);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(109, 39);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // RouteNum
            // 
            this.RouteNum.AutoSize = true;
            this.RouteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteNum.Location = new System.Drawing.Point(69, 279);
            this.RouteNum.Name = "RouteNum";
            this.RouteNum.Size = new System.Drawing.Size(99, 29);
            this.RouteNum.TabIndex = 3;
            this.RouteNum.Text = "Рейс №";
            this.RouteNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoutNums
            // 
            this.RoutNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoutNums.FormattingEnabled = true;
            this.RoutNums.ItemHeight = 25;
            this.RoutNums.Location = new System.Drawing.Point(191, 277);
            this.RoutNums.Name = "RoutNums";
            this.RoutNums.Size = new System.Drawing.Size(70, 33);
            this.RoutNums.TabIndex = 5;
            this.RoutNums.SelectedValueChanged += new System.EventHandler(this.RoutNums_SelectedValueChanged);
            this.RoutNums.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num.Location = new System.Drawing.Point(284, 279);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(64, 29);
            this.Num.TabIndex = 6;
            this.Num.Text = "К-во";
            this.Num.Click += new System.EventHandler(this.label2_Click);
            // 
            // numTic
            // 
            this.numTic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTic.Location = new System.Drawing.Point(371, 278);
            this.numTic.Name = "numTic";
            this.numTic.Size = new System.Drawing.Size(70, 30);
            this.numTic.TabIndex = 8;
            this.numTic.ValueChanged += new System.EventHandler(this.numTic_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.numTic);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.RoutNums);
            this.Controls.Add(this.RouteNum);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.RouteData);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Покупка билета";
            ((System.ComponentModel.ISupportInitialize)(this.RouteData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RouteData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignOutItem;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label RouteNum;
        private System.Windows.Forms.ComboBox RoutNums;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.NumericUpDown numTic;
    }
}

namespace ESLAM
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
            this.components = new System.ComponentModel.Container();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Single = new System.Windows.Forms.ToolStripMenuItem();
            this.SlideShow = new System.Windows.Forms.ToolStripMenuItem();
            this.Multi = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(867, 33);
            this.lstBox.Margin = new System.Windows.Forms.Padding(4);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(405, 660);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn.Image = global::ESLAM.Properties.Resources.assassin_with_two_swords_esport_gaming_1258_29051;
            this.btn.Location = new System.Drawing.Point(668, 647);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(163, 47);
            this.btn.TabIndex = 2;
            this.btn.Text = "Browse";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(198, 662);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 0;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.Location = new System.Drawing.Point(31, 33);
            this.pnl.Margin = new System.Windows.Forms.Padding(4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(800, 581);
            this.pnl.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Single,
            this.SlideShow,
            this.Multi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 76);
            // 
            // Single
            // 
            this.Single.CheckOnClick = true;
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(198, 24);
            this.Single.Text = "Single Mode";
            this.Single.Click += new System.EventHandler(this.Single_Click);
            // 
            // SlideShow
            // 
            this.SlideShow.CheckOnClick = true;
            this.SlideShow.Name = "SlideShow";
            this.SlideShow.Size = new System.Drawing.Size(198, 24);
            this.SlideShow.Text = "Slide Show MODE";
            this.SlideShow.Click += new System.EventHandler(this.SlideShow_Click);
            // 
            // Multi
            // 
            this.Multi.CheckOnClick = true;
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(198, 24);
            this.Multi.Text = "Multi MODE";
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 709);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Single;
        private System.Windows.Forms.ToolStripMenuItem SlideShow;
        private System.Windows.Forms.ToolStripMenuItem Multi;
    }
}


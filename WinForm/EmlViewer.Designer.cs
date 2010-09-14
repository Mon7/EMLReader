namespace EmlReader.WinForm
{
    partial class EmlViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmlViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.ccBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bccBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.attachmentsGroup = new System.Windows.Forms.GroupBox();
            this.attachmentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachmentsGroup.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(48, 31);
            this.fromBox.Name = "fromBox";
            this.fromBox.ReadOnly = true;
            this.fromBox.Size = new System.Drawing.Size(262, 21);
            this.fromBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(48, 57);
            this.toBox.Name = "toBox";
            this.toBox.ReadOnly = true;
            this.toBox.Size = new System.Drawing.Size(262, 21);
            this.toBox.TabIndex = 1;
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(48, 83);
            this.ccBox.Name = "ccBox";
            this.ccBox.ReadOnly = true;
            this.ccBox.Size = new System.Drawing.Size(262, 21);
            this.ccBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CC:";
            // 
            // bccBox
            // 
            this.bccBox.Location = new System.Drawing.Point(48, 109);
            this.bccBox.Name = "bccBox";
            this.bccBox.ReadOnly = true;
            this.bccBox.Size = new System.Drawing.Size(262, 21);
            this.bccBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BCC:";
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(48, 136);
            this.bodyBox.Multiline = true;
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.ReadOnly = true;
            this.bodyBox.Size = new System.Drawing.Size(513, 214);
            this.bodyBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Body:";
            // 
            // attachmentsGroup
            // 
            this.attachmentsGroup.Controls.Add(this.attachmentsPanel);
            this.attachmentsGroup.Location = new System.Drawing.Point(11, 365);
            this.attachmentsGroup.Name = "attachmentsGroup";
            this.attachmentsGroup.Padding = new System.Windows.Forms.Padding(5);
            this.attachmentsGroup.Size = new System.Drawing.Size(550, 143);
            this.attachmentsGroup.TabIndex = 4;
            this.attachmentsGroup.TabStop = false;
            this.attachmentsGroup.Text = "Attachments";
            // 
            // attachmentsPanel
            // 
            this.attachmentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachmentsPanel.Location = new System.Drawing.Point(5, 19);
            this.attachmentsPanel.Name = "attachmentsPanel";
            this.attachmentsPanel.Size = new System.Drawing.Size(540, 119);
            this.attachmentsPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(579, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(40, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "EML Files|*.eml|MHT Files|*.mht|All files|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogFileOk);
            // 
            // EmlViewer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 533);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.attachmentsGroup);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bccBox);
            this.Controls.Add(this.ccBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmlViewer";
            this.Text = "EML Viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EmlViewerDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(EmlViewerDragEnter);
            this.attachmentsGroup.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox ccBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bccBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox attachmentsGroup;
        private System.Windows.Forms.FlowLayoutPanel attachmentsPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


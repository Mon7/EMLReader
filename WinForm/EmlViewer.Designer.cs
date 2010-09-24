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
            this.label1 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.ccBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bccBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.attachmentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(81, 3);
            this.fromBox.Name = "fromBox";
            this.fromBox.ReadOnly = true;
            this.fromBox.Size = new System.Drawing.Size(300, 21);
            this.fromBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(81, 30);
            this.toBox.Name = "toBox";
            this.toBox.ReadOnly = true;
            this.toBox.Size = new System.Drawing.Size(300, 21);
            this.toBox.TabIndex = 1;
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(81, 57);
            this.ccBox.Name = "ccBox";
            this.ccBox.ReadOnly = true;
            this.ccBox.Size = new System.Drawing.Size(300, 21);
            this.ccBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CC:";
            // 
            // bccBox
            // 
            this.bccBox.Location = new System.Drawing.Point(81, 84);
            this.bccBox.Name = "bccBox";
            this.bccBox.ReadOnly = true;
            this.bccBox.Size = new System.Drawing.Size(300, 21);
            this.bccBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BCC:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Body:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
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
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(81, 111);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.ReadOnly = true;
            this.subjectBox.Size = new System.Drawing.Size(300, 21);
            this.subjectBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subject:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.attachmentsPanel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.subjectBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fromBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bccBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.toBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ccBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bodyBox, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 417);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Attachments:";
            // 
            // attachmentsPanel
            // 
            this.attachmentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsPanel.AutoSize = true;
            this.attachmentsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.attachmentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attachmentsPanel.Location = new System.Drawing.Point(81, 138);
            this.attachmentsPanel.MinimumSize = new System.Drawing.Size(0, 40);
            this.attachmentsPanel.Name = "attachmentsPanel";
            this.attachmentsPanel.Size = new System.Drawing.Size(380, 40);
            this.attachmentsPanel.TabIndex = 4;
            // 
            // bodyBox
            // 
            this.bodyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyBox.HideSelection = false;
            this.bodyBox.Location = new System.Drawing.Point(81, 184);
            this.bodyBox.Multiline = true;
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.ReadOnly = true;
            this.bodyBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bodyBox.Size = new System.Drawing.Size(380, 230);
            this.bodyBox.TabIndex = 5;
            this.bodyBox.WordWrap = false;
            // 
            // EmlViewer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "EmlViewer";
            this.Text = "EML Viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EmlViewerDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.EmlViewerDragEnter);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel attachmentsPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bodyBox;
    }
}


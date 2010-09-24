using System.IO;
using System.Linq;
using System.Windows.Forms;
using ADODB;
using CDO;
using System.Diagnostics;
using Stream = ADODB.Stream;
using System;

namespace EmlReader.WinForm
{
    public partial class EmlViewer : Form
    {
        public EmlViewer()
        {
            InitializeComponent();
        }

        public void OpenEml(string filepath)
        {
            try
            {
                var stream = new StreamClass();
                stream.Open();
                stream.LoadFromFile(filepath);
                stream.Flush();

                var mail = new MessageClass();
                mail.DataSource.OpenObject(stream, "_Stream");
                mail.DataSource.Save();

                fromBox.Text = mail.From;
                toBox.Text = mail.To;
                ccBox.Text = mail.CC;
                bccBox.Text = mail.BCC;
                subjectBox.Text = mail.Subject;
                bodyBox.Text = mail.TextBody;

                attachmentsPanel.Controls.Clear();
                foreach (IBodyPart attachment in mail.Attachments)
                {
                    var linkLabel = new LinkLabel
                                        {
                                            Text = attachment.FileName,
                                            AutoSize = true,
                                        };
                    linkLabel.Links.Add(0, linkLabel.Text.Length, attachment.GetDecodedContentStream());
                    linkLabel.LinkClicked += LinkLabelLinkClicked;
                    linkLabel.Disposed += LinkLabelDisposed;
                    attachmentsPanel.Controls.Add(linkLabel);
                }
                stream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "An error occured while opening the file", "Email could not be opened",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void LinkLabelDisposed(object sender, EventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            if (linkLabel == null) return;
            foreach (LinkLabel.Link link in linkLabel.Links)
                ((Stream)link.LinkData).Close();
        }

        static void LinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            if (linkLabel == null) return;

            var fileName = linkLabel.Text;
            linkLabel.LinkVisited = true;

            var stream = e.Link.LinkData as Stream;
            if (stream == null) return;

            var tempFile = Path.Combine(Path.GetTempPath(), fileName);
            stream.SaveToFile(tempFile, SaveOptionsEnum.adSaveCreateOverWrite);
            Process.Start(tempFile);
        }

        private void EmlViewerDragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenEml(files.First());
        }

        private void EmlViewerDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void OpenButtonClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        private void OpenFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var dialog = sender as FileDialog;
            if (dialog == null) return;
            OpenEml(dialog.FileName);
        }
    }
}

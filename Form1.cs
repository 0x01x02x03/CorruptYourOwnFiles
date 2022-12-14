using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Corrupt_Your_Own_Files
{
    public partial class fMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="fMain"/> class.
        /// </summary>
        public fMain()
        {
            InitializeComponent();
            UpdateTextPosition();
        }
        /// <summary>
        /// Handles the Click event of the bFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oD = new OpenFileDialog
            {
                Title = "Select the file you want to corrupt",
                InitialDirectory = @"C:\",
                DefaultExt = "*.*",
                Filter = "All files (*.*)|*.*"
            };
            oD.ShowDialog();
            if (!oD.CheckFileExists == true || !oD.CheckPathExists == true)
            {
                MessageBox.Show("Error none existant file or path detected");
            }
            else
            {
                tFile.Text = oD.FileName.ToString();

            }
        }
        /// <summary>
        /// Updates the text position.
        /// </summary>
/        private void UpdateTextPosition()
        {
            Graphics g = CreateGraphics();
            double startingPoint = (Width / 2) - (g.MeasureString(Text.Trim(), Font).Width / 2);
            double widthOfASpace = g.MeasureString(" ", Font).Width;
            string tmp = " ";
            double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            Text = tmp + Text.Trim();
        }

        /// <summary>Handles the Click event of the bCorrrupt control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void bCorrrupt_Click(object sender, EventArgs e)
        {
            pBar.Value = 0;
            pBar.Minimum = 0;
            pBar.Maximum = 9;
            pBar.Step = 1;

            if (tFile.Text != "")
            {

                using (BinaryWriter writer = new BinaryWriter(File.Open(tFile.Text, FileMode.Open, FileAccess.ReadWrite)))
                {
                    for (int j = 1; j < 10; j++)
                    {
                        int offset = 1;
                        byte[] corruptedData = new byte[] { 0x00, 0x68, 0x69, 0x89, 0x99 };
                        writer.Seek(offset, SeekOrigin.Begin);
                        writer.Write(corruptedData);
                        pBar.PerformStep();
                    }

                }

                MessageBox.Show("Process completed!");
            }
        }

        /// <summary>Handles the Click event of the bInfo control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void bInfo_Click(object sender, EventArgs e)
        {
            fAbout myNewForm = new fAbout();

            myNewForm.Show();
        }
    }
}

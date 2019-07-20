using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPARReaderV3.View
{
    public partial class openScreen : Form
    {
        private bool isMouseDown = false;
        private Point lastLocation;
        loadingScreen pleaseWait;

        public openScreen()
        {
            InitializeComponent();
            pleaseWait = new loadingScreen();
            loadingLabel.Visible = false;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFileOpener = new OpenFileDialog();
            myFileOpener.InitialDirectory = @"C:\";
            myFileOpener.CheckFileExists = true;
            myFileOpener.CheckPathExists = true;
            myFileOpener.Title = "Browse For A g02 File";
            myFileOpener.Filter = "g02 files (*.g02)|*.g02";
            myFileOpener.RestoreDirectory = true;

            if (myFileOpener.ShowDialog() == DialogResult.OK)
            {
                LoadMain(myFileOpener);
                
                //mainWindow stationWindow = new mainWindow(myFileOpener.FileName.ToString(), myFileOpener.SafeFileName);
                //stationWindow.Show();
                
            }
        }

        private async void LoadMain(OpenFileDialog fd)
        {
            //pleaseWait.Show();
            loadingLabel.Visible = true; openFileButton.Visible = false;
            mainWindow stationWindow = await Task.Run(() => new mainWindow(fd.FileName.ToString(), fd.SafeFileName));
            stationWindow.Show();
            loadingLabel.Visible = false; openFileButton.Visible = true;
            //pleaseWait.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}

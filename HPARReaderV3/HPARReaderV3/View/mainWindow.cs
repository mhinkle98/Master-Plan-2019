using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPARReaderV3
{
    public partial class mainWindow : Form
    {
        private bool isMouseDown = false;
        private Point lastLocation;

        HPARReaderV3.Model.G02 G02File;
        HPARReaderV3.Model.Station curstation = null;
        string g02Name;

        public mainWindow(string filepath, string filename)
        {
            InitializeComponent();
            g02Name = filename;
            
            G02File = new Model.G02(filepath);
            PopulateStations(G02File);
            crossSectionPanel.Paint += new PaintEventHandler(crossSectionPanel_Paint);
        }

        private void PopulateStations(HPARReaderV3.Model.G02 file)
        {
            stationSelector.Items.Clear();
            stationLabel.Text = g02Name;
            foreach (HPARReaderV3.Model.Station curstation in file.Stations)
            {
                stationSelector.Items.Add(curstation.stationName.ToString());
            }
        }

        private void ShowDataValues(Model.Station selectedStation)
        {
            wetAreaNumber.Text = selectedStation.wetArea.ToString();
            wetPerimeterNumber.Text = selectedStation.wetPerimeter.ToString();
            rValueNumber.Text = selectedStation.R.ToString();
            conveyanceNumber.Text = selectedStation.Conveyance.ToString();
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            G02File = null;
            curstation = null;
            
            this.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void stationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            heightBox.Items.Clear();
            curstation = null;
            string selectedStation = stationSelector.SelectedItem.ToString();
            foreach (Model.Station station in G02File.Stations)
            {
                if (selectedStation == station.stationName.ToString())
                {
                    curstation = station;
                }
            }
            wetAreaNumber.Text = curstation.wetArea.ToString();
            wetPerimeterNumber.Text = curstation.wetPerimeter.ToString();
            rValueNumber.Text = curstation.R.ToString();
            conveyanceNumber.Text = curstation.Conveyance.ToString();
            Int32 min_height = Convert.ToInt32(curstation.ys.Min());
            Int32 max_height = Convert.ToInt32(curstation.ys.Max());
            for (int height = min_height; height < max_height; height++)
            {
                string[] numbers = { height.ToString() };
                heightBox.Items.AddRange(numbers);
            }
            crossSectionPanel.Refresh();

            Model.drawing.drawCrossSection(curstation.xs, curstation.ys, 0, crossSectionPanel);
            
        }

        private void heightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStation = stationSelector.SelectedItem.ToString();
            int selectedheight = Convert.ToInt32(heightBox.SelectedItem);
            foreach (Model.Station station in G02File.Stations)
            {
                if (selectedStation == station.stationName.ToString())
                {
                    curstation = station;
                }
            }
            wetAreaNumber.Text = curstation.wet_areas[heightBox.SelectedIndex].ToString();
            wetPerimeterNumber.Text = curstation.wet_perims[heightBox.SelectedIndex].ToString();
            double conveyance_ar = curstation.wet_areas[heightBox.SelectedIndex] * curstation.wet_areas[heightBox.SelectedIndex] /
                curstation.wet_perims[heightBox.SelectedIndex] * (2 / 3);
            conveyanceNumber.Refresh();
            //conveyanceNumber.Text = conveyance_ar.ToString();
            conveyanceNumber.Text = curstation.conveyances[heightBox.SelectedIndex].ToString();
            rValueNumber.Text = curstation.Rs[heightBox.SelectedIndex].ToString();
            crossSectionPanel.Refresh();
            Model.drawing.drawCrossSection(curstation.xs, curstation.ys, selectedheight, crossSectionPanel);
            
        }

        private void crossSectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

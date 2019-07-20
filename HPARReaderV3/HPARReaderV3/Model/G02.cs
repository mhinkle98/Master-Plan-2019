using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HPARReaderV3.Model
{
    public class G02
    {
        // Each g02 file should have a list of corresponding station objects
        public List<Station> Stations = new List<Station>();
        string[] raw;

        public G02(string path)
        {
            // Opening new file as "raw"
            // Creating station instances for each in file
            raw = File.ReadAllLines(path);

            int i = 0;
            List<string> currentStationLines = new List<string>();
            while (i < raw.Length - 1)
            {
                if (raw[i].Contains("BEGIN DESCRIPTION"))
                {
                    // found a station
                    string cur_station_name = raw[i + 1];


                    while (!raw[i].Contains("#Sta/Elev"))
                    {
                        i += 1;
                    }
                    i += 1;
                    while (!raw[i].Contains("#Mann"))
                    {
                        currentStationLines.Add(raw[i]);

                        i += 1;
                    }


                    Station cur_station = new Station(cur_station_name, currentStationLines);
                    Stations.Add(cur_station);
                    currentStationLines.Clear();
                    // Console.WriteLine("Current Station xs: " + cur_station.xs);
                    //Console.WriteLine("Current Station ys: " + cur_station.ys);
                }
                else
                {
                    i += 1;
                }
            }
        }
    }
}

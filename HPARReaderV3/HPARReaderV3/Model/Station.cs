using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPARReaderV3.Model
{
    public class Station
    {
        public string stationName;
        public double wetArea = 0;
        public double wetPerimeter = 0;
        public double R = 0;
        public double Conveyance;
        public List<double> xs = new List<double>();
        public List<double> ys = new List<double>();

        public List<double> wet_areas = new List<double>();
        public List<double> wet_perims = new List<double>();
        public List<double> Rs = new List<double>();
        public List<double> conveyances = new List<double>();

        public double Area(double x1, double x2, double y1, double y2, double w_height = 0)
        {
            if (w_height > Math.Max(y1, y2))
            {
                double a = 0;
                double x_base = Math.Abs(x2 - x1);
                double tri_height = Math.Abs(y2 - y1);
                double tri_area = 0.5 * x_base * tri_height;
                double rect_height = Math.Abs(w_height - Math.Min(y1, y2));
                double rect_area = x_base * rect_height;
                a = rect_area - tri_area;
                return a;
            }
            else
            {
                if (w_height > Math.Min(y1, y2))
                {
                    double h_water = Math.Abs(w_height - Math.Min(y1, y2));
                    double angle = 0;
                    try
                    {
                        angle = Math.Atan((Math.Abs(y2 - y1) / (Math.Abs(x2 - x1))));
                    }
                    catch (DivideByZeroException e)
                    {
                        angle = Math.PI / 2;
                    }
                    double x_dif = h_water / Math.Tan(angle);
                    double new_base = Math.Abs(Math.Abs(x2 - x1) - x_dif);
                    double a = new_base * h_water * 0.5;
                    return a;
                }
                else
                {
                    return 0;
                }
            }

        }

        public double Perimeter(double x1, double x2, double y1, double y2, double w_height = 0)
        {
            if (w_height > Math.Max(y1, y2))
            {
                double Base = Math.Abs(x2 - x1);
                double height = Math.Abs(y2 - y1);
                double hyp = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(height, 2));
                return hyp;
            }
            else
            {
                if (w_height > Math.Min(y1, y2))
                {
                    double w_height_cur = w_height - Math.Min(y1, y2);
                    double angle = 0;
                    try
                    {
                        angle = Math.Atan((Math.Abs(y2 - y1) / (Math.Abs(x2 - x1))));
                    }
                    catch (DivideByZeroException e)
                    {
                        angle = Math.PI / 2;
                    }
                    double x_dif = w_height_cur / Math.Tan(angle);
                    double new_base = Math.Abs(Math.Abs(x2 - x1) - x_dif);
                    double hyp = Math.Sqrt(Math.Pow(new_base, 2) + Math.Pow(w_height, 2));
                    return hyp;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void Addxy(string line)
        {
            List<double> numlist = new List<double> { };
            int pos = 0;
            string current = "";

            while (pos < line.Length)
            {
                if (line[pos].ToString() != @" " && line[pos].ToString() != @"\t")
                {
                    current += line[pos].ToString();
                    pos += 1;
                }
                else
                {
                    if (current != "")
                    {
                        if (current.Length == 13)
                        {
                            numlist.Add(Convert.ToDouble(current.Substring(0, 5)));
                            numlist.Add(Convert.ToDouble(current.Substring(5, 8)));
                        }
                        if (current.Length == 12)
                        {
                            numlist.Add(Convert.ToDouble(current.Substring(0, 4)));
                            numlist.Add(Convert.ToDouble(current.Substring(4, 8)));
                        }
                        if (current.Length == 11)
                        {
                            numlist.Add(Convert.ToDouble(current.Substring(0, 3)));
                            numlist.Add(Convert.ToDouble(current.Substring(3, 8)));
                        }
                        if (current.Length == 10)
                        {
                            numlist.Add(Convert.ToDouble(current.Substring(0, 2)));
                            numlist.Add(Convert.ToDouble(current.Substring(2, 8)));
                        }
                        if (current.Length < 10)
                        {
                            numlist.Add(Convert.ToDouble(current));
                        }
                    }
                    current = "";
                    pos += 1;
                }
            }
            int lp = 0;
            while (lp < numlist.Count - 1)
            {
                xs.Add(numlist.ElementAt(lp));
                ys.Add(numlist.ElementAt(lp + 1));

                if (xs.Count != ys.Count)
                {
                    System.Console.Out.WriteLine("Lengths don't match!");
                }
                lp += 2;
            }
        }

        public Station(string Name, List<string> lines, int w_height = 0)
        {
            stationName = Name;
            foreach (string line in lines)
            {
                Addxy(line);
            }

            // defining area and perimeter
            Int32 min_height = Convert.ToInt32(ys.Min());
            Int32 max_height = Convert.ToInt32(ys.Max());
            for (int height = min_height; height < max_height; height++)
            {
                wetPerimeter = 0;
                wetArea = 0;
                for (int i = 0; i < xs.Count - 1; i++)
                {
                    wetArea += Area(xs[i], xs[i + 1], ys[i], ys[i + 1], height);
                    wetPerimeter += Perimeter(xs[i], xs[i + 1], ys[i], ys[i + 1], height);
                }

                try
                {
                    R = wetArea / wetPerimeter;
                    //Conveyance = wetArea * R * Convert.ToDouble(2 / 3);
                }
                catch (DivideByZeroException e)
                {
                    R = 1;
                    //Conveyance = wetArea * 2 / 3;
                }
                Conveyance = wetArea * R * Convert.ToDouble(2 / 3);


                wet_areas.Add(wetArea);
                wet_perims.Add(wetPerimeter);
                Rs.Add(R);
                conveyances.Add(Conveyance);
            }
        }
    }
}

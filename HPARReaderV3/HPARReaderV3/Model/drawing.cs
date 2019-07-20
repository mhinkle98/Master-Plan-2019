using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPARReaderV3.Model
{
    public static class drawing
    {

        public static void drawCrossSection(List<double> xs, List<double> ys, double w_height, System.Windows.Forms.Panel panel)
        {
            double maxX = xs.Max(); 
            double maxY = ys.Max();
            double width = maxX - xs.Min();
            double maxheight = maxY - ys.Min();
            double xscale = panel.Width / width;
            double yscale = panel.Height / maxheight;

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tan, 3); 
            
            System.Drawing.SolidBrush waterFill = new System.Drawing.SolidBrush(System.Drawing.Color.AliceBlue);
            System.Drawing.Pen waterFillPen = new System.Drawing.Pen(System.Drawing.Color.AliceBlue);
            System.Drawing.Graphics crossSection = panel.CreateGraphics();
            crossSection.ScaleTransform((float)xscale, (float)yscale);
            System.Drawing.PointF[] crosspoints = new System.Drawing.PointF[xs.Count];

            for (int i = 0; i < xs.Count - 1; i++)
            {
                double y = maxY - ys[i];
                double y2 = maxY - ys[i + 1];
                double x = xs[i];
                double curwidth = xs[i + 1] - xs[i];
                double highpoint = Math.Max(y, y2);

                //crossSection.DrawRectangle(waterFillPen, (float)x, -(float)highpoint, (float)curwidth, -(float)(w_height - highpoint));
                //crosspoints[i] = new System.Drawing.PointF((float)x, (float)highpoint);   
               // crosspoints[i + 1] = new System.Drawing.PointF((float)xs[i + 1], (float)highpoint);

                crossSection.DrawLine(pen, (float)xs[i], (float)y, (float)xs[i + 1], (float)y2);
                if (w_height > highpoint)
                {
                    System.Drawing.RectangleF currec = new System.Drawing.RectangleF();
                    currec.Height = (float)(maxY - (w_height - highpoint));
                    currec.Location = new System.Drawing.PointF((float)x, (float)(maxY - (w_height)));
                    currec.Width = (float)(xs[i + 1] - x);
                    crossSection.FillRectangle(waterFill, currec);
                    //crossSection.FillRectangle(waterFill, (float)x, (float)(panel.Height - ys[i]), (float)curwidth, -(float)(maxheight - (w_height - highpoint)));
                }
                    
            }
            //crossSection.FillClosedCurve(waterFill, points);
            //crossSection.FillPolygon(waterFill, points);

        }

        public static void drawCrossSection2(List<double> xs, List<double> ys, double w_height, System.Windows.Forms.Panel panel)
        {
            double maxX = xs.Max();
            double maxY = ys.Max();
            double width = maxX - xs.Min();
            double maxheight = maxY - ys.Min();
            double xscale = panel.Width / width;
            double yscale = panel.Height / maxheight;

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tan, 3);

            System.Drawing.SolidBrush waterFill = new System.Drawing.SolidBrush(System.Drawing.Color.AliceBlue);
            System.Drawing.Graphics crossSection = panel.CreateGraphics();
            crossSection.ScaleTransform((float)xscale, (float)yscale);
            System.Drawing.PointF[] points = new System.Drawing.PointF[xs.Count];

            for (int i = 0; i < xs.Count - 1; i++)
            {
                double y = maxY - ys[i];
                double y2 = maxY - ys[i + 1];
                double x = xs[i];
                if (x == maxX)
                    points[i] = new System.Drawing.PointF((float)x, (float)maxY);
                else
                    points[i] = new System.Drawing.PointF((float)x, (float)y);
                if (xs[i+1] == maxX)
                    points[i+1] = new System.Drawing.PointF((float)x, (float)maxY);

            }
            crossSection.DrawLines(pen, points);
        }

        public static void drawGraphics(List<double> xs, List<double> ys, double w_height, System.Windows.Forms.Panel panel)
        {
            double maxX = xs.Max();
            double maxY = ys.Max();
            double width = maxX - xs.Min();
            double maxheight = maxY - ys.Min();
            double xscale = panel.Width / width;
            double yscale = panel.Height / maxheight;

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tan, 3);
            System.Drawing.SolidBrush waterFill = new System.Drawing.SolidBrush(System.Drawing.Color.AliceBlue);

            
            System.Drawing.Graphics crossSection = panel.CreateGraphics();
            crossSection.ScaleTransform((float)xscale, (float)yscale);
            System.Drawing.PointF[] points = new System.Drawing.PointF[xs.Count];

            for (int i = 0; i < xs.Count - 1; i++)
            {
                double y = maxY - ys[i];
                double y2 = maxY - ys[i + 1];
                double x = xs[i];
                points[i] = new System.Drawing.PointF((float)x, (float)y);
            }
            byte[] types = { (byte)points[0].X, (byte)System.Drawing.Drawing2D.PathPointType.Line, (byte)System.Drawing.Drawing2D.PathPointType.DashMode };

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath(points, types, System.Drawing.Drawing2D.FillMode.Alternate);
            crossSection.DrawPath(pen, path);

            crossSection.FillPath(waterFill, path);
        }
    }
}

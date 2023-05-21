using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpModelingLab1.Classes
{
    class DistributionGenerator
    {
        private RandomValueGenerator _generator;
        public RandomValueGenerator generator
        {
            get => _generator;
            set => _generator = value;
        }
        public DistributionGenerator(RandomValueGenerator generator)
        {
            _generator = generator;
        }
        
        public void Generate(ListBox box, Chart chart, int count)
        {
            box.Items.Clear();
            chart.Series[0].Points.Clear();
            List<double> xs = new List<double>();
            double x, minX, maxX, deltaX, tmpX;
            for (int i = 0; i < count; i++)
            {
                x = generator.Next();
                box.Items.Add(x);
                xs.Add(x);
            }

            xs.Sort();
            minX = xs.Min();
            maxX = xs.Max();

            deltaX = (maxX - minX) / 10;
            tmpX = minX + deltaX;
            for(int i = 0, tmpCount = 0; i< count; i++)
            {
                x = Convert.ToDouble(box.Items[i]);
                if (x>tmpX)
                {
                    chart.Series[0].Points.Add(tmpCount);
                    tmpX += deltaX;
                    tmpCount = 0;
                }
                tmpCount++;
            }
        }
    }
}

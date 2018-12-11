using System;
using System.Windows.Forms;
using GraphicalInterface.FlyWeightPainter;
using GraphicalInterface.SimpleMapPainter;

namespace GraphicalInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var random = new Random();
            var nonFlyWeightWatch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = 0; i < 100000; i++)
            {
                IMapPainter RockPainter = new SimpleRockPainter(random.Next(100), random.Next(100),
                    random.Next(100), random.Next(100));
                 RockPainter.Draw(e.Graphics);
            }

            for (var i = 0; i < 100000; i++)
            {
                IMapPainter treePainter = new SimpleTreePainter(random.Next(100), random.Next(100),
                    random.Next(100), random.Next(100));
                  treePainter.Draw(e.Graphics);

            }
            nonFlyWeightWatch.Stop();
            richTextBox1.Text += @"Objects created not using Flyweight: " + (SimpleRockPainter.ObjectCounter + SimpleTreePainter.ObjectCounter) + Environment.NewLine;
            richTextBox1.Text += @"Time elapsed not using Flyweight: " + nonFlyWeightWatch.ElapsedMilliseconds + @" ms" + Environment.NewLine;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += Environment.NewLine;
           // ----------------------------------------------------------

           var flyWeightWatch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = 0; i < 100000; i++)
            {
                var housePaint = PaintObjectsFactory.GetPaint("RockPaint");
                housePaint.Draw(e.Graphics, random.Next(100), random.Next(100),
                 random.Next(100), random.Next(100));
            }

            for (var i = 0; i < 100000; i++)
            {
                var treePaint = PaintObjectsFactory.GetPaint("TreePaint");
                treePaint.Draw(e.Graphics, random.Next(100), random.Next(100),
                 random.Next(100), random.Next(100));

            }
            flyWeightWatch.Stop();
            richTextBox1.Text += @"Objects created using Flyweight: " + (RockPainter.ObjectCounter + TreePainter.ObjectCounter) + Environment.NewLine;
            richTextBox1.Text += @"Time elapsed using Flyweight: " + flyWeightWatch.ElapsedMilliseconds + @" ms" + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

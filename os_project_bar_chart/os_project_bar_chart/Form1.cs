using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace os_project_bar_chart
{
    public partial class Form1 : Form
    {
        private int cat ;
        private int dog ;
        private int bird ;
        private int monkey ;
        private int day ;
        private int x;
        private int y;
        private int z;
        private int c;
        private int cahrtmix;
        public Form1()
        {
            InitializeComponent();
        }

  
        private void btnfill_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cat = 1;
            dog = 1;
            bird = 1;
            monkey = 1;
            day = 0;
            cahrtmix = 0;
            
        
        }

        private void mytimer_Tick(object sender, EventArgs e)
        {
        
            Random ran = new Random();
            x = ran.Next(1, 6);
            y = ran.Next(1, 6);
            z = ran.Next(1, 6);
            c = ran.Next(1, 6);


            cat += x;
            dog += y;
            bird += z;
            monkey += c;
            day += 1;
   
            this.chart1.Series["Cat"].Points.AddXY(day, cat);
            this.chart1.Series["Cat"].Points.AddXY(day, cat);
            this.chart1.Series["Dog"].Points.AddXY(day, dog);
            this.chart1.Series["Bird"].Points.AddXY(day, bird);
            this.chart1.Series["Monkey"].Points.AddXY(day, monkey);
            Invalidate();

 
        }

   
    }
}

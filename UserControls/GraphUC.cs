using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.UserControls
{
    public partial class GraphUC : UserControl
    {
        public GraphUC()
        {
            InitializeComponent();
        }

        private void GraphUC_Load(object sender, EventArgs e)
        {
            chart_price.Series[0].Points.AddXY("월요일", 150);
            chart_price.Series[0].Points.AddXY("화요일", 120);
            chart_price.Series[0].Points.AddXY("수요일", 130);
            chart_price.Series[0].Points.AddXY("목요일", 140);
            chart_price.Series[0].Points.AddXY("금요일", 210);
            chart_price.Series[0].Points.AddXY("토요일", 240);
            chart_price.Series[0].Points.AddXY("일요일", 190);

            //chart_price.Series[0].Points[4].Color = Color.DarkRed;

            chart_price.Series[1].Points.AddXY("월요일", 50);
            chart_price.Series[1].Points.AddXY("화요일", 70);
            chart_price.Series[1].Points.AddXY("수요일", 60);
            chart_price.Series[1].Points.AddXY("목요일", 50);
            chart_price.Series[1].Points.AddXY("금요일", 80);
            chart_price.Series[1].Points.AddXY("토요일", 90);
            chart_price.Series[1].Points.AddXY("일요일", 75);
        }
    }
}

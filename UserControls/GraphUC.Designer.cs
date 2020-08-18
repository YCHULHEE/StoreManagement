namespace StoreManagement.UserControls
{
    partial class GraphUC
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_price = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_price)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_price
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_price.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "요일별 총매출(만원)";
            this.chart_price.Legends.Add(legend2);
            this.chart_price.Location = new System.Drawing.Point(3, 3);
            this.chart_price.Name = "chart_price";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "성인요금매출";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "아동요금매출";
            this.chart_price.Series.Add(series3);
            this.chart_price.Series.Add(series4);
            this.chart_price.Size = new System.Drawing.Size(777, 482);
            this.chart_price.TabIndex = 0;
            this.chart_price.Text = "chart1";
            // 
            // GraphUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.chart_price);
            this.Name = "GraphUC";
            this.Size = new System.Drawing.Size(1063, 485);
            this.Load += new System.EventHandler(this.GraphUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_price;
    }
}

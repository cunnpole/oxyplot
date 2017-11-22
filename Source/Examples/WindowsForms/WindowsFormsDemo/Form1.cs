// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WindowsFormsDemo
{
    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            Redraw();
        }

        private void Redraw()
        {
            var goalSeries = new LineSeries
            {
                MarkerType = MarkerType.None,
                Color = OxyColors.Blue,
                LineStyle = LineStyle.Dot,
                BrokenLineThickness = 1,
            };
            goalSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016, 1, 1)), 130));
            goalSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2018, 1, 1)) + 20, 130));

            PlotModel PlotModel = new PlotModel { Title = null, Subtitle = null, };

            PlotModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, IsAxisVisible = true,
                FontSize = 10, MajorStep = 182, StringFormat="MMM yy",
                MajorTickSize = 5,
                MinorTickSize = 2, MinorStep = 182, Maximum = DateTimeAxis.ToDouble(new DateTime(2018, 1, 1))+20, Minimum = DateTimeAxis.ToDouble(new DateTime(2016, 1, 1)) });
            PlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, StringFormat="000", IsAxisVisible = true, FontSize = 10, MajorStep =10, MinorStep=10, Maximum=160, Minimum=100});
            PlotModel.Series.Add(goalSeries);

            var lineSeries = new FiveColorLineSeries
            {// Smooth = true,
                MarkerType = MarkerType.Circle,
                MarkerSize = 2,
                MarkerStroke = OxyColors.Purple,
                MarkerFill = OxyColors.Purple,
                Color = OxyColors.Green,
                StrokeThickness=1,
                LineStyle = LineStyle.Solid,
                MarkerStroke2 = OxyColors.Purple,
                MarkerFill2 = OxyColors.Transparent,
                LabelFormatString = "{1}",
                LabelMargin=2,
                FontSize=10,
                TextColor= OxyColors.Green,
                LimitHi2 = 150,
                LimitHi = 130.000000001,
                LimitLo = 100,
                LimitLo2 = 100,
                SectionBackColorAlpha = 50,
                ShowColouredLines = true,
                ColorLo = OxyColors.Green,
                ColorLo2 = OxyColors.Green,
            };
            int i = 0;
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 130) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 124) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 120) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016, 1, 1).AddDays(18 * i++)), 123) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 105) { ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 124) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 120) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 123) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 123) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 124) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 120) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 123) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 124) { ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 124) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 122) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 126) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 155) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 120) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 128) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016,1,1).AddDays(18*i++)), 131) { MarkerColour = OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2016, 1, 1).AddDays(18 * i++)), 130));
            PlotModel.Series.Add(lineSeries);
           //   PlotModel.PlotMargins = new OxyThickness(25,0,0,15);
            PlotModel.PlotAreaBorderThickness = new OxyThickness(0);
            PlotModel.PlotAreaBorderColor = OxyColors.Transparent;
            PlotModel.Background = OxyColors.White;

            plot1.Model = PlotModel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void cmdRedraw_Click(object sender, EventArgs e)
        {

            Redraw();
        }
    }
}

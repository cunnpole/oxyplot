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
                SectionBackColorAlpha = 20,
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

        private void cmdBloodGlucose_Click(object sender, EventArgs e)
        {


            PlotModel PlotModel = new PlotModel { Title = null, Subtitle = null, };

            var yesterday = DateTime.Today.AddDays(-1);
            PlotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                IsAxisVisible = true,
                FontSize = 10,
                MajorStep = 1/24.0,
                StringFormat = "HH",
                Title="Hours",
                MajorTickSize = 5,
                MinorTickSize = 2,
                MinorStep = 1/24.0,
                Maximum = DateTimeAxis.ToDouble(DateTime.Today),
                Minimum = DateTimeAxis.ToDouble(yesterday)
            });
            PlotModel.Axes.Add(new LinearAxis {
                Position = AxisPosition.Left,
                Title = "mmol/L", StringFormat = "00", IsAxisVisible = true, FontSize = 10, MajorStep = 2, MinorStep = 2, Maximum = 16, Minimum = -1 });

            var rand = new Random();
            var hours = 50;
            int i = 0;
            AddLineSeries(PlotModel, OxyColors.Purple, 2, 15, hours, rand, yesterday, i++, true);
            AddLineSeries(PlotModel, OxyColors.Blue, 2, 15, hours, rand, yesterday, i++);
            AddLineSeries(PlotModel, OxyColors.Pink, 0, 15, hours, rand, yesterday, i++);
            AddLineSeries(PlotModel, OxyColors.Gray, 1, 15, hours, rand, yesterday, i++);
            AddLineSeries(PlotModel, OxyColors.Black, 0, 15, hours, rand, yesterday, i++);
            AddLineSeries(PlotModel, OxyColors.Yellow, 0, 15, hours, rand, yesterday, i++);
            AddLineSeries(PlotModel, OxyColors.Orange, 0, 15, hours, rand, yesterday, i++);
            //   PlotModel.PlotMargins = new OxyThickness(25,0,0,15);
            PlotModel.PlotAreaBorderThickness = new OxyThickness(0);
            PlotModel.PlotAreaBorderColor = OxyColors.Transparent;
            PlotModel.Background = OxyColors.White;
            PlotModel.LegendPlacement = LegendPlacement.Outside;
            PlotModel.LegendPosition = LegendPosition.BottomCenter;
            PlotModel.LegendOrientation = LegendOrientation.Horizontal;
            PlotModel.LegendFontSize = 10;
            PlotModel.LegendBorderThickness = 0;
            PlotModel.LegendPadding = 0; 
           // PlotModel.Le
            plot1.Model = PlotModel;
        }

        public static string ToOccurrenceSuffix(int integer)
        {
            switch (integer % 100)
            {
                case 11:
                case 12:
                case 13:
                    return "th";
            }
            switch (integer % 10)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }

        private static void AddLineSeries(PlotModel PlotModel, OxyColor colour, int start, int end, int count, Random rand, DateTime yesterday, int index, bool first = false)
        {
            var lineSeries = new FiveColorLineSeries
            {// Smooth = true,
                MarkerType = MarkerType.Circle,
                MarkerSize = 2,
                Title= yesterday.Date.AddDays(index).Day + ToOccurrenceSuffix(yesterday.Date.AddDays(index).Day),
                MarkerStroke = colour,
                MarkerFill = colour,
                Color = first? OxyColors.Green: OxyColors.Transparent,
                StrokeThickness = 1,
                LineStyle = LineStyle.Solid,
                MarkerStroke2 = colour,
                MarkerFill2 = OxyColors.Transparent,
                LabelFormatString = "{1}",
                LabelMargin = 2,
                FontSize = 10,
                TextColor = colour,
                LimitHi2 = 7,
                LimitHi = 7,
                LimitLo =4,
                LimitLo2 = 4,
                SectionBackColorAlpha = first?(byte)50:(Byte)0,
                ShowColouredLines = false,
                DefaultLineColor = colour,
                ColorLo = OxyColors.Transparent,
                ColorLo2 = OxyColors.Transparent,
                ColorHi = OxyColors.Transparent,
                ColorHi2 = OxyColors.Transparent,
                

            };
            int last = rand.Next(start, end);
            for (int i = 0; i < count; i++)
            {
                last += rand.Next(-1, 2);
                if (last < start)
                    last = start;
                if (last > end)
                    last = end;
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(yesterday.AddMinutes((30 *i++) + rand.Next(-15, 15))), last) { MarkerColour = rand.Next(3) > 0 ? OxyPlot.Foundation.MarkerColor.Color1 : OxyPlot.Foundation.MarkerColor.Color2, ShowLabel = false });
            }
            PlotModel.Series.Add(lineSeries);
        }
    }
}

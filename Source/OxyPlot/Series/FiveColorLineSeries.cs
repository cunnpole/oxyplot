// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreeColorLineSeries.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Represents a three-color line series.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Series
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a two-color line series.
    /// </summary>
    public class FiveColorLineSeries : MultiColorMarkerLineSeries
    {
        /// <summary>
        /// The default low color.
        /// </summary>
        private OxyColor defaultColorLo;

        /// <summary>
        /// The default low color.
        /// </summary>
        private OxyColor defaultColorLo2;

        /// <summary>
        /// The default hi color.
        /// </summary>
        private OxyColor defaultColorHi;

        /// <summary>
        /// The default hi color.
        /// </summary>
        private OxyColor defaultColorHi2;

        /// <summary>
        /// Initializes a new instance of the <see cref = "ThreeColorLineSeries" /> class.
        /// </summary>
        public FiveColorLineSeries()
        {
            this.LimitLo = -5.0;
            this.ColorLo = OxyColors.Orange;
            this.LineStyleLo = LineStyle.Solid;
            this.LimitLo2 = -5.0;
            this.ColorLo2 = OxyColors.Red;
            this.LineStyleLo2 = LineStyle.Solid;
            this.LimitHi = 5.0;
            this.ColorHi = OxyColors.Orange;
            this.LineStyleHi = LineStyle.Solid;
            this.LimitHi2 = 5.0;
            this.ColorHi2 = OxyColors.Red;
            this.LineStyleHi2 = LineStyle.Solid;
            this.ShowColouredLines = true;
            this.DefaultLineColor = OxyColors.Black;
            this.SectionBackColorAlpha = 255;
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor ColorLo { get; set; }
        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor ColorLo2 { get; set; }

        /// <summary>
        /// Gets or sets the color for the part of the line that is above the limit.
        /// </summary>
        public OxyColor ColorHi { get; set; }

        /// <summary>
        /// Gets or sets the color for the part of the line that is above the limit.
        /// </summary>
        public OxyColor ColorHi2 { get; set; }

        /// <summary>
        /// Gets the actual hi color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualColorLo
        {
            get { return this.ColorLo.GetActualColor(this.defaultColorLo); }
        }

        /// <summary>
        /// Gets the actual hi color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualColorLo2
        {
            get { return this.ColorLo2.GetActualColor(this.defaultColorLo2); }
        }

        /// <summary>
        /// Gets the actual low color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualColorHi
        {
            get { return this.ColorHi.GetActualColor(this.defaultColorHi); }
        }

        /// <summary>
        /// Gets the actual low color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualColorHi2
        {
            get { return this.ColorHi2.GetActualColor(this.defaultColorHi2); }
        }

        /// <summary>
        /// Gets or sets the high limit.
        /// </summary>
        /// <remarks>The parts of the line that is below this limit will be rendered with ColorHi.
        /// The parts of the line that is above the limit will be rendered with Color.</remarks>
        public double LimitHi { get; set; }

        /// <summary>
        /// Gets or sets the high limit.
        /// </summary>
        /// <remarks>The parts of the line that is below this limit will be rendered with ColorHi.
        /// The parts of the line that is above the limit will be rendered with Color.</remarks>
        public double LimitHi2 { get; set; }

        /// <summary>
        /// Gets or sets the low limit.
        /// </summary>
        /// <remarks>The parts of the line that is below this limit will be rendered with ColorLo.
        /// The parts of the line that is above the limit will be rendered with Color.</remarks>
        public double LimitLo { get; set; }

        /// <summary>
        /// Gets or sets the low limit.
        /// </summary>
        /// <remarks>The parts of the line that is below this limit will be rendered with ColorLo.
        /// The parts of the line that is above the limit will be rendered with Color.</remarks>
        public double LimitLo2 { get; set; }

        /// <summary>
        /// Gets or sets the dash array for the rendered line that is above the limit (overrides <see cref="LineStyle" />).
        /// </summary>
        /// <value>The dash array.</value>
        /// <remarks>If this is not <c>null</c> it overrides the <see cref="LineStyle" /> property.</remarks>
        public double[] DashesHi { get; set; }

        /// <summary>
        /// Gets or sets the dash array for the rendered line that is above the limit (overrides <see cref="LineStyle" />).
        /// </summary>
        /// <value>The dash array.</value>
        /// <remarks>If this is not <c>null</c> it overrides the <see cref="LineStyle" /> property.</remarks>
        public double[] DashesHi2 { get; set; }

        /// <summary>
        /// Gets or sets the dash array for the rendered line that is below the limit (overrides <see cref="LineStyle" />).
        /// </summary>
        /// <value>The dash array.</value>
        /// <remarks>If this is not <c>null</c> it overrides the <see cref="LineStyle" /> property.</remarks>
        public double[] DashesLo { get; set; }
        /// <summary>
        /// Gets or sets the dash array for the rendered line that is below the limit (overrides <see cref="LineStyle" />).
        /// </summary>
        /// <value>The dash array.</value>
        /// <remarks>If this is not <c>null</c> it overrides the <see cref="LineStyle" /> property.</remarks>
        public double[] DashesLo2 { get; set; }

        /// <summary>
        /// Gets or sets the line style for the part of the line that is above the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle LineStyleHi { get; set; }

        /// <summary>
        /// Gets or sets the line style for the part of the line that is above the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle LineStyleHi2 { get; set; }

        /// <summary>
        /// Gets or sets the line style for the part of the line that is below the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle LineStyleLo { get; set; }

        /// <summary>
        /// Gets or sets the line style for the part of the line that is below the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle LineStyleLo2 { get; set; }

        /// <summary>
        /// Gets the actual line style for the part of the line that is above the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle ActualLineStyleHi
        {
            get
            {
                return this.LineStyleHi != LineStyle.Automatic ? this.LineStyleHi : LineStyle.Solid;
            }
        }

        /// <summary>
        /// Gets the actual line style for the part of the line that is above the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle ActualLineStyleHi2
        {
            get
            {
                return this.LineStyleHi2 != LineStyle.Automatic ? this.LineStyleHi2 : LineStyle.Solid;
            }
        }

        /// <summary>
        /// Gets the actual line style for the part of the line that is below the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle ActualLineStyleLo
        {
            get
            {
                return this.LineStyleLo != LineStyle.Automatic ? this.LineStyleLo : LineStyle.Solid;
            }
        }
        /// <summary>
        /// Gets the actual line style for the part of the line that is below the limit.
        /// </summary>
        /// <value>The line style.</value>
        public LineStyle ActualLineStyleLo2
        {
            get
            {
                return this.LineStyleLo2 != LineStyle.Automatic ? this.LineStyleLo2 : LineStyle.Solid;
            }
        }

        /// <summary>
        /// Gets the actual dash array for the line that is above the limit.
        /// </summary>
        protected double[] ActualDashArrayHi
        {
            get
            {
                return this.DashesHi ?? this.ActualLineStyleHi.GetDashArray();
            }
        }

        /// <summary>
        /// Gets the actual dash array for the line that is above the limit.
        /// </summary>
        protected double[] ActualDashArrayHi2
        {
            get
            {
                return this.DashesHi2 ?? this.ActualLineStyleHi2.GetDashArray();
            }
        }

        /// <summary>
        /// Gets the actual dash array for the line that is below the limit.
        /// </summary>
        protected double[] ActualDashArrayLo
        {
            get
            {
                return this.DashesLo ?? this.ActualLineStyleLo.GetDashArray();
            }
        }

        /// <summary>
        /// Gets the actual dash array for the line that is below the limit.
        /// </summary>
        protected double[] ActualDashArrayLo2
        {
            get
            {
                return this.DashesLo2 ?? this.ActualLineStyleLo2.GetDashArray();
            }
        }

        public byte SectionBackColorAlpha { get; set; }
        public bool ShowColouredLines { get; set; }

        public OxyColor DefaultLineColor{get; set;}

        public string MiddleText { get; set; }
        public string LoText { get; set; }
        public string Lo2Text { get; set; }
        public string HiText { get; set; }
        public string Hi2Text { get; set; }

        /// <summary>
        /// Sets the default values.
        /// </summary>
        protected internal override void SetDefaultValues()
        {
            base.SetDefaultValues();

            if (this.ColorLo.IsAutomatic())
            {
                this.defaultColorLo = this.PlotModel.GetDefaultColor();
            }

            if (this.LineStyleLo == LineStyle.Automatic)
            {
                this.LineStyleLo = this.PlotModel.GetDefaultLineStyle();
            }

            if (this.ColorHi.IsAutomatic())
            {
                this.defaultColorHi = this.PlotModel.GetDefaultColor();
            }

            if (this.LineStyleHi == LineStyle.Automatic)
            {
                this.LineStyleHi = this.PlotModel.GetDefaultLineStyle();
            }

            if (this.ColorLo2.IsAutomatic())
            {
                this.defaultColorLo2 = this.PlotModel.GetDefaultColor();
            }

            if (this.LineStyleLo2 == LineStyle.Automatic)
            {
                this.LineStyleLo2 = this.PlotModel.GetDefaultLineStyle();
            }

            if (this.ColorHi2.IsAutomatic())
            {
                this.defaultColorHi2 = this.PlotModel.GetDefaultColor();
            }

            if (this.LineStyleHi2 == LineStyle.Automatic)
            {
                this.LineStyleHi2 = this.PlotModel.GetDefaultLineStyle();
            }

        }

        /// <summary>
        /// Renders the smoothed line.
        /// </summary>
        /// <param name="rc">The render context.</param>
        /// <param name="clippingRect">The clipping rectangle.</param>
        /// <param name="pointsToRender">The points.</param>
        protected override void RenderLine(IRenderContext rc, OxyRect clippingRect, IList<ScreenPoint> pointsToRender)
        {
            var bottom = clippingRect.Bottom;
            var top = clippingRect.Top;

            // todo: this does not work when y axis is reversed
            var yLo = this.YAxis.Transform(this.LimitLo);
            var yHi = this.YAxis.Transform(this.LimitHi);
            var yLo2 = this.YAxis.Transform(this.LimitLo2);
            var yHi2 = this.YAxis.Transform(this.LimitHi2);

            if (yLo < clippingRect.Top)
            {
                yLo = clippingRect.Top;
            }

            if (yLo > clippingRect.Bottom)
            {
                yLo = clippingRect.Bottom;
            }

            if (yHi < clippingRect.Top)
            {
                yHi = clippingRect.Top;
            }

            if (yHi > clippingRect.Bottom)
            {
                yHi = clippingRect.Bottom;
            }

            if (yLo2 < clippingRect.Top)
            {
                yLo2 = clippingRect.Top;
            }

            if (yLo2 > clippingRect.Bottom)
            {
                yLo2 = clippingRect.Bottom;
            }

            if (yHi2 < clippingRect.Top)
            {
                yHi2 = clippingRect.Top;
            }

            if (yHi2 > clippingRect.Bottom)
            {
                yHi2 = clippingRect.Bottom;
            }
            
            var hasText = String.IsNullOrWhiteSpace(MiddleText) || String.IsNullOrWhiteSpace(LoText) || String.IsNullOrWhiteSpace(Lo2Text) || String.IsNullOrWhiteSpace(HiText) || String.IsNullOrWhiteSpace(Hi2Text);
            //middle bit
            
            clippingRect = new OxyRect(clippingRect.Left, yHi, clippingRect.Width, Math.Max(yLo - yHi,0));
            if (SectionBackColorAlpha > 0)
            {
                var clippy = !hasText ? clippingRect : OxyRect.Create(clippingRect.Left - this.YAxis.AxisDistance, clippingRect.Top, clippingRect.Right, clippingRect.Bottom);
                var sectionBackColor = SectionBackColorAlpha < 255 ? OxyColor.FromAColor(SectionBackColorAlpha, this.GetSelectableColor(this.ActualColor)) : this.GetSelectableColor(this.ActualColor);
                rc.DrawClippedRectangle(clippy, clippy, sectionBackColor, sectionBackColor, 0);
                if (!String.IsNullOrWhiteSpace(MiddleText))
                    rc.DrawText(new ScreenPoint(clippy.Left + 3, clippy.Center.Y), MiddleText, this.GetSelectableColor(this.ActualColor), Font, FontSize, FontWeight, 0, HorizontalAlignment.Left, VerticalAlignment.Middle);

            }
            if (pointsToRender.Any(x => x.Y <= yLo && x.Y >= yHi) || (pointsToRender.Any(x => x.Y <= yHi) && pointsToRender.Any(x => x.Y >= yLo)))
            {
                rc.DrawClippedLine(
                    clippingRect,
                    pointsToRender,
                    this.MinimumSegmentLength * this.MinimumSegmentLength,
                    ShowColouredLines ? this.GetSelectableColor(this.ActualColor) : DefaultLineColor,
                    this.StrokeThickness,
                    this.ActualDashArray,
                    this.LineJoin,
                    false);
            }
            //lower middle

            clippingRect = new OxyRect(clippingRect.Left, yLo, clippingRect.Width, Math.Max(yLo2 - yLo, 0));
            if (SectionBackColorAlpha > 0)
            {
                var clippy = !hasText ? clippingRect : OxyRect.Create(clippingRect.Left - this.YAxis.AxisDistance, clippingRect.Top, clippingRect.Right, clippingRect.Bottom);
                if (!String.IsNullOrWhiteSpace(LoText))
                    rc.DrawText(new ScreenPoint(clippy.Left + 3, clippy.Center.Y), LoText, this.GetSelectableColor(this.ActualColorLo), Font, FontSize, FontWeight, 0, HorizontalAlignment.Left, VerticalAlignment.Middle);
                var sectionBackColor = SectionBackColorAlpha < 255 ? OxyColor.FromAColor(SectionBackColorAlpha, this.GetSelectableColor(this.ActualColorLo)) : this.GetSelectableColor(this.ActualColorLo);
                rc.DrawRectangle(clippy, sectionBackColor, sectionBackColor, 0);
            }
            if (pointsToRender.Any(x => x.Y >= yLo && x.Y <= yLo2) || (pointsToRender.Any(x => x.Y <= yLo) && pointsToRender.Any(x => x.Y >= yLo2)))
            {
                rc.DrawClippedLine(
                    clippingRect,
                    pointsToRender,
                    this.MinimumSegmentLength * this.MinimumSegmentLength,
                    ShowColouredLines ? this.GetSelectableColor(this.ActualColorLo) : DefaultLineColor,
                    this.StrokeThickness,
                    this.ActualDashArrayLo,
                    this.LineJoin,
                    false);
            }
            //lower outer

            clippingRect = new OxyRect(clippingRect.Left, yLo2, clippingRect.Width, Math.Max(bottom - yLo2, 0));
            if (SectionBackColorAlpha > 0)
            {
                var clippy = !hasText ? clippingRect : OxyRect.Create(clippingRect.Left - this.YAxis.AxisDistance, clippingRect.Top, clippingRect.Right, clippingRect.Bottom);
                if (!String.IsNullOrWhiteSpace(Lo2Text))
                    rc.DrawText(new ScreenPoint(clippy.Left + 3, clippy.Center.Y), Lo2Text, this.GetSelectableColor(this.ActualColorLo2), Font, FontSize, FontWeight, 0, HorizontalAlignment.Left, VerticalAlignment.Middle);
                var sectionBackColor = SectionBackColorAlpha < 255 ? OxyColor.FromAColor(SectionBackColorAlpha, this.GetSelectableColor(this.ActualColorLo2)) : this.GetSelectableColor(this.ActualColorLo2);
                rc.DrawRectangle(clippy, sectionBackColor, sectionBackColor, 0);
            }
            if (pointsToRender.Any(x => x.Y >= yLo2))
            {
                rc.DrawClippedLine(
                    clippingRect,
                    pointsToRender,
                    this.MinimumSegmentLength * this.MinimumSegmentLength,
                    ShowColouredLines ? this.GetSelectableColor(this.ActualColorLo2) : DefaultLineColor,
                    this.StrokeThickness,
                    this.ActualDashArrayLo2,
                    this.LineJoin,
                    false);
            }
            //upper middle

            clippingRect = new OxyRect(clippingRect.Left, yHi2, clippingRect.Width, Math.Max(yHi - yHi2, 0));
            if (SectionBackColorAlpha > 0)
            {
                var clippy = !hasText ? clippingRect : OxyRect.Create(clippingRect.Left - this.YAxis.AxisDistance, clippingRect.Top, clippingRect.Right, clippingRect.Bottom);
                if (!String.IsNullOrWhiteSpace(HiText))
                    rc.DrawText(new ScreenPoint(clippy.Left + 3, clippy.Center.Y), HiText, this.GetSelectableColor(this.ActualColorHi), Font, FontSize, FontWeight, 0, HorizontalAlignment.Left, VerticalAlignment.Middle);
                var sectionBackColor = SectionBackColorAlpha < 255 ? OxyColor.FromAColor(SectionBackColorAlpha, this.GetSelectableColor(this.ActualColorHi)) : this.GetSelectableColor(this.ActualColorHi);
                rc.DrawRectangle(clippy, sectionBackColor, sectionBackColor, 0);
            }
            if (pointsToRender.Any(x => x.Y <= yHi) && pointsToRender.Any(x=>x.Y >= yHi2) || (pointsToRender.Any(x => x.Y >= yHi) && pointsToRender.Any(x => x.Y <= yHi2)))
            {
                rc.DrawClippedLine(
                   clippingRect,
                   pointsToRender,
                   this.MinimumSegmentLength * this.MinimumSegmentLength,
                   ShowColouredLines ? this.GetSelectableColor(this.ActualColorHi) : DefaultLineColor,
                   this.StrokeThickness,
                   this.ActualDashArrayHi,
                   this.LineJoin,
                   false);
            }
            //upper outer

            clippingRect = new OxyRect(clippingRect.Left, top, clippingRect.Width, Math.Max(yHi2 - top, 0));
            if (SectionBackColorAlpha > 0)
            {
                var clippy = !hasText ? clippingRect : OxyRect.Create(clippingRect.Left - this.YAxis.AxisDistance, clippingRect.Top, clippingRect.Right, clippingRect.Bottom);
                if (!String.IsNullOrWhiteSpace(Hi2Text))
                    rc.DrawText(new ScreenPoint(clippy.Left + 3, clippy.Center.Y), Hi2Text, this.GetSelectableColor(this.ActualColorHi2), Font, FontSize, FontWeight, 0, HorizontalAlignment.Left, VerticalAlignment.Middle);
                var sectionBackColor = SectionBackColorAlpha < 255 ? OxyColor.FromAColor(SectionBackColorAlpha, this.GetSelectableColor(this.ActualColorHi2)) : this.GetSelectableColor(this.ActualColorHi2);
                rc.DrawRectangle(clippy, sectionBackColor, sectionBackColor, 0);
            }
            if (pointsToRender.Any(x => x.Y <= yHi2))
            {
                rc.DrawClippedLine(
                   clippingRect,
                   pointsToRender,
                   this.MinimumSegmentLength * this.MinimumSegmentLength,
                   ShowColouredLines ? this.GetSelectableColor(this.ActualColorHi2) : DefaultLineColor,
                   this.StrokeThickness,
                   this.ActualDashArrayHi2,
                   this.LineJoin,
                   false);

            }
        }
        /// <summary>
        /// Renders the legend symbol for the line series on the
        /// specified rendering context.
        /// </summary>
        /// <param name="rc">The rendering context.</param>
        /// <param name="legendBox">The bounding rectangle of the legend box.</param>
        public override void RenderLegend(IRenderContext rc, OxyRect legendBox)
        {
            double xmid = (legendBox.Left + legendBox.Right) / 2;
            double ymid = (legendBox.Top + legendBox.Bottom) / 2;
            var pts = new[] { new ScreenPoint(legendBox.Left, ymid), new ScreenPoint(legendBox.Right, ymid) };
           
            var midpt = new ScreenPoint(xmid, ymid);
            rc.DrawMarker(
                legendBox,
                midpt,
                this.MarkerType,
                this.MarkerOutline,
                this.MarkerSize,
                this.ActualMarkerFill,
                this.MarkerStroke,
                this.MarkerStrokeThickness);
        }
    }
}

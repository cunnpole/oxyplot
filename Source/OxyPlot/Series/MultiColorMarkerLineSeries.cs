// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoColorLineSeries.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Represents a two-color line series.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Series
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a two-color line series.
    /// </summary>
    public class MultiColorMarkerLineSeries : LineSeries
    {
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerStroke2;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerFill2;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerStroke3;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerFill3;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerStroke4;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerFill4;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerStroke5;
        /// <summary>
        /// The default second color.
        /// </summary>
        private OxyColor defaultMarkerFill5;
       
        /// <summary>
        /// Initializes a new instance of the <see cref = "MultiColorMarkerLineSeries" /> class.
        /// </summary>
        public MultiColorMarkerLineSeries()
        {
            this.MarkerStroke2 = OxyColors.Blue;
            this.MarkerFill2 = OxyColors.Blue;
            this.MarkerStroke3 = OxyColors.Red;
            this.MarkerFill3 = OxyColors.Red;
            this.MarkerStroke4 = OxyColors.Orange;
            this.MarkerFill4 = OxyColors.Orange;
            this.MarkerStroke5 = OxyColors.Purple;
            this.MarkerFill5 = OxyColors.Purple;
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerStroke2 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerStroke2
        {
            get { return this.MarkerStroke2.GetActualColor(this.defaultMarkerStroke2); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerFill2 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerFill2
        {
            get { return this.MarkerFill2.GetActualColor(this.defaultMarkerFill2); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerStroke3 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerStroke3
        {
            get { return this.MarkerStroke3.GetActualColor(this.defaultMarkerStroke3); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerFill3 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerFill3
        {
            get { return this.MarkerFill3.GetActualColor(this.defaultMarkerFill3); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerStroke4 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerStroke4
        {
            get { return this.MarkerStroke4.GetActualColor(this.defaultMarkerStroke4); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerFill4 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerFill4
        {
            get { return this.MarkerFill4.GetActualColor(this.defaultMarkerFill4); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerStroke5 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerStroke5
        {
            get { return this.MarkerStroke5.GetActualColor(this.defaultMarkerStroke5); }
        }

        /// <summary>
        /// Gets or sets the color for the part of the line that is below the limit.
        /// </summary>
        public OxyColor MarkerFill5 { get; set; }

        /// <summary>
        /// Gets the actual second color.
        /// </summary>
        /// <value>The actual color.</value>
        public OxyColor ActualMarkerFill5
        {
            get { return this.MarkerFill5.GetActualColor(this.defaultMarkerFill5); }
        }


        /// <summary>
        /// Sets the default values.
        /// </summary>
        protected internal override void SetDefaultValues()
        {
            base.SetDefaultValues();

            if (this.MarkerStroke2.IsAutomatic())
            {
                this.defaultMarkerStroke2 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerFill2.IsAutomatic())
            {
                this.defaultMarkerFill2 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerStroke3.IsAutomatic())
            {
                this.defaultMarkerStroke3 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerFill3.IsAutomatic())
            {
                this.defaultMarkerFill3 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerStroke4.IsAutomatic())
            {
                this.defaultMarkerStroke4 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerFill4.IsAutomatic())
            {
                this.defaultMarkerFill4 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerStroke5.IsAutomatic())
            {
                this.defaultMarkerStroke5 = this.PlotModel.GetDefaultColor();
            }

            if (this.MarkerFill5.IsAutomatic())
            {
                this.defaultMarkerFill5 = this.PlotModel.GetDefaultColor();
            }
        }

        protected override void RenderLineAndMarkers(IRenderContext rc, OxyRect clippingRect, IList<ScreenPoint> pointsToRender)
        {
            var screenPoints = pointsToRender;
            if (this.InterpolationAlgorithm != null)
            {
                // spline smoothing (should only be used on small datasets)
                var resampledPoints = ScreenPointHelper.ResamplePoints(pointsToRender, this.MinimumSegmentLength);
                screenPoints = this.InterpolationAlgorithm.CreateSpline(resampledPoints, false, 0.25);
            }

            // clip the line segments with the clipping rectangle
            if (this.StrokeThickness > 0 && this.ActualLineStyle != LineStyle.None)
            {
                this.RenderLine(rc, clippingRect, screenPoints);
            }

            if (this.MarkerType != MarkerType.None)
            {
                var markerBinOffset = this.MarkerResolution > 0 ? this.Transform(this.MinX, this.MinY) : default(ScreenPoint);
                foreach(var g in pointsToRender.GroupBy(x => x.MarkerColour))
                {
                    switch(g.Key)
                    {
                        case Foundation.MarkerColor.Color1:
                            rc.DrawMarkers(clippingRect, g.ToList(), this.MarkerType, this.MarkerOutline, new[] { this.MarkerSize }, this.ActualMarkerFill, this.MarkerStroke, this.MarkerStrokeThickness, this.MarkerResolution, markerBinOffset);
                            break;
                        case Foundation.MarkerColor.Color2:
                            rc.DrawMarkers(clippingRect, g.ToList(), this.MarkerType, this.MarkerOutline, new[] { this.MarkerSize }, this.ActualMarkerFill2, this.MarkerStroke2, this.MarkerStrokeThickness, this.MarkerResolution, markerBinOffset);
                            break;
                        case Foundation.MarkerColor.Color3:
                            rc.DrawMarkers(clippingRect, g.ToList(), this.MarkerType, this.MarkerOutline, new[] { this.MarkerSize }, this.ActualMarkerFill3, this.MarkerStroke3, this.MarkerStrokeThickness, this.MarkerResolution, markerBinOffset);
                            break;
                        case Foundation.MarkerColor.Color4:
                            rc.DrawMarkers(clippingRect, g.ToList(), this.MarkerType, this.MarkerOutline, new[] { this.MarkerSize }, this.ActualMarkerFill4, this.MarkerStroke4, this.MarkerStrokeThickness, this.MarkerResolution, markerBinOffset);
                            break;
                        case Foundation.MarkerColor.Color5:
                            rc.DrawMarkers(clippingRect, g.ToList(), this.MarkerType, this.MarkerOutline, new[] { this.MarkerSize }, this.ActualMarkerFill5, this.MarkerStroke5, this.MarkerStrokeThickness, this.MarkerResolution, markerBinOffset);
                            break;

                    }
                }
               
            }
        }
    }
}

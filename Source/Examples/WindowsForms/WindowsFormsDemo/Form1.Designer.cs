// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="OxyPlot">
//   http://oxyplot.codeplex.com, license: MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using OxyPlot.WindowsForms;

namespace WindowsFormsDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.cmdRedraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Margin = new System.Windows.Forms.Padding(0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(350, 92);
            this.plot1.TabIndex = 0;
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // cmdRedraw
            // 
            this.cmdRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRedraw.Location = new System.Drawing.Point(181, 95);
            this.cmdRedraw.Name = "cmdRedraw";
            this.cmdRedraw.Size = new System.Drawing.Size(167, 23);
            this.cmdRedraw.TabIndex = 1;
            this.cmdRedraw.Text = "Redraw";
            this.cmdRedraw.UseVisualStyleBackColor = true;
            this.cmdRedraw.Click += new System.EventHandler(this.cmdRedraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.Controls.Add(this.cmdRedraw);
            this.Controls.Add(this.plot1);
            this.Name = "Form1";
            this.Text = "OxyPlot in Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private PlotView plot1;
        private System.Windows.Forms.Button cmdRedraw;
    }
}

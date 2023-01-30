namespace Prog1_GUI
{
    partial class Prog1Form
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.calcEstimateBtn = new System.Windows.Forms.Button();
            this.lengthLongSide = new System.Windows.Forms.Label();
            this.heightLongSide = new System.Windows.Forms.Label();
            this.pricePerYdLbl = new System.Windows.Forms.Label();
            this.moldingTypeLegendLbl = new System.Windows.Forms.Label();
            this.firstRoomLegendLbl = new System.Windows.Forms.Label();
            this.sqYardsLbl = new System.Windows.Forms.Label();
            this.hardwoodCostLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.longLengthTxt = new System.Windows.Forms.TextBox();
            this.longHeightTxt = new System.Windows.Forms.TextBox();
            this.sqFootSupplierTxt = new System.Windows.Forms.TextBox();
            this.firstWindowTxt = new System.Windows.Forms.TextBox();
            this.secondWindowTxt = new System.Windows.Forms.TextBox();
            this.TotalSQFeetNeededOutputLbl = new System.Windows.Forms.TextBox();
            this.plasterboardsNeededOutputLbl = new System.Windows.Forms.TextBox();
            this.totalCostOutputLbl = new System.Windows.Forms.TextBox();
            this.shortSideLengthTxt = new System.Windows.Forms.TextBox();
            this.shortSideHeightTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costSQFootTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.laborCostSQFootTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.laborCostOutputLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(63, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(241, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Dry Wall and Window Cost Calculator";
            // 
            // calcEstimateBtn
            // 
            this.calcEstimateBtn.Location = new System.Drawing.Point(91, 571);
            this.calcEstimateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcEstimateBtn.Name = "calcEstimateBtn";
            this.calcEstimateBtn.Size = new System.Drawing.Size(208, 32);
            this.calcEstimateBtn.TabIndex = 1;
            this.calcEstimateBtn.Text = "Calculate Estimate";
            this.calcEstimateBtn.UseVisualStyleBackColor = true;
            this.calcEstimateBtn.Click += new System.EventHandler(this.calcEstimateBtn_Click);
            // 
            // lengthLongSide
            // 
            this.lengthLongSide.AutoSize = true;
            this.lengthLongSide.Location = new System.Drawing.Point(36, 49);
            this.lengthLongSide.Name = "lengthLongSide";
            this.lengthLongSide.Size = new System.Drawing.Size(162, 17);
            this.lengthLongSide.TabIndex = 2;
            this.lengthLongSide.Text = "Length of Long Side (ft);";
            // 
            // heightLongSide
            // 
            this.heightLongSide.AutoSize = true;
            this.heightLongSide.Location = new System.Drawing.Point(30, 77);
            this.heightLongSide.Name = "heightLongSide";
            this.heightLongSide.Size = new System.Drawing.Size(159, 17);
            this.heightLongSide.TabIndex = 3;
            this.heightLongSide.Text = "Height of Long Side (ft):";
            // 
            // pricePerYdLbl
            // 
            this.pricePerYdLbl.AutoSize = true;
            this.pricePerYdLbl.Location = new System.Drawing.Point(21, 194);
            this.pricePerYdLbl.Name = "pricePerYdLbl";
            this.pricePerYdLbl.Size = new System.Drawing.Size(200, 17);
            this.pricePerYdLbl.TabIndex = 4;
            this.pricePerYdLbl.Text = "Square Foot Size of Suppliers ";
            // 
            // moldingTypeLegendLbl
            // 
            this.moldingTypeLegendLbl.AutoSize = true;
            this.moldingTypeLegendLbl.Location = new System.Drawing.Point(21, 248);
            this.moldingTypeLegendLbl.Name = "moldingTypeLegendLbl";
            this.moldingTypeLegendLbl.Size = new System.Drawing.Size(183, 17);
            this.moldingTypeLegendLbl.TabIndex = 6;
            this.moldingTypeLegendLbl.Text = "Window? (1 = YES, 0 = NO)";
            // 
            // firstRoomLegendLbl
            // 
            this.firstRoomLegendLbl.AutoSize = true;
            this.firstRoomLegendLbl.Location = new System.Drawing.Point(7, 276);
            this.firstRoomLegendLbl.Name = "firstRoomLegendLbl";
            this.firstRoomLegendLbl.Size = new System.Drawing.Size(211, 17);
            this.firstRoomLegendLbl.TabIndex = 8;
            this.firstRoomLegendLbl.Text = "2nd Window? (1 = YES, 0 = NO)";
            // 
            // sqYardsLbl
            // 
            this.sqYardsLbl.AutoSize = true;
            this.sqYardsLbl.Location = new System.Drawing.Point(50, 373);
            this.sqYardsLbl.Name = "sqYardsLbl";
            this.sqYardsLbl.Size = new System.Drawing.Size(148, 17);
            this.sqYardsLbl.TabIndex = 9;
            this.sqYardsLbl.Text = "Total SQ feet needed:";
            // 
            // hardwoodCostLbl
            // 
            this.hardwoodCostLbl.AutoSize = true;
            this.hardwoodCostLbl.Location = new System.Drawing.Point(14, 411);
            this.hardwoodCostLbl.Name = "hardwoodCostLbl";
            this.hardwoodCostLbl.Size = new System.Drawing.Size(190, 17);
            this.hardwoodCostLbl.TabIndex = 10;
            this.hardwoodCostLbl.Text = "Total Plasterboards Needed:";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLbl.Location = new System.Drawing.Point(117, 484);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(87, 17);
            this.totalCostLbl.TabIndex = 13;
            this.totalCostLbl.Text = "Total Cost:";
            // 
            // longLengthTxt
            // 
            this.longLengthTxt.Location = new System.Drawing.Point(207, 49);
            this.longLengthTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.longLengthTxt.Name = "longLengthTxt";
            this.longLengthTxt.Size = new System.Drawing.Size(151, 22);
            this.longLengthTxt.TabIndex = 14;
            // 
            // longHeightTxt
            // 
            this.longHeightTxt.Location = new System.Drawing.Point(208, 77);
            this.longHeightTxt.Margin = new System.Windows.Forms.Padding(4);
            this.longHeightTxt.Name = "longHeightTxt";
            this.longHeightTxt.Size = new System.Drawing.Size(151, 22);
            this.longHeightTxt.TabIndex = 15;
            // 
            // sqFootSupplierTxt
            // 
            this.sqFootSupplierTxt.Location = new System.Drawing.Point(206, 213);
            this.sqFootSupplierTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sqFootSupplierTxt.Name = "sqFootSupplierTxt";
            this.sqFootSupplierTxt.Size = new System.Drawing.Size(151, 22);
            this.sqFootSupplierTxt.TabIndex = 16;
            // 
            // firstWindowTxt
            // 
            this.firstWindowTxt.Location = new System.Drawing.Point(207, 243);
            this.firstWindowTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstWindowTxt.Name = "firstWindowTxt";
            this.firstWindowTxt.Size = new System.Drawing.Size(151, 22);
            this.firstWindowTxt.TabIndex = 17;
            // 
            // secondWindowTxt
            // 
            this.secondWindowTxt.Location = new System.Drawing.Point(224, 273);
            this.secondWindowTxt.Margin = new System.Windows.Forms.Padding(4);
            this.secondWindowTxt.Name = "secondWindowTxt";
            this.secondWindowTxt.Size = new System.Drawing.Size(140, 22);
            this.secondWindowTxt.TabIndex = 18;
            // 
            // TotalSQFeetNeededOutputLbl
            // 
            this.TotalSQFeetNeededOutputLbl.Location = new System.Drawing.Point(213, 370);
            this.TotalSQFeetNeededOutputLbl.Margin = new System.Windows.Forms.Padding(4);
            this.TotalSQFeetNeededOutputLbl.Name = "TotalSQFeetNeededOutputLbl";
            this.TotalSQFeetNeededOutputLbl.ReadOnly = true;
            this.TotalSQFeetNeededOutputLbl.Size = new System.Drawing.Size(151, 22);
            this.TotalSQFeetNeededOutputLbl.TabIndex = 19;
            // 
            // plasterboardsNeededOutputLbl
            // 
            this.plasterboardsNeededOutputLbl.Location = new System.Drawing.Point(209, 411);
            this.plasterboardsNeededOutputLbl.Margin = new System.Windows.Forms.Padding(4);
            this.plasterboardsNeededOutputLbl.Name = "plasterboardsNeededOutputLbl";
            this.plasterboardsNeededOutputLbl.ReadOnly = true;
            this.plasterboardsNeededOutputLbl.Size = new System.Drawing.Size(149, 22);
            this.plasterboardsNeededOutputLbl.TabIndex = 20;
            // 
            // totalCostOutputLbl
            // 
            this.totalCostOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutputLbl.Location = new System.Drawing.Point(206, 484);
            this.totalCostOutputLbl.Margin = new System.Windows.Forms.Padding(4);
            this.totalCostOutputLbl.Name = "totalCostOutputLbl";
            this.totalCostOutputLbl.ReadOnly = true;
            this.totalCostOutputLbl.Size = new System.Drawing.Size(151, 23);
            this.totalCostOutputLbl.TabIndex = 23;
            // 
            // shortSideLengthTxt
            // 
            this.shortSideLengthTxt.Location = new System.Drawing.Point(208, 113);
            this.shortSideLengthTxt.Name = "shortSideLengthTxt";
            this.shortSideLengthTxt.Size = new System.Drawing.Size(149, 22);
            this.shortSideLengthTxt.TabIndex = 24;
            // 
            // shortSideHeightTxt
            // 
            this.shortSideHeightTxt.Location = new System.Drawing.Point(208, 141);
            this.shortSideHeightTxt.Name = "shortSideHeightTxt";
            this.shortSideHeightTxt.Size = new System.Drawing.Size(149, 22);
            this.shortSideHeightTxt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Length of Short Side (ft):";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Height of Short Side (ft):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "PlasterBoard (ft):";
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cost of Dry Wall Per SQ Foot:";
            // 
            // costSQFootTXT
            // 
            this.costSQFootTXT.Location = new System.Drawing.Point(208, 307);
            this.costSQFootTXT.Name = "costSQFootTXT";
            this.costSQFootTXT.Size = new System.Drawing.Size(153, 22);
            this.costSQFootTXT.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cost of Labor Per SQ Foot:";
            // 
            // laborCostSQFootTxt
            // 
            this.laborCostSQFootTxt.Location = new System.Drawing.Point(211, 341);
            this.laborCostSQFootTxt.Name = "laborCostSQFootTxt";
            this.laborCostSQFootTxt.Size = new System.Drawing.Size(153, 22);
            this.laborCostSQFootTxt.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Labor Cost:";
            // 
            // laborCostOutputLabel
            // 
            this.laborCostOutputLabel.Location = new System.Drawing.Point(206, 443);
            this.laborCostOutputLabel.Name = "laborCostOutputLabel";
            this.laborCostOutputLabel.ReadOnly = true;
            this.laborCostOutputLabel.Size = new System.Drawing.Size(151, 22);
            this.laborCostOutputLabel.TabIndex = 34;
            // 
            // Prog1Form
            // 
            this.AcceptButton = this.calcEstimateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 651);
            this.Controls.Add(this.laborCostOutputLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.laborCostSQFootTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costSQFootTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shortSideHeightTxt);
            this.Controls.Add(this.shortSideLengthTxt);
            this.Controls.Add(this.totalCostOutputLbl);
            this.Controls.Add(this.plasterboardsNeededOutputLbl);
            this.Controls.Add(this.TotalSQFeetNeededOutputLbl);
            this.Controls.Add(this.secondWindowTxt);
            this.Controls.Add(this.firstWindowTxt);
            this.Controls.Add(this.sqFootSupplierTxt);
            this.Controls.Add(this.longHeightTxt);
            this.Controls.Add(this.longLengthTxt);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.hardwoodCostLbl);
            this.Controls.Add(this.sqYardsLbl);
            this.Controls.Add(this.firstRoomLegendLbl);
            this.Controls.Add(this.moldingTypeLegendLbl);
            this.Controls.Add(this.pricePerYdLbl);
            this.Controls.Add(this.heightLongSide);
            this.Controls.Add(this.lengthLongSide);
            this.Controls.Add(this.calcEstimateBtn);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prog1Form";
            this.Text = "Program 1";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button calcEstimateBtn;
        private System.Windows.Forms.Label lengthLongSide;
        private System.Windows.Forms.Label heightLongSide;
        private System.Windows.Forms.Label pricePerYdLbl;
        private System.Windows.Forms.Label moldingTypeLegendLbl;
        private System.Windows.Forms.Label firstRoomLegendLbl;
        private System.Windows.Forms.Label sqYardsLbl;
        private System.Windows.Forms.Label hardwoodCostLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.TextBox longLengthTxt;
        private System.Windows.Forms.TextBox longHeightTxt;
        private System.Windows.Forms.TextBox sqFootSupplierTxt;
        private System.Windows.Forms.TextBox firstWindowTxt;
        private System.Windows.Forms.TextBox secondWindowTxt;
        private System.Windows.Forms.TextBox TotalSQFeetNeededOutputLbl;
        private System.Windows.Forms.TextBox plasterboardsNeededOutputLbl;
        private System.Windows.Forms.TextBox totalCostOutputLbl;
        private System.Windows.Forms.TextBox shortSideLengthTxt;
        private System.Windows.Forms.TextBox shortSideHeightTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costSQFootTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox laborCostSQFootTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox laborCostOutputLabel;
    }
}


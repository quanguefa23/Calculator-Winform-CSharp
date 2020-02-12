using System.Text;
using System;

namespace Calculator
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonPercentage = new System.Windows.Forms.Button();
            this.buttonEquation = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.boxDisplay = new System.Windows.Forms.TextBox();
            this.boxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSeven
            // 
            this.buttonSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(21, 247);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(87, 64);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(114, 247);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(87, 64);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(207, 247);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(87, 64);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(207, 408);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(87, 64);
            this.buttonThree.TabIndex = 6;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(114, 408);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(87, 64);
            this.buttonTwo.TabIndex = 5;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(21, 408);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(87, 64);
            this.buttonOne.TabIndex = 4;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(207, 328);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(87, 64);
            this.buttonSix.TabIndex = 9;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(114, 328);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(87, 64);
            this.buttonFive.TabIndex = 8;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(21, 328);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(87, 64);
            this.buttonFour.TabIndex = 7;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(207, 488);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(87, 78);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = "•";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(114, 488);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(87, 78);
            this.buttonZero.TabIndex = 11;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonPercentage
            // 
            this.buttonPercentage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPercentage.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercentage.Location = new System.Drawing.Point(21, 488);
            this.buttonPercentage.Name = "buttonPercentage";
            this.buttonPercentage.Size = new System.Drawing.Size(87, 78);
            this.buttonPercentage.TabIndex = 10;
            this.buttonPercentage.Text = "%";
            this.buttonPercentage.UseVisualStyleBackColor = true;
            this.buttonPercentage.Click += new System.EventHandler(this.buttonPercentage_Click);
            // 
            // buttonEquation
            // 
            this.buttonEquation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEquation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquation.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonEquation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEquation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.buttonEquation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquation.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEquation.Location = new System.Drawing.Point(302, 408);
            this.buttonEquation.Name = "buttonEquation";
            this.buttonEquation.Size = new System.Drawing.Size(96, 158);
            this.buttonEquation.TabIndex = 16;
            this.buttonEquation.Text = "=";
            this.buttonEquation.UseVisualStyleBackColor = false;
            this.buttonEquation.Click += new System.EventHandler(this.buttonEquation_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonPlus.Location = new System.Drawing.Point(302, 328);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(96, 64);
            this.buttonPlus.TabIndex = 15;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft JhengHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonMinus.Location = new System.Drawing.Point(302, 247);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(96, 64);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "−";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Location = new System.Drawing.Point(302, 157);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 76);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "⌫";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMulti.Font = new System.Drawing.Font("Microsoft JhengHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulti.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonMulti.Location = new System.Drawing.Point(207, 157);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(87, 76);
            this.buttonMulti.TabIndex = 19;
            this.buttonMulti.Text = "×";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft JhengHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonDivision.Location = new System.Drawing.Point(114, 157);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(87, 76);
            this.buttonDivision.TabIndex = 18;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClear.Location = new System.Drawing.Point(21, 157);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 76);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // boxDisplay
            // 
            this.boxDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDisplay.ForeColor = System.Drawing.SystemColors.InfoText;
            this.boxDisplay.HideSelection = false;
            this.boxDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boxDisplay.Location = new System.Drawing.Point(21, 27);
            this.boxDisplay.Margin = new System.Windows.Forms.Padding(50);
            this.boxDisplay.Name = "boxDisplay";
            this.boxDisplay.ReadOnly = true;
            this.boxDisplay.Size = new System.Drawing.Size(377, 56);
            this.boxDisplay.TabIndex = 21;
            this.boxDisplay.Text = "0";
            this.boxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxDisplay.TextChanged += new System.EventHandler(this.boxDisplay_TextChanged);
            // 
            // boxResult
            // 
            this.boxResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.boxResult.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxResult.ForeColor = System.Drawing.Color.DimGray;
            this.boxResult.Location = new System.Drawing.Point(21, 88);
            this.boxResult.Margin = new System.Windows.Forms.Padding(50);
            this.boxResult.Name = "boxResult";
            this.boxResult.ReadOnly = true;
            this.boxResult.Size = new System.Drawing.Size(377, 40);
            this.boxResult.TabIndex = 22;
            this.boxResult.Text = "0";
            this.boxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxResult.TextChanged += new System.EventHandler(this.boxResult_TextChanged);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(418, 586);
            this.Controls.Add(this.boxResult);
            this.Controls.Add(this.boxDisplay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquation);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonPercentage);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator 4.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonPercentage;
        private System.Windows.Forms.Button buttonEquation;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox boxDisplay;
        private System.Windows.Forms.TextBox boxResult;
    }
}


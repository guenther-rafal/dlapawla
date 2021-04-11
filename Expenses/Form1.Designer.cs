
using Expenses.Models;
using System;

namespace Expenses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdExpenses = new System.Windows.Forms.DataGridView();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.drpExpenseTypes = new System.Windows.Forms.ComboBox();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.drpMonthFilter = new System.Windows.Forms.ComboBox();
            this.btnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // grdExpenses
            // 
            this.grdExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenses.Location = new System.Drawing.Point(12, 133);
            this.grdExpenses.Name = "grdExpenses";
            this.grdExpenses.RowTemplate.Height = 25;
            this.grdExpenses.Size = new System.Drawing.Size(776, 305);
            this.grdExpenses.TabIndex = 0;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(120, 43);
            this.nudAmount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(199, 23);
            this.nudAmount.TabIndex = 1;
            // 
            // drpExpenseTypes
            // 
            this.drpExpenseTypes.FormattingEnabled = true;
            this.drpExpenseTypes.Location = new System.Drawing.Point(119, 12);
            this.drpExpenseTypes.Name = "drpExpenseTypes";
            this.drpExpenseTypes.Size = new System.Drawing.Size(200, 23);
            this.drpExpenseTypes.TabIndex = 2;
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Location = new System.Drawing.Point(119, 73);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(200, 23);
            this.dtpExpenseDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expense type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(244, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // drpMonthFilter
            // 
            this.drpMonthFilter.FormattingEnabled = true;
            this.drpMonthFilter.Location = new System.Drawing.Point(564, 72);
            this.drpMonthFilter.Name = "drpMonthFilter";
            this.drpMonthFilter.Size = new System.Drawing.Size(204, 23);
            this.drpMonthFilter.TabIndex = 8;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(693, 104);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.drpMonthFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpExpenseDate);
            this.Controls.Add(this.drpExpenseTypes);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.grdExpenses);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdExpenses;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ComboBox drpExpenseTypes;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox drpMonthFilter;
        private System.Windows.Forms.Button btnRead;
    }
}


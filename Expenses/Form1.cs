using Expenses.Models;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Expenses
{
    public partial class Form1 : Form
    {
        private readonly Services.Expenses _expenses;

        public Form1()
        {
            InitializeComponent();
            Initialize();
            _expenses = new Services.Expenses();
        }

        private void Initialize()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");
            drpExpenseTypes.DataSource = Enum.GetValues(typeof(ExpenseTypes));
            drpMonthFilter.DataSource = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            nudAmount.Maximum = decimal.MaxValue;
            nudAmount.DecimalPlaces = 2;
            dtpExpenseDate.Format = DateTimePickerFormat.Custom;
            dtpExpenseDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var results = _expenses.Filter(drpMonthFilter.SelectedIndex);
            grdExpenses.DataSource = results;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var expense = new Expense(drpExpenseTypes.SelectedIndex, dtpExpenseDate.Value, nudAmount.Value);
            _expenses.Add(expense);
        }
    }
}

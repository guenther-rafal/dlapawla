using System;
using System.Xml.Linq;

namespace Expenses.Models
{
    public class Expense
    {
        public Expense(XElement xElement)
        {
            Type = (ExpenseTypes)int.Parse(xElement.Attribute(nameof(Type)).Value);
            Date = DateTime.Parse(xElement.Attribute(nameof(Date)).Value);
            Amount = decimal.Parse(xElement.Attribute(nameof(Type)).Value);
        }

        public Expense(int type, DateTime date, decimal amount)
        {
            Type = (ExpenseTypes)type;
            Date = date;
            Amount = amount;
        }

        public ExpenseTypes Type { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }

        public XElement ToXElement()
        {
            return new XElement(nameof(Expense),
                new XAttribute(nameof(Type), (int)Type),
                new XAttribute(nameof(Date), Date.Date),
                new XAttribute(nameof(Amount), Amount));
        }
    }
}

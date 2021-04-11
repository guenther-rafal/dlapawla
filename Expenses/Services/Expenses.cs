using Expenses.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Expenses.Services
{
    public class Expenses
    {
        private const string XmlFileName = "expenses.xml";
        private const string RootName = nameof(Expenses);

        public void Add(Expense expense)
        {
            if (!File.Exists(XmlFileName))
            {
                var xDoc = new XDocument(new XElement(RootName));
                xDoc.Save(XmlFileName);
            }

            var expenses = XDocument.Load(XmlFileName);
            expenses.Root.Add(expense.ToXElement());
            expenses.Save(XmlFileName, SaveOptions.None);
        }

        public ICollection<Expense> Filter(int monthFilter)
        {
            var expenses = XDocument.Load(XmlFileName);
            return expenses.Root.Descendants()
                .Where(z => DateTime.Parse(z.Attribute("Date").Value).Month == monthFilter + 1)
                .Select(z => new Expense(z))
                .ToList();
        }
    }
}

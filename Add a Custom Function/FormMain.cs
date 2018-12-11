using Stimulsoft.Data.Extensions;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Add_a_Custom_Function
{
    public partial class FormMain : Form
    {
        public class MyClass
        {
            public static decimal MySum(object value)
            {
                if (!ListExt.IsList(value))
                    return Stimulsoft.Base.Helpers.StiValueHelper.TryToDecimal(value);

                return Stimulsoft.Data.Functions.Funcs.SkipNulls(ListExt.ToList(value))
                    .TryCastToDecimal()
                    .Sum();
            }
        }

        public FormMain()
        {
            InitializeComponent();

            AddCustomFunction();
        }

        private void AddCustomFunction()
        {
            StiFunctions.AddFunction(
                "My Category", "MySum", "description",
                typeof(MyClass),
                typeof(decimal),
                "Calculates a sum of the specified set of values.",
                new[] { typeof(object) },
                new[] { "values" },
                new[] { "A set of values" }).UseFullPath = false;
        }

        private void buttonDesigner_Click(object sender, EventArgs e)
        {
            var report = StiReport.CreateNewDashboard();
            report.Design();
        }
    }
}

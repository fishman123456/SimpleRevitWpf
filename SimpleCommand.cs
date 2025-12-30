using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;

namespace SimpleRevitWpf
{
    [Transaction(TransactionMode.Manual)]
    public class SimpleCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var window = new MainWindow();
            window.ShowDialog();
            return Result.Succeeded;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ut6_Actividad_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            reportViewer.Owner = this;

            CrystalReportInformeClientes informe = new CrystalReportInformeClientes();

            informe.SetDatabaseLogon("tema6servidorluis","asdecu@dor77");
            reportViewer.ViewerCore.ReportSource = informe;
        }
    }
}

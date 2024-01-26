using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistProduccionEnC.Procesos
{
    /// <summary>
    /// Lógica de interacción para frmPROC_EntradaProdTransf.xaml
    /// </summary>
    public partial class frmPROC_EntradaProdTransf : Window
    {
        public frmPROC_EntradaProdTransf()
        {
            InitializeComponent();
        }

        public MainWindow MdiParent { get; internal set; }
    }
}

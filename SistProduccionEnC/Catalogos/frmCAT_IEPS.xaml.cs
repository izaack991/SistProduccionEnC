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

namespace SistProduccionEnC.Catalogos
{
    /// <summary>
    /// Lógica de interacción para frmCAT_IEPS.xaml
    /// </summary>
    public partial class frmCAT_IEPS : Window
    {
        public frmCAT_IEPS()
        {
            InitializeComponent();
        }

        public MainWindow MdiParent { get; internal set; }
    }
}

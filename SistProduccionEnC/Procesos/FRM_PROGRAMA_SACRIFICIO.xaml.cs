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
    /// Lógica de interacción para FRM_PROGRAMA_SACRIFICIO.xaml
    /// </summary>
    public partial class FRM_PROGRAMA_SACRIFICIO : Window
    {
        public FRM_PROGRAMA_SACRIFICIO()
        {
            InitializeComponent();
        }

        public MainWindow MdiParent { get; internal set; }
    }
}

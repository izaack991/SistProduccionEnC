// Updated by XamlIntelliSenseFileGenerator 19/01/2024 05:26:06 p. m.
#pragma checksum "..\..\..\Catalogos\frmCAT_ProductosCte.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CF7EDB462B8CEC3783362B33BCDCB4A8070ED886D93FC95972C4CB79B6B0AA06"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using SistProduccionEnC.Catalogos;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SistProduccionEnC.Catalogos
{


    /// <summary>
    /// frmCAT_ProductosCte
    /// </summary>
    public partial class frmCAT_ProductosCte : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SistProduccionEnC;component/catalogos/frmcat_productoscte.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Catalogos\frmCAT_ProductosCte.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 22 "..\..\..\Catalogos\frmCAT_ProductosCte.xaml"
                    ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);

#line default
#line hidden
                    return;
                case 2:
                    this.txtNumber = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:

#line 26 "..\..\..\Catalogos\frmCAT_ProductosCte.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Increase_Click);

#line default
#line hidden
                    return;
                case 4:

#line 27 "..\..\..\Catalogos\frmCAT_ProductosCte.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Decrease_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}


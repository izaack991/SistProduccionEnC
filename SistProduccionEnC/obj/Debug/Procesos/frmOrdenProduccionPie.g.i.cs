﻿#pragma checksum "..\..\..\Procesos\frmOrdenProduccionPie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1771D643F63C105492ED8001002EBB5DCCBFFC56EF105FFC3C1B6927B8ED093"
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
using SistProduccionEnC.Procesos;
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


namespace SistProduccionEnC.Procesos {
    
    
    /// <summary>
    /// frmOrdenProduccionPie
    /// </summary>
    public partial class frmOrdenProduccionPie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SistProduccionEnC.Procesos.frmOrdenProduccionPie frmOrdenProduccionPie1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LBL_ESTATUS;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LBL_FECHA;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_CAPTURAR;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CMB_ESTATUS;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DTP_FECHA;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SistProduccionEnC;component/procesos/frmordenproduccionpie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.frmOrdenProduccionPie1 = ((SistProduccionEnC.Procesos.frmOrdenProduccionPie)(target));
            return;
            case 2:
            this.LBL_ESTATUS = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LBL_FECHA = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BTN_CAPTURAR = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Procesos\frmOrdenProduccionPie.xaml"
            this.BTN_CAPTURAR.Click += new System.Windows.RoutedEventHandler(this.BTN_CAPTURAR_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CMB_ESTATUS = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.DTP_FECHA = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F76C28F0952BD3F1B8039DB2D8ABDC69863C267732C0360C69FEA1418632ED39"
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


namespace SistProduccionEnC.Catalogos {
    
    
    /// <summary>
    /// frmCAT_TiposVehiculo
    /// </summary>
    public partial class frmCAT_TiposVehiculo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_EDITAR;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_CANCELAR;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_NUEVO;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_GUARDAR;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_nombre;
        
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
            System.Uri resourceLocater = new System.Uri("/SistProduccionEnC;component/catalogos/frmcat_tiposvehiculo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
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
            this.BTN_EDITAR = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.BTN_CANCELAR = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.BTN_NUEVO = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
            this.BTN_NUEVO.Click += new System.Windows.RoutedEventHandler(this.BTN_NUEVO_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_GUARDAR = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Catalogos\frmCAT_TiposVehiculo.xaml"
            this.BTN_GUARDAR.Click += new System.Windows.RoutedEventHandler(this.btn_guardar_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbl_nombre = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


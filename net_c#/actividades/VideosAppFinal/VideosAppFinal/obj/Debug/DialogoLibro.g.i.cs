﻿#pragma checksum "..\..\DialogoLibro.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5EE40BA77FFC56DA80D4E24BDC77EE9F5DD8F82A63EB6894D24D1BB599CF8BAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using VideosAppFinal;


namespace VideosAppFinal {
    
    
    /// <summary>
    /// DialogoLibro
    /// </summary>
    public partial class DialogoLibro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTitulo;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelAutor;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelFechaEntrada;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxTitulo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxAutor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerFechaDeEntrada;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAceptar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DialogoLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/VideosAppFinal;component/dialogolibro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DialogoLibro.xaml"
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
            this.labelTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelAutor = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labelFechaEntrada = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBoxTitulo = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\DialogoLibro.xaml"
            this.textBoxTitulo.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.validation_Error));
            
            #line default
            #line hidden
            
            #line 13 "..\..\DialogoLibro.xaml"
            this.textBoxTitulo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxTitulo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxAutor = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\DialogoLibro.xaml"
            this.textBoxAutor.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.validation_Error));
            
            #line default
            #line hidden
            return;
            case 6:
            this.datePickerFechaDeEntrada = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.buttonAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\DialogoLibro.xaml"
            this.buttonAceptar.Click += new System.Windows.RoutedEventHandler(this.buttonAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\DialogoLibro.xaml"
            this.buttonCancelar.Click += new System.Windows.RoutedEventHandler(this.buttonCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


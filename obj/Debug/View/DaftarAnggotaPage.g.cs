﻿#pragma checksum "..\..\..\View\DaftarAnggotaPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "648E1FE385F67FE9B7DD43A2DD13EF34610984A460289D0DBD95262D1553EB58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PerpusDong.View;
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


namespace PerpusDong.View {
    
    
    /// <summary>
    /// DaftarAnggotaPage
    /// </summary>
    public partial class DaftarAnggotaPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\DaftarAnggotaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAnggota;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\DaftarAnggotaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKembali;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\DaftarAnggotaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAnggota1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\DaftarAnggotaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDaftarAnggota;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\DaftarAnggotaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInputAnggota;
        
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
            System.Uri resourceLocater = new System.Uri("/PerpusDong;component/view/daftaranggotapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DaftarAnggotaPage.xaml"
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
            this.dgAnggota = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btnKembali = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\DaftarAnggotaPage.xaml"
            this.btnKembali.Click += new System.Windows.RoutedEventHandler(this.btnKembali_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblAnggota1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnDaftarAnggota = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\View\DaftarAnggotaPage.xaml"
            this.btnDaftarAnggota.Click += new System.Windows.RoutedEventHandler(this.btnDaftarAnggota_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnInputAnggota = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\DaftarAnggotaPage.xaml"
            this.btnInputAnggota.Click += new System.Windows.RoutedEventHandler(this.btnInputAnggota_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


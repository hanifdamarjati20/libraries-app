#pragma checksum "..\..\..\View\MainMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C9AF89E15143E19062F59150D0E405460DE54BB97B28D378C27788311A96AE74"
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


namespace PerpusDong.View
{


    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainMenuPage;

#line default
#line hidden


#line 11 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;

#line default
#line hidden


#line 21 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAplikasiPerpustakaan;

#line default
#line hidden


#line 23 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;

#line default
#line hidden


#line 26 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnggota;

#line default
#line hidden


#line 29 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPeminjaman;

#line default
#line hidden


#line 32 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuku;

#line default
#line hidden


#line 33 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBuku;

#line default
#line hidden


#line 35 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBuku;

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
            System.Uri resourceLocater = new System.Uri("/PerpusDong;component/view/mainmenu.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\MainMenu.xaml"
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
                    this.MainMenuPage = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.image1 = ((System.Windows.Controls.Image)(target));
                    return;
                case 3:
                    this.lblAplikasiPerpustakaan = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.btnLogout = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\..\View\MainMenu.xaml"
                    this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.lblLogout = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.btnAnggota = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\..\View\MainMenu.xaml"
                    this.btnAnggota.Click += new System.Windows.RoutedEventHandler(this.btnAnggota_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.lblAnggota = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.btnPeminjaman = ((System.Windows.Controls.Button)(target));

#line 29 "..\..\..\View\MainMenu.xaml"
                    this.btnPeminjaman.Click += new System.Windows.RoutedEventHandler(this.btnPeminjaman_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.lblPeminjaman = ((System.Windows.Controls.Label)(target));
                    return;
                case 10:
                    this.btnBuku = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\..\View\MainMenu.xaml"
                    this.btnBuku.Click += new System.Windows.RoutedEventHandler(this.btnBuku_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.imgBuku = ((System.Windows.Controls.Image)(target));
                    return;
                case 12:
                    this.lblBuku = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Image imgAnggota;
        internal System.Windows.Controls.Image imgPeminjaman;
        internal System.Windows.Controls.Image imgLogout;
        internal System.Windows.Controls.Label lblAnggota;
        internal System.Windows.Controls.Label lblLogout;
        internal System.Windows.Controls.Label lblPeminjaman;
    }
}


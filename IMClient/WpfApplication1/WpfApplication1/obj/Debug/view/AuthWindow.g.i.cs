﻿#pragma checksum "..\..\..\view\AuthWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "137CCC4EA916EE20DA056C98FC2F2126"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// AuthWindow
    /// </summary>
    public partial class AuthWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border txtBoxBorder;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border txtBoxBorder2;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Close_btn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\view\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/IMClient;component/view/authwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\AuthWindow.xaml"
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
            this.txtBoxBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\view\AuthWindow.xaml"
            this.txtUsername.GotFocus += new System.Windows.RoutedEventHandler(this.UsernameGotFocus);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\view\AuthWindow.xaml"
            this.txtUsername.LostFocus += new System.Windows.RoutedEventHandler(this.UsernameLostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBoxBorder2 = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 41 "..\..\..\view\AuthWindow.xaml"
            this.txtPassword.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordGotFocus);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\view\AuthWindow.xaml"
            this.txtPassword.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordLostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\view\AuthWindow.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.Login);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 64 "..\..\..\view\AuthWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.move_window);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Close_btn = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 65 "..\..\..\view\AuthWindow.xaml"
            this.Close_btn.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EXIT);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\view\AuthWindow.xaml"
            this.Close_btn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Activate_Title_Icons);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\view\AuthWindow.xaml"
            this.Close_btn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Deactivate_Title_Icons);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\view\AuthWindow.xaml"
            this.Close_btn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Close_pressing);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\view\AuthWindow.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.Register);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblErrorMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


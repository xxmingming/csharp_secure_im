﻿#pragma checksum "..\..\IMMainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C0740C794F9FB5E00331190E8C4438F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IMClient;
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
    /// IMMainWindow
    /// </summary>
    public partial class IMMainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\IMMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Close_btn;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\IMMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\IMMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridContacts;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\IMMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listContacts;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\IMMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBuddies;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\IMMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBuddies;
        
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
            System.Uri resourceLocater = new System.Uri("/IMClient;component/immainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\IMMainWindow.xaml"
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
            
            #line 58 "..\..\IMMainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.move_window);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Close_btn = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 59 "..\..\IMMainWindow.xaml"
            this.Close_btn.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EXIT);
            
            #line default
            #line hidden
            
            #line 59 "..\..\IMMainWindow.xaml"
            this.Close_btn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Activate_Title_Icons);
            
            #line default
            #line hidden
            
            #line 59 "..\..\IMMainWindow.xaml"
            this.Close_btn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Deactivate_Title_Icons);
            
            #line default
            #line hidden
            
            #line 59 "..\..\IMMainWindow.xaml"
            this.Close_btn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Close_pressing);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 4:
            this.gridContacts = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.listContacts = ((System.Windows.Controls.ListBox)(target));
            
            #line 71 "..\..\IMMainWindow.xaml"
            this.listContacts.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ListContacts_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridBuddies = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.listBuddies = ((System.Windows.Controls.ListBox)(target));
            
            #line 94 "..\..\IMMainWindow.xaml"
            this.listBuddies.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ListBuddies_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


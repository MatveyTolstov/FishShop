﻿#pragma checksum "..\..\Admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DFFF3E53874CA7F7707B5B9C54650F4E1CD077AB98773E6D260882EF8FF1E68A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using gh;


namespace gh {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RolesGr;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Role_Button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Employ_Button;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_Button;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Auth;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstText_Box;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox FirstPswd;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecondText_Box;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThirdText_Box;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Fourth_Combobox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create_Button;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update_Button;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/gh;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin.xaml"
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
            this.RolesGr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\Admin.xaml"
            this.RolesGr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RolesGr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Role_Button = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Admin.xaml"
            this.Role_Button.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Employ_Button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Admin.xaml"
            this.Employ_Button.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Back_Button = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\Admin.xaml"
            this.Back_Button.Click += new System.Windows.RoutedEventHandler(this.Back_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_Auth = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Admin.xaml"
            this.Button_Auth.Click += new System.Windows.RoutedEventHandler(this.Button_Auth_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FirstText_Box = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.FirstPswd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.SecondText_Box = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ThirdText_Box = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Fourth_Combobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.Create_Button = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\Admin.xaml"
            this.Create_Button.Click += new System.Windows.RoutedEventHandler(this.Create_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Update_Button = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Admin.xaml"
            this.Update_Button.Click += new System.Windows.RoutedEventHandler(this.Update_Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Delete_Button = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\Admin.xaml"
            this.Delete_Button.Click += new System.Windows.RoutedEventHandler(this.Delete_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

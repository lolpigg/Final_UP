﻿#pragma checksum "..\..\BenefitPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30D95DEF4FE0B2588EDA9A1AEB1128DAD040BF909C46431F41A57AB5CDD6F91D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_Project_UP;
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


namespace Final_Project_UP {
    
    
    /// <summary>
    /// BenefitPage
    /// </summary>
    public partial class BenefitPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox min_age;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox max_age;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox size;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Change;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\BenefitPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
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
            System.Uri resourceLocater = new System.Uri("/Final_Project_UP;component/benefitpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BenefitPage.xaml"
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
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\BenefitPage.xaml"
            this.DataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.min_age = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.max_age = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.size = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Create = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\BenefitPage.xaml"
            this.Create.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Change = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\BenefitPage.xaml"
            this.Change.Click += new System.Windows.RoutedEventHandler(this.Change_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\BenefitPage.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\..\UI\Category\CategoryCard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F84CCA25CFA0D14DD662F6BF7626FD0218858D88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyNhaHang;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace QuanLyNhaHang {
    
    
    /// <summary>
    /// CategoryCard
    /// </summary>
    public partial class CategoryCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel mealInfo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mealType;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon addIcon;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon deleteIcon;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyNhaHang;component/ui/category/categorycard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mealInfo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.mealType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
            this.addButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.addButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
            this.addButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.addButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 5:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
            this.deleteButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\..\..\UI\Category\CategoryCard.xaml"
            this.deleteButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deleteIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\..\Windows\ClientListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "155669B878A71396685855ADD99D9D31BDD4EEFCCC82DF6F1FFF85AB5892790C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FitnessClubRasima.Windows;
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


namespace FitnessClubRasima.Windows {
    
    
    /// <summary>
    /// ClientListWindow
    /// </summary>
    public partial class ClientListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\Windows\ClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblSearch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\ClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearch;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\ClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbSort;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\ClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbSort;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\ClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvClient;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\Windows\ClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddClient;
        
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
            System.Uri resourceLocater = new System.Uri("/FitnessClubRasima;component/windows/clientlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ClientListWindow.xaml"
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
            this.TblSearch = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Windows\ClientListWindow.xaml"
            this.TbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbSort = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.CmbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\Windows\ClientListWindow.xaml"
            this.CmbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvClient = ((System.Windows.Controls.ListView)(target));
            
            #line 63 "..\..\..\Windows\ClientListWindow.xaml"
            this.lvClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnAddClient = ((System.Windows.Controls.Button)(target));
            
            #line 196 "..\..\..\Windows\ClientListWindow.xaml"
            this.BtnAddClient.Click += new System.Windows.RoutedEventHandler(this.BtnAddClient_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 181 "..\..\..\Windows\ClientListWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditClient_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


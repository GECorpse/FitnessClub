﻿#pragma checksum "..\..\..\Windows\AddEditClientListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "036FAFF50160C090BC60815F859B43234AC78CDA6AA94826A06E11DED67148DD"
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
    /// AddEditClientListWindow
    /// </summary>
    public partial class AddEditClientListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblockTitle;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgService;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChooseImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFirstNameClient;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLastNameClient;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPatronymicClient;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPhoneClient;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbEmailClient;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\AddEditClientListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddEditClient;
        
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
            System.Uri resourceLocater = new System.Uri("/FitnessClubRasima;component/windows/addeditclientlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddEditClientListWindow.xaml"
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
            this.TblockTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ImgService = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.BtnChooseImage = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Windows\AddEditClientListWindow.xaml"
            this.BtnChooseImage.Click += new System.Windows.RoutedEventHandler(this.BtnChooseImage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TbFirstNameClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbLastNameClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TbPatronymicClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TbPhoneClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TbEmailClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BtnAddEditClient = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\Windows\AddEditClientListWindow.xaml"
            this.BtnAddEditClient.Click += new System.Windows.RoutedEventHandler(this.BtnAddEditClient_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


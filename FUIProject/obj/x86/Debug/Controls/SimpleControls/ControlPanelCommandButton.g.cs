﻿#pragma checksum "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4E139102996E251FD5D8631B2A02FE38"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace FUIProject.Controls.SimpleControls {
    
    
    /// <summary>
    /// ControlPanelCommandButton
    /// </summary>
    public partial class ControlPanelCommandButton : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path BackgroundPath;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ButtonText;
        
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
            System.Uri resourceLocater = new System.Uri("/FUIProject;component/controls/simplecontrols/controlpanelcommandbutton.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
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
            
            #line 7 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
            ((FUIProject.Controls.SimpleControls.ControlPanelCommandButton)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
            ((FUIProject.Controls.SimpleControls.ControlPanelCommandButton)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\..\..\Controls\SimpleControls\ControlPanelCommandButton.xaml"
            ((FUIProject.Controls.SimpleControls.ControlPanelCommandButton)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.UserControl_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackgroundPath = ((System.Windows.Shapes.Path)(target));
            return;
            case 3:
            this.path = ((System.Windows.Shapes.Path)(target));
            return;
            case 4:
            this.ButtonText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


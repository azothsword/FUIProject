﻿#pragma checksum "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B03831374B2BA44E5FC1BAFD4396FC50"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FUIProject_A.Controls.SimpleControls;
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


namespace FUIProject_A.Controls.SimpleControls {
    
    
    /// <summary>
    /// CommandContentItem
    /// </summary>
    public partial class CommandContentItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FUIProject_A.Controls.SimpleControls.CommandContentItem userControl;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle BackgroundRect;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CommandNameText;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PressCommandText;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReleaseCommandText;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FUIProject_A.Controls.SimpleControls.DeleteButtonType1 DeleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FUIProject_A;component/controls/simplecontrols/commandcontentitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.userControl = ((FUIProject_A.Controls.SimpleControls.CommandContentItem)(target));
            
            #line 8 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
            this.userControl.MouseEnter += new System.Windows.Input.MouseEventHandler(this.userControl_MouseEnter);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\..\Controls\SimpleControls\CommandContentItem.xaml"
            this.userControl.MouseLeave += new System.Windows.Input.MouseEventHandler(this.userControl_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackgroundRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.CommandNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PressCommandText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ReleaseCommandText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DeleteButton = ((FUIProject_A.Controls.SimpleControls.DeleteButtonType1)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


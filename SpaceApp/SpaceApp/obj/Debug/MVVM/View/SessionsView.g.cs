﻿#pragma checksum "..\..\..\..\MVVM\View\SessionsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "81CAF9A9BF3627827802243CA931188B7EB6B8778D48C80FC695785F934C1269"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SpaceApp.MVVM.View;
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


namespace SpaceApp.MVVM.View {
    
    
    /// <summary>
    /// SessionsView
    /// </summary>
    public partial class SessionsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\..\MVVM\View\SessionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl UserSessionView;
        
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
            System.Uri resourceLocater = new System.Uri("/SpaceApp;component/mvvm/view/sessionsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\SessionsView.xaml"
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
            
            #line 20 "..\..\..\..\MVVM\View\SessionsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserSessionView = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 26 "..\..\..\..\MVVM\View\SessionsView.xaml"
            this.UserSessionView.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnPreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\MVVM\View\SessionsView.xaml"
            this.UserSessionView.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.OnPreviewMouseMove);
            
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
            case 3:
            
            #line 36 "..\..\..\..\MVVM\View\SessionsView.xaml"
            ((System.Windows.Controls.Border)(target)).Drop += new System.Windows.DragEventHandler(this.OnDrop);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\MVVM\View\SessionsView.xaml"
            ((System.Windows.Controls.Border)(target)).DragEnter += new System.Windows.DragEventHandler(this.OnDragEnter);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\MVVM\View\SessionsView.xaml"
            ((System.Windows.Controls.Border)(target)).DragLeave += new System.Windows.DragEventHandler(this.OnDragLeave);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


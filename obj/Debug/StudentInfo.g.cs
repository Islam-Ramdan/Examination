﻿#pragma checksum "..\..\StudentInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F243CC279EF1AB9916DD536B80671B7254CBC761406D1A9BFC098C46147E6B8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExaminationSystem;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ExaminationSystem {
    
    
    /// <summary>
    /// StudentInfo
    /// </summary>
    public partial class StudentInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox studentName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button take_exame;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_exame;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_results;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_topics;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox intake;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox track;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\StudentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox branch;
        
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
            System.Uri resourceLocater = new System.Uri("/ExaminationSystem;component/studentinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentInfo.xaml"
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
            
            #line 8 "..\..\StudentInfo.xaml"
            ((ExaminationSystem.StudentInfo)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.studentName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 29 "..\..\StudentInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.take_exame = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\StudentInfo.xaml"
            this.take_exame.Click += new System.Windows.RoutedEventHandler(this.TakeExam);
            
            #line default
            #line hidden
            return;
            case 5:
            this.view_exame = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\StudentInfo.xaml"
            this.view_exame.Click += new System.Windows.RoutedEventHandler(this.ViewExam);
            
            #line default
            #line hidden
            return;
            case 6:
            this.view_results = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\StudentInfo.xaml"
            this.view_results.Click += new System.Windows.RoutedEventHandler(this.ViewResults);
            
            #line default
            #line hidden
            return;
            case 7:
            this.view_topics = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\StudentInfo.xaml"
            this.view_topics.Click += new System.Windows.RoutedEventHandler(this.ViewTopics);
            
            #line default
            #line hidden
            return;
            case 8:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.intake = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.track = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.branch = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


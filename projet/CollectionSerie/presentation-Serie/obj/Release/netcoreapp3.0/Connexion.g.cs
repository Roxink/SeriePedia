﻿#pragma checksum "..\..\..\Connexion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "560D1D717DE65DFA11ED2D606420534567D76FE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Connexion;
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


namespace Connexion {
    
    
    /// <summary>
    /// ConnexionWindow
    /// </summary>
    public partial class ConnexionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox identifiant;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox mdp;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Se_connecter;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LanceInscription;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Retour;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/presentation-Serie;component/connexion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Connexion.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.identifiant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.mdp = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Se_connecter = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Connexion.xaml"
            this.Se_connecter.Click += new System.Windows.RoutedEventHandler(this.Connexion);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LanceInscription = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Connexion.xaml"
            this.LanceInscription.Click += new System.Windows.RoutedEventHandler(this.Inscription);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Retour = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Connexion.xaml"
            this.Retour.Click += new System.Windows.RoutedEventHandler(this.FermerFenetreCo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "C:\Users\spahi\Desktop\SMTH GRUPA\Grupa10-CokoBananice\Projekat\Posta\View\OpcijeSalter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC7CEA8BC875160A9390BA1BAA85B301"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Posta.Forms
{
    partial class OpcijeSalter : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 2:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 28 "..\..\..\View\OpcijeSalter.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.bNaplataRacuna = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\View\OpcijeSalter.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bNaplataRacuna).Click += this.bNaplataRacuna_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.bRegistracijaPotrosaca = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\View\OpcijeSalter.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bRegistracijaPotrosaca).Click += this.bRegistracijaPotrosaca_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.bLogout = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\View\OpcijeSalter.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bLogout).Click += this.bLogOut_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


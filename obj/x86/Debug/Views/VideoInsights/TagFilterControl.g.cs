﻿#pragma checksum "C:\Users\v-caspch\Desktop\Microsoft\Kiosk\Views\VideoInsights\TagFilterControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "777532E20596A1768E05AFB2A36F1F90"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.VideoInsights
{
    partial class TagFilterControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    global::Windows.UI.Xaml.Controls.CheckBox element1 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 17 "..\..\..\..\Views\VideoInsights\TagFilterControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element1).Checked += this.TagFilterChanged;
                    #line 17 "..\..\..\..\Views\VideoInsights\TagFilterControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element1).Unchecked += this.TagFilterChanged;
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


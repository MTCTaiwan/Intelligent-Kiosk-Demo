﻿#pragma checksum "C:\Users\v-caspch\Desktop\Microsoft\Kiosk\Controls\ImageSearchUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0198DB9C57C8DDCCA3123F193E275B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class ImageSearchUserControl : 
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
                    this.SearchControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2:
                {
                    this.imageResultsGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 65 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.imageResultsGrid).SelectionChanged += this.OnImageResultSelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4:
                {
                    this.addSelectedPhotosButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 76 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.addSelectedPhotosButton).Click += this.OnAcceptButtonClicked;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element5 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 80 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element5).Click += this.OnCancelButtonClicked;
                    #line default
                }
                break;
            case 6:
                {
                    this.autoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 32 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggestBox).QuerySubmitted += this.onQuerySubmitted;
                    #line 32 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggestBox).TextChanged += this.onTextChanged;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.LoadImagesFromFileClicked;
                    #line default
                }
                break;
            case 8:
                {
                    this.cameraCaptureFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    #line 42 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.cameraCaptureFlyout).Opened += this.OnCameraFlyoutOpened;
                    #line 42 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.cameraCaptureFlyout).Closed += this.OnCameraFlyoutClosed;
                    #line default
                }
                break;
            case 9:
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                    #line 50 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::IntelligentKioskSample.Controls.CameraControl)this.cameraControl).ImageCaptured += this.OnCameraImageCaptured;
                    #line default
                }
                break;
            case 10:
                {
                    this.autoCaptureToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 53 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.autoCaptureToggle).Toggled += this.OnCameraAutoCaptureToggleChanged;
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


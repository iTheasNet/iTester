﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProj2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            BrowserWindow uIReleasereleasesRESTAWindow = this.UIReleasereleasesRESTAWindow;
            #endregion

            // Go to web page 'https://www.visualstudio.com/en-us/docs/integrate/api/rm/releases#get-a-release' using new browser instance
            this.UIReleasereleasesRESTAWindow.LaunchUrl(new System.Uri(this.RecordedMethod1Params.UIReleasereleasesRESTAWindowUrl));

            // Perform Close on Browser Window
            uIReleasereleasesRESTAWindow.Close();
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIReleasereleasesRESTAWindow UIReleasereleasesRESTAWindow
        {
            get
            {
                if ((this.mUIReleasereleasesRESTAWindow == null))
                {
                    this.mUIReleasereleasesRESTAWindow = new UIReleasereleasesRESTAWindow();
                }
                return this.mUIReleasereleasesRESTAWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIReleasereleasesRESTAWindow mUIReleasereleasesRESTAWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'https://www.visualstudio.com/en-us/docs/integrate/api/rm/releases#get-a-release' using new browser instance
        /// </summary>
        public string UIReleasereleasesRESTAWindowUrl = "https://www.visualstudio.com/en-us/docs/integrate/api/rm/releases#get-a-release";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIReleasereleasesRESTAWindow : BrowserWindow
    {
        
        public UIReleasereleasesRESTAWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Release releases | REST API Reference for Visual Studio Team Services and Team Fo" +
                "undation Serve";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Release releases | REST API Reference for Visual Studio Team Services and Team Fo" +
                    "undation Serve");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
    }
}

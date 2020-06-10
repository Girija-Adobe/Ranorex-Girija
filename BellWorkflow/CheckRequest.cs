﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace BellWorkflow
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckRequest recording.
    /// </summary>
    [TestModule("e6924be7-8aa4-4d71-9ed0-d18ff00431ce", ModuleType.Recording, 1)]
    public partial class CheckRequest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BellWorkflowRepository repository.
        /// </summary>
        public static BellWorkflowRepository repo = BellWorkflowRepository.Instance;

        static CheckRequest instance = new CheckRequest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckRequest()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckRequest Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AdobeAcrobatProDCTrunk05242020.ClickProfile' at 929;14.", repo.AdobeAcrobatProDCTrunk05242020.ClickProfileInfo, new RecordItemIndex(0));
            //repo.AdobeAcrobatProDCTrunk05242020.ClickProfile.Click("929;14");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(1));
            //Delay.Duration(30000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PressSignOutFromProfile.AVLAVView' at 344;157.", repo.PressSignOutFromProfile.AVLAVViewInfo, new RecordItemIndex(2));
            //repo.PressSignOutFromProfile.AVLAVView.Click("344;157");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PressSignOutFromProfile' at 529;181.", repo.PressSignOutFromProfile.SelfInfo, new RecordItemIndex(4));
            //repo.PressSignOutFromProfile.Self.Click("529;181");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SampleFilePdfOpenedFromAdobeDocume.AVLAVView'.", repo.SampleFilePdfOpenedFromAdobeDocume.AVLAVViewInfo, new RecordItemIndex(6));
            //Validate.Exists(repo.SampleFilePdfOpenedFromAdobeDocume.AVLAVViewInfo);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AdobeAcrobatProDCTrunk05242020.ClickProfile' at 1854;17.", repo.AdobeAcrobatProDCTrunk05242020.ClickProfileInfo, new RecordItemIndex(7));
            repo.AdobeAcrobatProDCTrunk05242020.ClickProfile.Click("1854;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(8));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PressSignOutFromProfile.AVLAVView' at 338;152.", repo.PressSignOutFromProfile.AVLAVViewInfo, new RecordItemIndex(9));
            repo.PressSignOutFromProfile.AVLAVView.Click("338;152");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PressSignOutFromProfile' at 523;180.", repo.PressSignOutFromProfile.SelfInfo, new RecordItemIndex(11));
            repo.PressSignOutFromProfile.Self.Click("523;180");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(12));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SampleFilePdfOpenedFromAdobeDocume.AVLAVView'.", repo.SampleFilePdfOpenedFromAdobeDocume.AVLAVViewInfo, new RecordItemIndex(13));
            Validate.Exists(repo.SampleFilePdfOpenedFromAdobeDocume.AVLAVViewInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

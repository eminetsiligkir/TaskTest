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

namespace TaskTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Case3 recording.
    /// </summary>
    [TestModule("1ac4ba66-b310-49d3-a6b8-edb2c73356d7", ModuleType.Recording, 1)]
    public partial class Case3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskTestRepository repository.
        /// </summary>
        public static TaskTestRepository repo = TaskTestRepository.Instance;

        static Case3 instance = new Case3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case3()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case3 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.EPosta' at 226;9.", repo.ApplicationUnderTest.LoginRegister.EPostaInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LoginRegister.EPosta.Click("226;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RegisterEmail' at 194;21.", repo.ApplicationUnderTest.RegisterEmailInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.RegisterEmail.Click("194;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RegisterEmail' at 53;21.", repo.ApplicationUnderTest.RegisterEmailInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.RegisterEmail.Click("53;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '   ' with focus on 'ApplicationUnderTest.RegisterEmail'.", repo.ApplicationUnderTest.RegisterEmailInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.RegisterEmail.PressKeys("   ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RegisterPasswordInput' at 48;15.", repo.ApplicationUnderTest.RegisterPasswordInputInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.RegisterPasswordInput.Click("48;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '   ' with focus on 'ApplicationUnderTest.RegisterPasswordInput'.", repo.ApplicationUnderTest.RegisterPasswordInputInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.RegisterPasswordInput.PressKeys("   ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.QButtonQButtonMediumQFluidQPrima' at 215;13.", repo.ApplicationUnderTest.LoginRegister.QButtonQButtonMediumQFluidQPrimaInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.LoginRegister.QButtonQButtonMediumQFluidQPrima.Click("215;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.LrContainer' at 398;128.", repo.ApplicationUnderTest.LoginRegister.LrContainerInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.LoginRegister.LrContainer.Click("398;128");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
///////////////////////////////////////////////////////////////////////////////
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
    ///The Case4 recording.
    /// </summary>
    [TestModule("24b1b983-59e8-48ea-8a6b-3e6acfb55013", ModuleType.Recording, 1)]
    public partial class Case4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskTestRepository repository.
        /// </summary>
        public static TaskTestRepository repo = TaskTestRepository.Instance;

        static Case4 instance = new Case4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case4 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.ButtonQButtonQButtonMediumQSecond' at 177;30.", repo.ApplicationUnderTest.LoginRegister.ButtonQButtonQButtonMediumQSecondInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LoginRegister.ButtonQButtonQButtonMediumQSecond.Click("177;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.ButtonLeftMr5QButtonQButtonMediu' at 153;24.", repo.ApplicationUnderTest.LoginRegister.ButtonLeftMr5QButtonQButtonMediuInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.LoginRegister.ButtonLeftMr5QButtonQButtonMediu.Click("153;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginEmail' at 104;11.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LoginEmail.Click("104;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginEmail' at 224;21.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LoginEmail.Click("224;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'eminetsiligkir{RShiftKey down}@{RShiftKey up}hotmail.com' with focus on 'ApplicationUnderTest.LoginEmail'.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.LoginEmail.PressKeys("eminetsiligkir{RShiftKey down}@{RShiftKey up}hotmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.LrContainer' at 29;180.", repo.ApplicationUnderTest.LoginRegister.LrContainerInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.LoginRegister.LrContainer.Click("29;180");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginPasswordInput' at 53;16.", repo.ApplicationUnderTest.LoginPasswordInputInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.LoginPasswordInput.Click("53;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Emis' with focus on 'ApplicationUnderTest.LoginPasswordInput'.", repo.ApplicationUnderTest.LoginPasswordInputInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.LoginPasswordInput.PressKeys("Emis");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad9}{NumPad9}{NumPad7}' with focus on 'ApplicationUnderTest.LoginPasswordInput'.", repo.ApplicationUnderTest.LoginPasswordInputInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.LoginPasswordInput.PressKeys("{NumPad1}{NumPad9}{NumPad9}{NumPad7}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.QButtonQButtonMediumQFluidQPrima1' at 250;19.", repo.ApplicationUnderTest.LoginRegister.QButtonQButtonMediumQFluidQPrima1Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.LoginRegister.QButtonQButtonMediumQFluidQPrima1.Click("250;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.StickyHeader' at 248;42.", repo.ApplicationUnderTest.StickyHeaderInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.StickyHeader.Click("248;42");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.StickyHeader' at 248;42.", repo.ApplicationUnderTest.StickyHeaderInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.StickyHeader.Click("248;42");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Trendyol' at 101;27.", repo.ApplicationUnderTest.TrendyolInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Trendyol.Click("101;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PrdctCntnrWrppr' at 58;68.", repo.ApplicationUnderTest.PrdctCntnrWrpprInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.PrdctCntnrWrppr.Click("58;68");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PrdctCntnrWrppr' at 13;327.", repo.ApplicationUnderTest.PrdctCntnrWrpprInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.PrdctCntnrWrppr.Click("13;327");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PrdctCntnrWrppr' at 107;4.", repo.ApplicationUnderTest.PrdctCntnrWrpprInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.PrdctCntnrWrppr.Click("107;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ApplicationUnderTest.SepeteEkle' at 84;0.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.SepeteEkle.MoveTo("84;0");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ApplicationUnderTest.SepeteEkle' at 437;-248.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.SepeteEkle.MoveTo("437;-248");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.StickyHeader' at 1679;41.", repo.ApplicationUnderTest.StickyHeaderInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.StickyHeader.Click("1679;41");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Sepetim' at 18;6.", repo.ApplicationUnderTest.SepetimInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Sepetim.Click("18;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PbHeaderWrapper' at 501;25.", repo.ApplicationUnderTest.PbHeaderWrapperInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.PbHeaderWrapper.Click("501;25");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

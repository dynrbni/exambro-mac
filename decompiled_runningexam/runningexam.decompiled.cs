using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Arthur_WorkstationService;
using ExamBrowser;
using ExamBrowser.Properties;
using Gma.UserActivityMonitor;
using JCS;
using LibraryExam;
using Microsoft.Win32;
using Newtonsoft.Json;
using adOHu8we2DAKJQKPHPY;
using uB0dasaFwqgBoPJXYHG;

[assembly: AssemblyTrademark("")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyProduct("ExamBrowser")]
[assembly: ComVisible(false)]
[assembly: SuppressIldasm]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Guid("7e8f8d5b-f681-444a-8e01-51ff6b9dbf5c")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyTitle("ExamBrowser")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyVersion("1.0.0.0")]
internal class <Module>
{
	private static bool f8DCB9BEC8A7A55C;

	internal static void m8DCB9BEC8A7A55C()
	{
		if (!f8DCB9BEC8A7A55C)
		{
			f8DCB9BEC8A7A55C = true;
			if (Math.Sign((DateTime.Now - new DateTime(2024, 8, 11)).Days) >= 14)
			{
				throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
			}
		}
	}

	static <Module>()
	{
		m8DCB9BEC8A7A55C();
	}
}
namespace ExamBrowser
{
	public class ValidasiExam
	{
		public static bool IsUserAdministrator()
		{
			try
			{
				WindowsIdentity current = WindowsIdentity.GetCurrent();
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
				return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch
			{
				return false;
			}
		}

		public static bool examServicesisRunning()
		{
			Process[] processesByName = Process.GetProcessesByName(JYC3AkacE3hrYs377xw.EWJ9xtjenL(-810996197 ^ -408459160 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783));
			if (processesByName.Length < 1)
			{
				return true;
			}
			return false;
		}

		public static int getDISPw()
		{
			return Screen.PrimaryScreen.Bounds.Width;
		}

		public static int getDISPh()
		{
			return Screen.PrimaryScreen.Bounds.Height;
		}

		public ValidasiExam()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			base..ctor();
		}
	}
	public class frmSplashScreen : Form
	{
		private IContainer nAAORMGRC;

		private PictureBox HHVudDkZL;

		private ProgressBar EZo0ElePS;

		public frmSplashScreen()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			nAAORMGRC = null;
			((Form)this)..ctor();
			Jwi7nkoR7();
		}

		private void HNrnmZT5Y(object P_0, EventArgs P_1)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && nAAORMGRC != null)
			{
				nAAORMGRC.Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void Jwi7nkoR7()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected Obj, but got Unknown
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSplashScreen));
			HHVudDkZL = new PictureBox();
			EZo0ElePS = new ProgressBar();
			((ISupportInitialize)HHVudDkZL).BeginInit();
			((Control)this).SuspendLayout();
			HHVudDkZL.Image = Resources.kemdikbud2;
			((Control)HHVudDkZL).Location = new Point(1, 1);
			((Control)HHVudDkZL).Margin = new Padding(4);
			((Control)HHVudDkZL).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x759926FA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8);
			((Control)HHVudDkZL).Size = new Size(668, 517);
			HHVudDkZL.TabIndex = 0;
			HHVudDkZL.TabStop = false;
			((Control)HHVudDkZL).Click += HNrnmZT5Y;
			((Control)EZo0ElePS).Location = new Point(1, 519);
			((Control)EZo0ElePS).Margin = new Padding(4);
			EZo0ElePS.MarqueeAnimationSpeed = 50;
			((Control)EZo0ElePS).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A56276B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b);
			((Control)EZo0ElePS).Size = new Size(668, 32);
			EZo0ElePS.Style = (ProgressBarStyle)2;
			((Control)EZo0ElePS).TabIndex = 1;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 16f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(671, 559);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)EZo0ElePS);
			((Control)this).Controls.Add((Control)(object)HHVudDkZL);
			((Form)this).FormBorderStyle = (FormBorderStyle)0;
			((Form)this).Icon = (Icon)componentResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBDEBF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa));
			((Form)this).Margin = new Padding(4);
			((Control)this).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A562737 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b);
			((Form)this).StartPosition = (FormStartPosition)1;
			((Control)this).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B8AC25 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e);
			((ISupportInitialize)HHVudDkZL).EndInit();
			((Control)this).ResumeLayout(false);
		}
	}
	public class Form_Main : Form
	{
		private class z9itntasNv3YqSfuuiD
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string Ejsaq2Ho5T;

			[SpecialName]
			[CompilerGenerated]
			public string NvRa5RpuPq()
			{
				return Ejsaq2Ho5T;
			}

			[SpecialName]
			[CompilerGenerated]
			public void IStaA2cSHC(string P_0)
			{
				Ejsaq2Ho5T = P_0;
			}

			public z9itntasNv3YqSfuuiD()
			{
				rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
				base..ctor();
			}
		}

		private struct y5XwdGa8aAlGgUeaNsO
		{
			public string df6arN5XC8;

			public bool W77ayYU37D;
		}

		private struct Vh1hP7aoTJDq9iaMq9j
		{
			public y5XwdGa8aAlGgUeaNsO[] c0eaPeIqpy;

			public bool vGdaQlmeG3;
		}

		private struct uy6bVrabq4Wq3oZdwag
		{
			public bool ISZafpYNNx;

			public string lBaavdxcBA;
		}

		private class WsDk6oalHMUyJULU5M6
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string gT4aeEHktI;

			[SpecialName]
			[CompilerGenerated]
			public string f1IaZ0nACn()
			{
				return gT4aeEHktI;
			}

			[SpecialName]
			[CompilerGenerated]
			public void hWHadak1QH(string P_0)
			{
				gT4aeEHktI = P_0;
			}

			public WsDk6oalHMUyJULU5M6()
			{
				rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
				base..ctor();
			}
		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass99_0
		{
			public uint HSMaJC38UV;

			public <>c__DisplayClass99_0()
			{
				rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
				base..ctor();
			}

			internal bool cVuaLGPrH7(Process p)
			{
				return p.Id == HSMaJC38UV;
			}
		}

		private List<string> RWxSBltSe;

		private Vh1hP7aoTJDq9iaMq9j[] J53em9Ugh;

		private y5XwdGa8aAlGgUeaNsO[] JXKNWS0nY;

		private bool NIF3t3iZQ;

		private bool INrtaMfal;

		private bool HINLj3c09;

		private string N3yJMoF5B;

		private string s8GWqcN3S;

		private bool d0t6WejyR;

		private int fqaMi9cJu;

		private FilterInfoCollection TReX35cHD;

		private IContainer hpPcaNPXA;

		private StatusStrip KPBFdGLyt;

		private ToolStripStatusLabel S32hENGyX;

		private MenuStrip sT81F1fsy;

		private ToolStripMenuItem T6DD9TCde;

		private ToolStripMenuItem epUibJmRb;

		private Button wGMEIaLID;

		private Timer sVxkWoDgk;

		private Timer BD5mWD5un;

		private TextBox Y9h4oIeeA;

		private ToolStripProgressBar Bn2YjYLe1;

		private ToolStripMenuItem uPGU53FQu;

		private ToolStripStatusLabel bE3z10JZE;

		private Timer IejRTnkyvy;

		private Timer jC0RRfqE6m;

		private Timer II6RGNCTBs;

		private BackgroundWorker Ai9RaJglcB;

		private GroupBox N9nR9FsOSX;

		private Label qM8RwQD6dH;

		private Label quIRHKqem7;

		private Label QKoRV1j9m9;

		private Label gIhRBvEZ9V;

		private Label vnvRx5JIT8;

		private Label yMSRCwWChl;

		private Label YrTRg8KGen;

		private Label BxGR25NLmv;

		private Label vMYRnwwOL7;

		private Label BRLR7sE197;

		private Label tyqROHe9uN;

		private Label nWrRus5pxy;

		private Label uEAR0XQY4R;

		private Label uPORjYUcSL;

		private Label BWcRpC4PDV;

		private Label lrZRKgoV3Z;

		private PictureBox dNmRsq79qF;

		private PictureBox pA8R5DRioF;

		private PictureBox SRnRAFrErN;

		private PictureBox MIPRIn5Qn6;

		private PictureBox rwRRqVfJ3c;

		private PictureBox oikR8nhTSr;

		private PictureBox tKcRrW3BPt;

		private PictureBox FotRyAbsQc;

		private PictureBox piQRok3dUd;

		private PictureBox GoWRPingpk;

		private PictureBox r09RQ2hCq1;

		private PictureBox EYlRbTVKbU;

		private PictureBox OgvRfcFKjn;

		private PictureBox D9aRvBf5F4;

		private PictureBox UugRlCCWk1;

		private PictureBox rrIRZedMQ6;

		private PictureBox ryCRdQjIcx;

		private Timer DlgRSLrT2l;

		private Desktop gdjRehgWww;

		private Desktop HqrRN6E40H;

		private Desktop HCUR3rjigK;

		private int LXHRt0Eoqg;

		private Label oBcRLneGV7;

		private PictureBox XRSRJ0vnXd;

		private Label ldARWRuNr2;

		private ComboBox uvMR6AlYFP;

		private static string KhoRMgf9fF;

		public string usbcamera
		{
			get
			{
				return KhoRMgf9fF;
			}
			set
			{
				KhoRMgf9fF = value;
			}
		}

		public Form_Main()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected I4, but got Unknown
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			gdjRehgWww = Desktop.GetCurrent();
			HqrRN6E40H = Desktop.OpenInputDesktop();
			HCUR3rjigK = Desktop.CreateDesktop(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB1BA1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4));
			LXHRt0Eoqg = 1;
			((Form)this)..ctor();
			Process[] processesByName = Process.GetProcessesByName(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DA896 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2));
			if (processesByName.Length > 1)
			{
				string text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475AD8C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b);
				GetConfigure.Writer(text);
				SetMessage(text);
				int num = (int)MessageBox.Show(text, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
				return;
			}
			Thread thread = new Thread(StartSplash);
			thread.Start();
			Thread.Sleep(2000);
			bSlZUCi2O();
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696B8F3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c));
			Detailspek();
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA4836 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3));
			getListCameraUSB();
			thread.Abort();
		}

		private void o1njIU9gi(object P_0, EventArgs P_1)
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected I4, but got Unknown
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected Obj, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
			HINLj3c09 = false;
			((Control)this).Focus();
			((Control)this).Show();
			GBKs34g8Z();
			if (!ValidasiExam.IsUserAdministrator())
			{
				string text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AE81B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1);
				GetConfigure.Writer(text);
				SetMessage(text);
				int num = (int)MessageBox.Show(text, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
				((Form)this).Close();
			}
			string location = Assembly.GetEntryAssembly().Location;
			string tempPath = Path.GetTempPath();
			if (quYKJc4LV(location, tempPath))
			{
				string text2 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B8ADBB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e);
				MessageBox.Show((IWin32Window)new Form
				{
					TopMost = true
				}, text2, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
				GetConfigure.Writer(text2);
				Application.Exit();
			}
		}

		private void NntpREBBp(object P_0, FormClosingEventArgs P_1)
		{
			if (((Control)wGMEIaLID).Tag.ToString() == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AB0E8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08))
			{
				SetMessage(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE916A2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed));
				((CancelEventArgs)(object)P_1).Cancel = true;
			}
		}

		public void StartSplash()
		{
			Application.Run((Form)(object)new frmSplashScreen());
		}

		private static bool quYKJc4LV(string P_0, string P_1)
		{
			string directoryName = Path.GetDirectoryName(P_0);
			string text = Directory.GetParent(Directory.GetParent(directoryName)?.FullName)?.FullName;
			string text2 = Directory.GetParent(P_1)?.FullName;
			return text.ToUpper().Contains(text2.ToUpper());
		}

		private void GBKs34g8Z()
		{
			GetConfigure getConfigure = new GetConfigure();
			if (getConfigure.ReadConfig(Load_List: false).activecamera.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6512248F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb)))
			{
				((Control)this).Height = 580;
			}
			else
			{
				((Control)this).Height = 530;
			}
			Timer bD5mWD5un = BD5mWD5un;
			bool enabled = (((Control)Y9h4oIeeA).Visible = false);
			bD5mWD5un.Enabled = enabled;
			((ToolStripItem)S32hENGyX).Text = "";
			RWxSBltSe = new List<string>();
			((ToolStripItem)Bn2YjYLe1).Visible = false;
		}

		public void SetMessage(string str)
		{
			((ToolStripItem)S32hENGyX).Text = str;
			sVxkWoDgk.Enabled = true;
		}

		private Form_Password.IsPasswordValid_result b6M57dRV9()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected I4, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			Form_Password.IsPasswordValid_result result = default;
			Form_Password form_Password = new Form_Password();
			((Form)form_Password).Opacity = 1.0;
			int num = (int)((Form)form_Password).ShowDialog();
			if ((int)((Form)form_Password).DialogResult == 1)
			{
				return form_Password.IsPasswordValid();
			}
			return result;
		}

		public static void TulisLog(string logMessage)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected I4, but got Unknown
			try
			{
				File.AppendAllText(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8717959 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd), logMessage + Environment.NewLine);
			}
			catch (Exception ex)
			{
				int num = (int)MessageBox.Show(ex.Message, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
			}
		}

		private void hfvAT0mnu(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void UJmIYtnFx(object P_0, EventArgs P_1)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			Form_Password.IsPasswordValid_result isPasswordValid_result = b6M57dRV9();
			Form_Settings form_Settings = new Form_Settings();
			if (isPasswordValid_result.valid && isPasswordValid_result.isadmin)
			{
				form_Settings.setFormTag(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A5624C7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b));
				((Form)form_Settings).ShowDialog();
			}
			else if (isPasswordValid_result.valid && !isPasswordValid_result.isadmin)
			{
				form_Settings.setFormTag(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D034E5F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18));
				((Form)form_Settings).ShowDialog();
			}
			else if (!isPasswordValid_result.valid && !isPasswordValid_result.isadmin)
			{
				MessageBox.Show(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F8664F9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e), "", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			}
		}

		private void OAfqUeaTV(object P_0, EventArgs P_1)
		{
			//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected I4, but got Unknown
			//IL_093c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0941: Unknown result type (might be due to invalid IL or missing references)
			//IL_0943: Unknown result type (might be due to invalid IL or missing references)
			//IL_0946: Invalid comparison between Unknown and I4
			//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca8: Expected I4, but got Unknown
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected I4, but got Unknown
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected I4, but got Unknown
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected I4, but got Unknown
			//IL_0593: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Expected I4, but got Unknown
			//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0605: Expected I4, but got Unknown
			//IL_0658: Unknown result type (might be due to invalid IL or missing references)
			//IL_065f: Expected I4, but got Unknown
			//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Expected I4, but got Unknown
			//IL_0720: Unknown result type (might be due to invalid IL or missing references)
			//IL_0727: Expected I4, but got Unknown
			string text = "";
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			if (((Control)wGMEIaLID).Tag.ToString() == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x10D46A95 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f))
			{
				if (!qATbVOKyM() || !HeMfjAI6P())
				{
					return;
				}
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA4A96 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3));
				GetConfigure.KillAllBrowser();
				if (Convert.ToString(OSVersionInfo.OSBits).Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4765 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6)))
				{
					text = appConfig.has64;
				}
				else if (Convert.ToString(OSVersionInfo.OSBits).Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B8A861 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e)))
				{
					text = appConfig.has32;
				}
				try
				{
					if (Convert.ToInt32(appConfig.ModeUjian) == 1)
					{
						string text2 = appConfig.SemiUrl + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20D177 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
						IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
						string[] array = new string[addressList.Length];
						bool flag = false;
						for (int i = 0; i < addressList.Length; i++)
						{
							array[i] = addressList[i].ToString();
							string value = array[i].Substring(0, array[i].LastIndexOf(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD67C44 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3)));
							flag = text2.Contains(value);
							if (flag)
							{
								N3yJMoF5B = array[i];
								s8GWqcN3S = N3yJMoF5B;
								break;
							}
						}
						if (addressList.Length == 0 || !flag)
						{
							string text3 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD67C42 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
							SetMessage(text3);
							GetConfigure.Writer(text3);
							int num = (int)MessageBox.Show(text3, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
					}
					if (Convert.ToInt32(appConfig.ModeUjian) == 1)
					{
						WorkstationService workstationService = new WorkstationService();
						workstationService.Url = appConfig.SemiUrl + GetConfigure.urlservicesvhd;
						string url = workstationService.Url;
						ServicePointManager.ServerCertificateValidationCallback = (object param0, X509Certificate param1, X509Chain param2, SslPolicyErrors param3) => true;
						CBTResponse dataLove2Server = workstationService.GetDataLove2Server();
						GetConfigure.Writer((dataLove2Server.Result ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x75992250 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1089798187 ^ -1964913853 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79)) + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4785 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6));
						if (!dataLove2Server.Result)
						{
							SetMessage(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF9A16 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d));
							string text4 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF9BE2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
							GetConfigure.Writer(text4);
							int num2 = (int)MessageBox.Show(text4, "", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
							return;
						}
						string message = dataLove2Server.Message;
					}
				}
				catch (Exception ex)
				{
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1889902134 ^ -110352252 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b) + ex.Message);
					string text5 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x31363307 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b) + N3yJMoF5B + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E43C9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
					SetMessage(text5);
					int num3 = (int)MessageBox.Show(text5, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				if (ValidasiExam.getDISPw() < appConfig.validwidth || ValidasiExam.getDISPh() < appConfig.validheight)
				{
					string text6 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475AB58 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b);
					GetConfigure.Writer(text6);
					SetMessage(text6);
					int num4 = (int)MessageBox.Show(text6, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				if (Screen.AllScreens.Length > GetConfigure.jmlscreenmax || Nathivemetode.DetectDisplaySettings() > GetConfigure.jmlscreenmax)
				{
					string text7 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB6369A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
					GetConfigure.Writer(text7);
					SetMessage(text7);
					int num5 = (int)MessageBox.Show(text7, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				if (Convert.ToInt32(appConfig.ModeUjian) == 1 && ValidasiApps.CheckInternetPusmenjar())
				{
					string text8 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB63716 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
					GetConfigure.Writer(text8);
					SetMessage(text8);
					int num6 = (int)MessageBox.Show(text8, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				if (Registrydata.IsRemoteSession())
				{
					string text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8717D01 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
					GetConfigure.Writer(text9);
					SetMessage(text9);
					int num7 = (int)MessageBox.Show(text9, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				if (ValidasiApps.GetChecksum(GetConfigure.osversionfile) != ValidasiApps.osversionreal())
				{
					string text10 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC07D5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
					GetConfigure.Writer(text10);
					SetMessage(text10);
					int num8 = (int)MessageBox.Show(text10, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				if (!(ValidasiApps.GetChecksum(GetConfigure.elekBrowserFile) != text))
				{
					try
					{
						Registrydata.ChangeRegistry();
					}
					catch
					{
						GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x40A393BF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9));
					}
					try
					{
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4BAB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6), writable: true);
						if (ValidasiApps.getDenyConnection())
						{
							registryKey.SetValue(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18AD900B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361), 1, RegistryValueKind.DWord);
							GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB63920 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4));
						}
					}
					catch
					{
						GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC060F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f));
					}
					if (appConfig.activecamera.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAE38F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8)))
					{
						try
						{
							Form_Settings.saveCam(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C541F85 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8), Convert.ToString(((ListControl)uvMR6AlYFP).SelectedIndex));
						}
						catch
						{
							GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425D9B6D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a));
						}
					}
					if (appConfig.activecamera.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B4F40 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f)) && ((ListControl)uvMR6AlYFP).SelectedIndex != -1)
					{
						string text11 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C541FD7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8);
						DialogResult val = MessageBox.Show(text11, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D3FC7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0), (MessageBoxButtons)4);
						if ((int)val == 6)
						{
							LXHRt0Eoqg = 1;
						}
						else
						{
							LXHRt0Eoqg = 1;
							GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45E9457 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5));
						}
					}
					try
					{
						GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475A14A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b));
						GetConfigure.KillAllBrowser();
						if (appConfig.bukadesktop.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4007 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6)))
						{
							HCUR3rjigK.Show();
							Desktop.CreateProcess(GetConfigure.examServiceFile, JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1089798187 ^ -600953557 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10));
							GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425D9D45 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a));
							if (appConfig.activecamera.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AB0E8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08)) && LXHRt0Eoqg == 1 && ((ListControl)uvMR6AlYFP).SelectedIndex != -1)
							{
								Desktop.CreateProcess(GetConfigure.cameraFile, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425D91FB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a));
								GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE9198C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed));
							}
						}
						else
						{
							TerminateExplorer();
							Process.Start(GetConfigure.examServiceFile);
							GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE919D8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed));
							if (appConfig.activecamera.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65E3C722 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea)) && LXHRt0Eoqg == 1 && ((ListControl)uvMR6AlYFP).SelectedIndex != -1)
							{
								Process.Start(GetConfigure.cameraFile);
								GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DA456 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2));
							}
						}
						if (ValidasiExam.examServicesisRunning())
						{
							GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD51815 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd));
							if (appConfig.bukadesktop.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD67B4E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3)))
							{
								Desktop.Show(gdjRehgWww.DesktopName);
								GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D387F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0));
								Desktop.SetCurrent(gdjRehgWww);
								HCUR3rjigK.Close();
							}
							StartExplore();
							string text12 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18AD95A9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361);
							GetConfigure.Writer(text12);
							SetMessage(text12);
							int num9 = (int)MessageBox.Show(text12, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						}
						else
						{
							((Control)wGMEIaLID).Tag = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AB0E8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08);
							((Control)wGMEIaLID).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C1BBA37 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83);
							((Control)wGMEIaLID).BackColor = Color.Gainsboro;
							((Control)wGMEIaLID).ForeColor = Color.Green;
							((ToolStripItem)epUibJmRb).Enabled = false;
							((Form)this).Opacity = 0.75;
							II6RGNCTBs.Enabled = true;
							Taskbar.Hide();
							if (appConfig.DebugMode != JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20D609 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca))
							{
								((Control)this).SendToBack();
							}
							DlgRSLrT2l.Enabled = true;
						}
						return;
					}
					catch (Exception ex2)
					{
						SetMessage(ex2.Message);
						GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x40A3964B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9) + ex2.Message);
						return;
					}
				}
				string text13 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB134D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4);
				GetConfigure.Writer(text13);
				SetMessage(text13);
				int num10 = (int)MessageBox.Show(text13, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
			}
			else if (((Control)wGMEIaLID).Tag.ToString() == JYC3AkacE3hrYs377xw.EWJ9xtjenL(--489335283 ^ 0xAA9D87 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd))
			{
				((Control)wGMEIaLID).Click -= OAfqUeaTV;
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF9380 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d));
			}
			else
			{
				((Control)wGMEIaLID).Tag = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B4FD8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
				((Control)wGMEIaLID).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x43B0D809 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb4c51c87e664f2a80b08fdc8c7d117f);
				try
				{
					((Control)wGMEIaLID).ForeColor = Color.CornflowerBlue;
				}
				catch (Exception ex3)
				{
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD67596 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3) + ex3.Message);
				}
				((ToolStripItem)epUibJmRb).Enabled = true;
				((Form)this).Opacity = 1.0;
				Taskbar.Show();
				GetConfigure.KillAllBrowser();
				((Control)this).BringToFront();
				Registrydata.ResetRegistry();
				if (appConfig.bukadesktop.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x40A3983B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9)))
				{
					Desktop.Show(gdjRehgWww.DesktopName);
					Desktop.SetCurrent(gdjRehgWww);
					HCUR3rjigK.Close();
				}
				StartExplore();
				II6RGNCTBs.Enabled = false;
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C1BBACB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83));
			}
		}

		private void DvK8XsCKV(object P_0, EventArgs P_1)
		{
			((ToolStripItem)S32hENGyX).Text = "";
			sVxkWoDgk.Enabled = false;
		}

		private void VYura9jwJ(object P_0, EventArgs P_1)
		{
			try
			{
				((Control)Y9h4oIeeA).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBD0E9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa) + Environment.NewLine;
				for (int i = 0; i < RWxSBltSe.Count; i++)
				{
					((TextBoxBase)Y9h4oIeeA).AppendText(RWxSBltSe[i] + Environment.NewLine);
				}
				TextBox y9h4oIeeA = Y9h4oIeeA;
				string text = ((Control)y9h4oIeeA).Text + Environment.NewLine + Environment.NewLine;
				((Control)y9h4oIeeA).Text = text;
				TextBox y9h4oIeeA2 = Y9h4oIeeA;
				string text2 = ((Control)y9h4oIeeA2).Text + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D68C50 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711) + Environment.NewLine;
				((Control)y9h4oIeeA2).Text = text2;
				for (int j = 0; j < J53em9Ugh.Length; j++)
				{
					if (J53em9Ugh[j].vGdaQlmeG3)
					{
						string text3 = "";
						for (int k = 0; k < J53em9Ugh[j].c0eaPeIqpy.Length; k++)
						{
							text3 = text3 + ((k == 0) ? "" : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D3A87 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0)) + J53em9Ugh[j].c0eaPeIqpy[k].df6arN5XC8;
						}
						TextBox y9h4oIeeA3 = Y9h4oIeeA;
						string text4 = ((Control)y9h4oIeeA3).Text + text3 + Environment.NewLine;
						((Control)y9h4oIeeA3).Text = text4;
					}
				}
				TextBox y9h4oIeeA4 = Y9h4oIeeA;
				string text5 = ((Control)y9h4oIeeA4).Text + Environment.NewLine + Environment.NewLine;
				((Control)y9h4oIeeA4).Text = text5;
				TextBox y9h4oIeeA5 = Y9h4oIeeA;
				string text6 = ((Control)y9h4oIeeA5).Text + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB3E72 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79) + INrtaMfal + Environment.NewLine;
				((Control)y9h4oIeeA5).Text = text6;
			}
			catch (Exception ex)
			{
				string message = ex.Message;
			}
		}

		private void v3gyuQiN4(object P_0, EventArgs P_1)
		{
			try
			{
				((ToolStripItem)bE3z10JZE).Text = (((ToolStripItem)bE3z10JZE).Text + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF908C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d)).Substring(1, 10);
			}
			catch
			{
			}
		}

		private void JMlo8LnXY(object P_0, EventArgs P_1)
		{
			if (!Ai9RaJglcB.IsBusy)
			{
				Ai9RaJglcB.RunWorkerAsync();
			}
		}

		private void MpMPlucRT(object P_0, DoWorkEventArgs P_1)
		{
			Process[] processesByName = Process.GetProcessesByName(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76364C2E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b));
			if (processesByName.Length < 1)
			{
				Taskbar.Show();
				Desktop.Show(gdjRehgWww.DesktopName);
				Desktop.SetCurrent(gdjRehgWww);
				HqrRN6E40H.Show();
				HCUR3rjigK.Close();
				StartExplore();
				Registrydata.ResetRegistry();
				GetConfigure.KillAllBrowser();
				((Control)wGMEIaLID).Tag = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C6520D9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
				((Control)wGMEIaLID).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228F39F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
				((ToolStripItem)epUibJmRb).Enabled = true;
				((Form)this).Opacity = 1.0;
				II6RGNCTBs.Enabled = false;
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4D35 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6));
				Application.Exit();
			}
		}

		private void f6iQQx1tr(object P_0, EventArgs P_1)
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected I4, but got Unknown
			if (Screen.AllScreens.Length > GetConfigure.jmlscreenmax || Nathivemetode.DetectDisplaySettings() > GetConfigure.jmlscreenmax)
			{
				GetConfigure.KillAllBrowser();
				Taskbar.Show();
				NIF3t3iZQ = true;
				d0t6WejyR = true;
				string text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBD82D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa);
				GetConfigure.Writer(text);
				SetMessage(text);
				int num = (int)MessageBox.Show(text, "", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
			}
		}

		private bool qATbVOKyM()
		{
			return true;
		}

		private bool HeMfjAI6P()
		{
			return true;
		}

		private void iNlvuSI1Z(object P_0, EventArgs P_1)
		{
			fqaMi9cJu = Process.GetProcessesByName(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x12B396DF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_5d9c2c0b2f574c878b1c78cf0baed81d)).Length;
			DlgRSLrT2l.Enabled = false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && hpPcaNPXA != null)
			{
				hpPcaNPXA.Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		public void getListCameraUSB()
		{
			TReX35cHD = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			int count = TReX35cHD.Count;
			if (TReX35cHD.Count == 0)
			{
				return;
			}
			foreach (FilterInfo item in TReX35cHD)
			{
				uvMR6AlYFP.Items.Add((object)item.Name);
			}
			((ListControl)uvMR6AlYFP).SelectedIndex = count - 1;
		}

		public void TerminateExplorer()
		{
			<>c__DisplayClass99_0 CS$<>8__locals4 = new <>c__DisplayClass99_0();
			Process[] processesByName = Process.GetProcessesByName(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE91B3E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed));
			CS$<>8__locals4.HSMaJC38UV = Nathivemetode.GetShellProcessId();
			Process process = processesByName.FirstOrDefault((Process p) => p.Id == CS$<>8__locals4.HSMaJC38UV);
			if (process != null)
			{
				Nathivemetode.PostCloseMessageToShell();
				int num = 0;
				while (Nathivemetode.GetShellWindowHandle() != IntPtr.Zero && num < 3000)
				{
					Thread.Sleep(20);
					num += 20;
				}
				process.WaitForExit(3000);
				process.Refresh();
				if (!process.HasExited)
				{
					c4tlp8rwn(process.Id);
				}
				process.Refresh();
				if (process.HasExited)
				{
					GetConfigure.Writer(string.Format(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C5175 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf), CS$<>8__locals4.HSMaJC38UV));
				}
				else
				{
					GetConfigure.Writer(string.Format(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228F167 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f), CS$<>8__locals4.HSMaJC38UV));
				}
				process.Close();
			}
			else
			{
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696B609 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c));
			}
		}

		private void c4tlp8rwn(int P_0)
		{
			Process process = new Process();
			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C65335D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50));
			string environmentVariable = Environment.GetEnvironmentVariable(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C5405EF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8));
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD50411 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd));
			process.StartInfo.Arguments = string.Format(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D802824 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd), P_0);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.WorkingDirectory = environmentVariable;
			process.Start();
			process.WaitForExit();
		}

		public void StartExplore()
		{
			Process process = new Process();
			string environmentVariable = Environment.GetEnvironmentVariable(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B5C78 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f));
			string fileName = Path.Combine(environmentVariable, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F867609 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e));
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AF8F1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1));
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WorkingDirectory = environmentVariable;
			process.Start();
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFEB10C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83));
			while (Nathivemetode.GetShellWindowHandle() == IntPtr.Zero)
			{
				Thread.Sleep(20);
			}
			process.Refresh();
			GetConfigure.Writer(string.Format(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x651235C5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb), process.Id));
			process.Close();
		}

		public void Detailspek()
		{
			//IL_0702: Unknown result type (might be due to invalid IL or missing references)
			//IL_0709: Expected Obj, but got Unknown
			//IL_085f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0866: Expected Obj, but got Unknown
			//IL_098a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0991: Expected Obj, but got Unknown
			//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a93: Expected Obj, but got Unknown
			//IL_10d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_10da: Expected Obj, but got Unknown
			//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b93: Expected Obj, but got Unknown
			//IL_1241: Unknown result type (might be due to invalid IL or missing references)
			//IL_1248: Expected Obj, but got Unknown
			//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c93: Expected Obj, but got Unknown
			//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e0: Expected Obj, but got Unknown
			//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da0: Expected Obj, but got Unknown
			//IL_162b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1632: Expected Obj, but got Unknown
			//IL_13ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b5: Expected Obj, but got Unknown
			//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa9: Expected Obj, but got Unknown
			//IL_1747: Unknown result type (might be due to invalid IL or missing references)
			//IL_174e: Expected Obj, but got Unknown
			//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b83: Expected Obj, but got Unknown
			//IL_1875: Unknown result type (might be due to invalid IL or missing references)
			//IL_187c: Expected Obj, but got Unknown
			string text = "";
			DateTimeOffset dateTimeOffset = DateTimeOffset.Parse(ValidasiApps.TimeValidasi.Tanggal());
			string text2 = Convert.ToString(OSVersionInfo.OSBits);
			Form_Settings.createsharing();
			string checksum = ValidasiApps.GetChecksum(GetConfigure.osversionfile);
			string checksum2 = ValidasiApps.GetChecksum(GetConfigure.elekBrowserFile);
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			if (text2.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA4D56 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3)))
			{
				text = appConfig.has64.ToString();
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x43B0C7EB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb4c51c87e664f2a80b08fdc8c7d117f));
			}
			else if (text2.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AB784 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08)))
			{
				text = appConfig.has32.ToString();
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB622F2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4));
			}
			if (Convert.ToInt32(appConfig.ModeUjian) == 1)
			{
				((Control)ldARWRuNr2).Location = new Point(130, 15);
				((Control)ldARWRuNr2).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D690AE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711);
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696AB07 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c));
			}
			else
			{
				((Control)ldARWRuNr2).Location = new Point(173, 15);
				((Control)ldARWRuNr2).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76365F16 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b);
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20C7B3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca));
			}
			((Control)this).Text = appConfig.namaApps;
			((ToolStripItem)uPGU53FQu).Text = appConfig.versiexam + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC2976 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7) + appConfig.OSType + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x759935A8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8);
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA5A0A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3));
			((Control)yMSRCwWChl).Text = OSVersionInfo.Name + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C500D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6) + OSVersionInfo.Edition + JYC3AkacE3hrYs377xw.EWJ9xtjenL(--489335283 ^ 0xF9922DE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_5d9c2c0b2f574c878b1c78cf0baed81d) + OSVersionInfo.ServicePack + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76365F66 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b) + OSVersionInfo.OSBits;
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFEB310 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83));
			((Control)quIRHKqem7).Text = ValidasiApps.getRAMsize() + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E5591 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAF321 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8));
			((Control)gIhRBvEZ9V).Text = ValidasiApps.getPROC();
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3C851 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2));
			((Control)tyqROHe9uN).Text = ValidasiExam.getDISPw() + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C572F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6) + ValidasiExam.getDISPh();
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7636585E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b));
			((Control)YrTRg8KGen).Text = ValidasiApps.getSOUND();
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20C1FB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca));
			((Control)BWcRpC4PDV).Text = DateTime.Now.ToString(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18AD8DB7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361), new CultureInfo(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8716FDB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd)));
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB0E35 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4));
			oikR8nhTSr.Image = Resources.ceklis;
			piQRok3dUd.Image = Resources.ceklis;
			GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D69726 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711));
			try
			{
				string text3 = "";
				string text4 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F866401 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e);
				string text5 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC443AE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2);
				string text6 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(-810996197 ^ -1315605820 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
				string text7 = "";
				string text8 = "";
				string text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA4A34 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3);
				if (appConfig.activecamera.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x10D46A0D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f)))
				{
					((Control)oBcRLneGV7).Visible = true;
					((Control)XRSRJ0vnXd).Visible = true;
					((Control)uvMR6AlYFP).Visible = true;
					((Control)N9nR9FsOSX).Size = new Size(510, 430);
					((Control)wGMEIaLID).Location = new Point(12, 463);
					TReX35cHD = new FilterInfoCollection(FilterCategory.VideoInputDevice);
					if (TReX35cHD.Count != 0)
					{
						OgvRfcFKjn.Image = Resources.ceklis;
						text8 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC443AE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2);
					}
					else
					{
						OgvRfcFKjn.Image = Resources.ceklis;
						text8 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF9DA4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
						ToolTip val = new ToolTip();
						val.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD66DDA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
						val.IsBalloon = true;
						val.ShowAlways = true;
						val.SetToolTip((Control)(object)OgvRfcFKjn, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F8672B3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e));
					}
				}
				else
				{
					((Control)oBcRLneGV7).Visible = false;
					((Control)XRSRJ0vnXd).Visible = false;
					((Control)uvMR6AlYFP).Visible = false;
					((Control)N9nR9FsOSX).Size = new Size(510, 385);
					((Control)wGMEIaLID).Location = new Point(12, 415);
					text8 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF9DA4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
				}
				if (DateTime.Now.ToString(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C5403DB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8)) != dateTimeOffset.ToString(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45E89CB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5)))
				{
					EYlRbTVKbU.Image = Resources.silang;
					ToolTip val2 = new ToolTip();
					val2.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E53A5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
					val2.IsBalloon = true;
					val2.ShowAlways = true;
					val2.SetToolTip((Control)(object)EYlRbTVKbU, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DBE66 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2));
					text7 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1696630615 ^ 0x10B9A26B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8);
				}
				else
				{
					EYlRbTVKbU.Image = Resources.ceklis;
					text7 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC0CF7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
				}
				if (OSVersionInfo.Name == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6351B4EF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80) && appConfig.validwin10.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C6520D9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50)))
				{
					FotRyAbsQc.Image = Resources.silang;
					ToolTip val3 = new ToolTip();
					val3.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6351B675 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
					val3.IsBalloon = true;
					val3.ShowAlways = true;
					val3.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC45788 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2));
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA4AAC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3);
				}
				else if (OSVersionInfo.Name == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC4575C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2) && appConfig.validwin7.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB33E0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79)))
				{
					FotRyAbsQc.Image = Resources.silang;
					ToolTip val4 = new ToolTip();
					val4.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC1A63 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
					val4.IsBalloon = true;
					val4.ShowAlways = true;
					val4.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB6273E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4));
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B4FD8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
				}
				else if (OSVersionInfo.Name == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228E9C9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f) && appConfig.validwin8.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DABEA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2)))
				{
					FotRyAbsQc.Image = Resources.silang;
					ToolTip val5 = new ToolTip();
					val5.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E53A5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
					val5.IsBalloon = true;
					val5.ShowAlways = true;
					val5.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D69514 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711));
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC39E4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
				}
				else if (OSVersionInfo.Name == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475BA90 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b) && appConfig.validwin2008.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x871790B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd)))
				{
					FotRyAbsQc.Image = Resources.silang;
					ToolTip val6 = new ToolTip();
					val6.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228EBD9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
					val6.IsBalloon = true;
					val6.ShowAlways = true;
					val6.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE9028E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed));
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6351A079 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
				}
				else if (OSVersionInfo.Name == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6351B45B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80) && appConfig.validwin2012.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B8AF95 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e)))
				{
					FotRyAbsQc.Image = Resources.silang;
					ToolTip val7 = new ToolTip();
					val7.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A56328B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b);
					val7.IsBalloon = true;
					val7.ShowAlways = true;
					val7.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF8982 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d));
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475AE96 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b);
				}
				else if (!OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B5BB2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF8920 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x43B0CD8D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb4c51c87e664f2a80b08fdc8c7d117f)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x31362EB3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C5409 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324C5AE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB27C2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79)) && !OSVersionInfo.Name.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FF86AE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d)))
				{
					FotRyAbsQc.Image = Resources.silang;
					ToolTip val8 = new ToolTip();
					val8.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC4553A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2);
					val8.IsBalloon = true;
					val8.ShowAlways = true;
					val8.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45E88E1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5));
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65122417 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb);
				}
				else
				{
					FotRyAbsQc.Image = Resources.ceklis;
					text9 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB186F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4);
				}
				GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC225E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7));
				if (ValidasiExam.getDISPw() < appConfig.validwidth || ValidasiExam.getDISPh() < appConfig.validheight)
				{
					tKcRrW3BPt.Image = Resources.silang;
					ToolTip val9 = new ToolTip();
					val9.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D035821 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18);
					val9.IsBalloon = true;
					val9.ShowAlways = true;
					val9.SetToolTip((Control)(object)tKcRrW3BPt, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228E6A3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f));
					text3 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD51741 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBC7FF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa));
				}
				else
				{
					tKcRrW3BPt.Image = Resources.ceklis;
					text3 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C5CDF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324CB60 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10));
				}
				if (!ValidasiApps.CheckInternetPusmenjar() && Convert.ToInt32(appConfig.ModeUjian) == 2)
				{
					((Control)uPORjYUcSL).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD6614A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
					rrIRZedMQ6.Image = Resources.silang;
					ToolTip val10 = new ToolTip();
					val10.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE9003C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed);
					val10.IsBalloon = true;
					val10.ShowAlways = true;
					val10.SetToolTip((Control)(object)rrIRZedMQ6, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AF0EF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1));
					text5 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228FDD5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
				}
				else if (ValidasiApps.CheckInternetPusmenjar() && Convert.ToInt32(appConfig.ModeUjian) == 2)
				{
					((Control)uPORjYUcSL).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D035411 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18);
					rrIRZedMQ6.Image = Resources.ceklis;
					text5 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4007 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6);
				}
				else if (ValidasiApps.CheckInternetPusmenjar() && Convert.ToInt32(appConfig.ModeUjian) == 1)
				{
					((Control)uPORjYUcSL).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696A019 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c);
					rrIRZedMQ6.Image = Resources.silang;
					ToolTip val11 = new ToolTip();
					val11.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475B89A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b);
					val11.IsBalloon = true;
					val11.ShowAlways = true;
					val11.SetToolTip((Control)(object)rrIRZedMQ6, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18AD8355 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361));
					text5 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45E9C5F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228E4A3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f));
				}
				else
				{
					((Control)uPORjYUcSL).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE90CAC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed);
					rrIRZedMQ6.Image = Resources.ceklis;
					text5 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(-810996197 ^ -1437931207 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea);
				}
				if (ValidasiApps.getRAMsize() < (double)appConfig.validram)
				{
					GoWRPingpk.Image = Resources.silang;
					ToolTip val12 = new ToolTip();
					val12.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585EAC5C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
					val12.IsBalloon = true;
					val12.ShowAlways = true;
					val12.SetToolTip((Control)(object)GoWRPingpk, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBC43D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa));
					text4 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC39E4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65123CCD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb));
				}
				else
				{
					GoWRPingpk.Image = Resources.ceklis;
					text4 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29C174 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC14B5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f));
				}
				if (text2 != appConfig.OSType)
				{
					((Control)vMYRnwwOL7).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAFBEF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8);
					r09RQ2hCq1.Image = Resources.silang;
					ToolTip val13 = new ToolTip();
					val13.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C6536D5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
					val13.IsBalloon = true;
					val13.ShowAlways = true;
					val13.SetToolTip((Control)(object)r09RQ2hCq1, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AA8C2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08));
					text6 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA4AAC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696A5DD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c));
				}
				else if (checksum != ValidasiApps.osversionreal() || checksum2 != text)
				{
					((Control)vMYRnwwOL7).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D69E9C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711);
					r09RQ2hCq1.Image = Resources.silang;
					ToolTip val14 = new ToolTip();
					val14.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D035821 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18);
					val14.IsBalloon = true;
					val14.ShowAlways = true;
					val14.SetToolTip((Control)(object)r09RQ2hCq1, JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1089798187 ^ -518608904 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6));
					text6 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC0C6F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x87166F3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd));
				}
				else if (text2 != appConfig.OSType || checksum != ValidasiApps.osversionreal() || checksum2 != text)
				{
					((Control)vMYRnwwOL7).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18AD840B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361);
					r09RQ2hCq1.Image = Resources.silang;
					ToolTip val15 = new ToolTip();
					val15.ToolTipTitle = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585EAC5C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
					val15.IsBalloon = true;
					val15.ShowAlways = true;
					val15.SetToolTip((Control)(object)r09RQ2hCq1, JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6475B624 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b));
					text6 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA760C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD6642E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3));
				}
				else
				{
					((Control)vMYRnwwOL7).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C4223 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
					r09RQ2hCq1.Image = Resources.ceklis;
					text6 = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B4F40 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
					GetConfigure.Writer(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AAE4C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08));
				}
				if (((text9 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAE38F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8)) & (text7 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324D130 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10)) & (text3 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D034EB5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18)) & (text4 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DAB72 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2)) & (text5 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x313635DF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b)) & (text6 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC443AE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2))) && text8 == JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1971360885 ^ 0x37DD0640 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a))
				{
					((Control)wGMEIaLID).BackColor = Color.CornflowerBlue;
					((Control)wGMEIaLID).ForeColor = Color.GhostWhite;
					((Control)wGMEIaLID).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D3929 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0);
				}
				else
				{
					((Control)wGMEIaLID).Tag = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE9188A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed);
					((Control)wGMEIaLID).Enabled = false;
					((Control)wGMEIaLID).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1696630615 ^ 0x5945BA4A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50), 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
					((Control)wGMEIaLID).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD50AAB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd) + Environment.NewLine + JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1971360885 ^ 0x35231168 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9);
					((Control)wGMEIaLID).ForeColor = Color.Red;
				}
			}
			catch (Exception ex)
			{
				GetConfigure.Writer(ex.Message);
			}
		}

		private void bSlZUCi2O()
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected Obj, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected Obj, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected Obj, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected Obj, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected Obj, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected Obj, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected Obj, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected Obj, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected Obj, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected Obj, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected Obj, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected Obj, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected Obj, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected Obj, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected Obj, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected Obj, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected Obj, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected Obj, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected Obj, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected Obj, but got Unknown
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected Obj, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected Obj, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected Obj, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected Obj, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected Obj, but got Unknown
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected Obj, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected Obj, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected Obj, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected Obj, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected Obj, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected Obj, but got Unknown
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected Obj, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected Obj, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected Obj, but got Unknown
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected Obj, but got Unknown
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected Obj, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected Obj, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected Obj, but got Unknown
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Expected Obj, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected Obj, but got Unknown
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_084d: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c0: Expected Obj, but got Unknown
			//IL_09de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee1: Expected Obj, but got Unknown
			//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb8: Expected Obj, but got Unknown
			//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
			//IL_10af: Unknown result type (might be due to invalid IL or missing references)
			//IL_1160: Unknown result type (might be due to invalid IL or missing references)
			//IL_1201: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b0: Expected Obj, but got Unknown
			//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_144f: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ff: Expected Obj, but got Unknown
			//IL_1533: Unknown result type (might be due to invalid IL or missing references)
			//IL_1602: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1753: Unknown result type (might be due to invalid IL or missing references)
			//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1951: Unknown result type (might be due to invalid IL or missing references)
			//IL_19fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b52: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d78: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e28: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ed9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f8f: Expected Obj, but got Unknown
			//IL_1fc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_207e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2088: Expected Obj, but got Unknown
			//IL_20bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_2152: Unknown result type (might be due to invalid IL or missing references)
			//IL_215c: Expected Obj, but got Unknown
			//IL_2190: Unknown result type (might be due to invalid IL or missing references)
			//IL_2226: Unknown result type (might be due to invalid IL or missing references)
			//IL_2230: Expected Obj, but got Unknown
			//IL_2264: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_22fe: Expected Obj, but got Unknown
			//IL_2332: Unknown result type (might be due to invalid IL or missing references)
			//IL_23bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_23c6: Expected Obj, but got Unknown
			//IL_23fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_24b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_24c2: Expected Obj, but got Unknown
			//IL_24f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2585: Unknown result type (might be due to invalid IL or missing references)
			//IL_258f: Expected Obj, but got Unknown
			//IL_25c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2677: Unknown result type (might be due to invalid IL or missing references)
			//IL_2681: Expected Obj, but got Unknown
			//IL_26b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_273e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2748: Expected Obj, but got Unknown
			//IL_277c: Unknown result type (might be due to invalid IL or missing references)
			//IL_283a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2844: Expected Obj, but got Unknown
			//IL_2878: Unknown result type (might be due to invalid IL or missing references)
			//IL_2907: Unknown result type (might be due to invalid IL or missing references)
			//IL_2911: Expected Obj, but got Unknown
			//IL_2942: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a0a: Expected Obj, but got Unknown
			//IL_2a3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ac5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2acf: Expected Obj, but got Unknown
			//IL_2b00: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c44: Expected Obj, but got Unknown
			//IL_2c57: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cbc: Expected Obj, but got Unknown
			hpPcaNPXA = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_Main));
			KPBFdGLyt = new StatusStrip();
			bE3z10JZE = new ToolStripStatusLabel();
			S32hENGyX = new ToolStripStatusLabel();
			Bn2YjYLe1 = new ToolStripProgressBar();
			sT81F1fsy = new MenuStrip();
			T6DD9TCde = new ToolStripMenuItem();
			epUibJmRb = new ToolStripMenuItem();
			uPGU53FQu = new ToolStripMenuItem();
			sVxkWoDgk = new Timer(hpPcaNPXA);
			BD5mWD5un = new Timer(hpPcaNPXA);
			Y9h4oIeeA = new TextBox();
			IejRTnkyvy = new Timer(hpPcaNPXA);
			II6RGNCTBs = new Timer(hpPcaNPXA);
			jC0RRfqE6m = new Timer(hpPcaNPXA);
			Ai9RaJglcB = new BackgroundWorker();
			DlgRSLrT2l = new Timer(hpPcaNPXA);
			wGMEIaLID = new Button();
			N9nR9FsOSX = new GroupBox();
			ldARWRuNr2 = new Label();
			lrZRKgoV3Z = new Label();
			XRSRJ0vnXd = new PictureBox();
			uvMR6AlYFP = new ComboBox();
			ryCRdQjIcx = new PictureBox();
			oBcRLneGV7 = new Label();
			UugRlCCWk1 = new PictureBox();
			rrIRZedMQ6 = new PictureBox();
			uEAR0XQY4R = new Label();
			D9aRvBf5F4 = new PictureBox();
			OgvRfcFKjn = new PictureBox();
			EYlRbTVKbU = new PictureBox();
			r09RQ2hCq1 = new PictureBox();
			FotRyAbsQc = new PictureBox();
			piQRok3dUd = new PictureBox();
			GoWRPingpk = new PictureBox();
			tKcRrW3BPt = new PictureBox();
			oikR8nhTSr = new PictureBox();
			rwRRqVfJ3c = new PictureBox();
			MIPRIn5Qn6 = new PictureBox();
			SRnRAFrErN = new PictureBox();
			pA8R5DRioF = new PictureBox();
			dNmRsq79qF = new PictureBox();
			BRLR7sE197 = new Label();
			vMYRnwwOL7 = new Label();
			uPORjYUcSL = new Label();
			BWcRpC4PDV = new Label();
			YrTRg8KGen = new Label();
			BxGR25NLmv = new Label();
			tyqROHe9uN = new Label();
			nWrRus5pxy = new Label();
			quIRHKqem7 = new Label();
			QKoRV1j9m9 = new Label();
			gIhRBvEZ9V = new Label();
			vnvRx5JIT8 = new Label();
			yMSRCwWChl = new Label();
			qM8RwQD6dH = new Label();
			((Control)KPBFdGLyt).SuspendLayout();
			((Control)sT81F1fsy).SuspendLayout();
			((Control)N9nR9FsOSX).SuspendLayout();
			((ISupportInitialize)XRSRJ0vnXd).BeginInit();
			((ISupportInitialize)ryCRdQjIcx).BeginInit();
			((ISupportInitialize)UugRlCCWk1).BeginInit();
			((ISupportInitialize)rrIRZedMQ6).BeginInit();
			((ISupportInitialize)D9aRvBf5F4).BeginInit();
			((ISupportInitialize)OgvRfcFKjn).BeginInit();
			((ISupportInitialize)EYlRbTVKbU).BeginInit();
			((ISupportInitialize)r09RQ2hCq1).BeginInit();
			((ISupportInitialize)FotRyAbsQc).BeginInit();
			((ISupportInitialize)piQRok3dUd).BeginInit();
			((ISupportInitialize)GoWRPingpk).BeginInit();
			((ISupportInitialize)tKcRrW3BPt).BeginInit();
			((ISupportInitialize)oikR8nhTSr).BeginInit();
			((ISupportInitialize)rwRRqVfJ3c).BeginInit();
			((ISupportInitialize)MIPRIn5Qn6).BeginInit();
			((ISupportInitialize)SRnRAFrErN).BeginInit();
			((ISupportInitialize)pA8R5DRioF).BeginInit();
			((ISupportInitialize)dNmRsq79qF).BeginInit();
			((Control)this).SuspendLayout();
			((ToolStrip)KPBFdGLyt).ImageScalingSize = new Size(36, 36);
			((ToolStrip)KPBFdGLyt).Items.AddRange(new ToolStripItem[3]
			{
				(ToolStripItem)bE3z10JZE,
				(ToolStripItem)S32hENGyX,
				(ToolStripItem)Bn2YjYLe1
			});
			((Control)KPBFdGLyt).Location = new Point(0, 556);
			((Control)KPBFdGLyt).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8716473 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			KPBFdGLyt.Padding = new Padding(1, 0, 19, 0);
			((Control)KPBFdGLyt).Size = new Size(702, 26);
			((Control)KPBFdGLyt).TabIndex = 0;
			((Control)KPBFdGLyt).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFEBE00 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83);
			((ToolStripItem)bE3z10JZE).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD50A25 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd);
			((ToolStripItem)bE3z10JZE).Size = new Size(69, 20);
			((ToolStripItem)bE3z10JZE).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E58AD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
			((ToolStripItem)S32hENGyX).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DB6C6 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2);
			((ToolStripItem)S32hENGyX).Size = new Size(37, 20);
			((ToolStripItem)S32hENGyX).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D802602 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd);
			((ToolStripItem)Bn2YjYLe1).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AF6B7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1);
			((ToolStripItem)Bn2YjYLe1).Size = new Size(133, 22);
			((ToolStripItem)Bn2YjYLe1).Visible = false;
			((ToolStrip)sT81F1fsy).BackColor = SystemColors.ButtonFace;
			((ToolStrip)sT81F1fsy).ImageScalingSize = new Size(36, 36);
			((ToolStrip)sT81F1fsy).Items.AddRange(new ToolStripItem[3]
			{
				(ToolStripItem)T6DD9TCde,
				(ToolStripItem)epUibJmRb,
				(ToolStripItem)uPGU53FQu
			});
			((Control)sT81F1fsy).Location = new Point(0, 0);
			((Control)sT81F1fsy).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AF6D9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1);
			((Control)sT81F1fsy).Padding = new Padding(3, 1, 0, 1);
			((Control)sT81F1fsy).Size = new Size(702, 26);
			((Control)sT81F1fsy).TabIndex = 1;
			((Control)sT81F1fsy).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC45FA2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2);
			((ToolStripItem)T6DD9TCde).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696A699 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c);
			((ToolStripItem)T6DD9TCde).Size = new Size(59, 24);
			((ToolStripItem)T6DD9TCde).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xDB76715 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c874f2a03b794f3795625c7f6b64f71e);
			((ToolStripItem)T6DD9TCde).Click += hfvAT0mnu;
			((ToolStripItem)epUibJmRb).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1696630615 ^ 0x637D30F7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2);
			((ToolStripItem)epUibJmRb).Size = new Size(76, 24);
			((ToolStripItem)epUibJmRb).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA56C4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3);
			((ToolStripItem)epUibJmRb).Click += UJmIYtnFx;
			((ToolStripItem)uPGU53FQu).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(--826623140 ^ 0x6D5E1760 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
			((ToolStripItem)uPGU53FQu).Size = new Size(55, 24);
			sVxkWoDgk.Interval = 10000;
			sVxkWoDgk.Tick += DvK8XsCKV;
			BD5mWD5un.Enabled = true;
			BD5mWD5un.Tick += VYura9jwJ;
			((Control)Y9h4oIeeA).Location = new Point(16, 631);
			((Control)Y9h4oIeeA).Margin = new Padding(4, 4, 4, 4);
			((TextBoxBase)Y9h4oIeeA).Multiline = true;
			((Control)Y9h4oIeeA).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D69D84 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711);
			Y9h4oIeeA.ScrollBars = (ScrollBars)3;
			((Control)Y9h4oIeeA).Size = new Size(345, 51);
			((Control)Y9h4oIeeA).TabIndex = 3;
			IejRTnkyvy.Interval = 6000;
			IejRTnkyvy.Tick += v3gyuQiN4;
			II6RGNCTBs.Interval = 1000;
			II6RGNCTBs.Tick += JMlo8LnXY;
			jC0RRfqE6m.Enabled = true;
			jC0RRfqE6m.Interval = 20000;
			jC0RRfqE6m.Tick += f6iQQx1tr;
			Ai9RaJglcB.DoWork += MpMPlucRT;
			DlgRSLrT2l.Interval = 5000;
			DlgRSLrT2l.Tick += iNlvuSI1Z;
			((Control)wGMEIaLID).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA5768 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3), 16f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)wGMEIaLID).Location = new Point(0, 0);
			((Control)wGMEIaLID).Margin = new Padding(4, 4, 4, 4);
			((Control)wGMEIaLID).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EBF8B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
			((Control)wGMEIaLID).Size = new Size(680, 59);
			((Control)wGMEIaLID).TabIndex = 2;
			((Control)wGMEIaLID).Tag = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585EBA50 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
			((ButtonBase)wGMEIaLID).UseVisualStyleBackColor = true;
			((Control)wGMEIaLID).Click += OAfqUeaTV;
			((Control)N9nR9FsOSX).BackColor = Color.Gainsboro;
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)ldARWRuNr2);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)lrZRKgoV3Z);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)XRSRJ0vnXd);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)uvMR6AlYFP);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)ryCRdQjIcx);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)oBcRLneGV7);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)UugRlCCWk1);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)rrIRZedMQ6);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)uEAR0XQY4R);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)D9aRvBf5F4);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)OgvRfcFKjn);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)EYlRbTVKbU);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)r09RQ2hCq1);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)FotRyAbsQc);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)piQRok3dUd);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)GoWRPingpk);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)tKcRrW3BPt);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)oikR8nhTSr);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)rwRRqVfJ3c);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)MIPRIn5Qn6);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)SRnRAFrErN);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)pA8R5DRioF);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)dNmRsq79qF);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)BRLR7sE197);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)vMYRnwwOL7);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)uPORjYUcSL);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)BWcRpC4PDV);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)YrTRg8KGen);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)BxGR25NLmv);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)tyqROHe9uN);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)nWrRus5pxy);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)quIRHKqem7);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)QKoRV1j9m9);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)gIhRBvEZ9V);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)vnvRx5JIT8);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)yMSRCwWChl);
			((Control)N9nR9FsOSX).Controls.Add((Control)(object)qM8RwQD6dH);
			((Control)N9nR9FsOSX).Location = new Point(16, 33);
			((Control)N9nR9FsOSX).Margin = new Padding(4, 4, 4, 4);
			((Control)N9nR9FsOSX).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D036DD7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18);
			((Control)N9nR9FsOSX).Padding = new Padding(4, 4, 4, 4);
			((Control)N9nR9FsOSX).Size = new Size(267, 123);
			((Control)N9nR9FsOSX).TabIndex = 4;
			N9nR9FsOSX.TabStop = false;
			((Control)N9nR9FsOSX).Enter += rrTdG3Ut7;
			((Control)ldARWRuNr2).AutoSize = true;
			((Control)ldARWRuNr2).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18ADB96F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361), 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)ldARWRuNr2).ForeColor = SystemColors.Highlight;
			((Control)ldARWRuNr2).Location = new Point(0, 0);
			((Control)ldARWRuNr2).Margin = new Padding(4, 0, 4, 0);
			((Control)ldARWRuNr2).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x75990684 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8);
			((Control)ldARWRuNr2).Size = new Size(0, 52);
			((Control)ldARWRuNr2).TabIndex = 28;
			ldARWRuNr2.TextAlign = (ContentAlignment)32;
			((Control)lrZRKgoV3Z).AutoSize = true;
			((Control)lrZRKgoV3Z).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B6C34 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)lrZRKgoV3Z).ForeColor = SystemColors.Highlight;
			((Control)lrZRKgoV3Z).Location = new Point(55, 421);
			((Control)lrZRKgoV3Z).Margin = new Padding(4, 0, 4, 0);
			((Control)lrZRKgoV3Z).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD534E7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd);
			((Control)lrZRKgoV3Z).Size = new Size(218, 20);
			((Control)lrZRKgoV3Z).TabIndex = 25;
			((Control)lrZRKgoV3Z).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA5542 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a);
			((Control)XRSRJ0vnXd).BackColor = Color.Gainsboro;
			XRSRJ0vnXd.Image = Resources.webcam;
			((Control)XRSRJ0vnXd).Location = new Point(19, 496);
			((Control)XRSRJ0vnXd).Margin = new Padding(4, 4, 4, 4);
			((Control)XRSRJ0vnXd).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x64758D8A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b);
			((Control)XRSRJ0vnXd).Size = new Size(31, 27);
			XRSRJ0vnXd.SizeMode = (PictureBoxSizeMode)1;
			XRSRJ0vnXd.TabIndex = 24;
			XRSRJ0vnXd.TabStop = false;
			uvMR6AlYFP.DropDownStyle = (ComboBoxStyle)2;
			((ListControl)uvMR6AlYFP).FormattingEnabled = true;
			((Control)uvMR6AlYFP).Location = new Point(99, 496);
			((Control)uvMR6AlYFP).Margin = new Padding(4, 4, 4, 4);
			((Control)uvMR6AlYFP).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D6A29A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711);
			((Control)uvMR6AlYFP).Size = new Size(319, 24);
			((Control)uvMR6AlYFP).TabIndex = 4;
			((Control)ryCRdQjIcx).BackColor = Color.Gainsboro;
			ryCRdQjIcx.Image = Resources.jam2;
			((Control)ryCRdQjIcx).Location = new Point(19, 421);
			((Control)ryCRdQjIcx).Margin = new Padding(4, 4, 4, 4);
			((Control)ryCRdQjIcx).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xDB75997 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c874f2a03b794f3795625c7f6b64f71e);
			((Control)ryCRdQjIcx).Size = new Size(31, 27);
			ryCRdQjIcx.SizeMode = (PictureBoxSizeMode)1;
			ryCRdQjIcx.TabIndex = 26;
			ryCRdQjIcx.TabStop = false;
			((Control)oBcRLneGV7).AutoSize = true;
			((Control)oBcRLneGV7).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAC0FB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)oBcRLneGV7).ForeColor = SystemColors.Highlight;
			((Control)oBcRLneGV7).Location = new Point(55, 470);
			((Control)oBcRLneGV7).Margin = new Padding(4, 0, 4, 0);
			((Control)oBcRLneGV7).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB61144 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
			((Control)oBcRLneGV7).Size = new Size(81, 20);
			((Control)oBcRLneGV7).TabIndex = 23;
			((Control)oBcRLneGV7).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC1B02 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)UugRlCCWk1).BackColor = Color.Gainsboro;
			UugRlCCWk1.Image = Resources.nointernet;
			((Control)UugRlCCWk1).Location = new Point(19, 372);
			((Control)UugRlCCWk1).Margin = new Padding(4, 4, 4, 4);
			((Control)UugRlCCWk1).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A560611 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b);
			((Control)UugRlCCWk1).Size = new Size(31, 27);
			UugRlCCWk1.SizeMode = (PictureBoxSizeMode)1;
			UugRlCCWk1.TabIndex = 22;
			UugRlCCWk1.TabStop = false;
			((Control)rrIRZedMQ6).BackColor = Color.Transparent;
			((Control)rrIRZedMQ6).Location = new Point(627, 389);
			((Control)rrIRZedMQ6).Margin = new Padding(4, 4, 4, 4);
			((Control)rrIRZedMQ6).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C650269 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
			((Control)rrIRZedMQ6).Size = new Size(31, 27);
			rrIRZedMQ6.SizeMode = (PictureBoxSizeMode)1;
			rrIRZedMQ6.TabIndex = 21;
			rrIRZedMQ6.TabStop = false;
			((Control)uEAR0XQY4R).AutoSize = true;
			((Control)uEAR0XQY4R).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(-15832547 ^ -1333252760 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)uEAR0XQY4R).ForeColor = SystemColors.Highlight;
			((Control)uEAR0XQY4R).Location = new Point(55, 372);
			((Control)uEAR0XQY4R).Margin = new Padding(4, 0, 4, 0);
			((Control)uEAR0XQY4R).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x10D448DF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f);
			((Control)uEAR0XQY4R).Size = new Size(173, 20);
			((Control)uEAR0XQY4R).TabIndex = 20;
			((Control)uEAR0XQY4R).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8715B79 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)D9aRvBf5F4).BackColor = Color.Gainsboro;
			D9aRvBf5F4.Image = Resources.onlinetest;
			((Control)D9aRvBf5F4).Location = new Point(19, 322);
			((Control)D9aRvBf5F4).Margin = new Padding(4, 4, 4, 4);
			((Control)D9aRvBf5F4).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C6502D1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
			((Control)D9aRvBf5F4).Size = new Size(31, 27);
			D9aRvBf5F4.SizeMode = (PictureBoxSizeMode)1;
			D9aRvBf5F4.TabIndex = 19;
			D9aRvBf5F4.TabStop = false;
			((Control)OgvRfcFKjn).BackColor = Color.Transparent;
			((Control)OgvRfcFKjn).Location = new Point(627, 489);
			((Control)OgvRfcFKjn).Margin = new Padding(4, 4, 4, 4);
			((Control)OgvRfcFKjn).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65E3E594 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea);
			((Control)OgvRfcFKjn).Size = new Size(31, 27);
			OgvRfcFKjn.SizeMode = (PictureBoxSizeMode)1;
			OgvRfcFKjn.TabIndex = 27;
			OgvRfcFKjn.TabStop = false;
			((Control)EYlRbTVKbU).BackColor = Color.Transparent;
			((Control)EYlRbTVKbU).Location = new Point(627, 438);
			((Control)EYlRbTVKbU).Margin = new Padding(4, 4, 4, 4);
			((Control)EYlRbTVKbU).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D036FD7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18);
			((Control)EYlRbTVKbU).Size = new Size(31, 27);
			EYlRbTVKbU.SizeMode = (PictureBoxSizeMode)1;
			EYlRbTVKbU.TabIndex = 27;
			EYlRbTVKbU.TabStop = false;
			((Control)r09RQ2hCq1).BackColor = Color.Transparent;
			((Control)r09RQ2hCq1).Location = new Point(627, 340);
			((Control)r09RQ2hCq1).Margin = new Padding(4, 4, 4, 4);
			((Control)r09RQ2hCq1).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x46969BB9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c);
			((Control)r09RQ2hCq1).Size = new Size(31, 27);
			r09RQ2hCq1.SizeMode = (PictureBoxSizeMode)1;
			r09RQ2hCq1.TabIndex = 18;
			r09RQ2hCq1.TabStop = false;
			((Control)FotRyAbsQc).BackColor = Color.Transparent;
			((Control)FotRyAbsQc).Location = new Point(627, 96);
			((Control)FotRyAbsQc).Margin = new Padding(4, 4, 4, 4);
			((Control)FotRyAbsQc).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29E046 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6);
			((Control)FotRyAbsQc).Size = new Size(31, 27);
			FotRyAbsQc.SizeMode = (PictureBoxSizeMode)1;
			FotRyAbsQc.TabIndex = 17;
			FotRyAbsQc.TabStop = false;
			((Control)piQRok3dUd).BackColor = Color.Transparent;
			((Control)piQRok3dUd).Location = new Point(627, 145);
			((Control)piQRok3dUd).Margin = new Padding(4, 4, 4, 4);
			((Control)piQRok3dUd).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C61D1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6);
			((Control)piQRok3dUd).Size = new Size(31, 27);
			piQRok3dUd.SizeMode = (PictureBoxSizeMode)1;
			piQRok3dUd.TabIndex = 16;
			piQRok3dUd.TabStop = false;
			((Control)GoWRPingpk).BackColor = Color.Transparent;
			((Control)GoWRPingpk).Location = new Point(627, 194);
			((Control)GoWRPingpk).Margin = new Padding(4, 4, 4, 4);
			((Control)GoWRPingpk).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D801BAE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd);
			((Control)GoWRPingpk).Size = new Size(31, 27);
			GoWRPingpk.SizeMode = (PictureBoxSizeMode)1;
			GoWRPingpk.TabIndex = 15;
			GoWRPingpk.TabStop = false;
			((Control)tKcRrW3BPt).BackColor = Color.Transparent;
			((Control)tKcRrW3BPt).Location = new Point(627, 244);
			((Control)tKcRrW3BPt).Margin = new Padding(4, 4, 4, 4);
			((Control)tKcRrW3BPt).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324F092 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10);
			((Control)tKcRrW3BPt).Size = new Size(31, 27);
			tKcRrW3BPt.SizeMode = (PictureBoxSizeMode)1;
			tKcRrW3BPt.TabIndex = 14;
			tKcRrW3BPt.TabStop = false;
			((Control)oikR8nhTSr).BackColor = Color.Transparent;
			((Control)oikR8nhTSr).Location = new Point(627, 290);
			((Control)oikR8nhTSr).Margin = new Padding(4, 4, 4, 4);
			((Control)oikR8nhTSr).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBFDE5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa);
			((Control)oikR8nhTSr).Size = new Size(31, 27);
			oikR8nhTSr.SizeMode = (PictureBoxSizeMode)1;
			oikR8nhTSr.TabIndex = 13;
			oikR8nhTSr.TabStop = false;
			((Control)rwRRqVfJ3c).BackColor = Color.Gainsboro;
			rwRRqVfJ3c.Image = Resources.audio;
			((Control)rwRRqVfJ3c).Location = new Point(19, 273);
			((Control)rwRRqVfJ3c).Margin = new Padding(4, 4, 4, 4);
			((Control)rwRRqVfJ3c).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18ADBA6B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361);
			((Control)rwRRqVfJ3c).Size = new Size(31, 27);
			rwRRqVfJ3c.SizeMode = (PictureBoxSizeMode)1;
			rwRRqVfJ3c.TabIndex = 12;
			rwRRqVfJ3c.TabStop = false;
			((Control)MIPRIn5Qn6).BackColor = Color.Gainsboro;
			MIPRIn5Qn6.Image = Resources.monitor;
			((Control)MIPRIn5Qn6).Location = new Point(19, 223);
			((Control)MIPRIn5Qn6).Margin = new Padding(4, 4, 4, 4);
			((Control)MIPRIn5Qn6).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB136E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79);
			((Control)MIPRIn5Qn6).Size = new Size(31, 27);
			MIPRIn5Qn6.SizeMode = (PictureBoxSizeMode)1;
			MIPRIn5Qn6.TabIndex = 12;
			MIPRIn5Qn6.TabStop = false;
			((Control)SRnRAFrErN).BackColor = Color.Gainsboro;
			SRnRAFrErN.Image = (Image)(object)Resources.ram;
			((Control)SRnRAFrErN).Location = new Point(19, 172);
			((Control)SRnRAFrErN).Margin = new Padding(4, 4, 4, 4);
			((Control)SRnRAFrErN).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x651204B9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb);
			((Control)SRnRAFrErN).Size = new Size(31, 27);
			SRnRAFrErN.SizeMode = (PictureBoxSizeMode)1;
			SRnRAFrErN.TabIndex = 12;
			SRnRAFrErN.TabStop = false;
			((Control)pA8R5DRioF).BackColor = Color.Gainsboro;
			pA8R5DRioF.Image = (Image)(object)Resources.processor;
			((Control)pA8R5DRioF).Location = new Point(19, 122);
			((Control)pA8R5DRioF).Margin = new Padding(4, 4, 4, 4);
			((Control)pA8R5DRioF).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76366FBC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b);
			((Control)pA8R5DRioF).Size = new Size(31, 27);
			pA8R5DRioF.SizeMode = (PictureBoxSizeMode)1;
			pA8R5DRioF.TabIndex = 12;
			pA8R5DRioF.TabStop = false;
			((Control)dNmRsq79qF).BackColor = Color.Gainsboro;
			dNmRsq79qF.Image = Resources.windowsg;
			((Control)dNmRsq79qF).Location = new Point(19, 71);
			((Control)dNmRsq79qF).Margin = new Padding(4, 4, 4, 4);
			((Control)dNmRsq79qF).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x46969A4F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c);
			((Control)dNmRsq79qF).Size = new Size(31, 27);
			dNmRsq79qF.SizeMode = (PictureBoxSizeMode)1;
			dNmRsq79qF.TabIndex = 11;
			dNmRsq79qF.TabStop = false;
			((Control)BRLR7sE197).AutoSize = true;
			((Control)BRLR7sE197).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x759906D0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)BRLR7sE197).ForeColor = SystemColors.Highlight;
			((Control)BRLR7sE197).Location = new Point(55, 322);
			((Control)BRLR7sE197).Margin = new Padding(4, 0, 4, 0);
			((Control)BRLR7sE197).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65E3E7AC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea);
			((Control)BRLR7sE197).Size = new Size(135, 20);
			((Control)BRLR7sE197).TabIndex = 9;
			((Control)BRLR7sE197).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B6FEA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
			((Control)vMYRnwwOL7).AutoSize = true;
			((Control)vMYRnwwOL7).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC11AB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)vMYRnwwOL7).ForeColor = Color.RoyalBlue;
			((Control)vMYRnwwOL7).Location = new Point(95, 347);
			((Control)vMYRnwwOL7).Margin = new Padding(4, 0, 4, 0);
			((Control)vMYRnwwOL7).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C650709 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
			((Control)vMYRnwwOL7).Size = new Size(0, 20);
			((Control)vMYRnwwOL7).TabIndex = 10;
			((Control)uPORjYUcSL).AutoSize = true;
			((Control)uPORjYUcSL).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A563943 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)uPORjYUcSL).ForeColor = Color.RoyalBlue;
			((Control)uPORjYUcSL).Location = new Point(95, 396);
			((Control)uPORjYUcSL).Margin = new Padding(4, 0, 4, 0);
			((Control)uPORjYUcSL).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C5431B7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8);
			((Control)uPORjYUcSL).Size = new Size(0, 20);
			((Control)uPORjYUcSL).TabIndex = 10;
			((Control)BWcRpC4PDV).AutoSize = true;
			((Control)BWcRpC4PDV).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x87164CF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BWcRpC4PDV).ForeColor = Color.RoyalBlue;
			((Control)BWcRpC4PDV).Location = new Point(95, 446);
			((Control)BWcRpC4PDV).Margin = new Padding(4, 0, 4, 0);
			((Control)BWcRpC4PDV).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FFBAD0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
			((Control)BWcRpC4PDV).Size = new Size(0, 20);
			((Control)BWcRpC4PDV).TabIndex = 10;
			((Control)YrTRg8KGen).AutoSize = true;
			((Control)YrTRg8KGen).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x31362883 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)YrTRg8KGen).ForeColor = Color.RoyalBlue;
			((Control)YrTRg8KGen).Location = new Point(95, 298);
			((Control)YrTRg8KGen).Margin = new Padding(4, 0, 4, 0);
			((Control)YrTRg8KGen).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65D8C7A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2);
			((Control)YrTRg8KGen).Size = new Size(0, 20);
			((Control)YrTRg8KGen).TabIndex = 10;
			((Control)BxGR25NLmv).AutoSize = true;
			((Control)BxGR25NLmv).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8715AE7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)BxGR25NLmv).ForeColor = SystemColors.Highlight;
			((Control)BxGR25NLmv).Location = new Point(55, 273);
			((Control)BxGR25NLmv).Margin = new Padding(4, 0, 4, 0);
			((Control)BxGR25NLmv).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA6D14 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3);
			((Control)BxGR25NLmv).Size = new Size(107, 20);
			((Control)BxGR25NLmv).TabIndex = 9;
			((Control)BxGR25NLmv).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD530E5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd);
			((Control)tyqROHe9uN).AutoSize = true;
			((Control)tyqROHe9uN).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18AD8747 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)tyqROHe9uN).ForeColor = Color.RoyalBlue;
			((Control)tyqROHe9uN).Location = new Point(95, 249);
			((Control)tyqROHe9uN).Margin = new Padding(4, 0, 4, 0);
			((Control)tyqROHe9uN).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C650795 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
			((Control)tyqROHe9uN).Size = new Size(0, 20);
			((Control)tyqROHe9uN).TabIndex = 8;
			((Control)nWrRus5pxy).AutoSize = true;
			((Control)nWrRus5pxy).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC460DA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)nWrRus5pxy).ForeColor = SystemColors.Highlight;
			((Control)nWrRus5pxy).Location = new Point(55, 224);
			((Control)nWrRus5pxy).Margin = new Padding(4, 0, 4, 0);
			((Control)nWrRus5pxy).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B888E3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e);
			((Control)nWrRus5pxy).Size = new Size(167, 20);
			((Control)nWrRus5pxy).TabIndex = 7;
			((Control)nWrRus5pxy).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C1B93D7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83);
			((Control)quIRHKqem7).AutoSize = true;
			((Control)quIRHKqem7).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76365230 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)quIRHKqem7).ForeColor = Color.RoyalBlue;
			((Control)quIRHKqem7).Location = new Point(95, 199);
			((Control)quIRHKqem7).Margin = new Padding(4, 0, 4, 0);
			((Control)quIRHKqem7).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD65CE2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
			((Control)quIRHKqem7).Size = new Size(0, 20);
			((Control)quIRHKqem7).TabIndex = 6;
			((Control)QKoRV1j9m9).AutoSize = true;
			((Control)QKoRV1j9m9).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FFBED0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)QKoRV1j9m9).ForeColor = SystemColors.Highlight;
			((Control)QKoRV1j9m9).Location = new Point(55, 175);
			((Control)QKoRV1j9m9).Margin = new Padding(4, 0, 4, 0);
			((Control)QKoRV1j9m9).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C7A9F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
			((Control)QKoRV1j9m9).Size = new Size(49, 20);
			((Control)QKoRV1j9m9).TabIndex = 5;
			((Control)QKoRV1j9m9).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C54308F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8);
			((Control)gIhRBvEZ9V).AutoSize = true;
			((Control)gIhRBvEZ9V).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(--826623140 ^ 0xD114F2F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)gIhRBvEZ9V).ForeColor = Color.RoyalBlue;
			((Control)gIhRBvEZ9V).Location = new Point(95, 150);
			((Control)gIhRBvEZ9V).Margin = new Padding(4, 0, 4, 0);
			((Control)gIhRBvEZ9V).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8715FF5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)gIhRBvEZ9V).Size = new Size(0, 20);
			((Control)gIhRBvEZ9V).TabIndex = 4;
			((Control)vnvRx5JIT8).AutoSize = true;
			((Control)vnvRx5JIT8).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1A939C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)vnvRx5JIT8).ForeColor = SystemColors.Highlight;
			((Control)vnvRx5JIT8).Location = new Point(55, 126);
			((Control)vnvRx5JIT8).Margin = new Padding(4, 0, 4, 0);
			((Control)vnvRx5JIT8).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6351869B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
			((Control)vnvRx5JIT8).Size = new Size(47, 20);
			((Control)vnvRx5JIT8).TabIndex = 3;
			((Control)vnvRx5JIT8).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324F722 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10);
			((Control)yMSRCwWChl).AutoSize = true;
			((Control)yMSRCwWChl).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1971360885 ^ 0x5D8ECC18 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)yMSRCwWChl).ForeColor = Color.RoyalBlue;
			((Control)yMSRCwWChl).Location = new Point(95, 101);
			((Control)yMSRCwWChl).Margin = new Padding(4, 0, 4, 0);
			((Control)yMSRCwWChl).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(--393691509 ^ 0x38A270B4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd);
			((Control)yMSRCwWChl).Size = new Size(0, 20);
			((Control)yMSRCwWChl).TabIndex = 2;
			((Control)qM8RwQD6dH).AutoSize = true;
			((Control)qM8RwQD6dH).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC1A08 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)qM8RwQD6dH).ForeColor = SystemColors.Highlight;
			((Control)qM8RwQD6dH).Location = new Point(55, 76);
			((Control)qM8RwQD6dH).Margin = new Padding(4, 0, 4, 0);
			((Control)qM8RwQD6dH).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A560231 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b);
			((Control)qM8RwQD6dH).Size = new Size(159, 20);
			((Control)qM8RwQD6dH).TabIndex = 1;
			((Control)qM8RwQD6dH).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C1B9293 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 16f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Control)this).BackColor = Color.WhiteSmoke;
			((Form)this).ClientSize = new Size(702, 582);
			((Control)this).Controls.Add((Control)(object)N9nR9FsOSX);
			((Control)this).Controls.Add((Control)(object)Y9h4oIeeA);
			((Control)this).Controls.Add((Control)(object)wGMEIaLID);
			((Control)this).Controls.Add((Control)(object)KPBFdGLyt);
			((Control)this).Controls.Add((Control)(object)sT81F1fsy);
			((Form)this).Icon = (Icon)componentResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76364C7C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b));
			((Form)this).MainMenuStrip = sT81F1fsy;
			((Form)this).Margin = new Padding(4, 4, 4, 4);
			((Form)this).MaximizeBox = false;
			((Control)this).MaximumSize = new Size(720, 768);
			((Control)this).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324F7D4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10);
			((Form)this).StartPosition = (FormStartPosition)1;
			((Form)this).FormClosing += NntpREBBp;
			((Form)this).Load += o1njIU9gi;
			((Control)KPBFdGLyt).ResumeLayout(false);
			((Control)KPBFdGLyt).PerformLayout();
			((Control)sT81F1fsy).ResumeLayout(false);
			((Control)sT81F1fsy).PerformLayout();
			((Control)N9nR9FsOSX).ResumeLayout(false);
			((Control)N9nR9FsOSX).PerformLayout();
			((ISupportInitialize)XRSRJ0vnXd).EndInit();
			((ISupportInitialize)ryCRdQjIcx).EndInit();
			((ISupportInitialize)UugRlCCWk1).EndInit();
			((ISupportInitialize)rrIRZedMQ6).EndInit();
			((ISupportInitialize)D9aRvBf5F4).EndInit();
			((ISupportInitialize)OgvRfcFKjn).EndInit();
			((ISupportInitialize)EYlRbTVKbU).EndInit();
			((ISupportInitialize)r09RQ2hCq1).EndInit();
			((ISupportInitialize)FotRyAbsQc).EndInit();
			((ISupportInitialize)piQRok3dUd).EndInit();
			((ISupportInitialize)GoWRPingpk).EndInit();
			((ISupportInitialize)tKcRrW3BPt).EndInit();
			((ISupportInitialize)oikR8nhTSr).EndInit();
			((ISupportInitialize)rwRRqVfJ3c).EndInit();
			((ISupportInitialize)MIPRIn5Qn6).EndInit();
			((ISupportInitialize)SRnRAFrErN).EndInit();
			((ISupportInitialize)pA8R5DRioF).EndInit();
			((ISupportInitialize)dNmRsq79qF).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		private void rrTdG3Ut7(object P_0, EventArgs P_1)
		{
		}
	}
	public class Form_Password : Form
	{
		public struct IsPasswordValid_result
		{
			public bool valid;

			public bool isadmin;
		}

		public const string adminstr = "admin";

		private IContainer H32RhuV7Ot;

		private Label cfiR13JV1h;

		private TextBox tkURDpkdfS;

		private Button NVoRiPdsUj;

		public IsPasswordValid_result IsPasswordValid()
		{
			IsPasswordValid_result result = default;
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			string text = ((Control)tkURDpkdfS).Text.Trim();
			string text2 = encryption.DecryptString(encryption.ReadBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC2A09 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f)), encryption.passPhrase);
			string text3 = encryption.EncryptString(text, encryption.passPhrase);
			result.valid = (appConfig.Password == text || false || ((appConfig.PasswordSetUrl == text3) ? true : false)) && !string.IsNullOrEmpty(text);
			result.isadmin = appConfig.PasswordSetUrl == text3;
			Console.WriteLine(appConfig.PasswordSetUrl + JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C66AD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6) + text3);
			return result;
		}

		private void WIORXePASt(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		public Form_Password()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			((Form)this)..ctor();
			pc2RFEaot9();
		}

		private void uvJRcSPN3B(object P_0, EventArgs P_1)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && H32RhuV7Ot != null)
			{
				H32RhuV7Ot.Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void pc2RFEaot9()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_Password));
			cfiR13JV1h = new Label();
			tkURDpkdfS = new TextBox();
			NVoRiPdsUj = new Button();
			((Control)this).SuspendLayout();
			((Control)cfiR13JV1h).AutoSize = true;
			((Control)cfiR13JV1h).Location = new Point(13, 13);
			((Control)cfiR13JV1h).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EBA71 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
			((Control)cfiR13JV1h).Size = new Size(53, 13);
			((Control)cfiR13JV1h).TabIndex = 0;
			((Control)cfiR13JV1h).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x31361099 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b);
			((Control)tkURDpkdfS).Location = new Point(72, 10);
			((Control)tkURDpkdfS).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1089798187 ^ -1964905993 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79);
			tkURDpkdfS.PasswordChar = '*';
			((Control)tkURDpkdfS).Size = new Size(119, 20);
			((Control)tkURDpkdfS).TabIndex = 1;
			NVoRiPdsUj.DialogResult = (DialogResult)1;
			((Control)NVoRiPdsUj).Location = new Point(197, 8);
			((Control)NVoRiPdsUj).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x63518591 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
			((Control)NVoRiPdsUj).Size = new Size(75, 23);
			((Control)NVoRiPdsUj).TabIndex = 2;
			((Control)NVoRiPdsUj).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x46969FBD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c);
			((ButtonBase)NVoRiPdsUj).UseVisualStyleBackColor = true;
			((Control)NVoRiPdsUj).Click += WIORXePASt;
			((Form)this).AcceptButton = (IButtonControl)(object)NVoRiPdsUj;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(284, 45);
			((Control)this).Controls.Add((Control)(object)NVoRiPdsUj);
			((Control)this).Controls.Add((Control)(object)tkURDpkdfS);
			((Control)this).Controls.Add((Control)(object)cfiR13JV1h);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65E3E22A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea);
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE933EE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed);
			((Form)this).Load += uvJRcSPN3B;
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	public class Form_Settings : Form
	{
		private Panel BUYRzTYR0x;

		private RadioButton BYlGTwblRR;

		private Label hDhGRDxngp;

		private RadioButton A1WGGevaaw;

		private TextBox vGIGas1rls;

		private Label uWjG9xSrAS;

		private Panel PujGwkhsQy;

		private Label fNYGHZ4jqi;

		private Panel viJGVR4Rwn;

		private CheckBox vWiGBXeMnS;

		private TextBox meKGxkOdfd;

		private Label XgYGCRKKnY;

		private TextBox dq2GgvuZFq;

		private TextBox eJbG2ArIif;

		private TextBox msQGnrD4j1;

		private TextBox OxjG7i5Ka1;

		private Label J44GOT5QkO;

		private Label JWtGu8D0lP;

		private Label PvpG0dKOkY;

		private Label GAKGjIsuIG;

		private Label ovjGpOVLTK;

		private Panel zNMGKRcIDn;

		private Label F3jGsrM7Oj;

		private Panel KhEG5rRJTA;

		private TextBox qruGAWRbWH;

		private Label QSvGI8Z8Pf;

		private TextBox JAFGqMEZl9;

		private Label k7EG88xN14;

		private CheckBox GxdGraTWUh;

		private Label OsVGyQljiE;

		private TextBox GxfGo0MDxl;

		private TextBox XRkGPvb7JO;

		private Label txJGQSwqsX;

		private Label LZ2GbA0Yae;

		private Panel AE9GffhdrQ;

		private Label FOcGv4QbqX;

		private Panel eKnGlAjVm8;

		private TextBox qyFGZNcFZf;

		private Label VHlGdxa9HO;

		private CheckBox rjUGSHqiQ8;

		private CheckBox YYoGeZSm4e;

		private CheckBox SWwGNpf50K;

		private CheckBox vnmG3HwClr;

		private CheckBox DFRGtGxdfI;

		private Label Ct2GLDm4tv;

		private NumericUpDown FghGJGSvW8;

		private NumericUpDown rGGGWsX7tR;

		private Label UjnG6Q4MxV;

		private Label tXJGMXkeXH;

		private Label qvHGXedrwh;

		private NumericUpDown O8dGcnH91l;

		private Label H2GGFMDm7q;

		private Panel v4MGhakT0E;

		private Label znrG1MOUlk;

		private Button CCeGD5vrCy;

		private Button A5aGio7UF8;

		private TextBox QqwGEs7j4l;

		private Label Cm4Gkume3X;

		private Label bplGmQl8Nl;

		private NumericUpDown X9YG4uKF0w;

		private Label NulGYDDNif;

		private Label nm8GUQEYA6;

		private Label w7mGz694AV;

		private NumericUpDown bCVaTv9oYm;

		private NumericUpDown oHKaRju9jb;

		private NumericUpDown m30aGbYnCb;

		private Label TINaaZMl6L;

		private TextBox UPya9qL3oh;

		private NumericUpDown z7haw9hy6O;

		private TextBox h8uaHFjuEJ;

		private Label gfMaVE2snQ;

		private Label CaiaBL2PMI;

		private Label NstaxJMrFv;

		private TextBox hdeaC9s3oe;

		private CheckBox tfsagOPCSA;

		private Label iP5a2Ilptk;

		private ComboBox mUUanqdV9U;

		private Label VV8a7QWO17;

		private IContainer uZ3aOyU6mZ;

		public Form_Settings()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			((Form)this)..ctor();
			OhlRYDvcyl();
		}

		public static void createsharing()
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D8031FA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd));
				object value = registryKey.GetValue(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD51DC9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd));
				string value2 = encryption.DecryptString(encryption.ReadBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE93056 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed)), encryption.passPhrase);
				GetConfigure.SettingExambro settingExambro = new GetConfigure.SettingExambro();
				JsonConvert.PopulateObject(value2, settingExambro);
				settingExambro.sharingsession = Convert.ToString(value);
				string plainText = JsonConvert.SerializeObject(settingExambro);
				encryption.WriteBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65120271 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb), encryption.EncryptString(plainText, encryption.passPhrase));
			}
			catch
			{
				Form_Main.TulisLog(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D12D1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0));
			}
		}

		public static void saveCam(string par, string hasil)
		{
			string value = encryption.DecryptString(encryption.ReadBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC46550 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2)), encryption.passPhrase);
			GetConfigure.SettingExambro settingExambro = new GetConfigure.SettingExambro();
			JsonConvert.PopulateObject(value, settingExambro);
			settingExambro.Webcam = hasil;
			string plainText = JsonConvert.SerializeObject(settingExambro);
			encryption.WriteBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D801CA8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd), encryption.EncryptString(plainText, encryption.passPhrase));
		}

		public void setFormTag(string str)
		{
			((Control)this).Tag = str;
		}

		private void jAoREa6dLw()
		{
			if (((Control)this).Tag.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA764C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a)))
			{
				string value = encryption.DecryptString(encryption.ReadBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B69BE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f)), encryption.passPhrase);
				GetConfigure.SettingExambro settingExambro = new GetConfigure.SettingExambro();
				JsonConvert.PopulateObject(value, settingExambro);
				((Control)QqwGEs7j4l).Text = settingExambro.passwd;
				BYlGTwblRR.Checked = settingExambro.moda == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65E3C900 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea);
				A1WGGevaaw.Checked = settingExambro.moda == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AEAD5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1);
				((Control)vGIGas1rls).Text = settingExambro.unlockkeys;
				((Control)OxjG7i5Ka1).Text = settingExambro.nameapps;
				((Control)dq2GgvuZFq).Text = settingExambro.versi;
				((Control)meKGxkOdfd).Text = settingExambro.jenisbit;
				((Control)msQGnrD4j1).Text = settingExambro.hash64;
				((Control)eJbG2ArIif).Text = settingExambro.hash32;
				vWiGBXeMnS.Checked = settingExambro.aktifkamera == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C5CDF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
				X9YG4uKF0w.Value = settingExambro.HeartInterval;
				m30aGbYnCb.Value = settingExambro.ImageInterval;
				oHKaRju9jb.Value = settingExambro.PesanInterval;
				bCVaTv9oYm.Value = settingExambro.StatusInterval;
				((Control)h8uaHFjuEJ).Text = settingExambro.Kegiatan;
				z7haw9hy6O.Value = Convert.ToInt32(settingExambro.Webcam);
				FghGJGSvW8.Value = settingExambro.validheight;
				rGGGWsX7tR.Value = settingExambro.validwidth;
				O8dGcnH91l.Value = settingExambro.validram;
				((Control)qyFGZNcFZf).Text = settingExambro.sharingsession;
				DFRGtGxdfI.Checked = settingExambro.osversion[JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x12B3BEC9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_5d9c2c0b2f574c878b1c78cf0baed81d)] == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228FD4D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
				vnmG3HwClr.Checked = settingExambro.osversion[JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65D8EF2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2)] == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C652041 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
				SWwGNpf50K.Checked = settingExambro.osversion[JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D036B2F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18)] == JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1807825324 ^ -1528516416 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a);
				YYoGeZSm4e.Checked = settingExambro.osversion[JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD65EFC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3)] == JYC3AkacE3hrYs377xw.EWJ9xtjenL(--489335283 ^ 0x70C6908F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
				rjUGSHqiQ8.Checked = settingExambro.osversion[JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x76366B22 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b)] == JYC3AkacE3hrYs377xw.EWJ9xtjenL(--393691509 ^ 0x3D8C591A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4);
				((Control)XRkGPvb7JO).Text = settingExambro.urlsemionline;
				((Control)GxfGo0MDxl).Text = settingExambro.urlonline;
				((Control)UPya9qL3oh).Text = settingExambro.urlfr;
				GxdGraTWUh.Checked = settingExambro.validdesktop == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB186F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4);
				((Control)JAFGqMEZl9).Text = settingExambro.validparsemi;
				((Control)qruGAWRbWH).Text = settingExambro.validparonline;
				((Control)hdeaC9s3oe).Text = settingExambro.urlgetagent;
				tfsagOPCSA.Checked = settingExambro.validseleksi == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65DAB72 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2);
				if (settingExambro.jenisapps == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD65F24 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3))
				{
					((ListControl)mUUanqdV9U).SelectedIndex = 0;
				}
				else if (settingExambro.jenisapps == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB3C17 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4))
				{
					((ListControl)mUUanqdV9U).SelectedIndex = 1;
				}
				else
				{
					((ListControl)mUUanqdV9U).SelectedIndex = -1;
				}
			}
			else if (((Control)this).Tag.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4696BA57 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c)))
			{
				((Control)viJGVR4Rwn).Visible = false;
				((Control)zNMGKRcIDn).Visible = false;
				((Control)KhEG5rRJTA).Visible = false;
				((Control)AE9GffhdrQ).Visible = false;
				((Form)this).ClientSize = new Size(345, 200);
				((Control)A5aGio7UF8).Location = new Point(71, 155);
				((Control)CCeGD5vrCy).Location = new Point(180, 155);
				string value2 = encryption.DecryptString(encryption.ReadBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65E3E1DC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea)), encryption.passPhrase);
				GetConfigure.SettingExambro settingExambro2 = new GetConfigure.SettingExambro();
				JsonConvert.PopulateObject(value2, settingExambro2);
				((Control)QqwGEs7j4l).Text = settingExambro2.passwd;
				BYlGTwblRR.Checked = settingExambro2.moda == JYC3AkacE3hrYs377xw.EWJ9xtjenL(-810996197 ^ -1411609033 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b);
				A1WGGevaaw.Checked = settingExambro2.moda == JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C4007 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6);
				((Control)vGIGas1rls).Text = settingExambro2.unlockkeys;
			}
		}

		private void QVdRkiT0yv(object P_0, EventArgs P_1)
		{
			jAoREa6dLw();
		}

		private void EPyRmuKCBE(object P_0, EventArgs P_1)
		{
			if (((Control)this).Tag.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AB030 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08)))
			{
				GetConfigure.SettingExambro settingExambro = new GetConfigure.SettingExambro();
				settingExambro.passwd = ((Control)QqwGEs7j4l).Text;
				settingExambro.nameapps = ((Control)OxjG7i5Ka1).Text;
				settingExambro.versi = ((Control)dq2GgvuZFq).Text;
				settingExambro.jenisbit = ((Control)meKGxkOdfd).Text;
				settingExambro.hash64 = ((Control)msQGnrD4j1).Text;
				settingExambro.hash32 = ((Control)eJbG2ArIif).Text;
				settingExambro.moda = (A1WGGevaaw.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6512248F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7636414E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b));
				settingExambro.unlockkeys = ((Control)vGIGas1rls).Text;
				settingExambro.aktifkamera = (vWiGBXeMnS.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1089798187 ^ -2089820268 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324D1A8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10));
				settingExambro.HeartInterval = Convert.ToInt32(X9YG4uKF0w.Value);
				settingExambro.ImageInterval = Convert.ToInt32(m30aGbYnCb.Value);
				settingExambro.PesanInterval = Convert.ToInt32(oHKaRju9jb.Value);
				settingExambro.StatusInterval = Convert.ToInt32(bCVaTv9oYm.Value);
				settingExambro.Kegiatan = ((Control)h8uaHFjuEJ).Text;
				settingExambro.Webcam = z7haw9hy6O.Value.ToString();
				settingExambro.validheight = Convert.ToInt32(FghGJGSvW8.Value);
				settingExambro.validwidth = Convert.ToInt32(rGGGWsX7tR.Value);
				settingExambro.validram = Convert.ToInt32(O8dGcnH91l.Value);
				settingExambro.sharingsession = ((Control)qyFGZNcFZf).Text;
				settingExambro.osversion.Add(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC1C92 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7), DFRGtGxdfI.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x313635DF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x40A398A3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9));
				settingExambro.osversion.Add(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E60B1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783), vnmG3HwClr.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3DF35 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B8AF95 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e));
				settingExambro.osversion.Add(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EB95D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5), SWwGNpf50K.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FD517D9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA760C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a));
				settingExambro.osversion.Add(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA6F86 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3), YYoGeZSm4e.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB186F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB33E0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79));
				settingExambro.osversion.Add(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C6449 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6), rjUGSHqiQ8.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD67B4E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7599253C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8));
				settingExambro.urlsemionline = ((Control)XRkGPvb7JO).Text;
				settingExambro.urlonline = ((Control)GxfGo0MDxl).Text;
				settingExambro.urlfr = ((Control)UPya9qL3oh).Text;
				settingExambro.validdesktop = (GxdGraTWUh.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x10D46A0D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C1BB4CB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83));
				settingExambro.validparsemi = ((Control)JAFGqMEZl9).Text;
				settingExambro.validparonline = ((Control)qruGAWRbWH).Text;
				settingExambro.urlgetagent = ((Control)hdeaC9s3oe).Text;
				settingExambro.validseleksi = (tfsagOPCSA.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B4F40 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1AB070 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08));
				settingExambro.jenisapps = mUUanqdV9U.SelectedItem.ToString();
				string plainText = JsonConvert.SerializeObject(settingExambro);
				encryption.WriteBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAC571 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8), encryption.EncryptString(plainText, encryption.passPhrase));
				((Form)this).Close();
				Process.Start(Process.GetCurrentProcess().MainModule.FileName);
				Process.GetCurrentProcess().Kill();
			}
			else if (((Control)this).Tag.Equals(JYC3AkacE3hrYs377xw.EWJ9xtjenL(--489335283 ^ 0x4131E659 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f)))
			{
				string value = encryption.DecryptString(encryption.ReadBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29E78A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6)), encryption.passPhrase);
				GetConfigure.SettingExambro settingExambro2 = new GetConfigure.SettingExambro();
				JsonConvert.PopulateObject(value, settingExambro2);
				settingExambro2.passwd = ((Control)QqwGEs7j4l).Text;
				settingExambro2.moda = (A1WGGevaaw.Checked ? JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45E9CC7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5) : JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C652E63 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50));
				settingExambro2.unlockkeys = ((Control)vGIGas1rls).Text;
				string plainText2 = JsonConvert.SerializeObject(settingExambro2);
				encryption.WriteBinFile(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFE851E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83), encryption.EncryptString(plainText2, encryption.passPhrase));
				((Form)this).Close();
				Process.Start(Process.GetCurrentProcess().MainModule.FileName);
				Process.GetCurrentProcess().Kill();
			}
		}

		private void iOOR4J95hX(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && uZ3aOyU6mZ != null)
			{
				uZ3aOyU6mZ.Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void OhlRYDvcyl()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected Obj, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected Obj, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected Obj, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected Obj, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected Obj, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected Obj, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected Obj, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected Obj, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected Obj, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected Obj, but got Unknown
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected Obj, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected Obj, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected Obj, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected Obj, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected Obj, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected Obj, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected Obj, but got Unknown
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected Obj, but got Unknown
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected Obj, but got Unknown
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected Obj, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected Obj, but got Unknown
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected Obj, but got Unknown
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected Obj, but got Unknown
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected Obj, but got Unknown
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected Obj, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected Obj, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected Obj, but got Unknown
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Expected Obj, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected Obj, but got Unknown
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Expected Obj, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected Obj, but got Unknown
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected Obj, but got Unknown
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected Obj, but got Unknown
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Expected Obj, but got Unknown
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Expected Obj, but got Unknown
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Expected Obj, but got Unknown
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected Obj, but got Unknown
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected Obj, but got Unknown
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected Obj, but got Unknown
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected Obj, but got Unknown
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Expected Obj, but got Unknown
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Expected Obj, but got Unknown
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Expected Obj, but got Unknown
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Expected Obj, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Expected Obj, but got Unknown
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected Obj, but got Unknown
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Expected Obj, but got Unknown
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Expected Obj, but got Unknown
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Expected Obj, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Expected Obj, but got Unknown
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Expected Obj, but got Unknown
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_0330: Expected Obj, but got Unknown
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected Obj, but got Unknown
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected Obj, but got Unknown
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Expected Obj, but got Unknown
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Expected Obj, but got Unknown
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Expected Obj, but got Unknown
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Expected Obj, but got Unknown
			//IL_058b: Unknown result type (might be due to invalid IL or missing references)
			//IL_060f: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_078c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0834: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8d: Expected Obj, but got Unknown
			//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad4: Expected Obj, but got Unknown
			//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1045: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_117d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1234: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1371: Unknown result type (might be due to invalid IL or missing references)
			//IL_142f: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_156e: Unknown result type (might be due to invalid IL or missing references)
			//IL_161a: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1755: Unknown result type (might be due to invalid IL or missing references)
			//IL_17fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1876: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_196d: Unknown result type (might be due to invalid IL or missing references)
			//IL_19fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_1caf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ded: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df7: Expected Obj, but got Unknown
			//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_228e: Unknown result type (might be due to invalid IL or missing references)
			//IL_234c: Unknown result type (might be due to invalid IL or missing references)
			//IL_23f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_249c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2523: Unknown result type (might be due to invalid IL or missing references)
			//IL_25c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2641: Unknown result type (might be due to invalid IL or missing references)
			//IL_26ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_276c: Unknown result type (might be due to invalid IL or missing references)
			//IL_27f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_28a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2962: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a09: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b04: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d08: Expected Obj, but got Unknown
			//IL_2fb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_303d: Unknown result type (might be due to invalid IL or missing references)
			//IL_30ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_3265: Unknown result type (might be due to invalid IL or missing references)
			//IL_331d: Unknown result type (might be due to invalid IL or missing references)
			//IL_33d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_348d: Unknown result type (might be due to invalid IL or missing references)
			//IL_352e: Unknown result type (might be due to invalid IL or missing references)
			//IL_35dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_369c: Unknown result type (might be due to invalid IL or missing references)
			//IL_374d: Unknown result type (might be due to invalid IL or missing references)
			//IL_37fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_389d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3940: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a96: Expected Obj, but got Unknown
			//IL_3b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c23: Unknown result type (might be due to invalid IL or missing references)
			//IL_3db2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dbc: Expected Obj, but got Unknown
			//IL_3dbf: Unknown result type (might be due to invalid IL or missing references)
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_Settings));
			BUYRzTYR0x = new Panel();
			QqwGEs7j4l = new TextBox();
			Cm4Gkume3X = new Label();
			BYlGTwblRR = new RadioButton();
			hDhGRDxngp = new Label();
			A1WGGevaaw = new RadioButton();
			vGIGas1rls = new TextBox();
			uWjG9xSrAS = new Label();
			PujGwkhsQy = new Panel();
			fNYGHZ4jqi = new Label();
			viJGVR4Rwn = new Panel();
			gfMaVE2snQ = new Label();
			CaiaBL2PMI = new Label();
			z7haw9hy6O = new NumericUpDown();
			h8uaHFjuEJ = new TextBox();
			NulGYDDNif = new Label();
			nm8GUQEYA6 = new Label();
			w7mGz694AV = new Label();
			bCVaTv9oYm = new NumericUpDown();
			oHKaRju9jb = new NumericUpDown();
			m30aGbYnCb = new NumericUpDown();
			X9YG4uKF0w = new NumericUpDown();
			bplGmQl8Nl = new Label();
			vWiGBXeMnS = new CheckBox();
			meKGxkOdfd = new TextBox();
			XgYGCRKKnY = new Label();
			dq2GgvuZFq = new TextBox();
			eJbG2ArIif = new TextBox();
			msQGnrD4j1 = new TextBox();
			OxjG7i5Ka1 = new TextBox();
			J44GOT5QkO = new Label();
			JWtGu8D0lP = new Label();
			PvpG0dKOkY = new Label();
			GAKGjIsuIG = new Label();
			ovjGpOVLTK = new Label();
			zNMGKRcIDn = new Panel();
			F3jGsrM7Oj = new Label();
			KhEG5rRJTA = new Panel();
			mUUanqdV9U = new ComboBox();
			VV8a7QWO17 = new Label();
			tfsagOPCSA = new CheckBox();
			iP5a2Ilptk = new Label();
			NstaxJMrFv = new Label();
			hdeaC9s3oe = new TextBox();
			TINaaZMl6L = new Label();
			UPya9qL3oh = new TextBox();
			qruGAWRbWH = new TextBox();
			QSvGI8Z8Pf = new Label();
			JAFGqMEZl9 = new TextBox();
			k7EG88xN14 = new Label();
			GxdGraTWUh = new CheckBox();
			OsVGyQljiE = new Label();
			GxfGo0MDxl = new TextBox();
			XRkGPvb7JO = new TextBox();
			txJGQSwqsX = new Label();
			LZ2GbA0Yae = new Label();
			AE9GffhdrQ = new Panel();
			FOcGv4QbqX = new Label();
			eKnGlAjVm8 = new Panel();
			qyFGZNcFZf = new TextBox();
			VHlGdxa9HO = new Label();
			rjUGSHqiQ8 = new CheckBox();
			YYoGeZSm4e = new CheckBox();
			SWwGNpf50K = new CheckBox();
			vnmG3HwClr = new CheckBox();
			DFRGtGxdfI = new CheckBox();
			Ct2GLDm4tv = new Label();
			FghGJGSvW8 = new NumericUpDown();
			rGGGWsX7tR = new NumericUpDown();
			UjnG6Q4MxV = new Label();
			tXJGMXkeXH = new Label();
			qvHGXedrwh = new Label();
			O8dGcnH91l = new NumericUpDown();
			H2GGFMDm7q = new Label();
			v4MGhakT0E = new Panel();
			znrG1MOUlk = new Label();
			CCeGD5vrCy = new Button();
			A5aGio7UF8 = new Button();
			((Control)BUYRzTYR0x).SuspendLayout();
			((Control)PujGwkhsQy).SuspendLayout();
			((Control)viJGVR4Rwn).SuspendLayout();
			((ISupportInitialize)z7haw9hy6O).BeginInit();
			((ISupportInitialize)bCVaTv9oYm).BeginInit();
			((ISupportInitialize)oHKaRju9jb).BeginInit();
			((ISupportInitialize)m30aGbYnCb).BeginInit();
			((ISupportInitialize)X9YG4uKF0w).BeginInit();
			((Control)zNMGKRcIDn).SuspendLayout();
			((Control)KhEG5rRJTA).SuspendLayout();
			((Control)AE9GffhdrQ).SuspendLayout();
			((Control)eKnGlAjVm8).SuspendLayout();
			((ISupportInitialize)FghGJGSvW8).BeginInit();
			((ISupportInitialize)rGGGWsX7tR).BeginInit();
			((ISupportInitialize)O8dGcnH91l).BeginInit();
			((Control)v4MGhakT0E).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)BUYRzTYR0x).BackColor = SystemColors.Control;
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)QqwGEs7j4l);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)Cm4Gkume3X);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)BYlGTwblRR);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)hDhGRDxngp);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)A1WGGevaaw);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)vGIGas1rls);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)uWjG9xSrAS);
			((Control)BUYRzTYR0x).Controls.Add((Control)(object)PujGwkhsQy);
			((Control)BUYRzTYR0x).Location = new Point(20, 12);
			((Control)BUYRzTYR0x).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C5432DD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8);
			((Control)BUYRzTYR0x).Size = new Size(416, 169);
			((Control)BUYRzTYR0x).TabIndex = 0;
			((Control)QqwGEs7j4l).Location = new Point(152, 48);
			((Control)QqwGEs7j4l).Margin = new Padding(1);
			((Control)QqwGEs7j4l).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8715DB1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)QqwGEs7j4l).Size = new Size(237, 22);
			((Control)QqwGEs7j4l).TabIndex = 31;
			((Control)Cm4Gkume3X).AutoSize = true;
			((Control)Cm4Gkume3X).Location = new Point(9, 48);
			((Control)Cm4Gkume3X).Margin = new Padding(4, 0, 4, 0);
			((Control)Cm4Gkume3X).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2AFB3CAF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4);
			((Control)Cm4Gkume3X).Size = new Size(67, 16);
			((Control)Cm4Gkume3X).TabIndex = 30;
			((Control)Cm4Gkume3X).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xDB75E93 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c874f2a03b794f3795625c7f6b64f71e);
			((Control)BYlGTwblRR).AutoSize = true;
			((Control)BYlGTwblRR).Location = new Point(296, 125);
			((Control)BYlGTwblRR).Margin = new Padding(4);
			((Control)BYlGTwblRR).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B88BD3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e);
			((Control)BYlGTwblRR).Size = new Size(90, 20);
			((Control)BYlGTwblRR).TabIndex = 29;
			BYlGTwblRR.TabStop = true;
			((Control)BYlGTwblRR).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18ADBE9B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361);
			((ButtonBase)BYlGTwblRR).UseVisualStyleBackColor = true;
			((Control)hDhGRDxngp).AutoSize = true;
			((Control)hDhGRDxngp).Location = new Point(9, 126);
			((Control)hDhGRDxngp).Margin = new Padding(4, 0, 4, 0);
			((Control)hDhGRDxngp).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E61AF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
			((Control)hDhGRDxngp).Size = new Size(104, 16);
			((Control)hDhGRDxngp).TabIndex = 28;
			((Control)hDhGRDxngp).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x12B3BF8B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_5d9c2c0b2f574c878b1c78cf0baed81d);
			((Control)A1WGGevaaw).AutoSize = true;
			((Control)A1WGGevaaw).Location = new Point(152, 125);
			((Control)A1WGGevaaw).Margin = new Padding(4);
			((Control)A1WGGevaaw).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x12B3B077 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_5d9c2c0b2f574c878b1c78cf0baed81d);
			((Control)A1WGGevaaw).Size = new Size(100, 20);
			((Control)A1WGGevaaw).TabIndex = 27;
			A1WGGevaaw.TabStop = true;
			((Control)A1WGGevaaw).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FFB6D2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
			((ButtonBase)A1WGGevaaw).UseVisualStyleBackColor = true;
			((Control)vGIGas1rls).Location = new Point(152, 86);
			((Control)vGIGas1rls).Margin = new Padding(1);
			((Control)vGIGas1rls).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29EA78 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6);
			((Control)vGIGas1rls).Size = new Size(237, 22);
			((Control)vGIGas1rls).TabIndex = 26;
			((Control)uWjG9xSrAS).AutoSize = true;
			((Control)uWjG9xSrAS).Location = new Point(9, 86);
			((Control)uWjG9xSrAS).Margin = new Padding(4, 0, 4, 0);
			((Control)uWjG9xSrAS).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DB903 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a);
			((Control)uWjG9xSrAS).Size = new Size(82, 16);
			((Control)uWjG9xSrAS).TabIndex = 25;
			((Control)uWjG9xSrAS).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC12AC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)PujGwkhsQy).BackColor = SystemColors.Highlight;
			((Control)PujGwkhsQy).Controls.Add((Control)(object)fNYGHZ4jqi);
			((Control)PujGwkhsQy).Location = new Point(2, 1);
			((Control)PujGwkhsQy).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DB9DB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a);
			((Control)PujGwkhsQy).Size = new Size(414, 29);
			((Control)PujGwkhsQy).TabIndex = 0;
			((Control)PujGwkhsQy).Paint += QaDRUwnW89;
			((Control)fNYGHZ4jqi).AutoSize = true;
			((Control)fNYGHZ4jqi).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1A9B60 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08), 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)fNYGHZ4jqi).ForeColor = SystemColors.ButtonHighlight;
			((Control)fNYGHZ4jqi).Location = new Point(95, 0);
			((Control)fNYGHZ4jqi).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(--489335283 ^ 0x68B3AAE1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8);
			((Control)fNYGHZ4jqi).Size = new Size(216, 27);
			((Control)fNYGHZ4jqi).TabIndex = 30;
			((Control)fNYGHZ4jqi).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x63518B47 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
			((Control)viJGVR4Rwn).BackColor = SystemColors.Control;
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)gfMaVE2snQ);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)CaiaBL2PMI);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)z7haw9hy6O);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)h8uaHFjuEJ);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)NulGYDDNif);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)nm8GUQEYA6);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)w7mGz694AV);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)bCVaTv9oYm);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)oHKaRju9jb);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)m30aGbYnCb);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)X9YG4uKF0w);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)bplGmQl8Nl);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)vWiGBXeMnS);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)meKGxkOdfd);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)XgYGCRKKnY);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)dq2GgvuZFq);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)eJbG2ArIif);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)msQGnrD4j1);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)OxjG7i5Ka1);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)J44GOT5QkO);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)JWtGu8D0lP);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)PvpG0dKOkY);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)GAKGjIsuIG);
			((Control)viJGVR4Rwn).Controls.Add((Control)(object)ovjGpOVLTK);
			((Control)viJGVR4Rwn).Location = new Point(20, 199);
			((Control)viJGVR4Rwn).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x40A3B275 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9);
			((Control)viJGVR4Rwn).Size = new Size(416, 479);
			((Control)viJGVR4Rwn).TabIndex = 1;
			((Control)gfMaVE2snQ).AutoSize = true;
			((Control)gfMaVE2snQ).Location = new Point(9, 431);
			((Control)gfMaVE2snQ).Margin = new Padding(4, 0, 4, 0);
			((Control)gfMaVE2snQ).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D1D99 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0);
			((Control)gfMaVE2snQ).Size = new Size(102, 16);
			((Control)gfMaVE2snQ).TabIndex = 68;
			((Control)gfMaVE2snQ).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EB6BB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
			((Control)CaiaBL2PMI).AutoSize = true;
			((Control)CaiaBL2PMI).Location = new Point(9, 394);
			((Control)CaiaBL2PMI).Margin = new Padding(4, 0, 4, 0);
			((Control)CaiaBL2PMI).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x43B0FCC1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb4c51c87e664f2a80b08fdc8c7d117f);
			((Control)CaiaBL2PMI).Size = new Size(81, 16);
			((Control)CaiaBL2PMI).TabIndex = 67;
			((Control)CaiaBL2PMI).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B6574 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
			((Control)z7haw9hy6O).Location = new Point(151, 431);
			((Control)z7haw9hy6O).Margin = new Padding(2);
			z7haw9hy6O.Maximum = new decimal(new int[4] { 600000, 0, 0, 0 });
			((Control)z7haw9hy6O).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D801084 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd);
			((UpDownBase)z7haw9hy6O).ReadOnly = true;
			((Control)z7haw9hy6O).Size = new Size(235, 22);
			((Control)z7haw9hy6O).TabIndex = 66;
			((Control)h8uaHFjuEJ).Location = new Point(151, 394);
			((Control)h8uaHFjuEJ).Margin = new Padding(1);
			((Control)h8uaHFjuEJ).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1A9A04 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08);
			((Control)h8uaHFjuEJ).Size = new Size(237, 22);
			((Control)h8uaHFjuEJ).TabIndex = 65;
			((Control)NulGYDDNif).AutoSize = true;
			((Control)NulGYDDNif).Location = new Point(9, 358);
			((Control)NulGYDDNif).Margin = new Padding(4, 0, 4, 0);
			((Control)NulGYDDNif).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD651DC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
			((Control)NulGYDDNif).Size = new Size(121, 16);
			((Control)NulGYDDNif).TabIndex = 64;
			((Control)NulGYDDNif).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x63518A43 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
			((Control)nm8GUQEYA6).AutoSize = true;
			((Control)nm8GUQEYA6).Location = new Point(9, 320);
			((Control)nm8GUQEYA6).Margin = new Padding(4, 0, 4, 0);
			((Control)nm8GUQEYA6).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC1036 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)nm8GUQEYA6).Size = new Size(123, 16);
			((Control)nm8GUQEYA6).TabIndex = 63;
			((Control)nm8GUQEYA6).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C7585 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
			((Control)w7mGz694AV).AutoSize = true;
			((Control)w7mGz694AV).Location = new Point(9, 285);
			((Control)w7mGz694AV).Margin = new Padding(4, 0, 4, 0);
			((Control)w7mGz694AV).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EA6348 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3);
			((Control)w7mGz694AV).Size = new Size(122, 16);
			((Control)w7mGz694AV).TabIndex = 62;
			((Control)w7mGz694AV).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585E93C4 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
			((Control)bCVaTv9oYm).Location = new Point(151, 358);
			((Control)bCVaTv9oYm).Margin = new Padding(2);
			bCVaTv9oYm.Maximum = new decimal(new int[4] { 600000, 0, 0, 0 });
			((Control)bCVaTv9oYm).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65D8244 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2);
			((Control)bCVaTv9oYm).Size = new Size(235, 22);
			((Control)bCVaTv9oYm).TabIndex = 61;
			((Control)oHKaRju9jb).Location = new Point(151, 320);
			((Control)oHKaRju9jb).Margin = new Padding(2);
			oHKaRju9jb.Maximum = new decimal(new int[4] { 600000, 0, 0, 0 });
			((Control)oHKaRju9jb).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x31361C05 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b);
			((Control)oHKaRju9jb).Size = new Size(235, 22);
			((Control)oHKaRju9jb).TabIndex = 60;
			m30aGbYnCb.Increment = new decimal(new int[4] { 1000, 0, 0, 0 });
			((Control)m30aGbYnCb).Location = new Point(151, 285);
			((Control)m30aGbYnCb).Margin = new Padding(2);
			m30aGbYnCb.Maximum = new decimal(new int[4] { 300000, 0, 0, 0 });
			((Control)m30aGbYnCb).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1EC46A56 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2);
			((Control)m30aGbYnCb).Size = new Size(235, 22);
			((Control)m30aGbYnCb).TabIndex = 59;
			((Control)X9YG4uKF0w).Location = new Point(151, 216);
			((Control)X9YG4uKF0w).Margin = new Padding(2);
			X9YG4uKF0w.Maximum = new decimal(new int[4] { 600000, 0, 0, 0 });
			((Control)X9YG4uKF0w).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D6A8AC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711);
			((Control)X9YG4uKF0w).Size = new Size(235, 22);
			((Control)X9YG4uKF0w).TabIndex = 58;
			((Control)bplGmQl8Nl).AutoSize = true;
			((Control)bplGmQl8Nl).Location = new Point(9, 216);
			((Control)bplGmQl8Nl).Margin = new Padding(1, 0, 1, 0);
			((Control)bplGmQl8Nl).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(-1089798187 ^ -1426764851 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
			((Control)bplGmQl8Nl).Size = new Size(86, 16);
			((Control)bplGmQl8Nl).TabIndex = 38;
			((Control)bplGmQl8Nl).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC1126 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)vWiGBXeMnS).AutoSize = true;
			((Control)vWiGBXeMnS).Location = new Point(152, 252);
			((Control)vWiGBXeMnS).Margin = new Padding(1);
			((Control)vWiGBXeMnS).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D6A948 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711);
			((Control)vWiGBXeMnS).Size = new Size(72, 20);
			((Control)vWiGBXeMnS).TabIndex = 37;
			((Control)vWiGBXeMnS).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585E92D2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
			((ButtonBase)vWiGBXeMnS).UseVisualStyleBackColor = true;
			((Control)meKGxkOdfd).Location = new Point(152, 110);
			((Control)meKGxkOdfd).Margin = new Padding(1);
			((Control)meKGxkOdfd).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F864C2B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e);
			((Control)meKGxkOdfd).Size = new Size(237, 22);
			((Control)meKGxkOdfd).TabIndex = 11;
			((Control)XgYGCRKKnY).AutoSize = true;
			((Control)XgYGCRKKnY).Location = new Point(9, 252);
			((Control)XgYGCRKKnY).Margin = new Padding(4, 0, 4, 0);
			((Control)XgYGCRKKnY).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3F7FB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2);
			((Control)XgYGCRKKnY).Size = new Size(82, 16);
			((Control)XgYGCRKKnY).TabIndex = 36;
			((Control)XgYGCRKKnY).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5C1B67AA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f);
			((Control)dq2GgvuZFq).Location = new Point(152, 78);
			((Control)dq2GgvuZFq).Margin = new Padding(1);
			((Control)dq2GgvuZFq).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x10D4428B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f);
			((Control)dq2GgvuZFq).Size = new Size(237, 22);
			((Control)dq2GgvuZFq).TabIndex = 10;
			((Control)eJbG2ArIif).Location = new Point(152, 183);
			((Control)eJbG2ArIif).Margin = new Padding(1);
			((Control)eJbG2ArIif).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x63518843 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
			((Control)eJbG2ArIif).Size = new Size(237, 22);
			((Control)eJbG2ArIif).TabIndex = 35;
			((Control)msQGnrD4j1).Location = new Point(152, 148);
			((Control)msQGnrD4j1).Margin = new Padding(1);
			((Control)msQGnrD4j1).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6351885D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80);
			((Control)msQGnrD4j1).Size = new Size(237, 22);
			((Control)msQGnrD4j1).TabIndex = 34;
			((Control)OxjG7i5Ka1).Location = new Point(152, 46);
			((Control)OxjG7i5Ka1).Margin = new Padding(1);
			((Control)OxjG7i5Ka1).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x87156CD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)OxjG7i5Ka1).Size = new Size(237, 22);
			((Control)OxjG7i5Ka1).TabIndex = 9;
			((Control)J44GOT5QkO).AutoSize = true;
			((Control)J44GOT5QkO).Location = new Point(9, 183);
			((Control)J44GOT5QkO).Margin = new Padding(1, 0, 1, 0);
			((Control)J44GOT5QkO).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC238B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
			((Control)J44GOT5QkO).Size = new Size(70, 16);
			((Control)J44GOT5QkO).TabIndex = 33;
			((Control)J44GOT5QkO).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DBD23 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a);
			((Control)JWtGu8D0lP).AutoSize = true;
			((Control)JWtGu8D0lP).Location = new Point(9, 110);
			((Control)JWtGu8D0lP).Margin = new Padding(1, 0, 1, 0);
			((Control)JWtGu8D0lP).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DBD1B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a);
			((Control)JWtGu8D0lP).Size = new Size(96, 16);
			((Control)JWtGu8D0lP).TabIndex = 8;
			((Control)JWtGu8D0lP).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20F9C3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
			((Control)PvpG0dKOkY).AutoSize = true;
			((Control)PvpG0dKOkY).Location = new Point(9, 148);
			((Control)PvpG0dKOkY).Margin = new Padding(1, 0, 1, 0);
			((Control)PvpG0dKOkY).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D036151 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18);
			((Control)PvpG0dKOkY).Size = new Size(70, 16);
			((Control)PvpG0dKOkY).TabIndex = 32;
			((Control)PvpG0dKOkY).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C650FBF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
			((Control)GAKGjIsuIG).AutoSize = true;
			((Control)GAKGjIsuIG).Location = new Point(9, 46);
			((Control)GAKGjIsuIG).Margin = new Padding(1, 0, 1, 0);
			((Control)GAKGjIsuIG).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29EEE2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6);
			((Control)GAKGjIsuIG).Size = new Size(79, 16);
			((Control)GAKGjIsuIG).TabIndex = 7;
			((Control)GAKGjIsuIG).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(--1696630615 ^ 0x5BC9BE53 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed);
			((Control)ovjGpOVLTK).AutoSize = true;
			((Control)ovjGpOVLTK).Location = new Point(9, 78);
			((Control)ovjGpOVLTK).Margin = new Padding(1, 0, 1, 0);
			((Control)ovjGpOVLTK).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x87157D5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)ovjGpOVLTK).Size = new Size(95, 16);
			((Control)ovjGpOVLTK).TabIndex = 6;
			((Control)ovjGpOVLTK).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C7285 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
			((Control)zNMGKRcIDn).BackColor = SystemColors.Highlight;
			((Control)zNMGKRcIDn).Controls.Add((Control)(object)F3jGsrM7Oj);
			((Control)zNMGKRcIDn).Location = new Point(21, 199);
			((Control)zNMGKRcIDn).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EB2B3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
			((Control)zNMGKRcIDn).Size = new Size(414, 29);
			((Control)zNMGKRcIDn).TabIndex = 31;
			((Control)F3jGsrM7Oj).AutoSize = true;
			((Control)F3jGsrM7Oj).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB61890 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4), 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)F3jGsrM7Oj).ForeColor = SystemColors.ButtonHighlight;
			((Control)F3jGsrM7Oj).Location = new Point(95, 0);
			((Control)F3jGsrM7Oj).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB1D6A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79);
			((Control)F3jGsrM7Oj).Size = new Size(208, 27);
			((Control)F3jGsrM7Oj).TabIndex = 30;
			((Control)F3jGsrM7Oj).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F864A23 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e);
			((Control)KhEG5rRJTA).BackColor = SystemColors.Control;
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)mUUanqdV9U);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)VV8a7QWO17);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)tfsagOPCSA);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)iP5a2Ilptk);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)NstaxJMrFv);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)hdeaC9s3oe);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)TINaaZMl6L);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)UPya9qL3oh);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)qruGAWRbWH);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)QSvGI8Z8Pf);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)JAFGqMEZl9);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)k7EG88xN14);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)GxdGraTWUh);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)OsVGyQljiE);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)GxfGo0MDxl);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)XRkGPvb7JO);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)txJGQSwqsX);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)LZ2GbA0Yae);
			((Control)KhEG5rRJTA).Controls.Add((Control)(object)AE9GffhdrQ);
			((Control)KhEG5rRJTA).Location = new Point(468, 14);
			((Control)KhEG5rRJTA).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C1B9A95 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83);
			((Control)KhEG5rRJTA).Size = new Size(416, 384);
			((Control)KhEG5rRJTA).TabIndex = 32;
			mUUanqdV9U.DropDownStyle = (ComboBoxStyle)2;
			((ListControl)mUUanqdV9U).FormattingEnabled = true;
			mUUanqdV9U.Items.AddRange(new object[2]
			{
				JYC3AkacE3hrYs377xw.EWJ9xtjenL(--826623140 ^ 0x44DC456A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8),
				JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DB64D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a)
			});
			((Control)mUUanqdV9U).Location = new Point(161, 319);
			((Control)mUUanqdV9U).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x31361B05 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b);
			((Control)mUUanqdV9U).Size = new Size(237, 24);
			((Control)mUUanqdV9U).TabIndex = 54;
			((Control)VV8a7QWO17).AutoSize = true;
			((Control)VV8a7QWO17).Location = new Point(21, 319);
			((Control)VV8a7QWO17).Margin = new Padding(4, 0, 4, 0);
			((Control)VV8a7QWO17).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20F8F9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
			((Control)VV8a7QWO17).Size = new Size(74, 16);
			((Control)VV8a7QWO17).TabIndex = 53;
			((Control)VV8a7QWO17).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EB24B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
			((Control)tfsagOPCSA).AutoSize = true;
			((Control)tfsagOPCSA).Location = new Point(161, 285);
			((Control)tfsagOPCSA).Margin = new Padding(1);
			((Control)tfsagOPCSA).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC17D8 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)tfsagOPCSA).Size = new Size(72, 20);
			((Control)tfsagOPCSA).TabIndex = 52;
			((Control)tfsagOPCSA).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC24ED ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
			((ButtonBase)tfsagOPCSA).UseVisualStyleBackColor = true;
			((Control)iP5a2Ilptk).AutoSize = true;
			((Control)iP5a2Ilptk).Location = new Point(18, 285);
			((Control)iP5a2Ilptk).Margin = new Padding(4, 0, 4, 0);
			((Control)iP5a2Ilptk).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29EC3E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6);
			((Control)iP5a2Ilptk).Size = new Size(52, 16);
			((Control)iP5a2Ilptk).TabIndex = 51;
			((Control)iP5a2Ilptk).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3F257 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2);
			((Control)NstaxJMrFv).AutoSize = true;
			((Control)NstaxJMrFv).Location = new Point(18, 118);
			((Control)NstaxJMrFv).Margin = new Padding(4, 0, 4, 0);
			((Control)NstaxJMrFv).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228D03D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
			((Control)NstaxJMrFv).Size = new Size(72, 16);
			((Control)NstaxJMrFv).TabIndex = 50;
			((Control)NstaxJMrFv).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD65640 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
			((Control)hdeaC9s3oe).Location = new Point(161, 112);
			((Control)hdeaC9s3oe).Margin = new Padding(1);
			((Control)hdeaC9s3oe).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBF08F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa);
			((Control)hdeaC9s3oe).Size = new Size(237, 22);
			((Control)hdeaC9s3oe).TabIndex = 49;
			((Control)TINaaZMl6L).AutoSize = true;
			((Control)TINaaZMl6L).Location = new Point(18, 247);
			((Control)TINaaZMl6L).Margin = new Padding(4, 0, 4, 0);
			((Control)TINaaZMl6L).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD65688 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3);
			((Control)TINaaZMl6L).Size = new Size(55, 16);
			((Control)TINaaZMl6L).TabIndex = 48;
			((Control)TINaaZMl6L).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x280E68EB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783);
			((Control)UPya9qL3oh).Location = new Point(161, 247);
			((Control)UPya9qL3oh).Margin = new Padding(1);
			((Control)UPya9qL3oh).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xDB7563F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_c874f2a03b794f3795625c7f6b64f71e);
			((Control)UPya9qL3oh).Size = new Size(237, 22);
			((Control)UPya9qL3oh).TabIndex = 47;
			((Control)qruGAWRbWH).Location = new Point(161, 212);
			((Control)qruGAWRbWH).Margin = new Padding(1);
			((Control)qruGAWRbWH).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8715415 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)qruGAWRbWH).Size = new Size(237, 22);
			((Control)qruGAWRbWH).TabIndex = 45;
			((Control)QSvGI8Z8Pf).AutoSize = true;
			((Control)QSvGI8Z8Pf).Location = new Point(18, 212);
			((Control)QSvGI8Z8Pf).Margin = new Padding(4, 0, 4, 0);
			((Control)QSvGI8Z8Pf).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585E9762 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
			((Control)QSvGI8Z8Pf).Size = new Size(111, 16);
			((Control)QSvGI8Z8Pf).TabIndex = 44;
			((Control)QSvGI8Z8Pf).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x87155D5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)JAFGqMEZl9).Location = new Point(161, 180);
			((Control)JAFGqMEZl9).Margin = new Padding(1);
			((Control)JAFGqMEZl9).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB1F12 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79);
			((Control)JAFGqMEZl9).Size = new Size(237, 22);
			((Control)JAFGqMEZl9).TabIndex = 43;
			((Control)k7EG88xN14).AutoSize = true;
			((Control)k7EG88xN14).Location = new Point(18, 180);
			((Control)k7EG88xN14).Margin = new Padding(4, 0, 4, 0);
			((Control)k7EG88xN14).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x10D44607 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f);
			((Control)k7EG88xN14).Size = new Size(104, 16);
			((Control)k7EG88xN14).TabIndex = 42;
			((Control)k7EG88xN14).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1D801674 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd);
			((Control)GxdGraTWUh).AutoSize = true;
			((Control)GxdGraTWUh).Location = new Point(161, 146);
			((Control)GxdGraTWUh).Margin = new Padding(1);
			((Control)GxdGraTWUh).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6512084D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb);
			((Control)GxdGraTWUh).Size = new Size(72, 20);
			((Control)GxdGraTWUh).TabIndex = 41;
			((Control)GxdGraTWUh).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB1B62 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79);
			((ButtonBase)GxdGraTWUh).UseVisualStyleBackColor = true;
			((Control)OsVGyQljiE).AutoSize = true;
			((Control)OsVGyQljiE).Location = new Point(18, 146);
			((Control)OsVGyQljiE).Margin = new Padding(4, 0, 4, 0);
			((Control)OsVGyQljiE).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FFB14E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d);
			((Control)OsVGyQljiE).Size = new Size(88, 16);
			((Control)OsVGyQljiE).TabIndex = 40;
			((Control)OsVGyQljiE).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20FA8D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
			((Control)GxfGo0MDxl).Location = new Point(161, 79);
			((Control)GxfGo0MDxl).Margin = new Padding(1);
			((Control)GxfGo0MDxl).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x45EB065 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5);
			((Control)GxfGo0MDxl).Size = new Size(237, 22);
			((Control)GxfGo0MDxl).TabIndex = 39;
			((Control)XRkGPvb7JO).Location = new Point(161, 46);
			((Control)XRkGPvb7JO).Margin = new Padding(1);
			((Control)XRkGPvb7JO).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC0A3A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)XRkGPvb7JO).Size = new Size(237, 22);
			((Control)XRkGPvb7JO).TabIndex = 36;
			((Control)txJGQSwqsX).AutoSize = true;
			((Control)txJGQSwqsX).Location = new Point(18, 79);
			((Control)txJGQSwqsX).Margin = new Padding(4, 0, 4, 0);
			((Control)txJGQSwqsX).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB6007E ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
			((Control)txJGQSwqsX).Size = new Size(75, 16);
			((Control)txJGQSwqsX).TabIndex = 38;
			((Control)txJGQSwqsX).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228CE4F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
			((Control)LZ2GbA0Yae).AutoSize = true;
			((Control)LZ2GbA0Yae).Location = new Point(18, 46);
			((Control)LZ2GbA0Yae).Margin = new Padding(4, 0, 4, 0);
			((Control)LZ2GbA0Yae).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFE90FA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83);
			((Control)LZ2GbA0Yae).Size = new Size(106, 16);
			((Control)LZ2GbA0Yae).TabIndex = 37;
			((Control)LZ2GbA0Yae).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8714AA1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)AE9GffhdrQ).BackColor = SystemColors.Highlight;
			((Control)AE9GffhdrQ).Controls.Add((Control)(object)FOcGv4QbqX);
			((Control)AE9GffhdrQ).Location = new Point(1, 0);
			((Control)AE9GffhdrQ).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20E5DB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
			((Control)AE9GffhdrQ).Size = new Size(414, 29);
			((Control)AE9GffhdrQ).TabIndex = 31;
			((Control)FOcGv4QbqX).AutoSize = true;
			((Control)FOcGv4QbqX).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B88485 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e), 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)FOcGv4QbqX).ForeColor = SystemColors.ButtonHighlight;
			((Control)FOcGv4QbqX).Location = new Point(95, 0);
			((Control)FOcGv4QbqX).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB600F0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
			((Control)FOcGv4QbqX).Size = new Size(204, 27);
			((Control)FOcGv4QbqX).TabIndex = 30;
			((Control)FOcGv4QbqX).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x46968945 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c);
			((Control)eKnGlAjVm8).BackColor = SystemColors.Control;
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)qyFGZNcFZf);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)VHlGdxa9HO);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)rjUGSHqiQ8);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)YYoGeZSm4e);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)SWwGNpf50K);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)vnmG3HwClr);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)DFRGtGxdfI);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)Ct2GLDm4tv);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)FghGJGSvW8);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)rGGGWsX7tR);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)UjnG6Q4MxV);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)tXJGMXkeXH);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)qvHGXedrwh);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)O8dGcnH91l);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)H2GGFMDm7q);
			((Control)eKnGlAjVm8).Controls.Add((Control)(object)v4MGhakT0E);
			((Control)eKnGlAjVm8).Location = new Point(468, 405);
			((Control)eKnGlAjVm8).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x8714A0F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd);
			((Control)eKnGlAjVm8).Size = new Size(415, 273);
			((Control)eKnGlAjVm8).TabIndex = 33;
			((Control)qyFGZNcFZf).Location = new Point(161, 237);
			((Control)qyFGZNcFZf).Margin = new Padding(1);
			((Control)qyFGZNcFZf).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAD023 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8);
			((Control)qyFGZNcFZf).Size = new Size(237, 22);
			((Control)qyFGZNcFZf).TabIndex = 41;
			((Control)VHlGdxa9HO).AutoSize = true;
			((Control)VHlGdxa9HO).Location = new Point(18, 237);
			((Control)VHlGdxa9HO).Margin = new Padding(1, 0, 1, 0);
			((Control)VHlGdxa9HO).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x763D05AF ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0);
			((Control)VHlGdxa9HO).Size = new Size(105, 16);
			((Control)VHlGdxa9HO).TabIndex = 42;
			((Control)VHlGdxa9HO).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB6016C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
			((Control)rjUGSHqiQ8).AutoSize = true;
			((Control)rjUGSHqiQ8).Location = new Point(283, 166);
			((Control)rjUGSHqiQ8).Margin = new Padding(1);
			((Control)rjUGSHqiQ8).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFE91FA ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83);
			((Control)rjUGSHqiQ8).Size = new Size(115, 20);
			((Control)rjUGSHqiQ8).TabIndex = 57;
			((Control)rjUGSHqiQ8).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3CBAB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2);
			((ButtonBase)rjUGSHqiQ8).UseVisualStyleBackColor = true;
			((Control)YYoGeZSm4e).AutoSize = true;
			((Control)YYoGeZSm4e).Location = new Point(283, 136);
			((Control)YYoGeZSm4e).Margin = new Padding(1);
			((Control)YYoGeZSm4e).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585AD8ED ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1);
			((Control)YYoGeZSm4e).Size = new Size(115, 20);
			((Control)YYoGeZSm4e).TabIndex = 56;
			((Control)YYoGeZSm4e).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228E9F7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
			((ButtonBase)YYoGeZSm4e).UseVisualStyleBackColor = true;
			((Control)SWwGNpf50K).AutoSize = true;
			((Control)SWwGNpf50K).Location = new Point(161, 197);
			((Control)SWwGNpf50K).Margin = new Padding(1);
			((Control)SWwGNpf50K).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB601C6 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
			((Control)SWwGNpf50K).Size = new Size(101, 20);
			((Control)SWwGNpf50K).TabIndex = 55;
			((Control)SWwGNpf50K).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C5409 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6);
			((ButtonBase)SWwGNpf50K).UseVisualStyleBackColor = true;
			((Control)vnmG3HwClr).AutoSize = true;
			((Control)vnmG3HwClr).Location = new Point(161, 166);
			((Control)vnmG3HwClr).Margin = new Padding(1);
			((Control)vnmG3HwClr).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DA0CD ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a);
			((Control)vnmG3HwClr).Size = new Size(94, 20);
			((Control)vnmG3HwClr).TabIndex = 54;
			((Control)vnmG3HwClr).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C6534C5 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50);
			((ButtonBase)vnmG3HwClr).UseVisualStyleBackColor = true;
			((Control)DFRGtGxdfI).AutoSize = true;
			((Control)DFRGtGxdfI).Location = new Point(161, 136);
			((Control)DFRGtGxdfI).Margin = new Padding(1);
			((Control)DFRGtGxdfI).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3EDA1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2);
			((Control)DFRGtGxdfI).Size = new Size(94, 20);
			((Control)DFRGtGxdfI).TabIndex = 52;
			((Control)DFRGtGxdfI).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4CEC1805 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f);
			((ButtonBase)DFRGtGxdfI).UseVisualStyleBackColor = true;
			((Control)Ct2GLDm4tv).AutoSize = true;
			((Control)Ct2GLDm4tv).Location = new Point(18, 136);
			((Control)Ct2GLDm4tv).Margin = new Padding(1, 0, 1, 0);
			((Control)Ct2GLDm4tv).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20E4B9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
			((Control)Ct2GLDm4tv).Size = new Size(75, 16);
			((Control)Ct2GLDm4tv).TabIndex = 53;
			((Control)Ct2GLDm4tv).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6324E07C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10);
			((Control)FghGJGSvW8).Location = new Point(311, 47);
			((Control)FghGJGSvW8).Margin = new Padding(2);
			FghGJGSvW8.Maximum = new decimal(new int[4] { 3000, 0, 0, 0 });
			((Control)FghGJGSvW8).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C5427B3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8);
			((Control)FghGJGSvW8).Size = new Size(85, 22);
			((Control)FghGJGSvW8).TabIndex = 51;
			FghGJGSvW8.Value = new decimal(new int[4] { 100, 0, 0, 0 });
			((Control)rGGGWsX7tR).Location = new Point(182, 47);
			((Control)rGGGWsX7tR).Margin = new Padding(2);
			rGGGWsX7tR.Maximum = new decimal(new int[4] { 3000, 0, 0, 0 });
			((Control)rGGGWsX7tR).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x585E8BCE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf);
			((Control)rGGGWsX7tR).Size = new Size(85, 22);
			((Control)rGGGWsX7tR).TabIndex = 50;
			rGGGWsX7tR.Value = new decimal(new int[4] { 100, 0, 0, 0 });
			((Control)UjnG6Q4MxV).AutoSize = true;
			((Control)UjnG6Q4MxV).Location = new Point(291, 52);
			((Control)UjnG6Q4MxV).Margin = new Padding(1, 0, 1, 0);
			((Control)UjnG6Q4MxV).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x425DA317 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a);
			((Control)UjnG6Q4MxV).Size = new Size(17, 16);
			((Control)UjnG6Q4MxV).TabIndex = 49;
			((Control)UjnG6Q4MxV).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3EE07 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2);
			((Control)tXJGMXkeXH).AutoSize = true;
			((Control)tXJGMXkeXH).Location = new Point(158, 50);
			((Control)tXJGMXkeXH).Margin = new Padding(1, 0, 1, 0);
			((Control)tXJGMXkeXH).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1A81DC ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08);
			((Control)tXJGMXkeXH).Size = new Size(20, 16);
			((Control)tXJGMXkeXH).TabIndex = 48;
			((Control)tXJGMXkeXH).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4228CC89 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f);
			((Control)qvHGXedrwh).AutoSize = true;
			((Control)qvHGXedrwh).Location = new Point(18, 49);
			((Control)qvHGXedrwh).Margin = new Padding(1, 0, 1, 0);
			((Control)qvHGXedrwh).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0xFB602D6 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4);
			((Control)qvHGXedrwh).Size = new Size(53, 16);
			((Control)qvHGXedrwh).TabIndex = 47;
			((Control)qvHGXedrwh).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C71E1 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6);
			((Control)O8dGcnH91l).Location = new Point(161, 88);
			((Control)O8dGcnH91l).Margin = new Padding(2);
			O8dGcnH91l.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
			((Control)O8dGcnH91l).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA4760 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a);
			((Control)O8dGcnH91l).Size = new Size(235, 22);
			((Control)O8dGcnH91l).TabIndex = 46;
			((Control)H2GGFMDm7q).AutoSize = true;
			((Control)H2GGFMDm7q).Location = new Point(18, 88);
			((Control)H2GGFMDm7q).Margin = new Padding(1, 0, 1, 0);
			((Control)H2GGFMDm7q).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE92724 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed);
			((Control)H2GGFMDm7q).Size = new Size(66, 16);
			((Control)H2GGFMDm7q).TabIndex = 45;
			((Control)H2GGFMDm7q).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C542773 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8);
			((Control)v4MGhakT0E).BackColor = SystemColors.Highlight;
			((Control)v4MGhakT0E).Controls.Add((Control)(object)znrG1MOUlk);
			((Control)v4MGhakT0E).Location = new Point(1, 1);
			((Control)v4MGhakT0E).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB02C0 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79);
			((Control)v4MGhakT0E).Size = new Size(414, 29);
			((Control)v4MGhakT0E).TabIndex = 32;
			((Control)znrG1MOUlk).AutoSize = true;
			((Control)znrG1MOUlk).Font = new Font(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C543D5F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8), 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)znrG1MOUlk).ForeColor = SystemColors.ButtonHighlight;
			((Control)znrG1MOUlk).Location = new Point(95, 0);
			((Control)znrG1MOUlk).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6DEC0934 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7);
			((Control)znrG1MOUlk).Size = new Size(222, 27);
			((Control)znrG1MOUlk).TabIndex = 30;
			((Control)znrG1MOUlk).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29F12C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6);
			((Control)CCeGD5vrCy).Location = new Point(468, 697);
			((Control)CCeGD5vrCy).Margin = new Padding(9);
			((Control)CCeGD5vrCy).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x5E1C7001 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6);
			((Control)CCeGD5vrCy).Size = new Size(108, 39);
			((Control)CCeGD5vrCy).TabIndex = 35;
			((Control)CCeGD5vrCy).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x1AFE93FE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83);
			((ButtonBase)CCeGD5vrCy).UseVisualStyleBackColor = true;
			((Control)CCeGD5vrCy).Click += iOOR4J95hX;
			((Control)A5aGio7UF8).Location = new Point(328, 697);
			((Control)A5aGio7UF8).Margin = new Padding(9);
			((Control)A5aGio7UF8).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F86542F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e);
			((Control)A5aGio7UF8).Size = new Size(108, 39);
			((Control)A5aGio7UF8).TabIndex = 34;
			((Control)A5aGio7UF8).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7E3C6C1D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf);
			((ButtonBase)A5aGio7UF8).UseVisualStyleBackColor = true;
			((Control)A5aGio7UF8).Click += EPyRmuKCBE;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 16f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Control)this).BackColor = SystemColors.ControlLight;
			((Form)this).ClientSize = new Size(903, 750);
			((Control)this).Controls.Add((Control)(object)CCeGD5vrCy);
			((Control)this).Controls.Add((Control)(object)A5aGio7UF8);
			((Control)this).Controls.Add((Control)(object)eKnGlAjVm8);
			((Control)this).Controls.Add((Control)(object)KhEG5rRJTA);
			((Control)this).Controls.Add((Control)(object)zNMGKRcIDn);
			((Control)this).Controls.Add((Control)(object)viJGVR4Rwn);
			((Control)this).Controls.Add((Control)(object)BUYRzTYR0x);
			((Form)this).FormBorderStyle = (FormBorderStyle)1;
			((Form)this).Icon = (Icon)componentResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x27EAE09F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8));
			((Form)this).Margin = new Padding(4);
			((Control)this).Name = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B89FC3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e);
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20CAF9 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca);
			((Form)this).Load += QVdRkiT0yv;
			((Control)BUYRzTYR0x).ResumeLayout(false);
			((Control)BUYRzTYR0x).PerformLayout();
			((Control)PujGwkhsQy).ResumeLayout(false);
			((Control)PujGwkhsQy).PerformLayout();
			((Control)viJGVR4Rwn).ResumeLayout(false);
			((Control)viJGVR4Rwn).PerformLayout();
			((ISupportInitialize)z7haw9hy6O).EndInit();
			((ISupportInitialize)bCVaTv9oYm).EndInit();
			((ISupportInitialize)oHKaRju9jb).EndInit();
			((ISupportInitialize)m30aGbYnCb).EndInit();
			((ISupportInitialize)X9YG4uKF0w).EndInit();
			((Control)zNMGKRcIDn).ResumeLayout(false);
			((Control)zNMGKRcIDn).PerformLayout();
			((Control)KhEG5rRJTA).ResumeLayout(false);
			((Control)KhEG5rRJTA).PerformLayout();
			((Control)AE9GffhdrQ).ResumeLayout(false);
			((Control)AE9GffhdrQ).PerformLayout();
			((Control)eKnGlAjVm8).ResumeLayout(false);
			((Control)eKnGlAjVm8).PerformLayout();
			((ISupportInitialize)FghGJGSvW8).EndInit();
			((ISupportInitialize)rGGGWsX7tR).EndInit();
			((ISupportInitialize)O8dGcnH91l).EndInit();
			((Control)v4MGhakT0E).ResumeLayout(false);
			((Control)v4MGhakT0E).PerformLayout();
			((Control)this).ResumeLayout(false);
		}

		private void QaDRUwnW89(object P_0, PaintEventArgs P_1)
		{
		}
	}
}
namespace XXolp5a00Jwnpw13339
{
	internal static class JrZQ77auWVAlAm0smou
	{
		[STAThread]
		private static void dOGajxTcC6()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			Application.Run((Form)(object)new Form_Main());
		}
	}
}
namespace ExamBrowser.Properties
{
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		private static ResourceManager SAMapsp8Wg;

		private static CultureInfo AdDaK0REXy;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (SAMapsp8Wg == null)
				{
					SAMapsp8Wg = new ResourceManager("ExamBrowser.Properties.Resources", typeof(Resources).Assembly);
				}
				return SAMapsp8Wg;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return AdDaK0REXy;
			}
			set
			{
				AdDaK0REXy = value;
			}
		}

		internal static Bitmap Lock_Lock_icon
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x7B29F19C ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6), AdDaK0REXy);
			}
		}

		internal static Bitmap Lock_Unlock_icon
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C54265F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8), AdDaK0REXy);
			}
		}

		internal static Bitmap test2
		{
			get
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6A5614B3 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b), AdDaK0REXy);
			}
		}

		internal static Bitmap test3
		{
			get
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA462A ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a), AdDaK0REXy);
			}
		}

		internal static Bitmap test4
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x18F3E87D ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2), AdDaK0REXy);
			}
		}

		internal static Bitmap ram
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4E1A87B2 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08), AdDaK0REXy);
			}
		}

		internal static Bitmap processor
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Bitmap)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x22D6B652 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711), AdDaK0REXy);
			}
		}

		internal static Image windowsg
		{
			get
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x15FFAADE ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d), AdDaK0REXy);
			}
		}

		internal static Image monitor
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x35EB0476 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79), AdDaK0REXy);
			}
		}

		internal static Image audio
		{
			get
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x43B0E1C7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb4c51c87e664f2a80b08fdc8c7d117f), AdDaK0REXy);
			}
		}

		internal static Image onlinetest
		{
			get
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3C65176F ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50), AdDaK0REXy);
			}
		}

		internal static Image onlineicon
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x65121349 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb), AdDaK0REXy);
			}
		}

		internal static Image koneksiinter
		{
			get
			{
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x6AD64C90 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3), AdDaK0REXy);
			}
		}

		internal static Image nointernet
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x3EE92152 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed), AdDaK0REXy);
			}
		}

		internal static Image ceklis
		{
			get
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2D037927 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18), AdDaK0REXy);
			}
		}

		internal static Image silang
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x20E1AB ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca), AdDaK0REXy);
			}
		}

		internal static Image kemdikbud2
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x30DA4126 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a), AdDaK0REXy);
			}
		}

		internal static Image botarrow3
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x4F86524B ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e), AdDaK0REXy);
			}
		}

		internal static Image jam2
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x66B89951 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e), AdDaK0REXy);
			}
		}

		internal static Image webcam
		{
			get
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				return (Image)ResourceManager.GetObject(JYC3AkacE3hrYs377xw.EWJ9xtjenL(0x2FFBEBC7 ^ <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}.m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa), AdDaK0REXy);
			}
		}

		internal Resources()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			base..ctor();
		}
	}
}
internal class <Module>{5ABAED93-E407-47E3-95E8-8A27B2BAB43F}
{
}
namespace jR5ohsa6ydVsJoIhYsC
{
	internal class dLgbycaW5qLEJWkECju
	{
		internal delegate void rEPshLaXesJRyBn4rHn(object o);

		internal static Module TspaMJ2fOV;

		internal static void HEKHqwIKra(int typemdt)
		{
			Type type = TspaMJ2fOV.ResolveType(33554432 + typemdt);
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				MethodInfo method = (MethodInfo)TspaMJ2fOV.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		public dLgbycaW5qLEJWkECju()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			base..ctor();
		}

		static dLgbycaW5qLEJWkECju()
		{
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			TspaMJ2fOV = typeof(dLgbycaW5qLEJWkECju).Assembly.ManifestModule;
		}
	}
}
namespace uB0dasaFwqgBoPJXYHG
{
	internal class JYC3AkacE3hrYs377xw
	{
		private delegate void wDiBkRw7TCaoH5WxoBE(object o);

		internal class wFYyhmwOZy15G992nje : Attribute
		{
			internal class cwfVZ9wu7bSHa3oTrX0<AFZWW9w0GsdgfTC8Ocq>
			{
				public cwfVZ9wu7bSHa3oTrX0()
				{
					rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
					base..ctor();
				}
			}

			public wFYyhmwOZy15G992nje(object P_0)
			{
			}
		}

		internal class VgZsltwjqyvg8P2DgLl
		{
			internal static string D1Nwpi7tuU(string P_0, string P_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(P_0);
				byte[] key = new byte[32]
				{
					82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
					51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
					34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
					1, 88
				};
				byte[] iV = udrazUUSkj(Encoding.Unicode.GetBytes(P_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = ydIaYNtXpE();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iV;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint k5aj81wKsdJDyjUS6WU(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr Uqm4S2ws0CPB1tXVF5V();

		internal struct BnanBsw566Vxg8JPX4y
		{
			internal bool djIwAGdGFl;

			internal byte[] sZgwIJ77Ex;
		}

		internal class oXuR3KwqIM5g2gdT6SW
		{
			private BinaryReader cQ7wPNyO3Y;

			public oXuR3KwqIM5g2gdT6SW(Stream P_0)
			{
				cQ7wPNyO3Y = new BinaryReader(P_0);
			}

			[SpecialName]
			internal Stream f9UtU12u5A()
			{
				return cQ7wPNyO3Y.BaseStream;
			}

			internal byte[] RRgw8TNlQS(int P_0)
			{
				return cQ7wPNyO3Y.ReadBytes(P_0);
			}

			internal int tarwr2YFmT(byte[] P_0, int P_1, int P_2)
			{
				return cQ7wPNyO3Y.Read(P_0, P_1, P_2);
			}

			internal int LiswyRIQq9()
			{
				return cQ7wPNyO3Y.ReadInt32();
			}

			internal void GHXwo2ycPH()
			{
				cQ7wPNyO3Y.Close();
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		private delegate IntPtr XmwidPwQiDxJdbAGefl(IntPtr hModule, string lpName, uint lpType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr CnKXjbwbxgBSxp4hZUI(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int FlbpKZwfutr2fBplyj5(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int nqWjwOwvfFPQoJjUgIj(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr o4HAZawlaQbkgyX3R9x(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int WeCeMZwZNQ1xsx0lpml(IntPtr ptr);

		[Flags]
		private enum urq9HqwdIHKFr9mxncv
		{

		}

		private static bool xIO9Nm1vlN;

		internal static RSACryptoServiceProvider Xo193VpLW2;

		private static object UZJ9LTO6Hs;

		private static int Biv9JFsovf;

		private static List<string> onx969syix;

		private static IntPtr iCf9Fdlyvi;

		private static IntPtr LJZ9h7F3PG;

		private static bool E8s9EVoFLL;

		private static int Wcp9m8h8Sc;

		private static bool VqOwR2lyLc;

		private static int NUEwaOHE4V;

		private static object Ey89W82FTn;

		private static SortedList wZx9kvB0ER;

		private static Dictionary<int, int> YIS9thJn1Q;

		private static List<int> k7e9MjogoI;

		private static object BUa91XVLR1;

		private static long eUk9ziGuXX;

		private static WeCeMZwZNQ1xsx0lpml ghdw2R4fai;

		internal static Hashtable crFwHYvWsR;

		private static bool JdjwGbGSbF;

		private static XmwidPwQiDxJdbAGefl V0kwVsDGNy;

		private static FlbpKZwfutr2fBplyj5 IOZwxls6Ks;

		private static IntPtr NhSwngTf2Q;

		private static byte[] R7L9Xr828p;

		private static int SSg9iOuINQ;

		private static uint[] KjY9Sgw2Im;

		internal static Assembly ERJ9djGxrA;

		private static long Gmx94s2iRa;

		internal static k5aj81wKsdJDyjUS6WU mql9Y5ex7A;

		private static int TL2wTFSIYV;

		private static bool aiu9eM2rpT;

		private static int[] btL9DyX8W1;

		private static nqWjwOwvfFPQoJjUgIj VANwC1SWcn;

		private static CnKXjbwbxgBSxp4hZUI cX8wB2W2j1;

		internal static k5aj81wKsdJDyjUS6WU Ncj9U4mtZd;

		private static byte[] RsE9cKnVfI;

		private static o4HAZawlaQbkgyX3R9x q9Uwgu8UgL;

		private static IntPtr amdw9F6n8B;

		[wFYyhmwOZy15G992nje(typeof(wFYyhmwOZy15G992nje.cwfVZ9wu7bSHa3oTrX0<object>[]))]
		private static bool pixww8NyKl;

		static JYC3AkacE3hrYs377xw()
		{
			ERJ9djGxrA = typeof(JYC3AkacE3hrYs377xw).Assembly;
			KjY9Sgw2Im = new uint[64]
			{
				3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
				4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
				3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
				1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
				681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
				2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
				4149444226u, 3174756917u, 718787259u, 3951481745u
			};
			aiu9eM2rpT = false;
			xIO9Nm1vlN = false;
			Xo193VpLW2 = null;
			YIS9thJn1Q = null;
			UZJ9LTO6Hs = new object();
			Biv9JFsovf = 0;
			Ey89W82FTn = new object();
			onx969syix = null;
			k7e9MjogoI = null;
			R7L9Xr828p = new byte[0];
			RsE9cKnVfI = new byte[0];
			iCf9Fdlyvi = IntPtr.Zero;
			LJZ9h7F3PG = IntPtr.Zero;
			BUa91XVLR1 = new string[0];
			btL9DyX8W1 = new int[0];
			SSg9iOuINQ = 1;
			E8s9EVoFLL = false;
			wZx9kvB0ER = new SortedList();
			Wcp9m8h8Sc = 0;
			Gmx94s2iRa = 0L;
			mql9Y5ex7A = null;
			Ncj9U4mtZd = null;
			eUk9ziGuXX = 0L;
			TL2wTFSIYV = 0;
			VqOwR2lyLc = false;
			JdjwGbGSbF = false;
			NUEwaOHE4V = 0;
			amdw9F6n8B = IntPtr.Zero;
			pixww8NyKl = false;
			crFwHYvWsR = new Hashtable();
			V0kwVsDGNy = null;
			cX8wB2W2j1 = null;
			IOZwxls6Ks = null;
			VANwC1SWcn = null;
			q9Uwgu8UgL = null;
			ghdw2R4fai = null;
			NhSwngTf2Q = IntPtr.Zero;
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private void TuSH8Efi0t()
		{
		}

		internal static byte[] pMXahMaRx6(byte[] P_0)
		{
			uint[] array = new uint[16];
			uint num = (uint)((448 - P_0.Length * 8 % 512 + 512) % 512);
			if (num == 0)
			{
				num = 512u;
			}
			uint num2 = (uint)(P_0.Length + num / 8 + 8);
			ulong num3 = (ulong)P_0.Length * 8uL;
			byte[] array2 = new byte[num2];
			for (int i = 0; i < P_0.Length; i++)
			{
				array2[i] = P_0[i];
			}
			array2[P_0.Length] |= 128;
			for (int num4 = 8; num4 > 0; num4--)
			{
				array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
			}
			uint num5 = (uint)(array2.Length * 8) / 32u;
			uint num6 = 1732584193u;
			uint num7 = 4023233417u;
			uint num8 = 2562383102u;
			uint num9 = 271733878u;
			for (uint num10 = 0u; num10 < num5 / 16; num10++)
			{
				uint num11 = num10 << 6;
				for (uint num12 = 0u; num12 < 61; num12 += 4)
				{
					array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
				}
				uint num13 = num6;
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				Jdpa1Dgu97(ref num6, num7, num8, num9, 0u, 7, 1u, array);
				Jdpa1Dgu97(ref num9, num6, num7, num8, 1u, 12, 2u, array);
				Jdpa1Dgu97(ref num8, num9, num6, num7, 2u, 17, 3u, array);
				Jdpa1Dgu97(ref num7, num8, num9, num6, 3u, 22, 4u, array);
				Jdpa1Dgu97(ref num6, num7, num8, num9, 4u, 7, 5u, array);
				Jdpa1Dgu97(ref num9, num6, num7, num8, 5u, 12, 6u, array);
				Jdpa1Dgu97(ref num8, num9, num6, num7, 6u, 17, 7u, array);
				Jdpa1Dgu97(ref num7, num8, num9, num6, 7u, 22, 8u, array);
				Jdpa1Dgu97(ref num6, num7, num8, num9, 8u, 7, 9u, array);
				Jdpa1Dgu97(ref num9, num6, num7, num8, 9u, 12, 10u, array);
				Jdpa1Dgu97(ref num8, num9, num6, num7, 10u, 17, 11u, array);
				Jdpa1Dgu97(ref num7, num8, num9, num6, 11u, 22, 12u, array);
				Jdpa1Dgu97(ref num6, num7, num8, num9, 12u, 7, 13u, array);
				Jdpa1Dgu97(ref num9, num6, num7, num8, 13u, 12, 14u, array);
				Jdpa1Dgu97(ref num8, num9, num6, num7, 14u, 17, 15u, array);
				Jdpa1Dgu97(ref num7, num8, num9, num6, 15u, 22, 16u, array);
				eSOaDrQFrU(ref num6, num7, num8, num9, 1u, 5, 17u, array);
				eSOaDrQFrU(ref num9, num6, num7, num8, 6u, 9, 18u, array);
				eSOaDrQFrU(ref num8, num9, num6, num7, 11u, 14, 19u, array);
				eSOaDrQFrU(ref num7, num8, num9, num6, 0u, 20, 20u, array);
				eSOaDrQFrU(ref num6, num7, num8, num9, 5u, 5, 21u, array);
				eSOaDrQFrU(ref num9, num6, num7, num8, 10u, 9, 22u, array);
				eSOaDrQFrU(ref num8, num9, num6, num7, 15u, 14, 23u, array);
				eSOaDrQFrU(ref num7, num8, num9, num6, 4u, 20, 24u, array);
				eSOaDrQFrU(ref num6, num7, num8, num9, 9u, 5, 25u, array);
				eSOaDrQFrU(ref num9, num6, num7, num8, 14u, 9, 26u, array);
				eSOaDrQFrU(ref num8, num9, num6, num7, 3u, 14, 27u, array);
				eSOaDrQFrU(ref num7, num8, num9, num6, 8u, 20, 28u, array);
				eSOaDrQFrU(ref num6, num7, num8, num9, 13u, 5, 29u, array);
				eSOaDrQFrU(ref num9, num6, num7, num8, 2u, 9, 30u, array);
				eSOaDrQFrU(ref num8, num9, num6, num7, 7u, 14, 31u, array);
				eSOaDrQFrU(ref num7, num8, num9, num6, 12u, 20, 32u, array);
				XC9aiRbKbq(ref num6, num7, num8, num9, 5u, 4, 33u, array);
				XC9aiRbKbq(ref num9, num6, num7, num8, 8u, 11, 34u, array);
				XC9aiRbKbq(ref num8, num9, num6, num7, 11u, 16, 35u, array);
				XC9aiRbKbq(ref num7, num8, num9, num6, 14u, 23, 36u, array);
				XC9aiRbKbq(ref num6, num7, num8, num9, 1u, 4, 37u, array);
				XC9aiRbKbq(ref num9, num6, num7, num8, 4u, 11, 38u, array);
				XC9aiRbKbq(ref num8, num9, num6, num7, 7u, 16, 39u, array);
				XC9aiRbKbq(ref num7, num8, num9, num6, 10u, 23, 40u, array);
				XC9aiRbKbq(ref num6, num7, num8, num9, 13u, 4, 41u, array);
				XC9aiRbKbq(ref num9, num6, num7, num8, 0u, 11, 42u, array);
				XC9aiRbKbq(ref num8, num9, num6, num7, 3u, 16, 43u, array);
				XC9aiRbKbq(ref num7, num8, num9, num6, 6u, 23, 44u, array);
				XC9aiRbKbq(ref num6, num7, num8, num9, 9u, 4, 45u, array);
				XC9aiRbKbq(ref num9, num6, num7, num8, 12u, 11, 46u, array);
				XC9aiRbKbq(ref num8, num9, num6, num7, 15u, 16, 47u, array);
				XC9aiRbKbq(ref num7, num8, num9, num6, 2u, 23, 48u, array);
				bXNaEJbQL4(ref num6, num7, num8, num9, 0u, 6, 49u, array);
				bXNaEJbQL4(ref num9, num6, num7, num8, 7u, 10, 50u, array);
				bXNaEJbQL4(ref num8, num9, num6, num7, 14u, 15, 51u, array);
				bXNaEJbQL4(ref num7, num8, num9, num6, 5u, 21, 52u, array);
				bXNaEJbQL4(ref num6, num7, num8, num9, 12u, 6, 53u, array);
				bXNaEJbQL4(ref num9, num6, num7, num8, 3u, 10, 54u, array);
				bXNaEJbQL4(ref num8, num9, num6, num7, 10u, 15, 55u, array);
				bXNaEJbQL4(ref num7, num8, num9, num6, 1u, 21, 56u, array);
				bXNaEJbQL4(ref num6, num7, num8, num9, 8u, 6, 57u, array);
				bXNaEJbQL4(ref num9, num6, num7, num8, 15u, 10, 58u, array);
				bXNaEJbQL4(ref num8, num9, num6, num7, 6u, 15, 59u, array);
				bXNaEJbQL4(ref num7, num8, num9, num6, 13u, 21, 60u, array);
				bXNaEJbQL4(ref num6, num7, num8, num9, 4u, 6, 61u, array);
				bXNaEJbQL4(ref num9, num6, num7, num8, 11u, 10, 62u, array);
				bXNaEJbQL4(ref num8, num9, num6, num7, 2u, 15, 63u, array);
				bXNaEJbQL4(ref num7, num8, num9, num6, 9u, 21, 64u, array);
				num6 += num13;
				num7 += num14;
				num8 += num15;
				num9 += num16;
			}
			byte[] array3 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
			Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
			return array3;
		}

		private static void Jdpa1Dgu97(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + n2QakoR4H2(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + KjY9Sgw2Im[P_6 - 1], P_5);
		}

		private static void eSOaDrQFrU(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + n2QakoR4H2(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + KjY9Sgw2Im[P_6 - 1], P_5);
		}

		private static void XC9aiRbKbq(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + n2QakoR4H2(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + KjY9Sgw2Im[P_6 - 1], P_5);
		}

		private static void bXNaEJbQL4(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + n2QakoR4H2(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + KjY9Sgw2Im[P_6 - 1], P_5);
		}

		private static uint n2QakoR4H2(uint P_0, ushort P_1)
		{
			return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
		}

		internal static bool mtpamcFfgZ()
		{
			if (!aiu9eM2rpT)
			{
				OG1aU2Djtx();
				aiu9eM2rpT = true;
			}
			return xIO9Nm1vlN;
		}

		internal JYC3AkacE3hrYs377xw()
		{
		}

		private void cLqa4ewYRL(byte[] P_0, byte[] P_1, byte[] P_2)
		{
			int num = P_2.Length % 4;
			int num2 = P_2.Length / 4;
			byte[] array = new byte[P_2.Length];
			int num3 = P_0.Length / 4;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = 0u;
			if (num > 0)
			{
				num2++;
			}
			uint num7 = 0u;
			for (int i = 0; i < num2; i++)
			{
				int num8 = i % num3;
				int num9 = i * 4;
				num7 = (uint)(num8 * 4);
				num5 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
				uint num10 = 255u;
				int num11 = 0;
				if (i == num2 - 1 && num > 0)
				{
					num6 = 0u;
					num4 += num5;
					for (int j = 0; j < num; j++)
					{
						if (j > 0)
						{
							num6 <<= 8;
						}
						num6 |= P_2[^(1 + j)];
					}
				}
				else
				{
					num4 += num5;
					num7 = (uint)num9;
					num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + 1] << 8) | P_2[num7]);
				}
				uint num12 = num4;
				num4 = 0u;
				uint num13 = 1896136748u;
				uint num14 = 1413621632u;
				uint num15 = 1297067484u;
				uint num16 = 274475689u;
				uint num17 = num12;
				uint num18 = num16 & 0xFF00FF;
				uint num19 = num16 & 0xFF00FF00u;
				num18 = ((num18 >> 8) | (num19 << 8)) + num14;
				num16 = (num16 >> 12) | (num16 << 20);
				if (num13 == 0)
				{
					num13--;
				}
				uint num20 = num15 / num13 + num13;
				num13 = num14 - num15 - num20 + num14;
				num18 = ((num14 >> 8) | (num14 << 24)) + num16;
				num19 = num18 & 0xF0F0F0F;
				num18 &= 0xF0F0F0F0u;
				num14 = (num18 >> 4) | (num19 << 4);
				num15 = 1740902894 + num16 - 2131956481;
				num13 = 2277 * (num13 & 0xFFFFF) - (num13 >> 20);
				num14 = 4020 * (num14 & 0xFFFFF) - (num14 >> 20);
				num16 = 40280 * num16 + num15;
				num17 ^= num17 << 7;
				num17 += num14;
				num17 ^= num17 >> 1;
				num17 += num15;
				num17 ^= num17 << 25;
				num17 += num17;
				num17 = (((num13 << 19) - num15) ^ num14) - num17;
				num4 = num12 + (uint)(double)num17;
				if (i == num2 - 1 && num > 0)
				{
					uint num21 = num4 ^ num6;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array[num9 + k] = (byte)((num21 & num10) >> num11);
					}
				}
				else
				{
					uint num22 = num4 ^ num6;
					array[num9] = (byte)(num22 & 0xFF);
					array[num9 + 1] = (byte)((num22 & 0xFF00) >> 8);
					array[num9 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					array[num9 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
				}
			}
			R7L9Xr828p = array;
		}

		internal static SymmetricAlgorithm ydIaYNtXpE()
		{
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (mtpamcFfgZ())
			{
				try
				{
					return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					try
					{
						return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
					}
					catch
					{
						return new RijndaelManaged();
					}
				}
			}
			try
			{
				return new RijndaelManaged();
			}
			catch
			{
				try
				{
					return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}

		internal static void OG1aU2Djtx()
		{
			try
			{
				new RijndaelManaged();
				xIO9Nm1vlN = false;
			}
			catch
			{
				xIO9Nm1vlN = true;
			}
		}

		internal static byte[] udrazUUSkj(byte[] P_0)
		{
			if (!mtpamcFfgZ())
			{
				return new MD5CryptoServiceProvider().ComputeHash(P_0);
			}
			return pMXahMaRx6(P_0);
		}

		internal static void VID9TDIpEV(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
		{
			while (P_2 != 0)
			{
				int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
				P_1.Read(P_3, 0, num);
				ueB9RlEq9m(P_0, P_3, 0, num);
				P_2 -= (uint)num;
			}
		}

		internal static void ueB9RlEq9m(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
		{
			P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
		}

		internal static uint zH09GH6upQ(uint P_0, int P_1, long P_2, BinaryReader P_3)
		{
			for (int i = 0; i < P_1; i++)
			{
				P_3.BaseStream.Position = P_2 + (i * 40 + 8);
				uint num = P_3.ReadUInt32();
				uint num2 = P_3.ReadUInt32();
				P_3.ReadUInt32();
				uint num3 = P_3.ReadUInt32();
				if (num2 <= P_0 && P_0 < num2 + num)
				{
					return num3 + P_0 - num2;
				}
			}
			return 0u;
		}

		public static void o6D9aQQdPn(RuntimeTypeHandle P_0)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(P_0);
				if (YIS9thJn1Q == null)
				{
					lock (UZJ9LTO6Hs)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(typeof(JYC3AkacE3hrYs377xw).Assembly.GetManifestResourceStream("K6dAeZgoqV2udgvsZK.GeLDSZ23VxdQsQc14C"));
						binaryReader.BaseStream.Position = 0L;
						byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						binaryReader.Close();
						if (array.Length != 0)
						{
							int num = array.Length % 4;
							int num2 = array.Length / 4;
							byte[] array2 = new byte[array.Length];
							uint num3 = 0u;
							uint num4 = 0u;
							if (num > 0)
							{
								num2++;
							}
							uint num5 = 0u;
							for (int i = 0; i < num2; i++)
							{
								int num6 = i * 4;
								uint num7 = 255u;
								int num8 = 0;
								if (i == num2 - 1 && num > 0)
								{
									num4 = 0u;
									for (int j = 0; j < num; j++)
									{
										if (j > 0)
										{
											num4 <<= 8;
										}
										num4 |= array[^(1 + j)];
									}
								}
								else
								{
									num5 = (uint)num6;
									num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
								}
								num3 = num3;
								num3 += Pbc9HQCGnT(num3);
								if (i == num2 - 1 && num > 0)
								{
									uint num9 = num3 ^ num4;
									for (int k = 0; k < num; k++)
									{
										if (k > 0)
										{
											num7 <<= 8;
											num8 += 8;
										}
										array2[num6 + k] = (byte)((num9 & num7) >> num8);
									}
								}
								else
								{
									uint num10 = num3 ^ num4;
									array2[num6] = (byte)(num10 & 0xFF);
									array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
									array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
									array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
								}
							}
							array = array2;
							array2 = null;
							int num11 = array.Length / 8;
							oXuR3KwqIM5g2gdT6SW oXuR3KwqIM5g2gdT6SW2 = new oXuR3KwqIM5g2gdT6SW(new MemoryStream(array));
							for (int l = 0; l < num11; l++)
							{
								int key = oXuR3KwqIM5g2gdT6SW2.LiswyRIQq9();
								int value = oXuR3KwqIM5g2gdT6SW2.LiswyRIQq9();
								dictionary.Add(key, value);
							}
							oXuR3KwqIM5g2gdT6SW2.GHXwo2ycPH();
						}
						YIS9thJn1Q = dictionary;
					}
				}
				FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
				for (int m = 0; m < fields.Length; m++)
				{
					try
					{
						FieldInfo fieldInfo = fields[m];
						int metadataToken = fieldInfo.MetadataToken;
						int num12 = YIS9thJn1Q[metadataToken];
						bool flag = (num12 & 0x40000000) > 0;
						num12 &= 0x3FFFFFFF;
						MethodInfo methodInfo = (MethodInfo)typeof(JYC3AkacE3hrYs377xw).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
						if (methodInfo.IsStatic)
						{
							fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
							continue;
						}
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num13 = parameters.Length + 1;
						Type[] array3 = new Type[num13];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
						ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
						for (int num14 = 0; num14 < num13; num14++)
						{
							switch (num14)
							{
							case 0:
								iLGenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								iLGenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								iLGenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								iLGenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								iLGenerator.Emit(OpCodes.Ldarg_S, num14);
								break;
							}
						}
						iLGenerator.Emit(OpCodes.Tailcall);
						iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						iLGenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private static uint Rsn9wPSNsZ(uint P_0)
		{
			return (uint)"{11111-22222-10009-11112}".Length;
		}

		private static uint Pbc9HQCGnT(uint P_0)
		{
			return 0u;
		}

		internal static void Pn59Vt4aI5()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void jdR9BurN3i(Stream P_0, int P_1)
		{
			int num = 277;
			int num3 = default;
			byte[] array4 = default;
			int num4 = default;
			byte[] array2 = default;
			byte[] array = default;
			Stream stream = default;
			ICryptoTransform transform = default;
			byte[] array5 = default;
			byte[] array3 = default;
			byte[] array6 = default;
			int num5 = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 39:
						num3 = 231 - 77;
						num2 = 122;
						continue;
					case 321:
						array4[10] = (byte)num4;
						num = 68;
						break;
					case 195:
						array2 = array;
						num2 = 53;
						continue;
					case 206:
					{
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						jmNbChHKYAyNg43L2j0(cryptoStream, array5, 0, array5.Length);
						tOYflCHs7dtvWcbZE7g(cryptoStream);
						R7L9Xr828p = (byte[])H9mDcAH5FDZcDIXnfdS(stream);
						YnZ7MpHAoOEGXlReOtO(stream);
						YnZ7MpHAoOEGXlReOtO(cryptoStream);
						num2 = 203;
						continue;
					}
					case 229:
						array[11] = (byte)num3;
						num2 = 253;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 181;
						}
						continue;
					case 288:
						num3 = 4 + 2;
						num2 = 99;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 231;
						}
						continue;
					case 26:
						array[29] = (byte)num3;
						num = 120;
						break;
					case 286:
						array[27] = 171;
						num2 = 24;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 57;
						}
						continue;
					case 300:
						array3[9] = array6[4];
						num2 = 265;
						continue;
					case 329:
						num3 = 53 + 112;
						num2 = 322;
						continue;
					case 136:
						array[22] = 157;
						num2 = 5;
						continue;
					case 275:
						array4[9] = (byte)num4;
						num2 = 280;
						continue;
					case 144:
						array[23] = 141;
						num2 = 140;
						continue;
					case 305:
						array4[1] = (byte)num4;
						num2 = 247;
						continue;
					default:
						array4[4] = 102;
						num2 = 285;
						continue;
					case 32:
						num3 = 123 + 104;
						num = 266;
						break;
					case 36:
						array[26] = 133;
						num2 = 287;
						continue;
					case 58:
						array[4] = (byte)num3;
						num2 = 297;
						continue;
					case 57:
						num3 = 127 - 42;
						num2 = 65;
						continue;
					case 71:
						num3 = 78 + 85;
						num = 334;
						break;
					case 103:
						array[13] = (byte)num3;
						num2 = 46;
						continue;
					case 210:
						array4[14] = 171;
						num2 = 95;
						continue;
					case 84:
						array[23] = (byte)num3;
						num2 = 200;
						continue;
					case 190:
						num4 = 133 - 44;
						num2 = 102;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 84;
						}
						continue;
					case 122:
						array[23] = (byte)num3;
						num2 = 144;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 50;
						}
						continue;
					case 126:
						array[18] = 237;
						num2 = 196;
						continue;
					case 86:
						array4[10] = 173;
						num2 = 284;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 161;
						}
						continue;
					case 214:
						array[30] = 152;
						num2 = 172;
						continue;
					case 266:
						array[28] = (byte)num3;
						num2 = 6;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 1;
						}
						continue;
					case 277:
					{
						oXuR3KwqIM5g2gdT6SW oXuR3KwqIM5g2gdT6SW2 = new oXuR3KwqIM5g2gdT6SW(P_0);
						h6BCvLHxm7DwIp4uTSP(NGMLEGHB79S7W3EmRXs(oXuR3KwqIM5g2gdT6SW2), 0L);
						array5 = (byte[])DKlJr2Hg1KuwNQP8UmZ(oXuR3KwqIM5g2gdT6SW2, (int)dVybWiHCxcEJfZi8y2W(NGMLEGHB79S7W3EmRXs(oXuR3KwqIM5g2gdT6SW2)));
						m8tWw6H2QDCNxCySd6G(oXuR3KwqIM5g2gdT6SW2);
						num2 = 276;
						continue;
					}
					case 133:
						num3 = 98 + 81;
						num2 = 339;
						continue;
					case 64:
						num3 = 232 - 77;
						num2 = 109;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 123;
						}
						continue;
					case 252:
						array3[7] = array6[3];
						num2 = 300;
						continue;
					case 306:
						array4[6] = 68;
						num2 = 11;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 167;
						}
						continue;
					case 339:
						array[14] = (byte)num3;
						num2 = 228;
						continue;
					case 310:
						num3 = 177 - 59;
						num2 = 157;
						continue;
					case 338:
						num4 = 71 + 79;
						num2 = 7;
						continue;
					case 336:
						array[24] = 188;
						num2 = 71;
						continue;
					case 225:
						array4[12] = (byte)num4;
						num2 = 179;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 172;
						}
						continue;
					case 170:
						array[7] = (byte)num3;
						num2 = 91;
						continue;
					case 267:
						num3 = 119 + 24;
						num2 = 84;
						continue;
					case 99:
						array[5] = 84;
						num = 241;
						break;
					case 75:
						num4 = 209 - 69;
						num2 = 9;
						continue;
					case 332:
						num3 = 142 + 92;
						num2 = 136;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 212;
						}
						continue;
					case 153:
						num4 = 168 - 56;
						num2 = 180;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 321;
						}
						continue;
					case 47:
						num4 = 144 - 48;
						num2 = 294;
						continue;
					case 54:
						num3 = 19 + 35;
						num2 = 63;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 19;
						}
						continue;
					case 302:
						array4[8] = (byte)num4;
						num2 = 289;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 151;
						}
						continue;
					case 258:
					case 326:
						array2[num5] ^= array3[num5];
						num2 = 109;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 83;
						}
						continue;
					case 180:
						array[17] = (byte)num3;
						num2 = 64;
						continue;
					case 37:
						num3 = 98 - 66;
						num2 = 192;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 147;
						}
						continue;
					case 79:
						num3 = 132 - 44;
						num2 = 171;
						continue;
					case 251:
						array4[3] = 140;
						num2 = 62;
						continue;
					case 131:
						array[29] = (byte)num3;
						num2 = 17;
						continue;
					case 247:
						array4[2] = 144;
						num2 = 85;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 18;
						}
						continue;
					case 78:
						array[7] = (byte)num3;
						num2 = 119;
						continue;
					case 325:
						array[20] = (byte)num3;
						num2 = 249;
						continue;
					case 327:
						array[15] = (byte)num3;
						num = 19;
						break;
					case 141:
						array[8] = 126;
						num = 201;
						break;
					case 168:
						array[15] = 166;
						num2 = 197;
						continue;
					case 76:
						array4[4] = (byte)num4;
						num2 = 256;
						continue;
					case 74:
						num3 = 199 - 118;
						num2 = 78;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 30;
						}
						continue;
					case 82:
						array4[6] = (byte)num4;
						num = 216;
						break;
					case 328:
						array[14] = 23;
						num2 = 168;
						continue;
					case 278:
						array[7] = 102;
						num2 = 257;
						continue;
					case 331:
						array[29] = 84;
						num2 = 214;
						continue;
					case 265:
						array3[11] = array6[5];
						num2 = 173;
						continue;
					case 220:
						num3 = 6 + 108;
						num2 = 342;
						continue;
					case 221:
						num4 = 163 + 15;
						num2 = 225;
						continue;
					case 293:
						num4 = 168 - 56;
						num2 = 75;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 302;
						}
						continue;
					case 139:
						array6 = (byte[])InjlMMHOkhu7FTpPgSD(BIsdkaH70v4RUr6l0tk(ERJ9djGxrA));
						num2 = 8;
						continue;
					case 285:
						num4 = 0 + 60;
						num2 = 76;
						continue;
					case 242:
						num4 = 166 - 55;
						num2 = 81;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 64;
						}
						continue;
					case 167:
						num4 = 144 - 48;
						num2 = 104;
						continue;
					case 330:
						array3[1] = array6[0];
						num2 = 40;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 14;
						}
						continue;
					case 212:
						array[30] = (byte)num3;
						num = 156;
						break;
					case 274:
						num4 = 6 + 108;
						num2 = 70;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 17;
						}
						continue;
					case 228:
						array[14] = 135;
						num2 = 328;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 121;
						}
						continue;
					case 226:
						array[13] = (byte)num3;
						num2 = 238;
						continue;
					case 209:
						array[20] = 106;
						num2 = 316;
						continue;
					case 202:
						array[1] = 143;
						num2 = 198;
						continue;
					case 270:
						array4[12] = (byte)num4;
						num2 = 254;
						continue;
					case 158:
					case 255:
						if (num5 < array3.Length)
						{
							num2 = 326;
							continue;
						}
						goto case 18;
					case 201:
						array[8] = 98;
						num2 = 110;
						continue;
					case 117:
						array[25] = 206;
						num2 = 69;
						continue;
					case 308:
						array[21] = (byte)num3;
						num2 = 178;
						continue;
					case 218:
						array[21] = 110;
						num2 = 91;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 248;
						}
						continue;
					case 178:
						num3 = 157 - 52;
						num2 = 177;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 32;
						}
						continue;
					case 227:
						array[9] = (byte)num3;
						num2 = 60;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 2;
						}
						continue;
					case 200:
						num3 = 191 - 63;
						num2 = 311;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 250;
						}
						continue;
					case 315:
						num3 = 152 - 50;
						num2 = 14;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 83;
						}
						continue;
					case 60:
						array[9] = 102;
						num2 = 37;
						continue;
					case 262:
						num3 = 66 + 36;
						num2 = 1;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 58;
						}
						continue;
					case 281:
						num3 = 159 + 94;
						num2 = 100;
						continue;
					case 113:
						array[19] = 130;
						num2 = 314;
						continue;
					case 317:
						num3 = 109 - 27;
						num2 = 208;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 155;
						}
						continue;
					case 163:
						num4 = 87 - 68;
						num2 = 305;
						continue;
					case 169:
						BNdrwYHnGL48hifFovH(array3);
						num2 = 15;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 139;
						}
						continue;
					case 207:
						num3 = 34 + 59;
						num2 = 239;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 196;
						}
						continue;
					case 345:
						array4[15] = (byte)num4;
						num2 = 105;
						continue;
					case 146:
						array[11] = 105;
						num2 = 188;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 87;
						}
						continue;
					case 261:
						array[0] = 137;
						num2 = 205;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 173;
						}
						continue;
					case 48:
						array4[3] = 170;
						num2 = 295;
						continue;
					case 22:
						array[16] = (byte)num3;
						num2 = 107;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 329;
						}
						continue;
					case 12:
						array[20] = 160;
						num2 = 13;
						continue;
					case 27:
						num3 = 152 - 50;
						num = 227;
						break;
					case 40:
						array3[3] = array6[1];
						num2 = 74;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 96;
						}
						continue;
					case 216:
						num4 = 125 - 41;
						num2 = 222;
						continue;
					case 185:
						num3 = 98 - 92;
						num = 52;
						break;
					case 49:
						array[8] = (byte)num3;
						num2 = 26;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 27;
						}
						continue;
					case 100:
						array[5] = (byte)num3;
						num2 = 66;
						continue;
					case 150:
						array[4] = (byte)num3;
						num2 = 317;
						continue;
					case 16:
						array[1] = 7;
						num2 = 283;
						continue;
					case 256:
						array4[4] = 161;
						num2 = 335;
						continue;
					case 301:
						num4 = 253 - 84;
						num2 = 12;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 56;
						}
						continue;
					case 248:
						num3 = 108 + 65;
						num2 = 259;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 308;
						}
						continue;
					case 128:
						num3 = 200 - 66;
						num2 = 107;
						continue;
					case 213:
						num3 = 102 + 88;
						num2 = 43;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 41;
						}
						continue;
					case 294:
						array4[15] = (byte)num4;
						num2 = 324;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 216;
						}
						continue;
					case 123:
						array[17] = (byte)num3;
						num = 213;
						break;
					case 287:
						array[26] = 158;
						num = 34;
						break;
					case 193:
						array4[4] = (byte)num4;
						num2 = 190;
						continue;
					case 120:
						array[29] = 138;
						num2 = 331;
						continue;
					case 98:
						if (NNluOUHIuITn0DuhOJk(ERJ9djGxrA) != null)
						{
							num2 = 162;
							continue;
						}
						goto case 344;
					case 77:
						array[1] = 99;
						num2 = 307;
						continue;
					case 20:
						array[17] = (byte)num3;
						num2 = 14;
						continue;
					case 19:
						array[16] = 122;
						num2 = 180;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 320;
						}
						continue;
					case 152:
						array4[11] = 8;
						num2 = 199;
						continue;
					case 333:
						num3 = 194 + 37;
						num2 = 327;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 107;
						}
						continue;
					case 83:
						array[30] = (byte)num3;
						num2 = 332;
						continue;
					case 282:
						num4 = 37 + 40;
						num = 145;
						break;
					case 234:
						num3 = 88 + 108;
						num2 = 250;
						continue;
					case 196:
						array[18] = 73;
						num2 = 137;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 92;
						}
						continue;
					case 161:
						array[26] = (byte)num3;
						num2 = 286;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 53;
						}
						continue;
					case 119:
						array[8] = 120;
						num2 = 141;
						continue;
					case 177:
						array[22] = (byte)num3;
						num2 = 136;
						continue;
					case 7:
						array4[5] = (byte)num4;
						num2 = 33;
						continue;
					case 68:
						array4[10] = 3;
						num2 = 86;
						continue;
					case 88:
						array[11] = 56;
						num2 = 55;
						continue;
					case 224:
						array4[1] = 213;
						num2 = 115;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 98;
						}
						continue;
					case 179:
						num4 = 56 + 30;
						num2 = 2;
						continue;
					case 268:
						num3 = 96 + 100;
						num2 = 30;
						continue;
					case 245:
						num3 = 156 + 63;
						num = 232;
						break;
					case 61:
						array[12] = 92;
						num2 = 42;
						continue;
					case 13:
						num3 = 41 + 35;
						num2 = 143;
						continue;
					case 312:
						array[15] = (byte)num3;
						num2 = 25;
						continue;
					case 341:
						num4 = 249 - 83;
						num2 = 184;
						continue;
					case 10:
						array4[9] = 101;
						num2 = 80;
						continue;
					case 116:
						array[1] = (byte)num3;
						num2 = 16;
						continue;
					case 230:
						array[31] = (byte)num3;
						num2 = 310;
						continue;
					case 263:
						array[17] = (byte)num3;
						num2 = 79;
						continue;
					case 65:
						array[27] = (byte)num3;
						num2 = 215;
						continue;
					case 299:
						array[3] = (byte)num3;
						num2 = 240;
						continue;
					case 142:
						array[20] = (byte)num3;
						num2 = 7;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 12;
						}
						continue;
					case 3:
						array4[13] = 98;
						num2 = 242;
						continue;
					case 110:
						num3 = 125 + 103;
						num = 49;
						break;
					case 41:
						array4[3] = (byte)num4;
						num2 = 233;
						continue;
					case 335:
						array4[4] = 121;
						num2 = 50;
						continue;
					case 6:
						array[28] = 175;
						num2 = 207;
						continue;
					case 194:
						array4[7] = 188;
						num = 293;
						break;
					case 114:
						array[11] = (byte)num3;
						num2 = 80;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 88;
						}
						continue;
					case 309:
						array[2] = 77;
						num2 = 65;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 185;
						}
						continue;
					case 171:
						array[18] = (byte)num3;
						num2 = 126;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 109;
						}
						continue;
					case 34:
						array[26] = 157;
						num2 = 268;
						continue;
					case 24:
						num4 = 194 - 106;
						num2 = 154;
						continue;
					case 101:
						array[23] = (byte)num3;
						num2 = 63;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 259;
						}
						continue;
					case 174:
						num3 = 219 - 73;
						num2 = 170;
						continue;
					case 2:
						array4[13] = (byte)num4;
						num2 = 3;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 2;
						}
						continue;
					case 176:
						num3 = 104 - 33;
						num = 22;
						break;
					case 50:
						num4 = 168 + 33;
						num2 = 193;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 143;
						}
						continue;
					case 290:
						num3 = 85 + 29;
						num2 = 125;
						continue;
					case 173:
						array3[13] = array6[6];
						num2 = 291;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 4;
						}
						continue;
					case 112:
						array4[11] = 18;
						num2 = 264;
						continue;
					case 42:
						array[12] = 125;
						num2 = 269;
						continue;
					case 344:
						Biv9JFsovf = 80;
						num2 = 108;
						continue;
					case 15:
						array4[6] = 115;
						num2 = 306;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 282;
						}
						continue;
					case 298:
						array[6] = 65;
						num2 = 174;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 38;
						}
						continue;
					case 273:
						num3 = 190 - 63;
						num2 = 226;
						continue;
					case 203:
						array5 = R7L9Xr828p;
						num2 = 98;
						continue;
					case 102:
						array4[5] = (byte)num4;
						num2 = 166;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 47;
						}
						continue;
					case 187:
						array[23] = (byte)num3;
						num2 = 168;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 234;
						}
						continue;
					case 25:
						array[15] = 30;
						num = 333;
						break;
					case 92:
						array4[5] = (byte)num4;
						num = 135;
						break;
					case 95:
						array4[14] = 203;
						num2 = 59;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 27;
						}
						continue;
					case 289:
						array4[8] = 125;
						num2 = 24;
						continue;
					case 156:
						num3 = 2 + 110;
						num2 = 230;
						continue;
					case 260:
						return;
					case 182:
						array[12] = 106;
						num2 = 191;
						continue;
					case 97:
						if (array6.Length == 0)
						{
							num2 = 4;
							continue;
						}
						goto case 330;
					case 45:
						array[31] = (byte)num3;
						num2 = 61;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 87;
						}
						continue;
					case 147:
						array4[0] = 172;
						num2 = 236;
						continue;
					case 44:
						array4[0] = (byte)num4;
						num2 = 147;
						continue;
					case 106:
						array[2] = 102;
						num2 = 288;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 288;
						}
						continue;
					case 134:
						num3 = 218 - 102;
						num2 = 161;
						continue;
					case 165:
						array4[2] = (byte)num4;
						num2 = 282;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 242;
						}
						continue;
					case 154:
						array4[8] = (byte)num4;
						num2 = 51;
						continue;
					case 259:
						num3 = 173 - 94;
						num2 = 187;
						continue;
					case 81:
						array4[13] = (byte)num4;
						num2 = 67;
						continue;
					case 211:
						array[7] = 144;
						num2 = 278;
						continue;
					case 340:
						array4[7] = (byte)num4;
						num2 = 164;
						continue;
					case 189:
						num3 = 164 - 54;
						num2 = 131;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 27;
						}
						continue;
					case 137:
						array[19] = 55;
						num2 = 113;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 23;
						}
						continue;
					case 217:
						num3 = 112 + 101;
						num2 = 151;
						continue;
					case 318:
						num3 = 189 - 63;
						num2 = 20;
						continue;
					case 157:
						array[31] = (byte)num3;
						num = 129;
						break;
					case 191:
						array[12] = 154;
						num2 = 61;
						continue;
					case 253:
						array[11] = 3;
						num2 = 146;
						continue;
					case 219:
						array4[13] = (byte)num4;
						num2 = 210;
						continue;
					case 51:
						array4[9] = 81;
						num2 = 10;
						continue;
					case 17:
						num3 = 73 + 13;
						num2 = 26;
						continue;
					case 231:
						array[2] = (byte)num3;
						num2 = 309;
						continue;
					case 28:
						array4[11] = (byte)num4;
						num2 = 274;
						continue;
					case 343:
						array[2] = (byte)num3;
						num2 = 106;
						continue;
					case 272:
						num4 = 237 - 79;
						num2 = 118;
						continue;
					case 9:
						array4[2] = (byte)num4;
						num2 = 292;
						continue;
					case 160:
						num3 = 7 + 41;
						num2 = 229;
						continue;
					case 249:
						array[20] = 148;
						num2 = 209;
						continue;
					case 155:
						array[26] = (byte)num3;
						num2 = 36;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 4;
						}
						continue;
					case 35:
						array[19] = (byte)num3;
						num2 = 38;
						continue;
					case 319:
						num3 = 174 - 58;
						num2 = 299;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 176;
						}
						continue;
					case 138:
						array[10] = 152;
						num = 271;
						break;
					case 188:
						num3 = 135 - 45;
						num2 = 114;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 31;
						}
						continue;
					case 94:
						array[6] = 138;
						num2 = 298;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 37;
						}
						continue;
					case 186:
						array4[0] = 124;
						num2 = 130;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 101;
						}
						continue;
					case 280:
						array4[9] = 109;
						num2 = 197;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 272;
						}
						continue;
					case 62:
						num4 = 63 + 15;
						num2 = 73;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 304;
						}
						continue;
					case 4:
					case 175:
					case 237:
						num5 = 0;
						num2 = 255;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 165;
						}
						continue;
					case 125:
						array[27] = (byte)num3;
						num2 = 245;
						continue;
					case 5:
						num3 = 56 + 114;
						num = 323;
						break;
					case 72:
						array[16] = 202;
						num2 = 16;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 176;
						}
						continue;
					case 59:
						num4 = 27 + 117;
						num2 = 90;
						continue;
					case 33:
						num4 = 58 + 67;
						num2 = 92;
						continue;
					case 85:
						array4[2] = 168;
						num = 75;
						break;
					case 108:
					case 162:
						new JYC3AkacE3hrYs377xw().cLqa4ewYRL(array2, array3, array5);
						num2 = 179;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 260;
						}
						continue;
					case 63:
						array[28] = (byte)num3;
						num2 = 148;
						continue;
					case 208:
						array[4] = (byte)num3;
						num2 = 99;
						continue;
					case 238:
						array[13] = 30;
						num2 = 5;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 29;
						}
						continue;
					case 283:
						num3 = 105 + 99;
						num = 343;
						break;
					case 132:
						array[29] = (byte)num3;
						num2 = 189;
						continue;
					case 129:
						num3 = 27 + 124;
						num2 = 19;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 45;
						}
						continue;
					case 235:
						array4[9] = 162;
						num2 = 153;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 127;
						}
						continue;
					case 205:
						array[0] = 226;
						num2 = 77;
						continue;
					case 80:
						num4 = 235 - 78;
						num2 = 275;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 147;
						}
						continue;
					case 183:
						array[0] = 180;
						num2 = 261;
						continue;
					case 89:
						array[3] = 121;
						num2 = 262;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 7;
						}
						continue;
					case 334:
						array[24] = (byte)num3;
						num2 = 128;
						continue;
					case 222:
						array4[6] = (byte)num4;
						num2 = 15;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 2;
						}
						continue;
					case 250:
						array[24] = (byte)num3;
						num2 = 336;
						continue;
					case 172:
						array[30] = 104;
						num2 = 315;
						continue;
					case 342:
						array[12] = (byte)num3;
						num2 = 182;
						continue;
					case 264:
						num4 = 239 - 79;
						num2 = 270;
						continue;
					case 96:
						array3[5] = array6[2];
						num2 = 252;
						continue;
					case 124:
						num3 = 26 + 56;
						num2 = 103;
						continue;
					case 166:
						array4[5] = 168;
						num2 = 338;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 62;
						}
						continue;
					case 246:
						array4[1] = (byte)num4;
						num2 = 224;
						continue;
					case 197:
						num3 = 144 - 48;
						num = 312;
						break;
					case 67:
						num4 = 169 - 63;
						num2 = 219;
						continue;
					case 337:
						array4[3] = (byte)num4;
						num2 = 251;
						continue;
					case 198:
						num3 = 224 - 74;
						num2 = 116;
						continue;
					case 127:
						num4 = 185 - 124;
						num2 = 345;
						continue;
					case 91:
						array[7] = 97;
						num2 = 175;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 211;
						}
						continue;
					case 291:
						array3[15] = array6[7];
						num2 = 237;
						continue;
					case 31:
						array[5] = 154;
						num2 = 148;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 281;
						}
						continue;
					case 215:
						array[27] = 141;
						num2 = 8;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 23;
						}
						continue;
					case 240:
						num3 = 160 - 53;
						num = 21;
						break;
					case 199:
						num4 = 56 + 104;
						num2 = 28;
						continue;
					case 239:
						array[28] = (byte)num3;
						num = 54;
						break;
					case 322:
						array[17] = (byte)num3;
						num2 = 225;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 243;
						}
						continue;
					case 118:
						array4[9] = (byte)num4;
						num2 = 75;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 235;
						}
						continue;
					case 52:
						array[2] = (byte)num3;
						num2 = 131;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 319;
						}
						continue;
					case 304:
						array4[4] = (byte)num4;
						num2 = 0;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 0;
						}
						continue;
					case 69:
						num3 = 34 + 68;
						num2 = 51;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 155;
						}
						continue;
					case 314:
						num3 = 145 + 6;
						num2 = 35;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 32;
						}
						continue;
					case 8:
						if (array6 == null)
						{
							num2 = 175;
							if (!PeSETrHHlPPUrqmyD5U())
							{
								num2 = 138;
							}
							continue;
						}
						goto case 97;
					case 271:
						num3 = 58 + 106;
						num2 = 111;
						continue;
					case 93:
						array[6] = 142;
						num2 = 94;
						continue;
					case 140:
						num3 = 212 - 70;
						num2 = 6;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 101;
						}
						continue;
					case 223:
						array4[7] = 91;
						num2 = 1;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 1;
						}
						continue;
					case 159:
						array4[11] = (byte)num4;
						num2 = 152;
						continue;
					case 30:
						array[26] = (byte)num3;
						num2 = 134;
						continue;
					case 14:
						num3 = 160 - 51;
						num2 = 74;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 263;
						}
						continue;
					case 164:
						array4[7] = 126;
						num2 = 194;
						continue;
					case 143:
						array[21] = (byte)num3;
						num2 = 39;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 218;
						}
						continue;
					case 184:
						array4[15] = (byte)num4;
						num2 = 47;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 10;
						}
						continue;
					case 115:
						array4[1] = 134;
						num2 = 163;
						continue;
					case 244:
						array4[12] = 131;
						num2 = 221;
						continue;
					case 87:
						array[31] = 83;
						num2 = 195;
						continue;
					case 151:
						array[28] = (byte)num3;
						num2 = 32;
						continue;
					case 149:
						stream = (Stream)prS7KBHp6Ov39MR8UBl();
						num2 = 206;
						continue;
					case 324:
						array4[15] = 90;
						num2 = 301;
						continue;
					case 105:
						array3 = array4;
						num2 = 169;
						continue;
					case 303:
						array[10] = (byte)num3;
						num2 = 160;
						continue;
					case 148:
						array[28] = 161;
						num2 = 121;
						continue;
					case 90:
						array4[14] = (byte)num4;
						num2 = 326;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 341;
						}
						continue;
					case 55:
						num3 = 143 + 104;
						num2 = 204;
						continue;
					case 109:
						num5++;
						num = 158;
						break;
					case 257:
						array[7] = 127;
						num2 = 74;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 55;
						}
						continue;
					case 269:
						array[12] = 15;
						num2 = 124;
						continue;
					case 297:
						num3 = 63 + 15;
						num2 = 150;
						continue;
					case 11:
						num3 = 20 + 107;
						num2 = 303;
						continue;
					case 130:
						num4 = 179 - 59;
						num2 = 38;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 44;
						}
						continue;
					case 313:
						array[25] = 140;
						num = 117;
						break;
					case 204:
						array[11] = (byte)num3;
						num2 = 220;
						continue;
					case 1:
						num4 = 95 + 52;
						num2 = 340;
						continue;
					case 121:
						num3 = 63 + 95;
						num = 132;
						break;
					case 107:
						array[25] = (byte)num3;
						num2 = 313;
						continue;
					case 307:
						array[1] = 134;
						num2 = 37;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 202;
						}
						continue;
					case 232:
						array[27] = (byte)num3;
						num2 = 217;
						continue;
					case 66:
						array[6] = 103;
						num2 = 93;
						continue;
					case 296:
						array4[15] = 146;
						num2 = 98;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 127;
						}
						continue;
					case 192:
						array[9] = (byte)num3;
						num2 = 138;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 45;
						}
						continue;
					case 18:
						if (P_1 == -1)
						{
							num2 = 19;
							if (drJBplHV3iLehWF68Un() == null)
							{
								num2 = 73;
							}
							continue;
						}
						goto case 98;
					case 53:
						array4 = new byte[16];
						num2 = 43;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 186;
						}
						continue;
					case 43:
						array[17] = (byte)num3;
						num2 = 89;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 318;
						}
						continue;
					case 316:
						num3 = 201 - 67;
						num2 = 72;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 142;
						}
						continue;
					case 233:
						num4 = 113 + 66;
						num2 = 337;
						continue;
					case 29:
						array[14] = 169;
						num2 = 133;
						continue;
					case 254:
						array4[12] = 154;
						num2 = 244;
						continue;
					case 276:
						array = new byte[32];
						num2 = 183;
						continue;
					case 145:
						array4[3] = (byte)num4;
						num2 = 48;
						continue;
					case 70:
						array4[11] = (byte)num4;
						num2 = 76;
						if (PeSETrHHlPPUrqmyD5U())
						{
							num2 = 112;
						}
						continue;
					case 21:
						array[3] = (byte)num3;
						num2 = 89;
						continue;
					case 38:
						num3 = 6 + 6;
						num2 = 325;
						continue;
					case 320:
						array[16] = 160;
						num2 = 72;
						continue;
					case 295:
						num4 = 91 + 34;
						num2 = 41;
						continue;
					case 181:
						array[10] = 109;
						num2 = 11;
						continue;
					case 56:
						array4[15] = (byte)num4;
						num2 = 296;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 20;
						}
						continue;
					case 323:
						array[22] = (byte)num3;
						num2 = 267;
						continue;
					case 104:
						array4[7] = (byte)num4;
						num2 = 223;
						continue;
					case 46:
						num3 = 165 - 55;
						num2 = 72;
						if (drJBplHV3iLehWF68Un() == null)
						{
							num2 = 279;
						}
						continue;
					case 23:
						array[27] = 117;
						num = 290;
						break;
					case 73:
					{
						object obj = OF7t1xHuuWneZp0ls59();
						mHfOExH0fdQ6PZxoGLM(obj, CipherMode.CBC);
						transform = (ICryptoTransform)E0naa1Hj8BCUjDQugmd(obj, array2, array3);
						num2 = 149;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 5;
						}
						continue;
					}
					case 241:
						array[5] = 148;
						num2 = 31;
						continue;
					case 279:
						array[13] = (byte)num3;
						num2 = 273;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 210;
						}
						continue;
					case 135:
						num4 = 112 + 50;
						num = 82;
						break;
					case 243:
						num3 = 46 + 11;
						num2 = 180;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 69;
						}
						continue;
					case 111:
						array[10] = (byte)num3;
						num2 = 181;
						if (!PeSETrHHlPPUrqmyD5U())
						{
							num2 = 76;
						}
						continue;
					case 284:
						num4 = 39 + 44;
						num2 = 159;
						continue;
					case 292:
						num4 = 71 - 2;
						num2 = 165;
						continue;
					case 236:
						num4 = 29 + 39;
						num2 = 246;
						continue;
					case 311:
						array[23] = (byte)num3;
						num2 = 39;
						if (drJBplHV3iLehWF68Un() != null)
						{
							num2 = 24;
						}
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string EWJ9xtjenL(int P_0)
		{
			if (R7L9Xr828p.Length == 0)
			{
				onx969syix = new List<string>();
				k7e9MjogoI = new List<int>();
				jdR9BurN3i(ERJ9djGxrA.GetManifestResourceStream("1jhwCOR6QYHykk0jvK.HKk9MsGXil7hBHgfpU"), P_0);
			}
			if (Biv9JFsovf < 75)
			{
				if ((object)ERJ9djGxrA != new StackFrame(1).GetMethod().DeclaringType.Assembly)
				{
					throw new Exception();
				}
				Biv9JFsovf++;
			}
			lock (Ey89W82FTn)
			{
				int num = BitConverter.ToInt32(R7L9Xr828p, P_0);
				if (num < k7e9MjogoI.Count && k7e9MjogoI[num] == P_0)
				{
					return onx969syix[num];
				}
				try
				{
					rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
					byte[] array = new byte[num];
					Array.Copy(R7L9Xr828p, P_0 + 4, array, 0, num);
					string text = Encoding.Unicode.GetString(array, 0, array.Length);
					onx969syix.Add(text);
					k7e9MjogoI.Add(P_0);
					Array.Copy(BitConverter.GetBytes(onx969syix.Count - 1), 0, R7L9Xr828p, P_0, 4);
					return text;
				}
				catch
				{
				}
			}
			return "";
		}

		internal static string QD39CtUi3H(string P_0)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(P_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		private static int VWA9gJi7fM()
		{
			return 5;
		}

		private static void RB492tlnrl()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private static Delegate NhG9nwAHuw(IntPtr P_0, Type P_1)
		{
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[2] { P_0, P_1 });
		}

		internal static object BlJ973qlYJ(object P_0)
		{
			try
			{
				if (File.Exists(((Assembly)P_0).Location))
				{
					return ((Assembly)P_0).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString()))
				{
					return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
						.ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		[DllImport("kernel32", EntryPoint = "LoadLibrary")]
		public static extern IntPtr WNf9OYhnKw(string P_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		public static extern IntPtr zcj9u5I9hl(IntPtr P_0, string P_1);

		private static IntPtr OGR90IXxgy(IntPtr P_0, string P_1, uint P_2)
		{
			if (V0kwVsDGNy == null)
			{
				V0kwVsDGNy = (XmwidPwQiDxJdbAGefl)Marshal.GetDelegateForFunctionPointer(zcj9u5I9hl(xMpiFL8WN(), "Find ".Trim() + "ResourceA"), typeof(XmwidPwQiDxJdbAGefl));
			}
			return V0kwVsDGNy(P_0, P_1, P_2);
		}

		private static IntPtr z019joFwZg(IntPtr P_0, uint P_1, uint P_2, uint P_3)
		{
			if (cX8wB2W2j1 == null)
			{
				cX8wB2W2j1 = (CnKXjbwbxgBSxp4hZUI)Marshal.GetDelegateForFunctionPointer(zcj9u5I9hl(xMpiFL8WN(), "Virtual ".Trim() + "Alloc"), typeof(CnKXjbwbxgBSxp4hZUI));
			}
			return cX8wB2W2j1(P_0, P_1, P_2, P_3);
		}

		private static int xa19pPQsDI(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
		{
			if (IOZwxls6Ks == null)
			{
				IOZwxls6Ks = (FlbpKZwfutr2fBplyj5)Marshal.GetDelegateForFunctionPointer(zcj9u5I9hl(xMpiFL8WN(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(FlbpKZwfutr2fBplyj5));
			}
			return IOZwxls6Ks(P_0, P_1, P_2, P_3, out P_4);
		}

		private static int iwR9K10wD7(IntPtr P_0, int P_1, int P_2, ref int P_3)
		{
			if (VANwC1SWcn == null)
			{
				VANwC1SWcn = (nqWjwOwvfFPQoJjUgIj)Marshal.GetDelegateForFunctionPointer(zcj9u5I9hl(xMpiFL8WN(), "Virtual ".Trim() + "Protect"), typeof(nqWjwOwvfFPQoJjUgIj));
			}
			return VANwC1SWcn(P_0, P_1, P_2, ref P_3);
		}

		private static IntPtr k0p9sHKuy2(uint P_0, int P_1, uint P_2)
		{
			if (q9Uwgu8UgL == null)
			{
				q9Uwgu8UgL = (o4HAZawlaQbkgyX3R9x)Marshal.GetDelegateForFunctionPointer(zcj9u5I9hl(xMpiFL8WN(), "Open ".Trim() + "Process"), typeof(o4HAZawlaQbkgyX3R9x));
			}
			return q9Uwgu8UgL(P_0, P_1, P_2);
		}

		private static int yoO957FVbK(IntPtr P_0)
		{
			if (ghdw2R4fai == null)
			{
				ghdw2R4fai = (WeCeMZwZNQ1xsx0lpml)Marshal.GetDelegateForFunctionPointer(zcj9u5I9hl(xMpiFL8WN(), "Close ".Trim() + "Handle"), typeof(WeCeMZwZNQ1xsx0lpml));
			}
			return ghdw2R4fai(P_0);
		}

		[SpecialName]
		private static IntPtr xMpiFL8WN()
		{
			if (NhSwngTf2Q == IntPtr.Zero)
			{
				NhSwngTf2Q = WNf9OYhnKw("kernel ".Trim() + "32.dll");
			}
			return NhSwngTf2Q;
		}

		private static byte[] jk89AF4HVM(string P_0)
		{
			using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			int num = 0;
			int num2 = (int)fileStream.Length;
			byte[] array = new byte[num2];
			while (num2 > 0)
			{
				int num3 = fileStream.Read(array, num, num2);
				num += num3;
				num2 -= num3;
			}
			return array;
		}

		internal static Stream QbL9Ijw6fi()
		{
			return new MemoryStream();
		}

		internal static byte[] A2u9qeWpTF(Stream P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		private static byte[] pxY98N5Chi(byte[] P_0)
		{
			Stream stream = QbL9Ijw6fi();
			SymmetricAlgorithm symmetricAlgorithm = ydIaYNtXpE();
			symmetricAlgorithm.Key = new byte[32]
			{
				70, 76, 240, 173, 231, 30, 61, 216, 170, 40,
				164, 92, 170, 208, 201, 77, 177, 210, 210, 117,
				87, 183, 237, 74, 121, 27, 219, 209, 95, 46,
				171, 245
			};
			symmetricAlgorithm.IV = new byte[16]
			{
				176, 171, 253, 116, 179, 23, 57, 179, 33, 17,
				47, 75, 167, 111, 234, 148
			};
			CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(P_0, 0, P_0.Length);
			cryptoStream.Close();
			byte[] result = A2u9qeWpTF(stream);
			rwVK9dwSXMcdTJAOpaL.mBoHrDqpfe();
			return result;
		}

		private byte[] TOx9rsTTKa()
		{
			return null;
		}

		private byte[] Ike9ydOfFV()
		{
			return null;
		}

		private byte[] gWe9oG2ZnU()
		{
			_ = "{11111-22222-20001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] PRa9P77lZd()
		{
			_ = "{11111-22222-20001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] dCf9Q135po()
		{
			_ = "{11111-22222-30001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] sNx9bswgAm()
		{
			_ = "{11111-22222-30001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] CxY9f8FPFh()
		{
			_ = "{11111-22222-40001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] K0S9vcOlmf()
		{
			_ = "{11111-22222-40001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] Gxx9laZKX4()
		{
			_ = "{11111-22222-50001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] dXL9ZZ4VLO()
		{
			_ = "{11111-22222-50001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal static object NGMLEGHB79S7W3EmRXs(object P_0)
		{
			return ((oXuR3KwqIM5g2gdT6SW)P_0).f9UtU12u5A();
		}

		internal static void h6BCvLHxm7DwIp4uTSP(object P_0, long P_1)
		{
			((Stream)P_0).Position = P_1;
		}

		internal static long dVybWiHCxcEJfZi8y2W(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		internal static object DKlJr2Hg1KuwNQP8UmZ(object P_0, int P_1)
		{
			return ((oXuR3KwqIM5g2gdT6SW)P_0).RRgw8TNlQS(P_1);
		}

		internal static void m8tWw6H2QDCNxCySd6G(object P_0)
		{
			((oXuR3KwqIM5g2gdT6SW)P_0).GHXwo2ycPH();
		}

		internal static void BNdrwYHnGL48hifFovH(object P_0)
		{
			Array.Reverse((Array)P_0);
		}

		internal static object BIsdkaH70v4RUr6l0tk(object P_0)
		{
			return ((Assembly)P_0).GetName();
		}

		internal static object InjlMMHOkhu7FTpPgSD(object P_0)
		{
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		internal static object OF7t1xHuuWneZp0ls59()
		{
			return ydIaYNtXpE();
		}

		internal static void mHfOExH0fdQ6PZxoGLM(object P_0, CipherMode P_1)
		{
			((SymmetricAlgorithm)P_0).Mode = P_1;
		}

		internal static object E0naa1Hj8BCUjDQugmd(object P_0, object P_1, object P_2)
		{
			return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[]?)P_2);
		}

		internal static object prS7KBHp6Ov39MR8UBl()
		{
			return QbL9Ijw6fi();
		}

		internal static void jmNbChHKYAyNg43L2j0(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void tOYflCHs7dtvWcbZE7g(object P_0)
		{
			((CryptoStream)P_0).FlushFinalBlock();
		}

		internal static object H9mDcAH5FDZcDIXnfdS(object P_0)
		{
			return A2u9qeWpTF((Stream)P_0);
		}

		internal static void YnZ7MpHAoOEGXlReOtO(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object NNluOUHIuITn0DuhOJk(object P_0)
		{
			return ((Assembly)P_0).EntryPoint;
		}

		internal static bool PeSETrHHlPPUrqmyD5U()
		{
			return null == null;
		}

		internal static object drJBplHV3iLehWF68Un()
		{
			return null;
		}
	}
}
namespace adOHu8we2DAKJQKPHPY
{
	internal class rwVK9dwSXMcdTJAOpaL
	{
		private static bool iMhwNlyqVy;

		internal static void mBoHrDqpfe()
		{
			if (!iMhwNlyqVy)
			{
				iMhwNlyqVy = true;
				if (Math.Sign((DateTime.Now - new DateTime(2024, 8, 11)).Days) >= 14)
				{
					throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
				}
			}
		}
	}
}
internal sealed class <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}
{
	internal int m_f4766bb306c74db4b549a2abe5d0e016;

	internal int m_62f7701e7e014d8cbe286aa3b981e5b4;

	internal int m_0589018cf09e4146a591c50f1ec35ac2;

	internal int m_6ba90f2369d54b20a8620e4bf08d69f2;

	internal int m_ce312da1fa914214846f6cebfc36e0e5;

	internal int m_69a3f0883a2e44578d65bfa554792bc6;

	internal int m_389e2933020f4d7fa64c053a66925a10;

	internal int m_b9ec53efaa9d47ca8b39d18e9d24f52d;

	internal int m_6e6875ef862a4f18b6ccb689f77fcc30;

	internal int m_283ad047d1594b798230036442d583ed;

	internal int m_3f26e26870e34a9e98cdc9843dbdd97f;

	internal int m_027ab08237d64cc78940da415d64b30a;

	internal int m_c1419ace2ca14a41b6107babebf11de8;

	internal int m_493a1790d4e64de788d0326ff7b056cf;

	internal int m_40a5dd4547b748899e4bb85ca9f33b7f;

	internal int m_d460f4b126a54265b80fbfb5ea4ee424;

	internal int m_cd3d273b94d64a3b9bb44307afe11254;

	internal int m_5b52f673eadf445ba15211d965dd4e5c;

	internal int m_ae050047eafc4c369a30de40f8126bb4;

	internal int m_6abb142d5a2a42099db4d2c544fd3569;

	internal int m_8a075b945d6c4e0683e9be5c1637c2e0;

	internal int m_68120a42c2874076aec5ed965f81539b;

	internal int m_c874f2a03b794f3795625c7f6b64f71e;

	internal int m_2ed0d35a40b64c88a7fb66fc3db4f298;

	internal int m_3a9bc1c099884238becd23eb976c03c3;

	internal int m_eb4c51c87e664f2a80b08fdc8c7d117f;

	internal int m_b8799d9d12164760abe2273e0b43a3b8;

	internal int m_487a9c03636f4132ae7d56afa1a05f7e;

	internal int m_17f1d815a4da46ac9a83ae8e20f4f165;

	internal int m_8101fe97078744c68a990cf628d18b17;

	internal int m_181c07bdd5d34078bdc5d04827b67f18;

	internal int m_14e6c17fd03243de988faeeed0fbdd77;

	internal int m_2139f10526cb4e768db0abb3d67ed031;

	internal int m_77c98afd49b14e29a17265e1b253c7aa;

	internal int m_dd0b344c6909465a896e78ae0bc286d6;

	internal int m_fadcb8ebee0144f5bdd6538bbdbb3210;

	internal int m_9a4d0786e8314c54b8fa5a6baf68a8d8;

	internal int m_d64af867a72147e0a995c254e11330e9;

	internal int m_543c69d7912b453e8f1ca646c910f711;

	internal int m_4ebf4fc31b3d40bf961e4a7873c86f4a;

	internal int m_19e955f1e78844e394cc31060c3bd489;

	internal int m_486b5961925f44cbb93dff5ddbca9bca;

	internal int m_dd979506b8aa441498151f4a7809a6c5;

	internal int m_e1334a8838ba4eaeaf99473f679eb548;

	internal int m_eb3e90d2e5434884a31c4998d55c9f6d;

	internal int m_0369b80e54f14dff9d976468929815cd;

	internal int m_857083d251044978af45548ea2980d50;

	internal int m_97aed94788994f29b725a6744c64aeb6;

	internal int m_beff6e54f4854049945826057572ca36;

	internal int m_3be8dfcaee924de29283b967aea97d78;

	internal int m_fe19072347b94ddbae8ebbf2031d6c83;

	internal int m_a5ad559dd3c64e4d93ef243199361f5d;

	internal int m_aefe09b11d3241e295888f070c7da88d;

	internal int m_7b836f32bbf549fa8fc6fb94c1fad79e;

	internal int m_319cdd6938bc43a6b5a49868e77118d8;

	internal int m_a6482f758d4a47149e59d76954f7f36b;

	internal int m_e1b0ac30dcfd4694ad2d8d821069fd80;

	internal int m_8724f33c76f74e57a1978c7b90943961;

	internal int m_a3df1cde168d4af296948a01a3b4ca0c;

	internal int m_408f37a85db04d01baf40b7922565dc0;

	internal int m_4f4904c8690145418f82d475ae45163f;

	internal int m_8612643327ae4e7ba2f2ab49008bb5a5;

	internal int m_b52e0b593a4d4d44806ea62944f7a81c;

	internal int m_efbcaa0d1f5845f69dad7d2488bb8518;

	internal int m_580d3528dcca4b4eb76786a93dafce8a;

	internal int m_8a730714655e4b0986f04779c3bb9dd3;

	internal int m_f9916f0dc04b400da698e69202acc536;

	internal int m_04b53e7f77cf4da9abb45cd819a76e08;

	internal int m_69bd40e1c080420b80fabf0e25d24a45;

	internal int m_70931b19ae2a42c7a80d4e7e66a528c2;

	internal int m_819981b7e4cb424e9921d3e1cae80095;

	internal static <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b} m_b8391cbeac534d7a8ba46c2e02938cf0;

	internal int m_46a6edffdef04a8ca7c012903f3e3dbf;

	internal int m_85a27ee4f9da43178ac82f723d8f3cc3;

	internal int m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79;

	internal int m_63ebddb2ca574184a22c260f98355fcd;

	internal int m_ff7bc6b0738d45f1a5683337a08293d0;

	internal int m_2fc82bbd37ff46b2ab41c2658fd35ead;

	internal int m_0bf7ad6a81f94386a489758f58afa0b8;

	internal int m_a71151733efa48afbeb59afd276197dd;

	internal int m_3e9fa7fe77a041249c803f9807ab90c9;

	internal int m_fcabfc4406e34fc28dc886ad9d4ba5db;

	internal int m_25073d5452454ce4822ca82beb6e33b5;

	internal int m_2a6b2bb68a0d44e2a852e01d5b295025;

	internal int m_7709014833e74e25a28517910294fe57;

	internal int m_12c1d64f4db746bfbc8ad85c9dcc8d84;

	internal int m_babc87acf245467caf78fc0e70d64bea;

	internal int m_ef4dfc12facc48b7a082606bd76db783;

	internal int m_753f78b3724c48c6b1d1adb335769852;

	internal int m_6b605d1ecae44aa884cae9c69bd75215;

	internal int m_09b5348e438f439caae6da54a05444f1;

	internal int m_9b55fcbcc36f4c6f99398af1c63f0559;

	internal int m_689a011ba2054636ace3a64494a8f311;

	internal int m_119784c63057497f953b9cf523a8cad2;

	internal int m_ecff76728e4b4734ad3a1a2d1c7cddd4;

	internal int m_f412b0f35c114b30a611880b534fabee;

	internal int m_86a577552a1b4537bd18bfaf6b13543c;

	internal int m_5d9c2c0b2f574c878b1c78cf0baed81d;

	internal int m_fe2f0b08fe4147b9bf9e4afc828acce4;

	internal int m_0457436cfd634df1b7a3d467e10632e8;

	internal int m_452b34a0d06f4c42b2964dd1e5b6b361;

	internal int m_f8fe1e6019604f049dfb603266c1f4d7;

	internal int m_e806af249f5d48b4a3a4347de665b5c1;

	internal int m_34d311246ce34690a1e37753bdc5ca83;

	internal int m_ed95be32fac245e7ae1d97d5927a537f;

	internal int m_802f9181d30340a6acb4abe64156490b;

	internal int m_6115a6c87e4841c48991f639b0cae607;

	internal int m_40d4247f238447c2834caf5082b4b807;

	internal int m_c69692590fe2488a9bab4b8f0ae4e51b;

	internal int m_9f3215bcab5341e9ba7e6d2d706769d6;

	internal int m_8904dc2f161a42ec961f418b99f547bb;

	internal int m_f340885c752249fc8127a823d021eb10;

	internal int m_8e1e020d40b14130aff4dc225a05611b;

	static <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}()
	{
		v80225153b43f42c48f1f0814f9ed07fe();
	}

	internal static void v80225153b43f42c48f1f0814f9ed07fe()
	{
		m_b8391cbeac534d7a8ba46c2e02938cf0 = new <Module>{028a5243-6f2a-4458-a9fe-fc69c92e877b}();
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_fadcb8ebee0144f5bdd6538bbdbb3210 = -759121745 ^ -759121745;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8904dc2f161a42ec961f418b99f547bb = 0x179B716C ^ 0x728956A1;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_7b836f32bbf549fa8fc6fb94c1fad79e = 0x7388FA48 ^ 0x15305607;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_a6482f758d4a47149e59d76954f7f36b = -1891313024 ^ -1891313024;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_2fc82bbd37ff46b2ab41c2658fd35ead = -759121745 ^ -759121745;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8724f33c76f74e57a1978c7b90943961 = -1085642163 ^ -1085642163;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_6e6875ef862a4f18b6ccb689f77fcc30 = -(2040688280 - 2082047872) ^ 0x27718E8;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_3be8dfcaee924de29283b967aea97d78 = -587057742 ^ -587057742;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_408f37a85db04d01baf40b7922565dc0 = 0x48A97992 ^ 0x48A97992;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_12c1d64f4db746bfbc8ad85c9dcc8d84 = (--868007057 << 2) ^ -822939068;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_c874f2a03b794f3795625c7f6b64f71e = -(-1583761318 - -79827217) ^ 0x54134E02;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_40a5dd4547b748899e4bb85ca9f33b7f = -1503372051 ^ -92335889;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_486b5961925f44cbb93dff5ddbca9bca = 0x52FE137D ^ 0x52DEC636;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_cd3d273b94d64a3b9bb44307afe11254 = -1569067839 ^ -1569067839;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_a3df1cde168d4af296948a01a3b4ca0c = 0x179B716C ^ 0x510DC893;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_0457436cfd634df1b7a3d467e10632e8 = 0x5AA48585 ^ 0x7D4E6548;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_4ebf4fc31b3d40bf961e4a7873c86f4a = 0xFAA15C5 ^ 0xFAA15C5;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_181c07bdd5d34078bdc5d04827b67f18 = 0x18220E40 ^ 0x352143B7;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_3e9fa7fe77a041249c803f9807ab90c9 = -1199820739 ^ -119559356;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_452b34a0d06f4c42b2964dd1e5b6b361 = -578433188 ^ -987212283;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_0bf7ad6a81f94386a489758f58afa0b8 = -587057742 ^ -587057742;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_14e6c17fd03243de988faeeed0fbdd77 = 0x7388FA48 ^ 0x7388FA48;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_389e2933020f4d7fa64c053a66925a10 = -47159019 ^ -1642808473;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_f9916f0dc04b400da698e69202acc536 = 0x164AD0B ^ 0x164AD0B;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_85a27ee4f9da43178ac82f723d8f3cc3 = -129644881 ^ -1835811165;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_283ad047d1594b798230036442d583ed = -1085642163 ^ -2119991385;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_857083d251044978af45548ea2980d50 = 0x37B3255B ^ 0xBD60658;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_70931b19ae2a42c7a80d4e7e66a528c2 = -1636182299 ^ -2037773678;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_c1419ace2ca14a41b6107babebf11de8 = --428035074 ^ 0x19834C02;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_753f78b3724c48c6b1d1adb335769852 = 0x59CC962A ^ 0x59CC962A;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_6abb142d5a2a42099db4d2c544fd3569 = 0x18220E40 ^ 0x18220E40;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_19e955f1e78844e394cc31060c3bd489 = -884666373 ^ 0x1A220100 ^ -781775109;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_babc87acf245467caf78fc0e70d64bea = 0x32DA01F5 ^ 0x5739C595;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1b0ac30dcfd4694ad2d8d821069fd80 = 0x3316910 ^ 0x6060CAB3;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a075b945d6c4e0683e9be5c1637c2e0 = 0x32DA01F5 ^ 0x44E7354C;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_09b5348e438f439caae6da54a05444f1 = -1621158132 ^ -955908453;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_580d3528dcca4b4eb76786a93dafce8a = -47159019 ^ -840295229;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_2a6b2bb68a0d44e2a852e01d5b295025 = (-327023451 - 681339041) ^ -1008362492;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_a71151733efa48afbeb59afd276197dd = -119580294 ^ -446734226;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe2f0b08fe4147b9bf9e4afc828acce4 = 0x1695224 ^ 0x2B924909;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8612643327ae4e7ba2f2ab49008bb5a5 = -(591417642 - 2082298426) ^ 0x58DD0910;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_77c98afd49b14e29a17265e1b253c7aa = -47159019 ^ -758401032;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb4c51c87e664f2a80b08fdc8c7d117f = (-1788512866 - -255220816) ^ -416611209;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_493a1790d4e64de788d0326ff7b056cf = -1380809482 ^ -745612437;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_40d4247f238447c2834caf5082b4b807 = ~(--1461056138) ^ -1461056139;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8a730714655e4b0986f04779c3bb9dd3 = -340446800 ^ -1369474874;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_dd979506b8aa441498151f4a7809a6c5 = 0x568AC907 ^ 0x568AC907;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_f4766bb306c74db4b549a2abe5d0e016 = 0x1EED55B0 ^ 0x1EED55B0;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_dd0b344c6909465a896e78ae0bc286d6 = -1503372051 ^ -1503372051;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_b52e0b593a4d4d44806ea62944f7a81c = 0xCAF9DC ^ 0xCAF9DC;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_2ed0d35a40b64c88a7fb66fc3db4f298 = -529602667 ^ -529602667;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_e806af249f5d48b4a3a4347de665b5c1 = 0x5892CDD4 ^ 0x5892CDD4;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_69a3f0883a2e44578d65bfa554792bc6 = -408223848 ^ -1179206435;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_b8799d9d12164760abe2273e0b43a3b8 = 0x3316910 ^ 0x3316910;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_17f1d815a4da46ac9a83ae8e20f4f165 = -1621158132 ^ -1621158132;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_d460f4b126a54265b80fbfb5ea4ee424 = -1569067839 ^ -1569067839;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_0369b80e54f14dff9d976468929815cd = -475184773 ^ -337888342;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_3a9bc1c099884238becd23eb976c03c3 = 0x28850361 ^ 0x28850361;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_2139f10526cb4e768db0abb3d67ed031 = -2074537848 ^ -2074537848;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_487a9c03636f4132ae7d56afa1a05f7e = -6470145 ^ -1340398916;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_eb3e90d2e5434884a31c4998d55c9f6d = --428035074 ^ 0x19834C02;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_fcabfc4406e34fc28dc886ad9d4ba5db = 0x62999F84 ^ 0x62999F84;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_ed95be32fac245e7ae1d97d5927a537f = -1636182299 ^ -761931440;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_027ab08237d64cc78940da415d64b30a = (-1788512866 - -255220816) ^ -423214951;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_34d311246ce34690a1e37753bdc5ca83 = -(2040688280 - 2082047872) ^ 0x3E6CAFF9;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_5d9c2c0b2f574c878b1c78cf0baed81d = -1684745328 ^ -1993913355;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_86a577552a1b4537bd18bfaf6b13543c = -622522496 ^ -622522496;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_f412b0f35c114b30a611880b534fabee = 0xA878F1 ^ 0xA878F1;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_aefe09b11d3241e295888f070c7da88d = 0x2E8C9200 ^ 0x3B730CE6;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_ef4dfc12facc48b7a082606bd76db783 = -1621158132 ^ -1219407489;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_ae050047eafc4c369a30de40f8126bb4 = 0x7E462A33 ^ 0x7E462A33;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_ecff76728e4b4734ad3a1a2d1c7cddd4 = -47159019 ^ -47159019;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_ce312da1fa914214846f6cebfc36e0e5 = -1631718413 ^ -1631718413;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_7709014833e74e25a28517910294fe57 = -497864027 ^ -497864027;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_543c69d7912b453e8f1ca646c910f711 = -578433188 ^ -11317972;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_0589018cf09e4146a591c50f1ec35ac2 = 0x7388FA48 ^ 0x75D55278;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_689a011ba2054636ace3a64494a8f311 = 0xFAA15C5 ^ 0xFAA15C5;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_ff7bc6b0738d45f1a5683337a08293d0 = -360918765 ^ -360918765;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_119784c63057497f953b9cf523a8cad2 = (-327023451 - 681339041) ^ -1008362492;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_25073d5452454ce4822ca82beb6e33b5 = 0x62999F84 ^ 0x66C70001;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_f8fe1e6019604f049dfb603266c1f4d7 = (--436736976 << 6) ^ -269955522;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_68120a42c2874076aec5ed965f81539b = ~(--1461056138) ^ -1713619992;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_3f26e26870e34a9e98cdc9843dbdd97f = -475184773 ^ -210163660;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_319cdd6938bc43a6b5a49868e77118d8 = 0x78A346D4 ^ 0xD3A6032;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_819981b7e4cb424e9921d3e1cae80095 = 0xB1BD3F5 ^ 0xB1BD3F5;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_6b605d1ecae44aa884cae9c69bd75215 = -1569067839 ^ -1569067839;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_6115a6c87e4841c48991f639b0cae607 = -470877005 ^ -470877005;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_9ed5e4d73dbf4bc1b67e0e40f6d5ec79 = -1684745328 ^ -1367350358;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_63ebddb2ca574184a22c260f98355fcd = -200370420 ^ -606370921;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_46a6edffdef04a8ca7c012903f3e3dbf = -470877005 ^ -1146075847;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_97aed94788994f29b725a6744c64aeb6 = -1503481065 ^ -582258399;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_c69692590fe2488a9bab4b8f0ae4e51b = -1160104250 ^ -856917272;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_9b55fcbcc36f4c6f99398af1c63f0559 = 0x7E462A33 ^ 0x7E462A33;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_62f7701e7e014d8cbe286aa3b981e5b4 = -1545058695 ^ -1403095517;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_5b52f673eadf445ba15211d965dd4e5c = -119580294 ^ -119580294;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_6ba90f2369d54b20a8620e4bf08d69f2 = 0x568AC907 ^ 0x484E89EB;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_b9ec53efaa9d47ca8b39d18e9d24f52d = 0x17050EE0 ^ 0x17050EE0;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_04b53e7f77cf4da9abb45cd819a76e08 = -1503372051 ^ -394334393;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_4f4904c8690145418f82d475ae45163f = -759121745 ^ -1863825760;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_e1334a8838ba4eaeaf99473f679eb548 = 0xD9C7558 ^ 0xD9C7558;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_efbcaa0d1f5845f69dad7d2488bb8518 = 0x62999F84 ^ 0x62999F84;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_802f9181d30340a6acb4abe64156490b = (-1788512866 - -255220816) ^ -825362765;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_d64af867a72147e0a995c254e11330e9 = 0xCAF9DC ^ 0xCAF9DC;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_a5ad559dd3c64e4d93ef243199361f5d = 0x1BC23F5 ^ 0x1BC23F5;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8e1e020d40b14130aff4dc225a05611b = -408223848 ^ -2082516268;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_9a4d0786e8314c54b8fa5a6baf68a8d8 = (--436736976 << 6) ^ -1101995627;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_beff6e54f4854049945826057572ca36 = 0xC9B66E ^ 0xC9B66E;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_8101fe97078744c68a990cf628d18b17 = 0x338E1952 ^ 0x338E1952;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_fe19072347b94ddbae8ebbf2031d6c83 = -497864027 ^ -122842617;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_69bd40e1c080420b80fabf0e25d24a45 = -759121745 ^ -759121745;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_f340885c752249fc8127a823d021eb10 = 0x568AC907 ^ 0x568AC907;
		m_b8391cbeac534d7a8ba46c2e02938cf0.m_9f3215bcab5341e9ba7e6d2d706769d6 = -129644881 ^ -1034761714;
	}
}

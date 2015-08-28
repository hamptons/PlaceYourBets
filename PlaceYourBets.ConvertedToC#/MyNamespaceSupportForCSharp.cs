using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.2.9749).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace PlaceYourBets.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::PlaceYourBets.PredictionLeagueTableForm PredictionLeagueTableForm_instance;
			bool PredictionLeagueTableForm_isCreating;
			public global::PlaceYourBets.PredictionLeagueTableForm PredictionLeagueTableForm {
				[DebuggerStepThrough] get { return GetForm(ref PredictionLeagueTableForm_instance, ref PredictionLeagueTableForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref PredictionLeagueTableForm_instance, value); }
			}
			
			global::PlaceYourBets.ReviewForm ReviewForm_instance;
			bool ReviewForm_isCreating;
			public global::PlaceYourBets.ReviewForm ReviewForm {
				[DebuggerStepThrough] get { return GetForm(ref ReviewForm_instance, ref ReviewForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ReviewForm_instance, value); }
			}
			
			global::PlaceYourBets.ContainerForm ContainerForm_instance;
			bool ContainerForm_isCreating;
			public global::PlaceYourBets.ContainerForm ContainerForm {
				[DebuggerStepThrough] get { return GetForm(ref ContainerForm_instance, ref ContainerForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ContainerForm_instance, value); }
			}
			
			global::PlaceYourBets.PredictionsSubmitted PredictionsSubmitted_instance;
			bool PredictionsSubmitted_isCreating;
			public global::PlaceYourBets.PredictionsSubmitted PredictionsSubmitted {
				[DebuggerStepThrough] get { return GetForm(ref PredictionsSubmitted_instance, ref PredictionsSubmitted_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref PredictionsSubmitted_instance, value); }
			}
			
			global::PlaceYourBets.LoginForm LoginForm_instance;
			bool LoginForm_isCreating;
			public global::PlaceYourBets.LoginForm LoginForm {
				[DebuggerStepThrough] get { return GetForm(ref LoginForm_instance, ref LoginForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref LoginForm_instance, value); }
			}
			
			global::PlaceYourBets.ProgressBarForm ProgressBarForm_instance;
			bool ProgressBarForm_isCreating;
			public global::PlaceYourBets.ProgressBarForm ProgressBarForm {
				[DebuggerStepThrough] get { return GetForm(ref ProgressBarForm_instance, ref ProgressBarForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ProgressBarForm_instance, value); }
			}
			
			global::PlaceYourBets.FixturesForm FixturesForm_instance;
			bool FixturesForm_isCreating;
			public global::PlaceYourBets.FixturesForm FixturesForm {
				[DebuggerStepThrough] get { return GetForm(ref FixturesForm_instance, ref FixturesForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref FixturesForm_instance, value); }
			}
			
			global::PlaceYourBets.RegistrationForm RegistrationForm_instance;
			bool RegistrationForm_isCreating;
			public global::PlaceYourBets.RegistrationForm RegistrationForm {
				[DebuggerStepThrough] get { return GetForm(ref RegistrationForm_instance, ref RegistrationForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref RegistrationForm_instance, value); }
			}
			
			global::PlaceYourBets.MenuForm MenuForm_instance;
			bool MenuForm_isCreating;
			public global::PlaceYourBets.MenuForm MenuForm {
				[DebuggerStepThrough] get { return GetForm(ref MenuForm_instance, ref MenuForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref MenuForm_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}

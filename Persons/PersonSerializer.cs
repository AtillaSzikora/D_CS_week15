using System;
using System.Windows.Forms;

namespace PersonSerializer {
	internal static class PersonSerialization {
		/// The main entry point for the application.
		[STAThread]
		private static void Main() {
			Serialization.CreateFile();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PersonSerializationForm()); }
} }
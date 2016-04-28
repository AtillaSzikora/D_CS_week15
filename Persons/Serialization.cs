using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace PersonSerializer {
	internal class Serialization {
		public static string FileName;
		private static readonly SoapFormatter Soap = new SoapFormatter();

		public static void SetFileName() {
			int i = 1;
			while (File.Exists($"person{i.ToString("D2")}.dat")) { i++; }
			if (i < 100) { FileName = $"person{i.ToString("D2")}.dat"; }
			else MessageBox.Show(@"The program can not serialize more than 99 persons!"); }

		public static void Serialize(Person person) {
			SetFileName();
			FileStream fsc = new FileStream(FileName, FileMode.Create);
			Soap.Serialize(fsc, person);
			fsc.Close(); }

		public static Person Deserialize(string fileName) {
			FileStream fso = new FileStream(fileName, FileMode.Open);
			Person person = (Person) Soap.Deserialize(fso);
			fso.Close();
			return person; }
} }
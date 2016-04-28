using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace PersonSerializer {
	internal class Serialization {
		public static string FileName = "person1.dat";
		private static readonly SoapFormatter Soap = new SoapFormatter();

		public static void CreateFile() {
			int i = 1;
			while (File.Exists($"person{i}.dat")) { i++; }
			if (i < 100) { FileName = $"person{i}.dat"; }
			else MessageBox.Show(@"The program can not serialize more than 99 persons!"); }

		public static void Serialize() {
			Person jozsef = new Person("Jozsi", "Miskolc", "301234567");
			FileStream fs = new FileStream(FileName, FileMode.Create);
			Soap.Serialize(fs, jozsef);
			fs.Close(); }

		public static Person Deserialize(string fileName) {
			FileStream fs = new FileStream(fileName, FileMode.Open);
			return (Person) Soap.Deserialize(fs); }
} }
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PersonSerializer {
	internal class Serialization {
		private static string _fileName;
		private static readonly XmlSerializer Serializer = new XmlSerializer (typeof (Person));

		public static void SetFileName() {
			var i = 1;
			while (File.Exists($"person{i.ToString("D2")}.dat")) { i++; }
			if (i < 100) { _fileName = $"person{i.ToString("D2")}.dat"; }
			else MessageBox.Show(@"The program can not serialize more than 99 persons!"); }

		public static void Serialize(Person person) {
			SetFileName();
			using (var swriter = new StreamWriter(_fileName)) {
				Serializer.Serialize(swriter, person); } }

		public static Person Deserialize(string fileName) {
			using (var sreader = new StreamReader(fileName)) {
				return (Person) Serializer.Deserialize(sreader); } }
} }
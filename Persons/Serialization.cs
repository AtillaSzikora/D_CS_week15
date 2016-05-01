using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PersonSerializer {
	internal class Serialization {
		private string _fileName;
		private readonly XmlSerializer _serializer = new XmlSerializer(typeof(Person));

		public void SetFileName() {
			var i = 1;
			while (File.Exists($"person{i.ToString("D2")}.dat")) { i++; }
			if (i < 100) { _fileName = $"person{i.ToString("D2")}.dat"; }
			else MessageBox.Show(@"The program can not serialize more than 99 persons!"); }

		public void Serialize(Person person) {
			SetFileName();
			using (var swriter = new StreamWriter(_fileName)) {
				_serializer.Serialize(swriter, person); } }

		public Person Deserialize(string fileName) {
			using (var sreader = new StreamReader(fileName)) {
				return (Person) _serializer.Deserialize(sreader); } }
} }
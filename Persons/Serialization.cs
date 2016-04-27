using System.IO;
using System.Windows.Forms;

namespace PersonSerializer {
	internal class Serialization {

		public static void Serialize() { }

		public static void Deserialize() { }

		public static void CreateFile() {
			int j = 1;
			for (int i = 1; i <= 99; i++) {
				if (File.Exists($"person{i}.dat")) { j = i + 1; } }
			if (j < 100) { File.Create($"person{j}.dat"); }
			else MessageBox.Show(@"The program can not serialize more than 99 persons!"); }
} }
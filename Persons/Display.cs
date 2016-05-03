using System.IO;
using System.Windows.Forms;

namespace PersonSerializer {
	public partial class PersonSerializationForm {

		private void DisplayPerson() {
			if (File.Exists(_fileName)) {
				var person = _serial.Deserialize(_fileName);
				txtName.Text = person.Name;
				txtAddress.Text = person.Address;
				txtPhone.Text = person.Phone; }
			else { MessageBox.Show(@"There are no more persons."); } }

		private void DisplayFilesAndDirs() {
			txtPath.Text = _path;
			if (Directory.Exists(_path)) {
				DirectoryInfo dirs = new DirectoryInfo(txtPath.Text);
				object[] fileEntries = dirs.GetFileSystemInfos();
				lstFiles.Items.Clear();
				lstFiles.Items.AddRange(fileEntries); }
			else { MessageBox.Show(@"The given path is not a directory!"); } }
} }
using System;
using System.IO;
using System.Windows.Forms;

namespace PersonSerializer {
	public partial class PersonSerializationForm : Form {

		private static int _i = 1;
		private string _fileName = $"person{_i.ToString("D2")}.dat";
		private string _path = Directory.GetCurrentDirectory();
		private readonly Serialization _serial = new Serialization();

		public PersonSerializationForm() { InitializeComponent(); }

		private void PersonSerializationForm_Load(object sender, EventArgs e) {
			if (File.Exists(_fileName)) { DisplayPerson(); }
			DisplayFilesAndDirs(); }

		private void btnSave_Click (object sender, EventArgs e) {
			var person = new Person(txtName.Text, txtAddress.Text, txtPhone.Text);
			_serial.Serialize(person);
			DisplayFilesAndDirs();
			MessageBox.Show($"{txtName.Text} was saved successfully."); }

		private void btnNext_Click(object sender, EventArgs e) {
			_i++;
			_fileName = $"person{_i.ToString("D2")}.dat";
			DisplayPerson ();
			if (!File.Exists(_fileName)) { _i--; } }

		private void btnPrevious_Click(object sender, EventArgs e) {
			_i--;
			_fileName = $"person{_i.ToString("D2")}.dat";
			DisplayPerson ();
			if (!File.Exists(_fileName)) { _i++; } }

		private void EnterOnPath (object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				_path = txtPath.Text;
				DisplayFilesAndDirs (); } }
 
		private void lstFiles_DoubleClick(object sender,EventArgs e) {
			if (Directory.Exists(_path + @"\" + lstFiles.SelectedItem) && lstFiles.SelectedIndex != -1) {
				_path += @"\" + lstFiles.SelectedItem;
				DisplayFilesAndDirs(); }
			else { MessageBox.Show(@"The selected item is not a directory!"); } }

		private void btnFolderUp_Click (object sender, EventArgs e) {
			if (_path.Split('\\').Length > 2) {
				_path = _path.Substring(0, _path.LastIndexOf(@"\", StringComparison.Ordinal)); }
			else {
				_path = @"c:\";
				txtPath.Text = _path; }
			DisplayFilesAndDirs (); }
} }
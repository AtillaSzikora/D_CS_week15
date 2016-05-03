using System.IO;
using System.Windows.Forms;

namespace PersonSerializer {
	public partial class PersonSerializationForm : Form {

		private static int _i = 1;
		private string _fileName = $"person{_i.ToString("D2")}.dat";
		private string _path = @"C:\GDrive\Visual Studio 2015\Projects\D_CS_week15\Persons\bin\Debug";
		private readonly Serialization _serial = new Serialization();

		public PersonSerializationForm() { InitializeComponent(); }

		private void PersonSerializationForm_Load(object sender, System.EventArgs e) {
			if (File.Exists(_fileName)) { DisplayPerson(); }
			DisplayFilesAndDirs(); }

		private void btnSave_Click (object sender, System.EventArgs e) {
			var person = new Person(txtName.Text, txtAddress.Text, txtPhone.Text);
			_serial.Serialize(person);
			DisplayFilesAndDirs();
			MessageBox.Show($"{txtName.Text} was saved successfully."); }

		private void btnNext_Click(object sender, System.EventArgs e) {
			_i++;
			_fileName = $"person{_i.ToString("D2")}.dat";
			DisplayPerson ();
			if (!File.Exists(_fileName)) { _i--; } }

		private void btnPrevious_Click(object sender, System.EventArgs e) {
			_i--;
			_fileName = $"person{_i.ToString("D2")}.dat";
			DisplayPerson ();
			if (!File.Exists(_fileName)) { _i++; } }

		private void DisplayPerson() {
			if (File.Exists(_fileName)) {
				var person = _serial.Deserialize(_fileName);
				txtName.Text = person.Name;
				txtAddress.Text = person.Address;
				txtPhone.Text = person.Phone; }
			else { MessageBox.Show(@"There are no more persons."); } }

		private void DisplayFilesAndDirs() {
			txtPath.Text = _path;
			if (Directory.Exists(txtPath.Text)) {
				DirectoryInfo dirs = new DirectoryInfo(txtPath.Text);
				object[] fileEntries = dirs.GetFileSystemInfos();
				lstFiles.Items.Clear();
				lstFiles.Items.AddRange(fileEntries); }
			else { MessageBox.Show(@"There is no directory at the given path!"); } }

		private void EnterOnPath (object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				_path = txtPath.Text;
				DisplayFilesAndDirs (); } }

		private void lstFiles_DoubleClick (object sender, System.EventArgs e) {
			_path += @"\" + lstFiles.SelectedItem;
			DisplayFilesAndDirs(); }
} }
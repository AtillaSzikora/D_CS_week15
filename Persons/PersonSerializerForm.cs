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
			DisplayFiles(); }

		private void btnSave_Click (object sender, System.EventArgs e) {
			var person = new Person(txtName.Text, txtAddress.Text, txtPhone.Text);
			_serial.Serialize(person);
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

		private void DisplayFiles() {
			txtPath.Text = _path;
			DirectoryInfo dirs = new DirectoryInfo(txtPath.Text);
			object[] fileEntries = dirs.GetFileSystemInfos();
			lstFiles.Items.AddRange(fileEntries); }

		private void PressedEnter (object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				lstFiles.Items.Clear();
				_path = txtPath.Text;
				DisplayFiles (); } }
} }
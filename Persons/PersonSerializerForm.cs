using System.IO;
using System.Windows.Forms;

namespace PersonSerializer {
	public partial class PersonSerializationForm : Form {
		private static int _i = 1;
		private static string _fileName = $"person{_i.ToString("D2")}.dat";
		public PersonSerializationForm() { InitializeComponent(); }

		private void PersonSerializationForm_Load(object sender, System.EventArgs e) {
			if (File.Exists(_fileName)) {
				NextPerson(); } }

		private void btnSave_Click (object sender, System.EventArgs e) {
			var person = new Person(txtName.Text, txtAddress.Text, txtPhone.Text);
			Serialization.Serialize(person);
			MessageBox.Show($"{txtName.Text} was saved successfully."); }

		private void btnNext_Click(object sender, System.EventArgs e) { NextPerson(); }
		private void btnPrevious_Click (object sender, System.EventArgs e) { PreviousPerson(); }

		private void NextPerson() {
			if (File.Exists(_fileName)) {
				var person = Serialization.Deserialize(_fileName);
				txtName.Text = person.Name;
				txtAddress.Text = person.Address;
				txtPhone.Text = person.Phone;
				_i++;
				_fileName = $"person{_i.ToString("D2")}.dat"; }
			else { MessageBox.Show(@"There are no more persons."); } }

		private void PreviousPerson() {
			if (File.Exists(_fileName)) {
				var person = Serialization.Deserialize(_fileName);
				txtName.Text = person.Name;
				txtAddress.Text = person.Address;
				txtPhone.Text = person.Phone;
				_i--;
				_fileName = $"person{_i.ToString("D2")}.dat";}
			else { MessageBox.Show(@"There are no more persons."); } }
} }
using System.IO;
using System.Windows.Forms;

namespace PersonSerializer {
	public partial class PersonSerializationForm : Form {
		public PersonSerializationForm() { InitializeComponent(); }

		private void PersonSerializationForm_Load(object sender, System.EventArgs e) {
			if (File.Exists(Serialization.FileName)) {
				Person person = Serialization.Deserialize(Serialization.FileName);
				txtName.Text = person.Name;
				txtAddress.Text = person.Address;
				txtPhone.Text = person.Phone; } }

		private void btnSave_Click (object sender, System.EventArgs e) {
			Person person = new Person(txtName.Text, txtAddress.Text, txtPhone.Text);
			Serialization.Serialize(person); }
	} }
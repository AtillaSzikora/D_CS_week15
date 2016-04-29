using System;

namespace PersonSerializer {
	[Serializable]
	public class Person {

		public Person () { }	
		public Person(string name, string address, string phone) {
            _name = name;
            _address = address;
            _phone = phone; }

		private string _name, _address, _phone;

		public string Name {
			get { return _name; }
			set { _name = value; } }
		public string Address {
			get { return _address; }
			set { _address = value; } }
		public string Phone {
			get { return _phone; }
			set { _phone = value; } }

		public override string ToString() {
			return $"[name: {_name}, address: {_address}, phone: {_phone}]"; }
} }
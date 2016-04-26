using System;

namespace PersonSerializer {

	[Serializable]
	internal class Person {

		public Person(string name, string address, string phone) {
            Name = name;
            Address = address;
            Phone = phone; }

        public string Name { get; }
        public string Address { get; }
        public string Phone { get; }

		public override string ToString() {
			return $"[name: {Name}, address: {Address}, phone: {Phone}]"; }
}	}
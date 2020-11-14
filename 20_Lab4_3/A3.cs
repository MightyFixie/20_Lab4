using System.Diagnostics;

namespace _20_Lab4_3 {
	class A3 : A {
		public object[] fieldarray;
		public override void DebugInfo() {
			base.DebugInfo();
			Debug.WriteLine($"fieldarray містить {fieldarray.Length} об'єктів{(fieldarray.Length == 0 ? '.' : ':')}");
			foreach (var o in fieldarray)
				Debug.WriteLine(o);
		}
		public A3(object o1, object o2, params object[] fields) : base(o1, o2) {
			fieldarray = fields;
		}
	}
}

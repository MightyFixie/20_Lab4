using System.Diagnostics;

namespace _20_Lab4_3 {
	class A1 : A {
		public object field3;
		public override void DebugInfo() {
			base.DebugInfo();
			Debug.WriteLine($"field3 містить об'єкт типу {field3.GetType()} ({field3})");
		}
		public A1(object o1, object o2, object o3) : base(o1, o2) {
			field3 = o3;
		}
	}
}

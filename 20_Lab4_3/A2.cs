using System.Diagnostics;

namespace _20_Lab4_3 {
	class A2 : A {
		public object field3;
		public object field4;
		public override void DebugInfo() {
			base.DebugInfo();
			Debug.WriteLine($"field3 містить об'єкт типу {field3.GetType()} ({field3})");
			Debug.WriteLine($"field4 містить об'єкт типу {field4.GetType()} ({field4})");
		}
		public A2(object o1, object o2, object o3, object o4) : base(o1, o2) {
			field3 = o3;
			field4 = o4;
		}
	}
}

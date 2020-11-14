using System.Diagnostics;

namespace _20_Lab4_3 {
	class A {
		public object field1;
		public object field2;
		public virtual void DebugInfo() {
			Debug.Print($"Інформація про поточний об'єкт типу {GetType()}:");
			Debug.WriteLine($"field1 містить об'єкт типу {field1.GetType()} ({field1})");
			Debug.WriteLine($"field2 містить об'єкт типу {field2.GetType()} ({field2})");
		}
		public A() {
		}
		public A(object o1, object o2) {
			field1 = o1;
			field2 = o2;
		}
	}
}

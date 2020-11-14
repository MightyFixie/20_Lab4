using System.Diagnostics;

namespace _20_Lab4_2 {
	class A<T> {
		public A(B b1, B b2) {
			Debug.WriteLineIf(b1.GetType().IsSubclassOf(typeof(B)), b1);
			Debug.WriteLineIf(b2.GetType().IsSubclassOf(typeof(B)), b2);
		}
		public A(B b1, B b2, B b3) {
			Debug.WriteLineIf(b1.GetType().IsSubclassOf(typeof(B)), b1);
			Debug.WriteLineIf(b2.GetType().IsSubclassOf(typeof(B)), b2);
			Debug.WriteLineIf(b3.GetType().IsSubclassOf(typeof(B)), b3);
		}
	}
}

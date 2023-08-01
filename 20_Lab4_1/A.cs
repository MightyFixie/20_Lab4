using System.Diagnostics;

namespace _20_Lab4_1 {
	class A {
		public virtual void DebugInfo(params object[] values) {
			if (GetType().Equals(typeof(A))) {
				for (int i = 0; i < values.Length; i++) {
					Debug.WriteLine(values[i]);
				}
			} else {
				for (int i = 0; i < values.Length; i++) {
					Debug.Write(values[i].GetType());
					Debug.Write('\t');
					Debug.WriteLine(values[i]);
				}
			}
		}
	}
}

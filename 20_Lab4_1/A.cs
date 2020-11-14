using System.Diagnostics;

namespace _20_Lab4_1 {
	class A {
		public virtual void DebugInfo(params object[] values) {
			// Якщо метод викликається об'єктом типу A,
			// просто перелічити всі використовувані значення.
			// А якщо метод викликається успадкованим від A об'єктом,
			// перелічити тип і значення.
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

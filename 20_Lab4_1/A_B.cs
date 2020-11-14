namespace _20_Lab4_1 {
	class A_B : A {
		public override void DebugInfo(params object[] values) {
			// Використання різних кольорів у Debug неможливе.
			base.DebugInfo(values);
		}
	}
}

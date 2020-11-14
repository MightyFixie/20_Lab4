using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab4_4 {
	readonly struct ProductKey {
		public ProductKey(int s1, int s2, int s3, int s4, int s5) {
			S1 = s1;
			S2 = s2;
			S3 = s3;
			S4 = s4;
			S5 = s5;
		}

		public int S1 {
			get;
		}
		public int S2 {
			get;
		}
		public int S3 {
			get;
		}
		public int S4 {
			get;
		}
		public int S5 {
			get;
		}
	}
}

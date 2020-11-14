using System;
using System.Text;

namespace _20_Lab4_4_Keygen {
	class Program {
		static void Main() {
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.Unicode;

			// Щоб повністю перевірити клас ApplicationLicense у дії,
			// потрібно взяти звідкись ключ активації.
			// Для цього я створюю генератор ключів.
			string chars = "2346789BCDFGHJKMPQRTVWXY";
			Random random = new Random();
			char[] k = new char[25];
			for (; ; ) {
				int a = 0;
				for (int i = 0; i < 5; i++) {
					if (i != 0)
						Console.Write('-');
					for (int j = 0; j < 5; j++) {
						char b = chars[random.Next(24)];
						k[a++] = b;
						Console.Write(b);
					}
				}

				int checksum = 0;
				for (int i = 0; i < 25; i++)
					checksum += k[i];
				if ((checksum & 0x1FF) == 99)
					break;
				Console.CursorLeft = 0;
			}
			Console.WriteLine();
			while (Console.KeyAvailable)
				Console.ReadKey(true);
			Console.ReadKey(true);
		}
	}
}

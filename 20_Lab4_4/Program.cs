using System;
using System.Text;
using System.Threading;

namespace _20_Lab4_4 {
	class Program {
		static void Main() {
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.Unicode;
			Console.Title = "20_Lab4_4";

			License license;
			if (!ApplicationLicense.Pro) {
				Console.WriteLine("Для використання всіх можливостей цієї програми Вам потрібно ввести 25-значний ключ.");
				Console.WriteLine("Щоб скасувати та використати " +
					$"{(ApplicationLicense.TrialTime.Ticks == 0 ? "безкоштовну версію" : "тріальний режим")}, " +
					"натисність Esc.");
				Console.WriteLine("Якщо програма не реагує на клавішу Enter, значить ключ введено неправильно.");
				Console.Write(".....-.....-.....-.....-.....");
				Console.CursorLeft = 0;
				char[] productkey = new char[25];
				int cursor = 0;
				for (; ; ) {
					var key = Console.ReadKey(true).Key;
					switch (key) {
					case ConsoleKey.Enter:
						if (ApplicationLicense.RegisterProduct(new string(productkey))) {
							Console.CursorLeft = 29;
							Console.WriteLine();
							Console.WriteLine("Продукт успішно активовано!");
							license = License.Pro;
							ApplicationLicense.AllowPro();
							goto RegisterSuccessfull; //
						}
						break;
					case ConsoleKey.Escape:
						goto ExitRegister;
					case ConsoleKey.LeftArrow:
						if (cursor > 0) {
							cursor--;
							Console.CursorLeft = cursor * 6 / 5;
						}
						break;
					case ConsoleKey.RightArrow:
						if (cursor < 24) {
							cursor++;
							Console.CursorLeft = cursor * 6 / 5;
						}
						break;
					case ConsoleKey.D0:
					case ConsoleKey.D1:
					case ConsoleKey.D2:
					case ConsoleKey.D3:
					case ConsoleKey.D4:
					case ConsoleKey.D5:
					case ConsoleKey.D6:
					case ConsoleKey.D7:
					case ConsoleKey.D8:
					case ConsoleKey.D9:
					case ConsoleKey.A:
					case ConsoleKey.B:
					case ConsoleKey.C:
					case ConsoleKey.D:
					case ConsoleKey.E:
					case ConsoleKey.F:
					case ConsoleKey.G:
					case ConsoleKey.H:
					case ConsoleKey.I:
					case ConsoleKey.J:
					case ConsoleKey.K:
					case ConsoleKey.L:
					case ConsoleKey.M:
					case ConsoleKey.N:
					case ConsoleKey.O:
					case ConsoleKey.P:
					case ConsoleKey.Q:
					case ConsoleKey.R:
					case ConsoleKey.S:
					case ConsoleKey.T:
					case ConsoleKey.U:
					case ConsoleKey.V:
					case ConsoleKey.W:
					case ConsoleKey.X:
					case ConsoleKey.Y:
					case ConsoleKey.Z:
						productkey[cursor] = (char)key;
						Console.Write((char)key);
						Console.CursorLeft--;
						goto case ConsoleKey.RightArrow;
					case ConsoleKey.NumPad0:
					case ConsoleKey.NumPad1:
					case ConsoleKey.NumPad2:
					case ConsoleKey.NumPad3:
					case ConsoleKey.NumPad4:
					case ConsoleKey.NumPad5:
					case ConsoleKey.NumPad6:
					case ConsoleKey.NumPad7:
					case ConsoleKey.NumPad8:
					case ConsoleKey.NumPad9:
						char num = (char)(key - ConsoleKey.NumPad0 + ConsoleKey.D0);
						productkey[cursor] = num;
						Console.Write(num);
						Console.CursorLeft--;
						goto case ConsoleKey.RightArrow;
					default:
						break;
					}
				}
			ExitRegister:
				Console.CursorLeft = 29;
				Console.WriteLine();
				Console.WriteLine("Наразі Ви використовуєте програму у режимі:");
				if (ApplicationLicense.TrialTime.Ticks != 0) {
					license = License.Trial;
					ApplicationLicense.AllowTrial();
				} else {
					license = License.Common;
					ApplicationLicense.AllowCommon();
				}
			} else {
				license = License.Pro;
				ApplicationLicense.AllowPro();
			}
		RegisterSuccessfull:
			Console.WriteLine(license);

			// Далі тут має бути щось, але завдання фактично виконано.

		}
		/*
		static char GetKeyChar() {
			while (Console.KeyAvailable)
				Console.ReadKey(true);
			for (; ; ) {
				var key = Console.ReadKey(true).Key;
				if (key == ConsoleKey.Escape)
					return ' ';
				if (key == ConsoleKey.Enter)
					return '\n';
				if (key >= ConsoleKey.D0 && key <= ConsoleKey.D9)
					return (char)key;
				if (key >= ConsoleKey.A && key <= ConsoleKey.Z)
					return (char)key;
				if (key >= ConsoleKey.NumPad0 && key <= ConsoleKey.NumPad9)
					return (char)(key - ConsoleKey.NumPad0 + ConsoleKey.D0);
			}
		}
		*/
	}
}

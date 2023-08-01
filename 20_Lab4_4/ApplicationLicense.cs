using System;
using System.IO;
using System.Diagnostics;

namespace _20_Lab4_4 {
	enum License {
		Common,
		Trial,
		Pro
	}
	static class ApplicationLicense {

		const string LicenseFile = "LICENSE";

		public static bool Pro {
			get; private set;
		}
		public static TimeSpan TrialTime {
			get;
		}
		static ApplicationLicense() {
			try {
				/*
				BinaryReader reader = new BinaryReader(File.OpenRead("LICENSE"));
				int s1 = reader.ReadInt32();
				int s2 = reader.ReadInt32();
				int s3 = reader.ReadInt32();
				int s4 = reader.ReadInt32();
				int s5 = reader.ReadInt32();
				ProductKey key = new ProductKey(s1, s2, s3, s4, s5);
				reader.Close();
				reader.Dispose();
				*/
				string key = File.ReadAllText(LicenseFile);
				Pro = RegisterProduct(key);
			} catch {
				Pro = false;
			}

			if (!Pro) {
				string exepath = Process.GetCurrentProcess().MainModule.FileName;
				DateTime expiredate = File.GetLastWriteTime(exepath).AddDays(7);
				TimeSpan timeleft = expiredate - DateTime.Now;
				if (timeleft.TotalDays > 7 || timeleft.Ticks <= 0) {
					TrialTime = new TimeSpan(0);
				} else {
					TrialTime = timeleft;
				}
			}
		}

		public static void AllowTrial() {
			if (!Pro && TrialTime.Ticks != 0)
				Console.WriteLine("Тріальній режим");
		}
		public static void AllowCommon() {
			if (!Pro && TrialTime.Ticks == 0)
				Console.WriteLine("Безкоштовна версія");
		}
		public static void AllowPro() {
			if (Pro)
				Console.WriteLine("Платна версія");
		}
		public static bool RegisterProduct(string key) {
			int checksum = 0;
			for (int i = 0; i < 25; i++)
				checksum += key[i];
			if ((checksum & 0x1FF) == 99) {
				try {
					File.WriteAllText(LicenseFile, key);
				} catch { }
				Pro = true;
				return true;
			}
			return false;
		}
	}
}

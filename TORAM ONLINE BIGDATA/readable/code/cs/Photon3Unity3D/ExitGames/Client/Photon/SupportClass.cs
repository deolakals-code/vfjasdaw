// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public class SupportClass // TypeDefIndex: 16960
{
	// Fields
	protected internal static SupportClass.IntegerMillisecondsDelegate IntegerMilliseconds; // 0x0

	// Methods

	// RVA: 0x30F1840 Offset: 0x30ED840 VA: 0x30F1840
	public static uint CalculateCrc(byte[] buffer, int length) { }

	// RVA: 0x30F18C0 Offset: 0x30ED8C0 VA: 0x30F18C0
	public static int GetTickCount() { }

	// RVA: 0x30F192C Offset: 0x30ED92C VA: 0x30F192C
	public static void CallInBackground(Func<bool> myThread) { }

	// RVA: 0x30F1984 Offset: 0x30ED984 VA: 0x30F1984
	public static void CallInBackground(Func<bool> myThread, int millisecondsInterval) { }

	// RVA: 0x30F1A9C Offset: 0x30EDA9C VA: 0x30F1A9C
	public static void WriteStackTrace(Exception throwable, TextWriter stream) { }

	// RVA: 0x30F1B48 Offset: 0x30EDB48 VA: 0x30F1B48
	public static void WriteStackTrace(Exception throwable) { }

	// RVA: 0x30F1BA0 Offset: 0x30EDBA0 VA: 0x30F1BA0
	public static string DictionaryToString(IDictionary dictionary) { }

	// RVA: 0x30F1BF8 Offset: 0x30EDBF8 VA: 0x30F1BF8
	public static string DictionaryToString(IDictionary dictionary, bool includeTypes) { }

	// RVA: 0x30F26F8 Offset: 0x30EE6F8 VA: 0x30F26F8
	private static void .cctor() { }
}

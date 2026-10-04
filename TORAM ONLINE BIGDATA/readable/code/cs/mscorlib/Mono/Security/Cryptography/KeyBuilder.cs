// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal sealed class KeyBuilder // TypeDefIndex: 9472
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x2E72020 Offset: 0x2E6E020 VA: 0x2E72020
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x2E72098 Offset: 0x2E6E098 VA: 0x2E72098
	public static byte[] Key(int size) { }

	// RVA: 0x2E72108 Offset: 0x2E6E108 VA: 0x2E72108
	public static byte[] IV(int size) { }
}

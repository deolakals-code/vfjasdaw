// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 13307
{
	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x3388AE8 Offset: 0x3384AE8 VA: 0x3388AE8
	public void .ctor() { }

	// RVA: 0x3388B0C Offset: 0x3384B0C VA: 0x3388B0C Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x3388B24 Offset: 0x3384B24 VA: 0x3388B24 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x3388D24 Offset: 0x3384D24 VA: 0x3388D24
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x3388BD0 Offset: 0x3384BD0 VA: 0x3388BD0
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }
}

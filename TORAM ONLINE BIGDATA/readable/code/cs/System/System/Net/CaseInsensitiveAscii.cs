// Assembly: System.dll
// Namespace: System.Net
internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 14413
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x34F263C Offset: 0x34EE63C VA: 0x34F263C Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x34F2754 Offset: 0x34EE754 VA: 0x34F2754 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x34F28C4 Offset: 0x34EE8C4 VA: 0x34F28C4
	private int FastGetHashCode(string myString) { }

	// RVA: 0x34F29B4 Offset: 0x34EE9B4 VA: 0x34F29B4 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x34F2B34 Offset: 0x34EEB34 VA: 0x34F2B34
	public void .ctor() { }

	// RVA: 0x34F2B3C Offset: 0x34EEB3C VA: 0x34F2B3C
	private static void .cctor() { }
}

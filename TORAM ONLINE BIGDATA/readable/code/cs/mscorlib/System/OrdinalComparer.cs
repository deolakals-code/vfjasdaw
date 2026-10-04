// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class OrdinalComparer : StringComparer // TypeDefIndex: 9669
{
	// Fields
	private readonly bool _ignoreCase; // 0x10

	// Methods

	// RVA: 0x2FFB900 Offset: 0x2FF7900 VA: 0x2FFB900
	internal void .ctor(bool ignoreCase) { }

	// RVA: 0x2FFB970 Offset: 0x2FF7970 VA: 0x2FFB970 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x2FFB9C8 Offset: 0x2FF79C8 VA: 0x2FFB9C8 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x2FFBA48 Offset: 0x2FF7A48 VA: 0x2FFBA48 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x2FFBAD0 Offset: 0x2FF7AD0 VA: 0x2FFBAD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FFBB68 Offset: 0x2FF7B68 VA: 0x2FFBB68 Slot: 2
	public override int GetHashCode() { }
}

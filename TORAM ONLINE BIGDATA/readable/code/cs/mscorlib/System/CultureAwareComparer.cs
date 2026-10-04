// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class CultureAwareComparer : StringComparer, ISerializable // TypeDefIndex: 9668
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10
	private CompareOptions _options; // 0x18

	// Methods

	// RVA: 0x2FFAE38 Offset: 0x2FF6E38 VA: 0x2FFAE38
	internal void .ctor(CultureInfo culture, CompareOptions options) { }

	// RVA: 0x2FFB324 Offset: 0x2FF7324 VA: 0x2FFB324
	internal void .ctor(CompareInfo compareInfo, CompareOptions options) { }

	// RVA: 0x2FFB410 Offset: 0x2FF7410 VA: 0x2FFB410
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FFB634 Offset: 0x2FF7634 VA: 0x2FFB634 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x2FFB688 Offset: 0x2FF7688 VA: 0x2FFB688 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x2FFB6D8 Offset: 0x2FF76D8 VA: 0x2FFB6D8 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x2FFB748 Offset: 0x2FF7748 VA: 0x2FFB748 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FFB7E0 Offset: 0x2FF77E0 VA: 0x2FFB7E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FFB814 Offset: 0x2FF7814 VA: 0x2FFB814 Slot: 13
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

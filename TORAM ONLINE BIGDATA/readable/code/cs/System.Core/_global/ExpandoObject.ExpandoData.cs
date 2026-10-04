// Assembly: System.Core.dll
// Namespace: 
[DefaultMember("Item")]
private class ExpandoObject.ExpandoData // TypeDefIndex: 15781
{
	// Fields
	internal static ExpandoObject.ExpandoData Empty; // 0x0
	internal readonly ExpandoClass Class; // 0x10
	private readonly object[] _dataArray; // 0x18
	private int _version; // 0x20

	// Properties
	internal object Item { get; set; }
	internal int Version { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x3186414 Offset: 0x3182414 VA: 0x3186414
	internal object get_Item(int index) { }

	// RVA: 0x318857C Offset: 0x318457C VA: 0x318857C
	internal void set_Item(int index, object value) { }

	// RVA: 0x31885F0 Offset: 0x31845F0 VA: 0x31885F0
	internal int get_Version() { }

	// RVA: 0x31885F8 Offset: 0x31845F8 VA: 0x31885F8
	internal int get_Length() { }

	// RVA: 0x3188614 Offset: 0x3184614 VA: 0x3188614
	private void .ctor() { }

	// RVA: 0x31886F4 Offset: 0x31846F4 VA: 0x31886F4
	internal void .ctor(ExpandoClass klass, object[] data, int version) { }

	// RVA: 0x318874C Offset: 0x318474C VA: 0x318874C
	internal ExpandoObject.ExpandoData UpdateClass(ExpandoClass newClass) { }

	// RVA: 0x31888F4 Offset: 0x31848F4 VA: 0x31888F4
	private static int GetAlignedSize(int len) { }

	// RVA: 0x3188900 Offset: 0x3184900 VA: 0x3188900
	private static void .cctor() { }
}

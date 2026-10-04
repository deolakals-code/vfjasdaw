// Assembly: mscorlib.dll
// Namespace: Mono
[DefaultMember("Item")]
internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 9430
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x2E65E34 Offset: 0x2E61E34 VA: 0x2E65E34
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x2E65E54 Offset: 0x2E61E54 VA: 0x2E65E54
	internal int get_Length() { }

	// RVA: 0x2E65E70 Offset: 0x2E61E70 VA: 0x2E65E70
	internal IntPtr get_Item(int i) { }

	// RVA: 0x2E65E74 Offset: 0x2E61E74 VA: 0x2E65E74
	internal IntPtr Lookup(int i) { }

	// RVA: 0x2E65ED8 Offset: 0x2E61ED8 VA: 0x2E65ED8
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x2E65EDC Offset: 0x2E61EDC VA: 0x2E65EDC
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}

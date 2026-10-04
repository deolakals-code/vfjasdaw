// Assembly: mscorlib.dll
// Namespace: Mono
[DefaultMember("Item")]
internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 9445
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x2E66170 Offset: 0x2E62170 VA: 0x2E66170
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x2E66190 Offset: 0x2E62190 VA: 0x2E66190 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E661AC Offset: 0x2E621AC VA: 0x2E661AC
	internal int get_Length() { }

	// RVA: 0x2E661C8 Offset: 0x2E621C8 VA: 0x2E661C8
	internal IntPtr get_Item(int i) { }
}

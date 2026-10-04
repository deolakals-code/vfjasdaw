// Assembly: mscorlib.dll
// Namespace: System.Buffers
public struct MemoryHandle : IDisposable // TypeDefIndex: 10991
{
	// Fields
	private void* _pointer; // 0x0
	private GCHandle _handle; // 0x8
	private IPinnable _pinnable; // 0x10

	// Properties
	[CLSCompliant(False)]
	public void* Pointer { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x2FC484C Offset: 0x2FC084C VA: 0x2FC484C
	public void .ctor(void* pointer, GCHandle handle, IPinnable pinnable) { }

	// RVA: 0x2FC485C Offset: 0x2FC085C VA: 0x2FC485C
	public void* get_Pointer() { }

	// RVA: 0x2FC4864 Offset: 0x2FC0864 VA: 0x2FC4864 Slot: 4
	public void Dispose() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class CycleActionPool<T> : IDisposable // TypeDefIndex: 13123
{
	// Fields
	private readonly T[] pools; // 0x0
	private readonly ReaderWriterLockSlim readerWriterLock; // 0x0
	private int currentIdx; // 0x0
	private readonly int capacity; // 0x0
	private readonly int mask; // 0x0
	[CompilerGenerated]
	private bool <Disposed>k__BackingField; // 0x0

	// Properties
	public bool Disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9888 Offset: 0x2DC5888 VA: 0x2DC9888
	|-CycleActionPool<object>..ctor
	|
	|-RVA: 0x2DCA074 Offset: 0x2DC6074 VA: 0x2DCA074
	|-CycleActionPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9948 Offset: 0x2DC5948 VA: 0x2DC9948
	|-CycleActionPool<object>.Finalize
	|
	|-RVA: 0x2DCA148 Offset: 0x2DC6148 VA: 0x2DCA148
	|-CycleActionPool<__Il2CppFullySharedGenericType>.Finalize
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_Disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC99F0 Offset: 0x2DC59F0 VA: 0x2DC99F0
	|-CycleActionPool<object>.get_Disposed
	|
	|-RVA: 0x2DCA1F4 Offset: 0x2DC61F4 VA: 0x2DCA1F4
	|-CycleActionPool<__Il2CppFullySharedGenericType>.get_Disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC99F8 Offset: 0x2DC59F8 VA: 0x2DC99F8
	|-CycleActionPool<object>.set_Disposed
	|
	|-RVA: 0x2DCA1FC Offset: 0x2DC61FC VA: 0x2DCA1FC
	|-CycleActionPool<__Il2CppFullySharedGenericType>.set_Disposed
	*/

	// RVA: -1 Offset: -1
	private void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9A04 Offset: 0x2DC5A04 VA: 0x2DC9A04
	|-CycleActionPool<object>.Dispose
	|
	|-RVA: 0x2DCA208 Offset: 0x2DC6208 VA: 0x2DCA208
	|-CycleActionPool<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9A38 Offset: 0x2DC5A38 VA: 0x2DC9A38
	|-CycleActionPool<object>.Dispose
	|
	|-RVA: 0x2DCA268 Offset: 0x2DC6268 VA: 0x2DCA268
	|-CycleActionPool<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9AB4 Offset: 0x2DC5AB4 VA: 0x2DC9AB4
	|-CycleActionPool<object>.Initialize
	|
	|-RVA: 0x2DCA2E8 Offset: 0x2DC62E8 VA: 0x2DCA2E8
	|-CycleActionPool<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public bool Add(T action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9BD0 Offset: 0x2DC5BD0 VA: 0x2DC9BD0
	|-CycleActionPool<object>.Add
	|
	|-RVA: 0x2DCA4C8 Offset: 0x2DC64C8 VA: 0x2DCA4C8
	|-CycleActionPool<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool TryGetActionByRevision(short revision, out T action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9DB4 Offset: 0x2DC5DB4 VA: 0x2DC9DB4
	|-CycleActionPool<object>.TryGetActionByRevision
	|
	|-RVA: 0x2DCA820 Offset: 0x2DC6820 VA: 0x2DCA820
	|-CycleActionPool<__Il2CppFullySharedGenericType>.TryGetActionByRevision
	*/

	// RVA: -1 Offset: -1
	private int FindRevisionIndex(int revision) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9E94 Offset: 0x2DC5E94 VA: 0x2DC9E94
	|-CycleActionPool<object>.FindRevisionIndex
	|
	|-RVA: 0x2DCA904 Offset: 0x2DC6904 VA: 0x2DCA904
	|-CycleActionPool<__Il2CppFullySharedGenericType>.FindRevisionIndex
	*/

	// RVA: -1 Offset: -1
	private bool GetActionByRevision(short revision, out T action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9F90 Offset: 0x2DC5F90 VA: 0x2DC9F90
	|-CycleActionPool<object>.GetActionByRevision
	|
	|-RVA: 0x2DCAA3C Offset: 0x2DC6A3C VA: 0x2DCAA3C
	|-CycleActionPool<__Il2CppFullySharedGenericType>.GetActionByRevision
	*/
}

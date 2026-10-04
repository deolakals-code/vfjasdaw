// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class WeakReference<T> : ISerializable // TypeDefIndex: 9837
{
	// Fields
	private GCHandle handle; // 0x0
	private bool trackResurrection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6AC68 Offset: 0x2D66C68 VA: 0x2D6AC68
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T target, bool trackResurrection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6ACA4 Offset: 0x2D66CA4 VA: 0x2D6ACA4
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6ACE4 Offset: 0x2D66CE4 VA: 0x2D6ACE4
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6AE0C Offset: 0x2D66E0C VA: 0x2D6AE0C
	|-WeakReference<object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	public void SetTarget(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6AEF8 Offset: 0x2D66EF8 VA: 0x2D6AEF8
	|-WeakReference<object>.SetTarget
	*/

	// RVA: -1 Offset: -1
	public bool TryGetTarget(out T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6AF04 Offset: 0x2D66F04 VA: 0x2D6AF04
	|-WeakReference<object>.TryGetTarget
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6AFFC Offset: 0x2D66FFC VA: 0x2D6AFFC
	|-WeakReference<object>.Finalize
	*/
}

// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 9836
{
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x18

	// Properties
	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x303F714 Offset: 0x303B714 VA: 0x303F714
	private void AllocateHandle(object target) { }

	// RVA: 0x303F73C Offset: 0x303B73C VA: 0x303F73C
	protected void .ctor() { }

	// RVA: 0x303F744 Offset: 0x303B744 VA: 0x303F744
	public void .ctor(object target) { }

	// RVA: 0x303F774 Offset: 0x303B774 VA: 0x303F774
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x303F7A8 Offset: 0x303B7A8 VA: 0x303F7A8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x303F8DC Offset: 0x303B8DC VA: 0x303F8DC Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x303F8FC Offset: 0x303B8FC VA: 0x303F8FC Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x303F930 Offset: 0x303B930 VA: 0x303F930 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x303F93C Offset: 0x303B93C VA: 0x303F93C Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x303F944 Offset: 0x303B944 VA: 0x303F944 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x303F9E0 Offset: 0x303B9E0 VA: 0x303F9E0 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

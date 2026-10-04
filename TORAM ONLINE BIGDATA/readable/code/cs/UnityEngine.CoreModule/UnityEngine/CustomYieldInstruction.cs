// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 16352
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0x37EBBD4 Offset: 0x37E7BD4 VA: 0x37EBBD4 Slot: 5
	public object get_Current() { }

	// RVA: 0x37EBBDC Offset: 0x37E7BDC VA: 0x37EBBDC Slot: 4
	public bool MoveNext() { }

	// RVA: 0x37EBBE8 Offset: 0x37E7BE8 VA: 0x37EBBE8 Slot: 8
	public virtual void Reset() { }

	// RVA: 0x37EBBEC Offset: 0x37E7BEC VA: 0x37EBBEC
	protected void .ctor() { }
}

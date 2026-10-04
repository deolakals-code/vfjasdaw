// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IHalloweenSkill // TypeDefIndex: 3374
{
	// Properties
	public virtual int UseItemId { get; }
	public virtual bool IsHate { get; }

	// Methods

	// RVA: 0x2354574 Offset: 0x2350574 VA: 0x2354574 Slot: 0
	public virtual int get_UseItemId() { }

	// RVA: 0x235457C Offset: 0x235057C VA: 0x235457C Slot: 1
	public virtual bool get_IsHate() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnInitializeEventRoom();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CheckRangeHitEventRoom(Transform actorTransform, Transform targetTransform, float size);
}

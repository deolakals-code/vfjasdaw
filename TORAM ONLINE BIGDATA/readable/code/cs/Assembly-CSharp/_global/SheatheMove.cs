// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SheatheMove // TypeDefIndex: 3554
{
	// Fields
	protected Vector2 lastInput; // 0x10
	private short calcEventId; // 0x18
	protected int takeId; // 0x1C

	// Methods

	// RVA: 0x23697B4 Offset: 0x23657B4 VA: 0x23697B4
	public void .ctor(short calcEventId, int takeId) { }

	// RVA: 0x2369A08 Offset: 0x2365A08 VA: 0x2369A08
	public SkillLinkedTake Update(InputManager input, short eventId) { }

	// RVA: 0x2369AB0 Offset: 0x2365AB0 VA: 0x2369AB0 Slot: 4
	protected virtual SkillLinkedTake CreateTake() { }
}

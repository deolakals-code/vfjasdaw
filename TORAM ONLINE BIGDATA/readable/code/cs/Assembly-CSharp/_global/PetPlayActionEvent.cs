// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetPlayActionEvent : OtherPlayerPlayActionDataBase // TypeDefIndex: 1370
{
	// Fields
	private int actionEventId; // 0x4C
	private FadeAnimationManager fadeAnime; // 0x50

	// Methods

	// RVA: 0x1FE0FF0 Offset: 0x1FDCFF0 VA: 0x1FE0FF0
	public void .ctor(OtherPlayerActionManager actor, int id) { }

	// RVA: 0x1FE10D4 Offset: 0x1FDD0D4 VA: 0x1FE10D4 Slot: 4
	protected override void OnStart() { }

	[IteratorStateMachine(typeof(PetPlayActionEvent.<WaitEventActionEnd>d__4))]
	// RVA: 0x1FE1238 Offset: 0x1FDD238 VA: 0x1FE1238
	private IEnumerator WaitEventActionEnd(Action callback) { }

	// RVA: 0x1FE12E8 Offset: 0x1FDD2E8 VA: 0x1FE12E8 Slot: 5
	protected override void OnUpdate() { }

	// RVA: 0x1FE12EC Offset: 0x1FDD2EC VA: 0x1FE12EC Slot: 6
	protected override void OnCancel() { }

	// RVA: 0x1FE12F0 Offset: 0x1FDD2F0 VA: 0x1FE12F0 Slot: 7
	protected override void OnEnd() { }

	// RVA: 0x1FE12F4 Offset: 0x1FDD2F4 VA: 0x1FE12F4 Slot: 3
	public override string ToString() { }
}

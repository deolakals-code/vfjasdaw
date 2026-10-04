// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryEventActionState : MercenaryAIStateBase // TypeDefIndex: 626
{
	// Fields
	[CompilerGenerated]
	private EventArea <Area>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x38
	private bool isWarp; // 0x3C

	// Properties
	protected EventArea Area { get; set; }
	protected int MemberNum { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E26B0 Offset: 0x19DE6B0 VA: 0x19E26B0
	protected EventArea get_Area() { }

	[CompilerGenerated]
	// RVA: 0x19E26B8 Offset: 0x19DE6B8 VA: 0x19E26B8
	public void set_Area(EventArea value) { }

	[CompilerGenerated]
	// RVA: 0x19E26C0 Offset: 0x19DE6C0 VA: 0x19E26C0
	protected int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x19E26C8 Offset: 0x19DE6C8 VA: 0x19E26C8
	public void set_MemberNum(int value) { }

	// RVA: 0x19E26D0 Offset: 0x19DE6D0 VA: 0x19E26D0 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E27F8 Offset: 0x19DE7F8 VA: 0x19E27F8 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E27FC Offset: 0x19DE7FC VA: 0x19E27FC Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E2800 Offset: 0x19DE800 VA: 0x19E2800 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryEventActionState.<GetState>d__13))]
	// RVA: 0x19E28A0 Offset: 0x19DE8A0 VA: 0x19E28A0 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E2934 Offset: 0x19DE934 VA: 0x19E2934
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetRetreatState : MercenaryAIStateBase // TypeDefIndex: 1283
{
	// Fields
	[CompilerGenerated]
	private AutoMemberAIRetreat <AiRetreat>k__BackingField; // 0x30
	private CharacterMove charaMove; // 0x38
	private Vector3 oldMove; // 0x40

	// Properties
	private AutoMemberAIRetreat AiRetreat { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FB2BCC Offset: 0x1FAEBCC VA: 0x1FB2BCC
	private AutoMemberAIRetreat get_AiRetreat() { }

	[CompilerGenerated]
	// RVA: 0x1FB2BD4 Offset: 0x1FAEBD4 VA: 0x1FB2BD4
	public void set_AiRetreat(AutoMemberAIRetreat value) { }

	// RVA: 0x1FB2BDC Offset: 0x1FAEBDC VA: 0x1FB2BDC Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x1FB2BE0 Offset: 0x1FAEBE0 VA: 0x1FB2BE0 Slot: 14
	public override void Dispose() { }

	// RVA: 0x1FB2BE4 Offset: 0x1FAEBE4 VA: 0x1FB2BE4 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x1FB2BE8 Offset: 0x1FAEBE8 VA: 0x1FB2BE8 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(PetRetreatState.<GetState>d__10))]
	// RVA: 0x1FB2BEC Offset: 0x1FAEBEC VA: 0x1FB2BEC Slot: 17
	protected override IEnumerator GetState() { }

	[IteratorStateMachine(typeof(PetRetreatState.<checkRetreat>d__11))]
	// RVA: 0x1FB2C80 Offset: 0x1FAEC80 VA: 0x1FB2C80
	protected IEnumerator checkRetreat() { }

	// RVA: 0x1FB2D14 Offset: 0x1FAED14 VA: 0x1FB2D14
	public void .ctor() { }
}

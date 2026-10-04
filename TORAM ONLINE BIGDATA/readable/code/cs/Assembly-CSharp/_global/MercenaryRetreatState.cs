// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryRetreatState : MercenaryAIStateBase // TypeDefIndex: 635
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
	// RVA: 0x19E3D94 Offset: 0x19DFD94 VA: 0x19E3D94
	private AutoMemberAIRetreat get_AiRetreat() { }

	[CompilerGenerated]
	// RVA: 0x19E3D9C Offset: 0x19DFD9C VA: 0x19E3D9C
	public void set_AiRetreat(AutoMemberAIRetreat value) { }

	// RVA: 0x19E3DA4 Offset: 0x19DFDA4 VA: 0x19E3DA4 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E3DA8 Offset: 0x19DFDA8 VA: 0x19E3DA8 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E3DAC Offset: 0x19DFDAC VA: 0x19E3DAC Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E3DB0 Offset: 0x19DFDB0 VA: 0x19E3DB0 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryRetreatState.<GetState>d__10))]
	// RVA: 0x19E3DB4 Offset: 0x19DFDB4 VA: 0x19E3DB4 Slot: 17
	protected override IEnumerator GetState() { }

	[IteratorStateMachine(typeof(MercenaryRetreatState.<checkRetreat>d__11))]
	// RVA: 0x19E3E48 Offset: 0x19DFE48 VA: 0x19E3E48
	private IEnumerator checkRetreat() { }

	// RVA: 0x19E3EDC Offset: 0x19DFEDC VA: 0x19E3EDC
	public void .ctor() { }
}

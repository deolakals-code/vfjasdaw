// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryDefaultTransition : MercenaryAIStateBase // TypeDefIndex: 620
{
	// Fields
	private AutoMemberAIRetreat aiRetreat; // 0x30
	private AutoMemberAIAction aiAction; // 0x38
	private AutoMemberBattleManager autoBattleManager; // 0x40
	private MercenarySkillDelayManager skillDelayManager; // 0x48
	protected GameObject lastTarget; // 0x50
	private AutoMemberManager autoMemberManager; // 0x58
	private Vector3 oldMove; // 0x60
	private float warpRange; // 0x6C
	private float Counter; // 0x70
	private bool battle_mode_transition; // 0x74
	private AIManagerdHate hateManaged; // 0x78
	private bool IsBossField; // 0x80

	// Methods

	// RVA: 0x19E0580 Offset: 0x19DC580 VA: 0x19E0580
	public void .ctor(AutoMemberAIAction aiAction, AutoMemberAIRetreat aiRetreat, MercenarySkillDelayManager skillDelayManager, float warpRange) { }

	// RVA: 0x19E0614 Offset: 0x19DC614 VA: 0x19E0614
	public void .ctor(AutoMemberAIAction aiAction, AutoMemberAIRetreat aiRetreat, MercenarySkillDelayManager skillDelayManager, float warpRange, AIManagerdHate managerdHate) { }

	// RVA: 0x19E0728 Offset: 0x19DC728 VA: 0x19E0728 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E0F40 Offset: 0x19DCF40 VA: 0x19E0F40 Slot: 19
	protected virtual void TraceAction(IAICentral central) { }

	// RVA: 0x19E1B5C Offset: 0x19DDB5C VA: 0x19E1B5C Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E1B60 Offset: 0x19DDB60 VA: 0x19E1B60 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E1B64 Offset: 0x19DDB64 VA: 0x19E1B64 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryDefaultTransition.<GetState>d__19))]
	// RVA: 0x19E1B68 Offset: 0x19DDB68 VA: 0x19E1B68 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E1BE8 Offset: 0x19DDBE8 VA: 0x19E1BE8 Slot: 20
	protected virtual GameObject searchTarget(IAICentral central) { }

	// RVA: 0x19E1E0C Offset: 0x19DDE0C VA: 0x19E1E0C
	private GameObject serachDirectedStateTarget(IAICentral central) { }

	[CompilerGenerated]
	// RVA: 0x19E1ECC Offset: 0x19DDECC VA: 0x19E1ECC
	private void <TraceAction>b__15_0(Vector3 x) { }

	[CompilerGenerated]
	// RVA: 0x19E1ED8 Offset: 0x19DDED8 VA: 0x19E1ED8
	private bool <TraceAction>b__15_3(AutoMember x) { }

	[CompilerGenerated]
	// RVA: 0x19E1F44 Offset: 0x19DDF44 VA: 0x19E1F44
	private void <TraceAction>b__15_4(IAICentral x) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UtsusemiAction : NinjaSkillBase // TypeDefIndex: 2926
{
	// Fields
	private int baseMp; // 0x124
	private PlayerActionManagerBase playerAction; // 0x128

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22D4014 Offset: 0x22D0014 VA: 0x22D4014 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22D401C Offset: 0x22D001C VA: 0x22D401C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D4024 Offset: 0x22D0024 VA: 0x22D4024 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D402C Offset: 0x22D002C VA: 0x22D402C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D4034 Offset: 0x22D0034 VA: 0x22D4034 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D403C Offset: 0x22D003C VA: 0x22D403C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D4044 Offset: 0x22D0044 VA: 0x22D4044 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D404C Offset: 0x22D004C VA: 0x22D404C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D4054 Offset: 0x22D0054 VA: 0x22D4054 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D405C Offset: 0x22D005C VA: 0x22D405C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22D4064 Offset: 0x22D0064 VA: 0x22D4064 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22D406C Offset: 0x22D006C VA: 0x22D406C Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22D4074 Offset: 0x22D0074 VA: 0x22D4074 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22D407C Offset: 0x22D007C VA: 0x22D407C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D4308 Offset: 0x22D0308 VA: 0x22D4308 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D4450 Offset: 0x22D0450 VA: 0x22D4450 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D45C8 Offset: 0x22D05C8 VA: 0x22D45C8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D418C Offset: 0x22D018C VA: 0x22D418C
	private void CreateTake(Vector3 pos) { }

	// RVA: 0x22D4A1C Offset: 0x22D0A1C VA: 0x22D4A1C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x22D4D7C Offset: 0x22D0D7C VA: 0x22D4D7C
	public void .ctor() { }
}

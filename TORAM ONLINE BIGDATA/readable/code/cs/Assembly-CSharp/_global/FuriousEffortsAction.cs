// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FuriousEffortsAction : PlayerAttackBase // TypeDefIndex: 3659
{
	// Fields
	private int useQigongNum; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23BC11C Offset: 0x23B811C VA: 0x23BC11C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BC124 Offset: 0x23B8124 VA: 0x23BC124 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BC12C Offset: 0x23B812C VA: 0x23BC12C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BC134 Offset: 0x23B8134 VA: 0x23BC134 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BC13C Offset: 0x23B813C VA: 0x23BC13C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BC144 Offset: 0x23B8144 VA: 0x23BC144 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BC14C Offset: 0x23B814C VA: 0x23BC14C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BC154 Offset: 0x23B8154 VA: 0x23BC154 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BC15C Offset: 0x23B815C VA: 0x23BC15C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BC164 Offset: 0x23B8164 VA: 0x23BC164 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BC3DC Offset: 0x23B83DC VA: 0x23BC3DC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BC4CC Offset: 0x23B84CC VA: 0x23BC4CC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BC660 Offset: 0x23B8660 VA: 0x23BC660 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23BCC3C Offset: 0x23B8C3C VA: 0x23BCC3C
	private void EndByOtherBarehandBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x23BCB20 Offset: 0x23B8B20 VA: 0x23BCB20
	private void EndByOtherBarehandBuf(IOtherPlayerActionManager otherPlayerAct) { }

	// RVA: 0x23BC30C Offset: 0x23B830C VA: 0x23BC30C
	private bool CheckExistOtherAuraBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x23BCD44 Offset: 0x23B8D44 VA: 0x23BCD44
	public void .ctor() { }
}

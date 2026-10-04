// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SwordTempestAction : PlayerAttackBase // TypeDefIndex: 2576
{
	// Fields
	private int damageCount; // 0x120
	private float rad; // 0x124
	private float skillRateFirst; // 0x128
	private float skillRate; // 0x12C
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x130
	private int fixAddDamage; // 0x138
	private int actionCount; // 0x13C
	private Transform targetTransform; // 0x140
	private bool isRangeBonus; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x21FCDA4 Offset: 0x21F8DA4 VA: 0x21FCDA4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21FCDAC Offset: 0x21F8DAC VA: 0x21FCDAC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21FCDB4 Offset: 0x21F8DB4 VA: 0x21FCDB4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21FCDBC Offset: 0x21F8DBC VA: 0x21FCDBC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21FCDC4 Offset: 0x21F8DC4 VA: 0x21FCDC4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21FCDCC Offset: 0x21F8DCC VA: 0x21FCDCC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21FCDD4 Offset: 0x21F8DD4 VA: 0x21FCDD4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21FCDDC Offset: 0x21F8DDC VA: 0x21FCDDC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21FCDE4 Offset: 0x21F8DE4 VA: 0x21FCDE4 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x21FCDEC Offset: 0x21F8DEC VA: 0x21FCDEC Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x21FCDF4 Offset: 0x21F8DF4 VA: 0x21FCDF4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21FD310 Offset: 0x21F9310 VA: 0x21FD310 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21FD700 Offset: 0x21F9700 VA: 0x21FD700 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FD7E4 Offset: 0x21F97E4 VA: 0x21FD7E4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FD834 Offset: 0x21F9834 VA: 0x21FD834
	private void calcFirstDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FDE74 Offset: 0x21F9E74 VA: 0x21FDE74
	private void calcAnyDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FE38C Offset: 0x21FA38C VA: 0x21FE38C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21FE4C0 Offset: 0x21FA4C0 VA: 0x21FE4C0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x21FE53C Offset: 0x21FA53C VA: 0x21FE53C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21FE7D0 Offset: 0x21FA7D0 VA: 0x21FE7D0
	public static bool TryGetAbnormalSuctionData(ActionAppendData appendData, out Vector3 effectPos, out float range) { }

	// RVA: 0x21FE9A4 Offset: 0x21FA9A4 VA: 0x21FE9A4
	public void .ctor() { }
}

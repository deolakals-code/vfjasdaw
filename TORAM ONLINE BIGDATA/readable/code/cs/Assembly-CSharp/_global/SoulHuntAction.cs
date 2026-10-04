// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SoulHuntAction : PlayerAttackBase // TypeDefIndex: 2614
{
	// Fields
	private float firstSkillRate; // 0x120
	private float secondSkillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int percent; // 0x12C
	private GameObject mainTarget; // 0x130
	private Vector3 attackPos; // 0x138
	private float attackRange; // 0x144
	private int baseMpHeal; // 0x148
	private int attackCount; // 0x14C
	private Dictionary<int, byte> targetExpList; // 0x150
	private bool isBow; // 0x158
	private bool activeInvincibility; // 0x159
	private byte invincibilityLocalId; // 0x15A

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x22105D4 Offset: 0x220C5D4 VA: 0x22105D4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22105DC Offset: 0x220C5DC VA: 0x22105DC Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x22105E4 Offset: 0x220C5E4 VA: 0x22105E4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22105EC Offset: 0x220C5EC VA: 0x22105EC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22105F4 Offset: 0x220C5F4 VA: 0x22105F4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22105FC Offset: 0x220C5FC VA: 0x22105FC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2210604 Offset: 0x220C604 VA: 0x2210604 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x221060C Offset: 0x220C60C VA: 0x221060C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2210614 Offset: 0x220C614 VA: 0x2210614 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x221061C Offset: 0x220C61C VA: 0x221061C Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x2210688 Offset: 0x220C688 VA: 0x2210688 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2210994 Offset: 0x220C994 VA: 0x2210994 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2210BBC Offset: 0x220CBBC VA: 0x2210BBC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2210F38 Offset: 0x220CF38 VA: 0x2210F38 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2210FC0 Offset: 0x220CFC0 VA: 0x2210FC0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2211240 Offset: 0x220D240 VA: 0x2211240 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22113E4 Offset: 0x220D3E4 VA: 0x22113E4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2211BBC Offset: 0x220DBBC VA: 0x2211BBC Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x2211BEC Offset: 0x220DBEC VA: 0x2211BEC
	public static void PayHp(PlayerStatusBase status) { }

	// RVA: 0x2211D04 Offset: 0x220DD04 VA: 0x2211D04
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class N_DragonToothAction : PlayerAttackBase // TypeDefIndex: 2951
{
	// Fields
	private float firstSkillRate; // 0x120
	private float secondSkillRate; // 0x124
	private int critical; // 0x128
	private int resist; // 0x12C
	private short mpRecovery; // 0x130
	private Vector3 startPos; // 0x134
	private Vector3 targetPos; // 0x140
	private CharacterActionManagerBase targetAction; // 0x150
	private float distance; // 0x158
	private bool isDamaged; // 0x15C
	private bool isLongStep; // 0x15D

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMove { get; }
	public override bool IsMoveAssistContinue { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x22DFB8C Offset: 0x22DBB8C VA: 0x22DFB8C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22DFB94 Offset: 0x22DBB94 VA: 0x22DFB94 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22DFB9C Offset: 0x22DBB9C VA: 0x22DFB9C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22DFBA4 Offset: 0x22DBBA4 VA: 0x22DFBA4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22DFBAC Offset: 0x22DBBAC VA: 0x22DFBAC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22DFBB4 Offset: 0x22DBBB4 VA: 0x22DFBB4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22DFBBC Offset: 0x22DBBBC VA: 0x22DFBBC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22DFBC4 Offset: 0x22DBBC4 VA: 0x22DFBC4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22DFBCC Offset: 0x22DBBCC VA: 0x22DFBCC Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22DFBD4 Offset: 0x22DBBD4 VA: 0x22DFBD4 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x22DFBDC Offset: 0x22DBBDC VA: 0x22DFBDC Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22DFBE4 Offset: 0x22DBBE4 VA: 0x22DFBE4 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22DFC24 Offset: 0x22DBC24 VA: 0x22DFC24 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DFDA8 Offset: 0x22DBDA8 VA: 0x22DFDA8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22DFEB8 Offset: 0x22DBEB8 VA: 0x22DFEB8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22DFF50 Offset: 0x22DBF50 VA: 0x22DFF50 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E0154 Offset: 0x22DC154 VA: 0x22E0154 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E0574 Offset: 0x22DC574 VA: 0x22E0574 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22E0AE0 Offset: 0x22DCAE0 VA: 0x22E0AE0 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22E0C58 Offset: 0x22DCC58 VA: 0x22E0C58 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E0E04 Offset: 0x22DCE04 VA: 0x22E0E04
	private void calcFirstDamage(PlayerActionManagerBase playerAction, PlayerSecondaryStatus secondaryStatus, MobActionManagerBase mobAction) { }

	// RVA: 0x22E0FBC Offset: 0x22DCFBC VA: 0x22E0FBC
	private void calcSecondDamage(PlayerActionManagerBase playerAction, PlayerSecondaryStatus secondaryStatus, MobActionManagerBase mobAction) { }

	// RVA: 0x22E1174 Offset: 0x22DD174 VA: 0x22E1174
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x22E1230 Offset: 0x22DD230 VA: 0x22E1230 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x22E1238 Offset: 0x22DD238 VA: 0x22E1238
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private class MobBattlePlayer.MobPlayActionSkill : MobBattlePlayer.MobPlayActionDataBase // TypeDefIndex: 730
{
	// Fields
	private MobAttackBase attack; // 0x50
	private MobSkillActionPlayer skillPlayer; // 0x58
	private List<MobActionTargetData> targetList; // 0x60
	private Vector3 actor; // 0x68
	private Quaternion startRot; // 0x74
	private CharacterMove charaMove; // 0x88

	// Properties
	public MobAttackBase AttackPattern { get; }
	public List<MobActionTargetData> TargetList { get; }

	// Methods

	// RVA: 0x1B97BE8 Offset: 0x1B93BE8 VA: 0x1B97BE8
	public MobAttackBase get_AttackPattern() { }

	// RVA: 0x1B97BF0 Offset: 0x1B93BF0 VA: 0x1B97BF0
	public List<MobActionTargetData> get_TargetList() { }

	// RVA: 0x1B953F0 Offset: 0x1B913F0 VA: 0x1B953F0
	public void .ctor(EnemyMobActionManagerBase mobAct, Vector3 actorPos, Quaternion startRot, MobSkillActionPlayer skillPlayer, GameObject target, Vector3 targetPos, MobAttackBase attack, bool skip, List<MobActionTargetData> targetList) { }

	// RVA: 0x1B97BF8 Offset: 0x1B93BF8 VA: 0x1B97BF8 Slot: 5
	public override void Start() { }

	// RVA: 0x1B97F60 Offset: 0x1B93F60 VA: 0x1B97F60 Slot: 4
	public override void Update() { }

	// RVA: 0x1B97FE4 Offset: 0x1B93FE4 VA: 0x1B97FE4 Slot: 6
	public override void Cancel() { }
}

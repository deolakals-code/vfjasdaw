// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NonTargetDummyMobActinoManager : EnemyMobActionManagerBase // TypeDefIndex: 1052
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x158
	private Vector3 hitDist; // 0x160
	private NonTargetDummyMobBattleStatus data; // 0x170

	// Properties
	public override bool IsDead { get; }
	public override bool IsLocalDead { get; }
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }

	// Methods

	// RVA: 0x1F3ED6C Offset: 0x1F3AD6C VA: 0x1F3ED6C Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1F3ED74 Offset: 0x1F3AD74 VA: 0x1F3ED74 Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x1F3ED7C Offset: 0x1F3AD7C VA: 0x1F3ED7C Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F3ED84 Offset: 0x1F3AD84 VA: 0x1F3ED84 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F3ED8C Offset: 0x1F3AD8C VA: 0x1F3ED8C Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F3EEAC Offset: 0x1F3AEAC VA: 0x1F3EEAC Slot: 73
	protected override void Update() { }

	// RVA: 0x1F3EFC4 Offset: 0x1F3AFC4 VA: 0x1F3EFC4 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F3EFC8 Offset: 0x1F3AFC8 VA: 0x1F3EFC8 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1F3EFCC Offset: 0x1F3AFCC VA: 0x1F3EFCC Slot: 92
	public override bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F3F084 Offset: 0x1F3B084 VA: 0x1F3F084 Slot: 93
	public override bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F3F13C Offset: 0x1F3B13C VA: 0x1F3F13C Slot: 94
	public override bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F3F1F8 Offset: 0x1F3B1F8 VA: 0x1F3F1F8
	public void .ctor() { }
}

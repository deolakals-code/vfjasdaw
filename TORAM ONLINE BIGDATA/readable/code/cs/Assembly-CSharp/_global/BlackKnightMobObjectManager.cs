// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobObjectManager // TypeDefIndex: 4206
{
	// Fields
	private BlackKnightMobObjectManager.EnemyData[] enemyList; // 0x10
	private GuideRail guideRail; // 0x18
	private BlackKnightPlayerManager playerManager; // 0x20

	// Properties
	public BlackKnightMobManagerBase[] TargetableMobList { get; }
	public BlackKnightBossManager BossManager { get; }

	// Methods

	// RVA: 0x24A9C58 Offset: 0x24A5C58 VA: 0x24A9C58
	public BlackKnightMobManagerBase[] get_TargetableMobList() { }

	// RVA: 0x24A9E38 Offset: 0x24A5E38 VA: 0x24A9E38
	public BlackKnightBossManager get_BossManager() { }

	// RVA: 0x24A9F8C Offset: 0x24A5F8C VA: 0x24A9F8C
	public void Initialize(GuideRail rail, TextAsset popPoint) { }

	// RVA: 0x24A9F94 Offset: 0x24A5F94 VA: 0x24A9F94
	public void Initialize(BlackKnightPlayerManager playerManager, GuideRail rail, byte[] text) { }

	[IteratorStateMachine(typeof(BlackKnightMobObjectManager.<LoadEffectModel>d__11))]
	// RVA: 0x24AA960 Offset: 0x24A6960 VA: 0x24AA960
	public IEnumerator LoadEffectModel() { }

	// RVA: 0x24AA9F4 Offset: 0x24A69F4 VA: 0x24AA9F4
	public void Clear() { }

	// RVA: 0x24AAA6C Offset: 0x24A6A6C VA: 0x24AAA6C
	private bool CheckFlag(byte flag, BlackKnightMobObjectManager.PopBitFlag checkFlag) { }

	// RVA: 0x24AA8C4 Offset: 0x24A68C4 VA: 0x24AA8C4
	private BlackKnightMobObjectManager.EnemyData CreateEnemy(BlackKnightPlayerManager playerManager, BlackKnightPopSettingData data) { }

	// RVA: 0x24AAA7C Offset: 0x24A6A7C VA: 0x24AAA7C
	private BlackKnightMobObjectManager.EnemyData CreateEnemy(BlackKnightPlayerManager playerManager, MobStatusMaster master, BlackKnightPopSettingData setData) { }

	// RVA: 0x24AAD78 Offset: 0x24A6D78 VA: 0x24AAD78
	public void UpdateEnemy() { }

	// RVA: 0x24AAE08 Offset: 0x24A6E08 VA: 0x24AAE08
	public void LateUpdateEnemy() { }

	// RVA: 0x24AAE98 Offset: 0x24A6E98 VA: 0x24AAE98
	public Dictionary<int, BlackKnightHitAreaData[]> GetHitAreaData() { }

	// RVA: 0x24AAFD4 Offset: 0x24A6FD4 VA: 0x24AAFD4
	public void HitMobToPlayer(BlackKnightHitAreaData hitArea, int localId) { }

	// RVA: 0x24AB06C Offset: 0x24A706C VA: 0x24AB06C
	public void EnterBossRoomStart() { }

	// RVA: 0x24AB0E4 Offset: 0x24A70E4 VA: 0x24AB0E4
	public void EnterBossRoom() { }

	// RVA: 0x24AB15C Offset: 0x24A715C VA: 0x24AB15C
	public void StopAllMob() { }

	// RVA: 0x24AB1D4 Offset: 0x24A71D4 VA: 0x24AB1D4
	public BlackKnightMobManagerBase GetNearMobManager() { }

	// RVA: 0x24AB298 Offset: 0x24A7298 VA: 0x24AB298
	public void .ctor() { }
}

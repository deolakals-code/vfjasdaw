// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class MobPatternTargetFactory // TypeDefIndex: 795
{
	// Methods

	// RVA: 0x1D4E6B4 Offset: 0x1D4A6B4 VA: 0x1D4E6B4
	public static List<MobPatternTargetData> CreateTargetData(EnemyMobActionManagerBase mobActionManager, MobPatternTargetType type) { }

	// RVA: 0x1D533F4 Offset: 0x1D4F3F4 VA: 0x1D533F4
	public static MobPatternTargetData CreateChantAttackTargetData(EnemyMobActionManagerBase mobActionManager, MobPatternTargetType type) { }

	// RVA: 0x1D551B4 Offset: 0x1D511B4 VA: 0x1D551B4
	public static GameObject GetTargetObject(EnemyMobActionManagerBase mobActionManager, MobActionPattern pattern) { }

	// RVA: 0x1D4E960 Offset: 0x1D4A960 VA: 0x1D4E960
	private static List<MobPatternTargetData> CreateTargetToHateManager(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D4F2DC Offset: 0x1D4B2DC VA: 0x1D4F2DC
	private static List<MobPatternTargetData> CreateTargetToNonHateManager(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D4FDC8 Offset: 0x1D4BDC8 VA: 0x1D4FDC8
	private static List<MobPatternTargetData> CreateTargetToNonHateManagerAll(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D508B8 Offset: 0x1D4C8B8 VA: 0x1D508B8
	private static List<MobPatternTargetData> CreateTargetToRandom(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D5133C Offset: 0x1D4D33C VA: 0x1D5133C
	private static List<MobPatternTargetData> CreateTargetToAll(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D51C94 Offset: 0x1D4DC94 VA: 0x1D51C94
	private static List<MobPatternTargetData> CreateTargetToNearNonHateManager(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D52848 Offset: 0x1D4E848 VA: 0x1D52848
	private static List<MobPatternTargetData> CreateTargetToFarNonHateManager(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D53590 Offset: 0x1D4F590 VA: 0x1D53590
	private static MobPatternTargetData CreateOneTargetToNonHateManager(MobPatternTargetData hateData) { }

	// RVA: 0x1D53F04 Offset: 0x1D4FF04 VA: 0x1D53F04
	private static MobPatternTargetData CreateOneTargetToNearNonHateManager(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D54860 Offset: 0x1D50860 VA: 0x1D54860
	private static MobPatternTargetData CreateOneTargetToFarNonHateManager(EnemyMobActionManagerBase mobActionManager, MobPatternTargetData hateData) { }

	// RVA: 0x1D55308 Offset: 0x1D51308 VA: 0x1D55308
	private static BattleMemberData GetSecondPartyTopHateMember(EnemyMobActionManagerBase mobActionManager) { }

	// RVA: 0x1D552A4 Offset: 0x1D512A4 VA: 0x1D552A4
	private static bool CheckSecondPartyTarget() { }
}

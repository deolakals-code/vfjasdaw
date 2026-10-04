// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TranslationExtraAttackPattern : MobPatternBase // TypeDefIndex: 835
{
	// Fields
	private readonly MobPatternTargetType[] TargetTypes; // 0x70
	private readonly Vector3 startPos; // 0x78
	private List<Vector3> attackPosList; // 0x88
	private int fristRot; // 0x90
	private int nextRot; // 0x94
	private int fireNum; // 0x98
	private ElementType element; // 0x9C

	// Properties
	public override bool VisibleAttackArea { get; }
	public MobAttackCategory InstallationCategory { get; }
	private bool IsFixedDirectionPattern { get; }

	// Methods

	// RVA: 0x1E25804 Offset: 0x1E21804 VA: 0x1E25804 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E2580C Offset: 0x1E2180C VA: 0x1E2580C
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1E25814 Offset: 0x1E21814 VA: 0x1E25814
	private bool get_IsFixedDirectionPattern() { }

	// RVA: 0x1E25838 Offset: 0x1E21838 VA: 0x1E25838
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobActionManager, GameObject target, Vector3 bulletPos) { }

	// RVA: 0x1E25AB4 Offset: 0x1E21AB4 VA: 0x1E25AB4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E25AB8 Offset: 0x1E21AB8 VA: 0x1E25AB8 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E259E0 Offset: 0x1E219E0 VA: 0x1E259E0
	private void CreateTargetList(Vector3 targetPos) { }

	// RVA: 0x1E25F6C Offset: 0x1E21F6C VA: 0x1E25F6C
	private void CreateTargetToHateManager(Vector3 targetPos) { }

	// RVA: 0x1E264E8 Offset: 0x1E224E8 VA: 0x1E264E8
	private void CreateTargetToNonHateManager(Vector3 targetPos) { }

	// RVA: 0x1E26B00 Offset: 0x1E22B00 VA: 0x1E26B00
	private void CreateTargetToRandom(Vector3 targetPos) { }

	// RVA: 0x1E27714 Offset: 0x1E23714 VA: 0x1E27714
	private void CreateTargetToCloseNonHateManager() { }

	// RVA: 0x1E27DC4 Offset: 0x1E23DC4 VA: 0x1E27DC4
	private void CreateTargetToDistantNonHateManager() { }

	// RVA: 0x1E270F4 Offset: 0x1E230F4 VA: 0x1E270F4
	private void CreateTargetToNonHateManagerAll() { }

	// RVA: 0x1E27404 Offset: 0x1E23404 VA: 0x1E27404
	private void CreateTargetToAll() { }
}

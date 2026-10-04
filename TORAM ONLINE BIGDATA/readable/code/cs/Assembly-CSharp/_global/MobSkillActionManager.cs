// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobSkillActionManager : SkillActionManagerBase // TypeDefIndex: 738
{
	// Fields
	private Transform mobTransform; // 0x58
	private MobAnimation mobAnimation; // 0x60
	private EnemyMobActionManagerBase mobActManager; // 0x68
	private TakeController takeController; // 0x70
	private MobAttackBase currentSkill; // 0x78
	private CharacterMove charaMove; // 0x80
	private GameObject actionTarget; // 0x88
	private MobPatternBase mobPattern; // 0x90
	private bool rangeCheck; // 0x98
	private Vector3 prevAttckPos; // 0x9C
	private MobInstallationAttackManager installationManager; // 0xA8

	// Properties
	public override bool IsInterruptable { get; }
	public override SkillActionBase CurrentSkill { get; }
	public override bool IsCasting { get; }
	public MobPatternBase MobPattern { get; }
	public bool IsTarget { get; }

	// Methods

	// RVA: 0x1B99640 Offset: 0x1B95640 VA: 0x1B99640 Slot: 4
	public override bool get_IsInterruptable() { }

	// RVA: 0x1B99648 Offset: 0x1B95648 VA: 0x1B99648 Slot: 5
	public override SkillActionBase get_CurrentSkill() { }

	// RVA: 0x1B99650 Offset: 0x1B95650 VA: 0x1B99650 Slot: 6
	public override bool get_IsCasting() { }

	// RVA: 0x1B99658 Offset: 0x1B95658 VA: 0x1B99658
	public MobPatternBase get_MobPattern() { }

	// RVA: 0x1B99660 Offset: 0x1B95660 VA: 0x1B99660
	public bool get_IsTarget() { }

	// RVA: 0x1B9967C Offset: 0x1B9567C VA: 0x1B9967C
	private void Awake() { }

	// RVA: 0x1B997F8 Offset: 0x1B957F8 VA: 0x1B997F8 Slot: 7
	public override void Initialize() { }

	// RVA: 0x1B99804 Offset: 0x1B95804 VA: 0x1B99804 Slot: 8
	public override void End() { }

	// RVA: 0x1B998A4 Offset: 0x1B958A4 VA: 0x1B998A4 Slot: 10
	public override void ActionCancel() { }

	// RVA: 0x1B90740 Offset: 0x1B8C740 VA: 0x1B90740
	public bool CreateAction(MobAttackBase action, GameObject target) { }

	// RVA: 0x1B999E4 Offset: 0x1B959E4 VA: 0x1B999E4
	public MobPatternBase CreateMobPattern(MobAttackBase action, GameObject target, float playSpeed) { }

	// RVA: 0x1B9A2C4 Offset: 0x1B962C4 VA: 0x1B9A2C4 Slot: 9
	public override void SetCurrentSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B987C4 Offset: 0x1B947C4 VA: 0x1B987C4
	public void SetCurrentSkillHateChange(MobAttackBase action) { }

	// RVA: 0x1B9A494 Offset: 0x1B96494 VA: 0x1B9A494
	private void Update() { }

	// RVA: 0x1B9BF08 Offset: 0x1B97F08 VA: 0x1B9BF08
	private void LateUpdate() { }

	// RVA: 0x1B9BF48 Offset: 0x1B97F48 VA: 0x1B9BF48
	public void AddInstallation(int commandId, GameObject target, Vector3 startPos, Vector3 endPos, MobPatternBase parentPattern, ElementType mobElement) { }

	// RVA: 0x1B9BF68 Offset: 0x1B97F68 VA: 0x1B9BF68
	public void AddInstallationCopy(MobPatternBase pattern, Vector3 targetPos) { }

	// RVA: 0x1B9BF84 Offset: 0x1B97F84 VA: 0x1B9BF84
	public void DelayAddInstallation(int commandId, GameObject target, Vector3 startPos, Vector3 endPos, MobPatternBase parentPattern, ElementType mobElement) { }

	// RVA: 0x1B9BFA4 Offset: 0x1B97FA4 VA: 0x1B9BFA4
	public void AddExtraInstallation(int commandId, GameObject target, Vector3 bulletPos, MobActionPattern parentPattern, ElementType mobElement) { }

	// RVA: 0x1B9C074 Offset: 0x1B98074 VA: 0x1B9C074
	public MobAttackBase[] GetInstallationAttack() { }

	// RVA: 0x1B9C090 Offset: 0x1B98090 VA: 0x1B9C090
	public bool CheckHitInstallation(Transform target) { }

	// RVA: 0x1B9C0AC Offset: 0x1B980AC VA: 0x1B9C0AC
	public bool CheckDamageAreaToInstallation(Transform target) { }

	// RVA: 0x1B9C0B4 Offset: 0x1B980B4 VA: 0x1B9C0B4
	public void ExternalActionHit(MobAttackBase skillBase, GameObject target) { }

	// RVA: 0x1B9CBDC Offset: 0x1B98BDC VA: 0x1B9CBDC
	public void InstallationAtackInvalid() { }

	// RVA: 0x1B9CC60 Offset: 0x1B98C60 VA: 0x1B9CC60
	public void Damaged() { }

	// RVA: 0x1B9BE90 Offset: 0x1B97E90 VA: 0x1B9BE90
	private void WaveAttack(MobAttackBase attack) { }

	// RVA: 0x1B9CF20 Offset: 0x1B98F20 VA: 0x1B9CF20
	private void WaveSingleAttack(MobAttackBase attack) { }

	// RVA: 0x1B9CCB0 Offset: 0x1B98CB0 VA: 0x1B9CCB0
	private void WaveRangeAttack(MobAttackBase attack) { }

	// RVA: 0x1B9BB0C Offset: 0x1B97B0C VA: 0x1B9BB0C
	private void WaveSupportAttack(MobAttackBase attack) { }

	// RVA: 0x1B9D3F0 Offset: 0x1B993F0 VA: 0x1B9D3F0
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobSkillManager : BlackKnightSkillActionManagerBase // TypeDefIndex: 4212
{
	// Fields
	private BlackKnightMobManagerBase actor; // 0x18
	private MobAnimation animation; // 0x20
	private TakeController effectTakeController; // 0x28
	private BlackKnightMobSkillBase currentSkill; // 0x30
	private BlackKnightMobPatternBase mobPattern; // 0x38
	private BlackKnightMobInstallationManager installationManager; // 0x40

	// Properties
	public override BlackKnightSkillActionBase CurrentSkill { get; }
	public BlackKnightMobSkillManager.KnockUpResisterState KnockUpResister { get; }

	// Methods

	// RVA: 0x24AB9A0 Offset: 0x24A79A0 VA: 0x24AB9A0 Slot: 4
	public override BlackKnightSkillActionBase get_CurrentSkill() { }

	// RVA: 0x24A7A8C Offset: 0x24A3A8C VA: 0x24A7A8C
	public BlackKnightMobSkillManager.KnockUpResisterState get_KnockUpResister() { }

	// RVA: 0x24A3D64 Offset: 0x249FD64 VA: 0x24A3D64
	public void .ctor(BlackKnightMobManagerBase actor, MobAnimation animation) { }

	// RVA: 0x24AB9B0 Offset: 0x24A79B0 VA: 0x24AB9B0 Slot: 5
	public override void Initialize() { }

	// RVA: 0x24ABA1C Offset: 0x24A7A1C VA: 0x24ABA1C Slot: 7
	public override void End() { }

	// RVA: 0x24A3FB4 Offset: 0x249FFB4 VA: 0x24A3FB4
	public void Clear() { }

	// RVA: 0x24ABA28 Offset: 0x24A7A28 VA: 0x24ABA28 Slot: 9
	public override void ActionCancel() { }

	// RVA: 0x24ABACC Offset: 0x24A7ACC VA: 0x24ABACC Slot: 8
	public override void UseSkill(GameObject actor, GameObject target, BlackKnightSkillActionBase action) { }

	// RVA: 0x24ABD78 Offset: 0x24A7D78 VA: 0x24ABD78 Slot: 6
	public override void Update() { }

	// RVA: 0x24AC0A8 Offset: 0x24A80A8 VA: 0x24AC0A8
	private BlackKnightHitAreaData CreateHitArea(BlackKnightMobSkillBase skill, MobActionPattern pattern) { }
}

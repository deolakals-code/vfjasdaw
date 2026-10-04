// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightNormalAttackPattern : BlackKnightMobPatternBase // TypeDefIndex: 4219
{
	// Fields
	private MobAnimation animation; // 0x38
	private BlackKnightMobManagerBase actor; // 0x40
	private int motionId; // 0x48
	private int startMotionId; // 0x4C
	private int endMotionId; // 0x50
	private float moveDistance; // 0x54
	private float moveSpeed; // 0x58
	private float moveTime; // 0x5C
	private float hitInterval; // 0x60
	private float hitIntervalTimer; // 0x64

	// Methods

	// RVA: 0x24ABC50 Offset: 0x24A7C50 VA: 0x24ABC50
	public void .ctor(BlackKnightMobManagerBase actor, MobActionPattern pattern, MobAnimation mobAnimation, float playSpeed, BlackKnightMobSkillBase skill) { }

	// RVA: 0x24ADA98 Offset: 0x24A9A98 VA: 0x24ADA98 Slot: 4
	public override void ActionCancel() { }

	// RVA: 0x24ADA9C Offset: 0x24A9A9C VA: 0x24ADA9C Slot: 6
	protected override bool OnPreUpdate() { }

	// RVA: 0x24ADB24 Offset: 0x24A9B24 VA: 0x24ADB24 Slot: 7
	protected override PatternCommand OnPostUpdate() { }
}

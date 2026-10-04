// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobWallPattern : BlackKnightMobPatternBase // TypeDefIndex: 4218
{
	// Fields
	private GameObject placeEffectObject; // 0x38
	private Motion placeEffectMotion; // 0x40
	private BlackKnightMobManagerBase actor; // 0x48
	private float range; // 0x50
	private float intervalTime; // 0x54
	private float intervalTimer; // 0x58
	private int damageCount; // 0x5C
	private GameObject targetObj; // 0x60
	private bool isEndless; // 0x68
	private BlackKnightHitAreaData baseHitArea; // 0x70

	// Methods

	// RVA: 0x24A59B0 Offset: 0x24A19B0 VA: 0x24A59B0
	public void .ctor(BlackKnightMobManagerBase actor, MobActionPattern pattern, float playSpeed, BlackKnightMobSkillBase skill) { }

	// RVA: 0x24AD054 Offset: 0x24A9054 VA: 0x24AD054 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x24AD15C Offset: 0x24A915C VA: 0x24AD15C Slot: 4
	public override void ActionCancel() { }

	// RVA: 0x24AD168 Offset: 0x24A9168 VA: 0x24AD168 Slot: 6
	protected override bool OnPreUpdate() { }

	// RVA: 0x24AD170 Offset: 0x24A9170 VA: 0x24AD170 Slot: 7
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x24AD298 Offset: 0x24A9298 VA: 0x24AD298 Slot: 11
	protected override void CreateHitArea(BlackKnightMobSkillBase skill) { }
}

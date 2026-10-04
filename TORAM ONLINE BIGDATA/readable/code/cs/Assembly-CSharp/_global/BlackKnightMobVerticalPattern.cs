// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobVerticalPattern : BlackKnightMobPatternBase // TypeDefIndex: 4217
{
	// Fields
	private GameObject placeEffectObject; // 0x38
	private Motion placeEffectMotion; // 0x40
	private BlackKnightMobManagerBase actor; // 0x48
	private float range; // 0x50
	private float fallTime; // 0x54
	private float fallDelay; // 0x58
	private GameObject targetObj; // 0x60
	private BlackKnightHitAreaData baseHitArea; // 0x68
	private Transform meteor; // 0x70
	private readonly int meteorSize; // 0x78

	// Methods

	// RVA: 0x24A565C Offset: 0x24A165C VA: 0x24A565C
	public void .ctor(BlackKnightMobManagerBase actor, MobActionPattern pattern, float playSpeed, BlackKnightMobSkillBase skill) { }

	// RVA: 0x24ACA20 Offset: 0x24A8A20 VA: 0x24ACA20 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x24ACB28 Offset: 0x24A8B28 VA: 0x24ACB28 Slot: 4
	public override void ActionCancel() { }

	// RVA: 0x24ACB34 Offset: 0x24A8B34 VA: 0x24ACB34 Slot: 6
	protected override bool OnPreUpdate() { }

	// RVA: 0x24ACB3C Offset: 0x24A8B3C VA: 0x24ACB3C Slot: 7
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x24ACBD8 Offset: 0x24A8BD8 VA: 0x24ACBD8 Slot: 11
	protected override void CreateHitArea(BlackKnightMobSkillBase skill) { }
}

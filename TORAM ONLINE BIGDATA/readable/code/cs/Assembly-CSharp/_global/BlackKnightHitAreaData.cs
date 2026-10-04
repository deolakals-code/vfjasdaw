// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightHitAreaData : ICloneable // TypeDefIndex: 4221
{
	// Fields
	private Cylinder area; // 0x10
	private float startTime; // 0x18
	private float endTime; // 0x1C
	private float elapsedTime; // 0x20
	private GameObject actor; // 0x28
	private Vector3 offset; // 0x30
	private bool isHitCheckStart; // 0x3C
	private BlackKnightHitAreaData.MoveType moveType; // 0x40
	private BlackKnightSkillActionBase skill; // 0x48
	private MobActionPattern pattern; // 0x50
	private bool isEndHit; // 0x58
	[CompilerGenerated]
	private bool <IsHitCheck>k__BackingField; // 0x59

	// Properties
	public Cylinder Area { get; }
	public bool IsHitCheck { get; set; }
	public BlackKnightSkillActionBase Skill { get; }
	public MobActionPattern Pattern { get; }
	public bool IsEndHit { get; }
	public bool IsPlace { get; }

	// Methods

	// RVA: 0x24ADC78 Offset: 0x24A9C78 VA: 0x24ADC78
	public Cylinder get_Area() { }

	[CompilerGenerated]
	// RVA: 0x24ADC80 Offset: 0x24A9C80 VA: 0x24ADC80
	public bool get_IsHitCheck() { }

	[CompilerGenerated]
	// RVA: 0x24ADC88 Offset: 0x24A9C88 VA: 0x24ADC88
	private void set_IsHitCheck(bool value) { }

	// RVA: 0x24ADC94 Offset: 0x24A9C94 VA: 0x24ADC94
	public BlackKnightSkillActionBase get_Skill() { }

	// RVA: 0x24ADC9C Offset: 0x24A9C9C VA: 0x24ADC9C
	public MobActionPattern get_Pattern() { }

	// RVA: 0x24ADCA4 Offset: 0x24A9CA4 VA: 0x24ADCA4
	public bool get_IsEndHit() { }

	// RVA: 0x24A8538 Offset: 0x24A4538 VA: 0x24A8538
	public bool get_IsPlace() { }

	// RVA: 0x24AC2CC Offset: 0x24A82CC VA: 0x24AC2CC
	public void .ctor(Vector3 center, float rad, float height, float start, float end, GameObject chara, BlackKnightSkillActionBase skill, BlackKnightHitAreaData.MoveType type) { }

	// RVA: 0x24AD704 Offset: 0x24A9704 VA: 0x24AD704
	public void .ctor() { }

	// RVA: 0x24ADE70 Offset: 0x24A9E70 VA: 0x24ADE70
	public void SetActor(GameObject manager) { }

	// RVA: 0x24ADE8C Offset: 0x24A9E8C VA: 0x24ADE8C
	public void SetMoveType(BlackKnightHitAreaData.MoveType type) { }

	// RVA: 0x24AD834 Offset: 0x24A9834 VA: 0x24AD834
	public void Set(Vector3 center, float rad, float height, float start, float end, BlackKnightSkillActionBase skill, BlackKnightHitAreaData.MoveType type) { }

	// RVA: 0x24ADE94 Offset: 0x24A9E94 VA: 0x24ADE94
	public void SetPattern(MobActionPattern pattern) { }

	// RVA: 0x24ADE9C Offset: 0x24A9E9C VA: 0x24ADE9C
	public bool GetIsHitCheckable() { }

	// RVA: 0x24A7C98 Offset: 0x24A3C98 VA: 0x24A7C98
	public bool GetIsEndCheck() { }

	// RVA: 0x24A7CA8 Offset: 0x24A3CA8 VA: 0x24A7CA8
	public void UpdateHitArea() { }

	// RVA: 0x24ADCAC Offset: 0x24A9CAC VA: 0x24ADCAC
	public void UpdateHitAreaPos() { }

	// RVA: 0x24ADEC4 Offset: 0x24A9EC4 VA: 0x24ADEC4
	public void Hit() { }

	// RVA: 0x24ADED0 Offset: 0x24A9ED0 VA: 0x24ADED0 Slot: 4
	public object Clone() { }
}

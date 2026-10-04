// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightMobPatternBase // TypeDefIndex: 4215
{
	// Fields
	protected readonly MobActionPattern pattern; // 0x10
	protected float startSoundTime; // 0x18
	protected float attackTime; // 0x1C
	protected float chargeTime; // 0x20
	protected List<BlackKnightHitAreaData> hitAreaList; // 0x28
	[CompilerGenerated]
	private float <PlaySpeed>k__BackingField; // 0x30

	// Properties
	public MobActionPattern Pattern { get; }
	public float PlaySpeed { get; set; }
	public List<BlackKnightHitAreaData> HitAreaList { get; }

	// Methods

	// RVA: 0x24AC4EC Offset: 0x24A84EC VA: 0x24AC4EC
	public MobActionPattern get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x24AC4F4 Offset: 0x24A84F4 VA: 0x24AC4F4
	public float get_PlaySpeed() { }

	[CompilerGenerated]
	// RVA: 0x24AC4FC Offset: 0x24A84FC VA: 0x24AC4FC
	private void set_PlaySpeed(float value) { }

	// RVA: 0x24AC504 Offset: 0x24A8504 VA: 0x24AC504
	public List<BlackKnightHitAreaData> get_HitAreaList() { }

	// RVA: 0x24AC50C Offset: 0x24A850C VA: 0x24AC50C
	protected void .ctor(MobActionPattern pattern, float playSpeed) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ActionCancel();

	// RVA: 0x24A6030 Offset: 0x24A2030 VA: 0x24A6030
	public PatternCommand Update() { }

	// RVA: 0x24AC5BC Offset: 0x24A85BC VA: 0x24AC5BC Slot: 5
	protected virtual void OnChargeUpdate(bool end) { }

	// RVA: 0x24AC5C0 Offset: 0x24A85C0 VA: 0x24AC5C0 Slot: 6
	protected virtual bool OnPreUpdate() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract PatternCommand OnPostUpdate();

	// RVA: 0x24AC5C8 Offset: 0x24A85C8 VA: 0x24AC5C8 Slot: 8
	public virtual void LateUpdate() { }

	// RVA: 0x24AC5CC Offset: 0x24A85CC VA: 0x24AC5CC Slot: 9
	public virtual void OnEnd() { }

	// RVA: 0x24AC5D0 Offset: 0x24A85D0 VA: 0x24AC5D0 Slot: 10
	public virtual bool CheckHit(Transform targetTransform) { }

	// RVA: 0x24AC5D8 Offset: 0x24A85D8 VA: 0x24AC5D8 Slot: 11
	protected virtual void CreateHitArea(BlackKnightMobSkillBase skill) { }

	// RVA: 0x24AC220 Offset: 0x24A8220 VA: 0x24AC220
	public void AddHitArea(BlackKnightHitAreaData hitArea) { }

	// RVA: 0x24AC5DC Offset: 0x24A85DC VA: 0x24AC5DC
	protected GameObject ChangeEffectModelColor(GameObject effect, int modelId, int motionId, ElementType element) { }

	// RVA: 0x24ACA04 Offset: 0x24A8A04 VA: 0x24ACA04
	private static Color CreateColor(float red, float green, float blue) { }
}

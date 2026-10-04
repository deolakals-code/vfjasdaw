// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightSkillActionBase : IEquatable<BlackKnightSkillActionBase> // TypeDefIndex: 4227
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <ActionRange>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <LoopParam>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Delay>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <Radius>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x30
	protected float startTargetDist; // 0x38
	private int _motionSpeed; // 0x3C
	private List<BlackKnightSkillActionBase.DamageData> targetDamageData; // 0x40
	protected List<BlackKnightHitAreaData> hitAreaList; // 0x48

	// Properties
	public int Id { get; set; }
	public abstract int ActionID { get; }
	public abstract bool IsInterruptable { get; }
	public abstract bool IsPlace { get; }
	protected abstract BlackKnightSkillActionBase.AttackType AtkType { get; }
	public float ActionRange { get; set; }
	public int MotionSpeed { get; set; }
	public int LoopParam { get; set; }
	public float Delay { get; set; }
	public ElementType Element { get; set; }
	public bool IsEnd { get; set; }
	public float Radius { get; set; }
	public List<BlackKnightSkillActionBase.DamageData> TargetDamageData { get; }
	public virtual bool IsChatLog { get; }
	public GameObject Target { get; set; }
	public List<BlackKnightHitAreaData> HitAreaList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24AED8C Offset: 0x24AAD8C VA: 0x24AED8C
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x24AED94 Offset: 0x24AAD94 VA: 0x24AED94
	private void set_Id(int value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_ActionID();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsInterruptable();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsPlace();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract BlackKnightSkillActionBase.AttackType get_AtkType();

	[CompilerGenerated]
	// RVA: 0x24AED9C Offset: 0x24AAD9C VA: 0x24AED9C
	public float get_ActionRange() { }

	[CompilerGenerated]
	// RVA: 0x24AEDA4 Offset: 0x24AADA4 VA: 0x24AEDA4
	protected void set_ActionRange(float value) { }

	// RVA: 0x24AEDAC Offset: 0x24AADAC VA: 0x24AEDAC
	public int get_MotionSpeed() { }

	// RVA: 0x24AEDCC Offset: 0x24AADCC VA: 0x24AEDCC
	protected void set_MotionSpeed(int value) { }

	[CompilerGenerated]
	// RVA: 0x24AEDD4 Offset: 0x24AADD4 VA: 0x24AEDD4
	public int get_LoopParam() { }

	[CompilerGenerated]
	// RVA: 0x24AEDDC Offset: 0x24AADDC VA: 0x24AEDDC
	protected void set_LoopParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x24AEDE4 Offset: 0x24AADE4 VA: 0x24AEDE4
	public float get_Delay() { }

	[CompilerGenerated]
	// RVA: 0x24AEDEC Offset: 0x24AADEC VA: 0x24AEDEC
	protected void set_Delay(float value) { }

	[CompilerGenerated]
	// RVA: 0x24AEDF4 Offset: 0x24AADF4 VA: 0x24AEDF4
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x24AEDFC Offset: 0x24AADFC VA: 0x24AEDFC
	protected void set_Element(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x24AEE04 Offset: 0x24AAE04 VA: 0x24AEE04
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x24AEE0C Offset: 0x24AAE0C VA: 0x24AEE0C
	protected void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24AEE18 Offset: 0x24AAE18 VA: 0x24AEE18
	public float get_Radius() { }

	[CompilerGenerated]
	// RVA: 0x24AEE20 Offset: 0x24AAE20 VA: 0x24AEE20
	protected void set_Radius(float value) { }

	// RVA: 0x24AEE28 Offset: 0x24AAE28 VA: 0x24AEE28
	public List<BlackKnightSkillActionBase.DamageData> get_TargetDamageData() { }

	// RVA: 0x24AEE30 Offset: 0x24AAE30 VA: 0x24AEE30 Slot: 9
	public virtual bool get_IsChatLog() { }

	[CompilerGenerated]
	// RVA: 0x24AEE38 Offset: 0x24AAE38 VA: 0x24AEE38
	public GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x24AEE40 Offset: 0x24AAE40 VA: 0x24AEE40
	protected void set_Target(GameObject value) { }

	// RVA: 0x24AEE48 Offset: 0x24AAE48 VA: 0x24AEE48
	public List<BlackKnightHitAreaData> get_HitAreaList() { }

	// RVA: 0x24A2EB4 Offset: 0x249EEB4 VA: 0x24A2EB4
	protected void .ctor() { }

	// RVA: 0x24AEE50 Offset: 0x24AAE50 VA: 0x24AEE50
	public void SetId(int id) { }

	// RVA: 0x24A4AFC Offset: 0x24A0AFC VA: 0x24A4AFC
	public void Initialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24AEE64 Offset: 0x24AAE64 VA: 0x24AEE64 Slot: 10
	protected virtual void InitializeElement(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24AEE68 Offset: 0x24AAE68 VA: 0x24AEE68 Slot: 11
	protected virtual void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24A2D5C Offset: 0x249ED5C VA: 0x24A2D5C Slot: 12
	public virtual void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24A2B24 Offset: 0x249EB24 VA: 0x24A2B24 Slot: 13
	public virtual void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24AEE6C Offset: 0x24AAE6C VA: 0x24AEE6C Slot: 14
	public virtual void ActionHit(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24AEE70 Offset: 0x24AAE70 VA: 0x24AEE70 Slot: 15
	public virtual void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24AEE74 Offset: 0x24AAE74 VA: 0x24AEE74 Slot: 16
	public virtual bool ActionSkillEndCheck(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24AEE7C Offset: 0x24AAE7C VA: 0x24AEE7C
	public void End() { }

	// RVA: 0x24AEEA4 Offset: 0x24AAEA4 VA: 0x24AEEA4 Slot: 17
	protected virtual void OnEnd() { }

	// RVA: 0x24AEEA8 Offset: 0x24AAEA8 VA: 0x24AEEA8
	public void MotionEnd() { }

	// RVA: 0x24AEEB8 Offset: 0x24AAEB8 VA: 0x24AEEB8 Slot: 18
	protected virtual void OnMotionEnd() { }

	// RVA: 0x24AEEBC Offset: 0x24AAEBC VA: 0x24AEEBC
	public void SetMotionSpeed(int speed) { }

	// RVA: 0x24A4278 Offset: 0x24A0278 VA: 0x24A4278
	public void CalcDamage(BlackKnightCharacterManagerBase actarAction, BlackKnightCharacterManagerBase targetAction) { }

	// RVA: 0x24AEEC4 Offset: 0x24AAEC4 VA: 0x24AEEC4 Slot: 19
	protected virtual void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AEEC8 Offset: 0x24AAEC8 VA: 0x24AEEC8 Slot: 20
	protected virtual void calcMobToPlayerDamage(BlackKnightMobManagerBase mobAction, BlackKnightPlayerManager playerAction) { }

	// RVA: 0x24AEECC Offset: 0x24AAECC VA: 0x24AEECC Slot: 21
	protected virtual BlackKnightSkillActionBase.DamageData templateToDamageData(BlackKnightSkillActionBase.DamageData damageData, BlackKnightCharacterManagerBase charaMng, int damage, bool isCritical) { }

	// RVA: 0x24AEED4 Offset: 0x24AAED4 VA: 0x24AEED4
	public void SetHitAreaList(List<BlackKnightHitAreaData> hitArea, GameObject obj) { }

	// RVA: 0x24AF040 Offset: 0x24AB040 VA: 0x24AF040
	protected void UpdateHitAreaPos() { }

	// RVA: 0x24AE4E4 Offset: 0x24AA4E4 VA: 0x24AE4E4
	public bool GetIsEndHitCheck() { }

	// RVA: 0x24AE888 Offset: 0x24AA888 VA: 0x24AE888 Slot: 22
	public virtual void NextRangeHit() { }

	// RVA: 0x24AF188 Offset: 0x24AB188 VA: 0x24AF188
	protected bool checkPercent(int max, int per) { }

	// RVA: 0x24A3990 Offset: 0x249F990 VA: 0x24A3990
	public static bool op_Equality(BlackKnightSkillActionBase x, BlackKnightSkillActionBase y) { }

	// RVA: 0x24ABA68 Offset: 0x24A7A68 VA: 0x24ABA68
	public static bool op_Inequality(BlackKnightSkillActionBase x, BlackKnightSkillActionBase y) { }

	// RVA: 0x24AF1F8 Offset: 0x24AB1F8 VA: 0x24AF1F8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24AF2A0 Offset: 0x24AB2A0 VA: 0x24AF2A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24AF1AC Offset: 0x24AB1AC VA: 0x24AF1AC Slot: 4
	public bool Equals(BlackKnightSkillActionBase other) { }
}

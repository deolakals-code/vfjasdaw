// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMemberAITactical // TypeDefIndex: 408
{
	// Fields
	protected SkillManager skillManager; // 0x10
	protected CharacterActionManagerBase actionManager; // 0x18
	protected PlayerStatusBase autoPlayerStatus; // 0x20
	protected PlayerStatusBase playerStatus; // 0x28
	protected List<Trio<AIActionCondition, SkillId, byte>> commandPattern; // 0x30
	private SkillId firstSkillId; // 0x38
	[CompilerGenerated]
	private bool <isFirstSkill>k__BackingField; // 0x3C
	[CompilerGenerated]
	private SkillId <DefaultSkillID>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <TacticalValue>k__BackingField; // 0x44

	// Properties
	public bool isFirstSkill { get; set; }
	public SkillId DefaultSkillID { get; set; }
	private int TacticalValue { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x173B560 Offset: 0x1737560 VA: 0x173B560
	public bool get_isFirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x173B568 Offset: 0x1737568 VA: 0x173B568
	private void set_isFirstSkill(bool value) { }

	[CompilerGenerated]
	// RVA: 0x173B574 Offset: 0x1737574 VA: 0x173B574
	public SkillId get_DefaultSkillID() { }

	[CompilerGenerated]
	// RVA: 0x173B57C Offset: 0x173757C VA: 0x173B57C
	public void set_DefaultSkillID(SkillId value) { }

	[CompilerGenerated]
	// RVA: 0x173B584 Offset: 0x1737584 VA: 0x173B584
	public void set_TacticalValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x173B58C Offset: 0x173758C VA: 0x173B58C
	private int get_TacticalValue() { }

	// RVA: 0x173B594 Offset: 0x1737594 VA: 0x173B594
	public void Initialize(SkillManager skill, PlayerStatusBase autoStatus, PlayerStatusBase playerStatus, CharacterActionManagerBase charaActionManager, bool isUsedFirstSkill) { }

	// RVA: 0x173B608 Offset: 0x1737608 VA: 0x173B608 Slot: 4
	public virtual void InitializePattern(SkillId firstSkillId, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x173B7C4 Offset: 0x17377C4 VA: 0x173B7C4 Slot: 5
	public virtual void InitializePattern(Trio<int, int, byte>[] pattern) { }

	// RVA: 0x173B978 Offset: 0x1737978 VA: 0x173B978 Slot: 6
	public virtual void Reset() { }

	// RVA: 0x173B97C Offset: 0x173797C VA: 0x173B97C Slot: 7
	public virtual SkillId GetSkillId(out byte lv) { }

	// RVA: 0x173C15C Offset: 0x173815C VA: 0x173C15C
	public void UsedFirstSkill() { }

	// RVA: 0x173BB54 Offset: 0x1737B54 VA: 0x173BB54
	protected bool checkCondition(AIActionCondition condition, SkillId skillId, byte skillLv) { }

	// RVA: 0x173CA28 Offset: 0x1738A28 VA: 0x173CA28
	private bool TacticalValueActionOff(bool ret, int bit) { }

	// RVA: 0x173C164 Offset: 0x1738164 VA: 0x173C164
	protected bool checkHpRateInPartyMember(int rate) { }

	// RVA: 0x173C4B0 Offset: 0x17384B0 VA: 0x173C4B0
	protected bool checkDeadInPartyMember(int people) { }

	// RVA: 0x173CA74 Offset: 0x1738A74 VA: 0x173CA74
	public void SetCommnadSkill(Trio<AIActionCondition, SkillId, byte>[] data) { }

	// RVA: 0x173CB04 Offset: 0x1738B04 VA: 0x173CB04
	public void SetCommandSkill(int no, Trio<AIActionCondition, SkillId, byte> data) { }

	// RVA: 0x173CB6C Offset: 0x1738B6C VA: 0x173CB6C
	public void SetTacticalValue(int val) { }

	// RVA: 0x173CB74 Offset: 0x1738B74 VA: 0x173CB74
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class AutoMemberAIAction // TypeDefIndex: 399
{
	// Fields
	private SkillBufferManager skillBufferManager; // 0x10
	protected PlayerStatusBase playerStatus; // 0x18
	protected AutoMemberBattleManager battleManager; // 0x20
	protected AutoMemberActionManager actionManager; // 0x28
	protected AutoMemberAITactical aiTactical; // 0x30
	protected AutoMemberAILoop aiLoop; // 0x38
	[CompilerGenerated]
	private bool <IsFirstSkill>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsUsedFirstSkill>k__BackingField; // 0x41
	private SkillId firstSkillId; // 0x44
	protected bool isLoopSkillReserved; // 0x48
	private SkillId defaultSkillID; // 0x4C

	// Properties
	public bool IsFirstSkill { get; set; }
	public bool IsUsedFirstSkill { get; set; }
	public SkillId DefaultSkillID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2560C24 Offset: 0x255CC24 VA: 0x2560C24
	public bool get_IsFirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x2560C2C Offset: 0x255CC2C VA: 0x2560C2C
	public void set_IsFirstSkill(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2560C38 Offset: 0x255CC38 VA: 0x2560C38
	public bool get_IsUsedFirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x2560C40 Offset: 0x255CC40 VA: 0x2560C40
	private void set_IsUsedFirstSkill(bool value) { }

	// RVA: 0x2560C4C Offset: 0x255CC4C VA: 0x2560C4C
	public SkillId get_DefaultSkillID() { }

	// RVA: 0x2560C54 Offset: 0x255CC54 VA: 0x2560C54
	public void set_DefaultSkillID(SkillId value) { }

	// RVA: 0x2560C80 Offset: 0x255CC80 VA: 0x2560C80
	public void Initialize(AutoMemberBattleManager battle, AutoMemberActionManager action, PlayerStatusBase avatarStatus, SkillId firstSkillId, bool isUsedFirstSkill) { }

	// RVA: 0x2560CE4 Offset: 0x255CCE4 VA: 0x2560CE4
	public void InitializeAI(AutoMemberAITactical tactial, AutoMemberAILoop loop) { }

	// RVA: 0x2560D4C Offset: 0x255CD4C VA: 0x2560D4C
	public void InitializeAIMercenary(AutoMemberAITactical tactical, AutoMemberAILoop loop, SkillBufferManager skillBuffer) { }

	// RVA: 0x2560D90 Offset: 0x255CD90 VA: 0x2560D90
	public void Reset() { }

	// RVA: 0x2560DC8 Offset: 0x255CDC8 VA: 0x2560DC8
	public AIActionType GetAction() { }

	// RVA: 0x2560DF0 Offset: 0x255CDF0 VA: 0x2560DF0 Slot: 4
	public virtual SkillActionBase GetSkillActionBase() { }

	// RVA: 0x25611A0 Offset: 0x255D1A0 VA: 0x25611A0
	public bool UsedLoopAction() { }

	// RVA: 0x2561270 Offset: 0x255D270 VA: 0x2561270 Slot: 5
	public virtual GameObject GetLowestHpMember() { }

	// RVA: 0x2561788 Offset: 0x255D788 VA: 0x2561788
	public GameObject GetNearDeadPartyMember(Transform trans) { }

	// RVA: 0x25610F8 Offset: 0x255D0F8 VA: 0x25610F8
	private bool IsCheckNeedChargeSkill(SkillId skillId) { }

	// RVA: 0x256118C Offset: 0x255D18C VA: 0x256118C
	private bool HaveChargingSkillBuff(SkillId skillId) { }

	// RVA: 0x255E400 Offset: 0x255A400 VA: 0x255E400
	public void .ctor() { }
}

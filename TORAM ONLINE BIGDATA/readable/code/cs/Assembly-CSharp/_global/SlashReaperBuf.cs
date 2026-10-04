// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SlashReaperBuf : CountBufferBase // TypeDefIndex: 3312
{
	// Fields
	[CompilerGenerated]
	private bool <EnableCounter>k__BackingField; // 0x28
	private int pointCount; // 0x2C
	private PlayerActionManagerBase playerAction; // 0x30
	private PlayerBattleManager battleManager; // 0x38
	private SkillComboType comboType; // 0x40
	private int comboRate; // 0x44
	private SlashReaperAction slashReaper; // 0x48

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool EnableCounter { get; set; }
	public ElementType Element { get; }

	// Methods

	// RVA: 0x23454EC Offset: 0x23414EC VA: 0x23454EC Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23454F4 Offset: 0x23414F4 VA: 0x23454F4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23454FC Offset: 0x23414FC VA: 0x23454FC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x2345528 Offset: 0x2341528 VA: 0x2345528
	public bool get_EnableCounter() { }

	[CompilerGenerated]
	// RVA: 0x2345530 Offset: 0x2341530 VA: 0x2345530
	private void set_EnableCounter(bool value) { }

	// RVA: 0x234553C Offset: 0x234153C VA: 0x234553C
	public ElementType get_Element() { }

	// RVA: 0x2345578 Offset: 0x2341578 VA: 0x2345578
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x234568C Offset: 0x234168C VA: 0x234568C
	public bool SetAction(SlashReaperAction action) { }

	// RVA: 0x23456C4 Offset: 0x23416C4 VA: 0x23456C4 Slot: 11
	public override void Updata() { }

	// RVA: 0x23456EC Offset: 0x23416EC VA: 0x23456EC
	private void StartSkill() { }

	// RVA: 0x234587C Offset: 0x234187C VA: 0x234587C
	private void UpdateBradeNum() { }

	// RVA: 0x23458C4 Offset: 0x23418C4 VA: 0x23458C4 Slot: 23
	public override void Next() { }

	// RVA: 0x234592C Offset: 0x234192C VA: 0x234592C
	public void SetComboParam(SkillComboType type, int rate) { }

	// RVA: 0x2345934 Offset: 0x2341934 VA: 0x2345934
	public void GetComboParam(out SkillComboType type, out int rate) { }

	// RVA: 0x2345948 Offset: 0x2341948 VA: 0x2345948 Slot: 17
	public override void OnLeave() { }

	// RVA: 0x234595C Offset: 0x234195C VA: 0x234595C
	public static void UpdateCount(PlayerActionManagerBase actorActionManager, SkillActionBase action, CharacterActionManagerBase target, SkillDamageData damageData, bool isFirst) { }

	// RVA: 0x2345BDC Offset: 0x2341BDC VA: 0x2345BDC
	public static void ReceivedAbnormal(PlayerActionManagerBase playerAction, AbnormalType abnormalType) { }

	// RVA: 0x2345D68 Offset: 0x2341D68 VA: 0x2345D68
	public void DamagedMagicalExplosion() { }

	// RVA: 0x2345DF0 Offset: 0x2341DF0 VA: 0x2345DF0
	public void BufferEnd() { }
}

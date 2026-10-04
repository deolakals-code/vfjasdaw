// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Partners
public class PartnerData : CompanionData // TypeDefIndex: 12944
{
	// Fields
	[CompilerGenerated]
	private PartnerStatusData <Status>k__BackingField; // 0x38
	[CompilerGenerated]
	private PartnerGameStatusData <GameStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private CompanionBattleStatusData <BattleStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x50

	// Properties
	public PartnerStatusData Status { get; set; }
	public PartnerGameStatusData GameStatus { get; set; }
	public CompanionBattleStatusData BattleStatus { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367D65C Offset: 0x367965C VA: 0x367D65C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367E564 Offset: 0x367A564 VA: 0x367E564
	public PartnerStatusData get_Status() { }

	[CompilerGenerated]
	// RVA: 0x367E56C Offset: 0x367A56C VA: 0x367E56C
	public void set_Status(PartnerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367E574 Offset: 0x367A574 VA: 0x367E574
	public PartnerGameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x367E57C Offset: 0x367A57C VA: 0x367E57C
	public void set_GameStatus(PartnerGameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367E584 Offset: 0x367A584 VA: 0x367E584
	public CompanionBattleStatusData get_BattleStatus() { }

	[CompilerGenerated]
	// RVA: 0x367E58C Offset: 0x367A58C VA: 0x367E58C
	public void set_BattleStatus(CompanionBattleStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367E594 Offset: 0x367A594 VA: 0x367E594
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x367E59C Offset: 0x367A59C VA: 0x367E59C
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x367E5A4 Offset: 0x367A5A4 VA: 0x367E5A4
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x367E8CC Offset: 0x367A8CC VA: 0x367E8CC
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x367EA28 Offset: 0x367AA28 VA: 0x367EA28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367EA30 Offset: 0x367AA30 VA: 0x367EA30 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x367EC00 Offset: 0x367AC00 VA: 0x367EC00 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

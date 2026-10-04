// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Mercenaries
public class MercenaryData : CompanionData // TypeDefIndex: 12967
{
	// Fields
	[CompilerGenerated]
	private MercenaryStatusData <Status>k__BackingField; // 0x38
	[CompilerGenerated]
	private MercenaryGameStatusData <GameStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private CompanionBattleStatusData <BattleStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x50
	[CompilerGenerated]
	private DateTime <UsageTime>k__BackingField; // 0x58

	// Properties
	public MercenaryStatusData Status { get; set; }
	public MercenaryGameStatusData GameStatus { get; set; }
	public CompanionBattleStatusData BattleStatus { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public DateTime UsageTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367D664 Offset: 0x3679664 VA: 0x367D664
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3683968 Offset: 0x367F968 VA: 0x3683968
	public MercenaryStatusData get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3683970 Offset: 0x367F970 VA: 0x3683970
	public void set_Status(MercenaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3683978 Offset: 0x367F978 VA: 0x3683978
	public MercenaryGameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3683980 Offset: 0x367F980 VA: 0x3683980
	public void set_GameStatus(MercenaryGameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3683988 Offset: 0x367F988 VA: 0x3683988
	public CompanionBattleStatusData get_BattleStatus() { }

	[CompilerGenerated]
	// RVA: 0x3683990 Offset: 0x367F990 VA: 0x3683990
	public void set_BattleStatus(CompanionBattleStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3683998 Offset: 0x367F998 VA: 0x3683998
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x36839A0 Offset: 0x367F9A0 VA: 0x36839A0
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x36839A8 Offset: 0x367F9A8 VA: 0x36839A8
	public DateTime get_UsageTime() { }

	[CompilerGenerated]
	// RVA: 0x36839B0 Offset: 0x367F9B0 VA: 0x36839B0
	public void set_UsageTime(DateTime value) { }

	// RVA: 0x36839B8 Offset: 0x367F9B8 VA: 0x36839B8
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3683CD8 Offset: 0x367FCD8 VA: 0x3683CD8
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3683E34 Offset: 0x367FE34 VA: 0x3683E34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3683E3C Offset: 0x367FE3C VA: 0x3683E3C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x368409C Offset: 0x368009C VA: 0x368409C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

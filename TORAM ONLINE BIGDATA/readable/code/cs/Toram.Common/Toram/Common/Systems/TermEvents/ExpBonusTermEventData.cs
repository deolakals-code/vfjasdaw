// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.TermEvents
public class ExpBonusTermEventData : TermEventData // TypeDefIndex: 11254
{
	// Fields
	[CompilerGenerated]
	private short <BonusLevelLimit>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <LevelBonus>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <PartyBonus>k__BackingField; // 0x38

	// Properties
	public override int EventId { get; }
	public short BonusLevelLimit { get; set; }
	public int LevelBonus { get; set; }
	public int PartyBonus { get; set; }

	// Methods

	// RVA: 0x36D01CC Offset: 0x36CC1CC VA: 0x36D01CC
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36D01D4 Offset: 0x36CC1D4 VA: 0x36D01D4 Slot: 8
	public override int get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x36D01DC Offset: 0x36CC1DC VA: 0x36D01DC
	public short get_BonusLevelLimit() { }

	[CompilerGenerated]
	// RVA: 0x36D01E4 Offset: 0x36CC1E4 VA: 0x36D01E4
	private void set_BonusLevelLimit(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D01EC Offset: 0x36CC1EC VA: 0x36D01EC
	public int get_LevelBonus() { }

	[CompilerGenerated]
	// RVA: 0x36D01F4 Offset: 0x36CC1F4 VA: 0x36D01F4
	private void set_LevelBonus(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D01FC Offset: 0x36CC1FC VA: 0x36D01FC
	public int get_PartyBonus() { }

	[CompilerGenerated]
	// RVA: 0x36D0204 Offset: 0x36CC204 VA: 0x36D0204
	private void set_PartyBonus(int value) { }

	// RVA: 0x36D020C Offset: 0x36CC20C VA: 0x36D020C Slot: 9
	protected override void GetBinaryParams(MemoryStream ms) { }

	// RVA: 0x36D0258 Offset: 0x36CC258 VA: 0x36D0258 Slot: 10
	protected override void SetValueParams(MemoryStream ms) { }
}

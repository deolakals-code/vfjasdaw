// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class BossResultData : PacketBase // TypeDefIndex: 13149
{
	// Fields
	[CompilerGenerated]
	private byte <AttackerRank>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <DefenderRank>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <SupporterRank>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte <BreakerRank>k__BackingField; // 0x23
	[CompilerGenerated]
	private byte <AssisterRank>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <AttackerPercent>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <DefenderPercent>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <SupporterPercent>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <BreakerPercent>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte[] <AssisterPercent>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <DeadCount>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <ResultItemId>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <Money>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <Time>k__BackingField; // 0x5C
	[CompilerGenerated]
	private byte[] <TopRankIndex>k__BackingField; // 0x60
	[CompilerGenerated]
	private BossResultTopRankData[] <TopRankData>k__BackingField; // 0x68
	[CompilerGenerated]
	private byte <MemberNumber>k__BackingField; // 0x70

	// Properties
	public override byte Code { get; }
	public byte AttackerRank { get; set; }
	public byte DefenderRank { get; set; }
	public byte SupporterRank { get; set; }
	public byte BreakerRank { get; set; }
	public byte AssisterRank { get; set; }
	public byte[] AttackerPercent { get; set; }
	public byte[] DefenderPercent { get; set; }
	public byte[] SupporterPercent { get; set; }
	public byte[] BreakerPercent { get; set; }
	public byte[] AssisterPercent { get; set; }
	public byte DeadCount { get; set; }
	public int ResultItemId { get; set; }
	public int Money { get; set; }
	public int Time { get; set; }
	public byte[] TopRankIndex { get; set; }
	public BossResultTopRankData[] TopRankData { get; set; }
	public byte MemberNumber { get; set; }

	// Methods

	// RVA: 0x36B431C Offset: 0x36B031C VA: 0x36B431C
	public void .ctor() { }

	// RVA: 0x36B4324 Offset: 0x36B0324 VA: 0x36B4324
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36B432C Offset: 0x36B032C VA: 0x36B432C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36B4334 Offset: 0x36B0334 VA: 0x36B4334
	public byte get_AttackerRank() { }

	[CompilerGenerated]
	// RVA: 0x36B433C Offset: 0x36B033C VA: 0x36B433C
	public void set_AttackerRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B4344 Offset: 0x36B0344 VA: 0x36B4344
	public byte get_DefenderRank() { }

	[CompilerGenerated]
	// RVA: 0x36B434C Offset: 0x36B034C VA: 0x36B434C
	public void set_DefenderRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B4354 Offset: 0x36B0354 VA: 0x36B4354
	public byte get_SupporterRank() { }

	[CompilerGenerated]
	// RVA: 0x36B435C Offset: 0x36B035C VA: 0x36B435C
	public void set_SupporterRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B4364 Offset: 0x36B0364 VA: 0x36B4364
	public byte get_BreakerRank() { }

	[CompilerGenerated]
	// RVA: 0x36B436C Offset: 0x36B036C VA: 0x36B436C
	public void set_BreakerRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B4374 Offset: 0x36B0374 VA: 0x36B4374
	public byte get_AssisterRank() { }

	[CompilerGenerated]
	// RVA: 0x36B437C Offset: 0x36B037C VA: 0x36B437C
	public void set_AssisterRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B4384 Offset: 0x36B0384 VA: 0x36B4384
	public byte[] get_AttackerPercent() { }

	[CompilerGenerated]
	// RVA: 0x36B438C Offset: 0x36B038C VA: 0x36B438C
	public void set_AttackerPercent(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B4394 Offset: 0x36B0394 VA: 0x36B4394
	public byte[] get_DefenderPercent() { }

	[CompilerGenerated]
	// RVA: 0x36B439C Offset: 0x36B039C VA: 0x36B439C
	public void set_DefenderPercent(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B43A4 Offset: 0x36B03A4 VA: 0x36B43A4
	public byte[] get_SupporterPercent() { }

	[CompilerGenerated]
	// RVA: 0x36B43AC Offset: 0x36B03AC VA: 0x36B43AC
	public void set_SupporterPercent(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B43B4 Offset: 0x36B03B4 VA: 0x36B43B4
	public byte[] get_BreakerPercent() { }

	[CompilerGenerated]
	// RVA: 0x36B43BC Offset: 0x36B03BC VA: 0x36B43BC
	public void set_BreakerPercent(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B43C4 Offset: 0x36B03C4 VA: 0x36B43C4
	public byte[] get_AssisterPercent() { }

	[CompilerGenerated]
	// RVA: 0x36B43CC Offset: 0x36B03CC VA: 0x36B43CC
	public void set_AssisterPercent(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B43D4 Offset: 0x36B03D4 VA: 0x36B43D4
	public byte get_DeadCount() { }

	[CompilerGenerated]
	// RVA: 0x36B43DC Offset: 0x36B03DC VA: 0x36B43DC
	public void set_DeadCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B43E4 Offset: 0x36B03E4 VA: 0x36B43E4
	public int get_ResultItemId() { }

	[CompilerGenerated]
	// RVA: 0x36B43EC Offset: 0x36B03EC VA: 0x36B43EC
	public void set_ResultItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B43F4 Offset: 0x36B03F4 VA: 0x36B43F4
	public int get_Money() { }

	[CompilerGenerated]
	// RVA: 0x36B43FC Offset: 0x36B03FC VA: 0x36B43FC
	public void set_Money(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B4404 Offset: 0x36B0404 VA: 0x36B4404
	public int get_Time() { }

	[CompilerGenerated]
	// RVA: 0x36B440C Offset: 0x36B040C VA: 0x36B440C
	public void set_Time(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B4414 Offset: 0x36B0414 VA: 0x36B4414
	public byte[] get_TopRankIndex() { }

	[CompilerGenerated]
	// RVA: 0x36B441C Offset: 0x36B041C VA: 0x36B441C
	public void set_TopRankIndex(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B4424 Offset: 0x36B0424 VA: 0x36B4424
	public BossResultTopRankData[] get_TopRankData() { }

	[CompilerGenerated]
	// RVA: 0x36B442C Offset: 0x36B042C VA: 0x36B442C
	public void set_TopRankData(BossResultTopRankData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B4434 Offset: 0x36B0434 VA: 0x36B4434
	public byte get_MemberNumber() { }

	[CompilerGenerated]
	// RVA: 0x36B443C Offset: 0x36B043C VA: 0x36B443C
	public void set_MemberNumber(byte value) { }

	// RVA: 0x36B4444 Offset: 0x36B0444 VA: 0x36B4444 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36B4CF0 Offset: 0x36B0CF0 VA: 0x36B4CF0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.ScoreAttack
public class ScoreAttackGetRankingResponse : OperationResponseBase // TypeDefIndex: 11732
{
	// Fields
	[CompilerGenerated]
	private ScoreAttackMyRankData_Solo <MyRank_Solo>k__BackingField; // 0x20
	[CompilerGenerated]
	private ScoreAttackRankingSendData_Solo[] <RankingList_Solo>k__BackingField; // 0x28
	[CompilerGenerated]
	private ScoreAttackMyRankData_Roll <MyRank_Roll>k__BackingField; // 0x30
	[CompilerGenerated]
	private ScoreAttackRankingSendData_Roll[] <RankingList_Roll>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ElapsedMinutes>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <Period>k__BackingField; // 0x42

	// Properties
	public ScoreAttackMyRankData_Solo MyRank_Solo { get; set; }
	public ScoreAttackRankingSendData_Solo[] RankingList_Solo { get; set; }
	public ScoreAttackMyRankData_Roll MyRank_Roll { get; set; }
	public ScoreAttackRankingSendData_Roll[] RankingList_Roll { get; set; }
	public short ElapsedMinutes { get; set; }
	public byte Period { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373E150 Offset: 0x373A150 VA: 0x373E150
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373E158 Offset: 0x373A158 VA: 0x373E158
	public ScoreAttackMyRankData_Solo get_MyRank_Solo() { }

	[CompilerGenerated]
	// RVA: 0x373E160 Offset: 0x373A160 VA: 0x373E160
	public void set_MyRank_Solo(ScoreAttackMyRankData_Solo value) { }

	[CompilerGenerated]
	// RVA: 0x373E168 Offset: 0x373A168 VA: 0x373E168
	public ScoreAttackRankingSendData_Solo[] get_RankingList_Solo() { }

	[CompilerGenerated]
	// RVA: 0x373E170 Offset: 0x373A170 VA: 0x373E170
	public void set_RankingList_Solo(ScoreAttackRankingSendData_Solo[] value) { }

	[CompilerGenerated]
	// RVA: 0x373E178 Offset: 0x373A178 VA: 0x373E178
	public ScoreAttackMyRankData_Roll get_MyRank_Roll() { }

	[CompilerGenerated]
	// RVA: 0x373E180 Offset: 0x373A180 VA: 0x373E180
	public void set_MyRank_Roll(ScoreAttackMyRankData_Roll value) { }

	[CompilerGenerated]
	// RVA: 0x373E188 Offset: 0x373A188 VA: 0x373E188
	public ScoreAttackRankingSendData_Roll[] get_RankingList_Roll() { }

	[CompilerGenerated]
	// RVA: 0x373E190 Offset: 0x373A190 VA: 0x373E190
	public void set_RankingList_Roll(ScoreAttackRankingSendData_Roll[] value) { }

	[CompilerGenerated]
	// RVA: 0x373E198 Offset: 0x373A198 VA: 0x373E198
	public short get_ElapsedMinutes() { }

	[CompilerGenerated]
	// RVA: 0x373E1A0 Offset: 0x373A1A0 VA: 0x373E1A0
	public void set_ElapsedMinutes(short value) { }

	[CompilerGenerated]
	// RVA: 0x373E1A8 Offset: 0x373A1A8 VA: 0x373E1A8
	public byte get_Period() { }

	[CompilerGenerated]
	// RVA: 0x373E1B0 Offset: 0x373A1B0 VA: 0x373E1B0
	public void set_Period(byte value) { }

	// RVA: 0x373E1B8 Offset: 0x373A1B8 VA: 0x373E1B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373E1C0 Offset: 0x373A1C0 VA: 0x373E1C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373E1C8 Offset: 0x373A1C8 VA: 0x373E1C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373E3B4 Offset: 0x373A3B4 VA: 0x373E3B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

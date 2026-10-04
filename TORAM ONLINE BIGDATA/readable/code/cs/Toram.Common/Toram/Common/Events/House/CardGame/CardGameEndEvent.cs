// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameEndEvent : EventSubBase // TypeDefIndex: 12830
{
	// Fields
	[CompilerGenerated]
	private CardGameTurnCardData[] <AllTurnData>k__BackingField; // 0x20
	[CompilerGenerated]
	private CardGameTurnTableData <TableData>k__BackingField; // 0x28
	[CompilerGenerated]
	private CardGameResultData <ResultData>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<int, short> <AccumulationScore>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <MyRate>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <AccumulationCount>k__BackingField; // 0x44
	[CompilerGenerated]
	private short <HighestScore>k__BackingField; // 0x46
	[CompilerGenerated]
	private bool <IsRateValid>k__BackingField; // 0x48

	// Properties
	public CardGameTurnCardData[] AllTurnData { get; set; }
	public CardGameTurnTableData TableData { get; set; }
	public CardGameResultData ResultData { get; set; }
	public Dictionary<int, short> AccumulationScore { get; set; }
	public int MyRate { get; set; }
	public byte AccumulationCount { get; set; }
	public short HighestScore { get; set; }
	public bool IsRateValid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3663920 Offset: 0x365F920 VA: 0x3663920
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3663928 Offset: 0x365F928 VA: 0x3663928
	public CardGameTurnCardData[] get_AllTurnData() { }

	[CompilerGenerated]
	// RVA: 0x3663930 Offset: 0x365F930 VA: 0x3663930
	public void set_AllTurnData(CardGameTurnCardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3663938 Offset: 0x365F938 VA: 0x3663938
	public CardGameTurnTableData get_TableData() { }

	[CompilerGenerated]
	// RVA: 0x3663940 Offset: 0x365F940 VA: 0x3663940
	public void set_TableData(CardGameTurnTableData value) { }

	[CompilerGenerated]
	// RVA: 0x3663948 Offset: 0x365F948 VA: 0x3663948
	public CardGameResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x3663950 Offset: 0x365F950 VA: 0x3663950
	public void set_ResultData(CardGameResultData value) { }

	[CompilerGenerated]
	// RVA: 0x3663958 Offset: 0x365F958 VA: 0x3663958
	public Dictionary<int, short> get_AccumulationScore() { }

	[CompilerGenerated]
	// RVA: 0x3663960 Offset: 0x365F960 VA: 0x3663960
	public void set_AccumulationScore(Dictionary<int, short> value) { }

	[CompilerGenerated]
	// RVA: 0x3663968 Offset: 0x365F968 VA: 0x3663968
	public int get_MyRate() { }

	[CompilerGenerated]
	// RVA: 0x3663970 Offset: 0x365F970 VA: 0x3663970
	public void set_MyRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x3663978 Offset: 0x365F978 VA: 0x3663978
	public byte get_AccumulationCount() { }

	[CompilerGenerated]
	// RVA: 0x3663980 Offset: 0x365F980 VA: 0x3663980
	public void set_AccumulationCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3663988 Offset: 0x365F988 VA: 0x3663988
	public short get_HighestScore() { }

	[CompilerGenerated]
	// RVA: 0x3663990 Offset: 0x365F990 VA: 0x3663990
	public void set_HighestScore(short value) { }

	[CompilerGenerated]
	// RVA: 0x3663998 Offset: 0x365F998 VA: 0x3663998
	public bool get_IsRateValid() { }

	[CompilerGenerated]
	// RVA: 0x36639A0 Offset: 0x365F9A0 VA: 0x36639A0
	public void set_IsRateValid(bool value) { }

	// RVA: 0x36639AC Offset: 0x365F9AC VA: 0x36639AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36639B4 Offset: 0x365F9B4 VA: 0x36639B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36639BC Offset: 0x365F9BC VA: 0x36639BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3663E6C Offset: 0x365FE6C VA: 0x3663E6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

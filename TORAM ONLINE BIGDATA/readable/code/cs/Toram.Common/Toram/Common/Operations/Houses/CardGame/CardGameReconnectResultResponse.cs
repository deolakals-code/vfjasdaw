// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameReconnectResultResponse : OperationResponseBase // TypeDefIndex: 12273
{
	// Fields
	[CompilerGenerated]
	private CardGameResultData <ResultData>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<int, short> <AccumulationScore>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <MyRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <AccumulationCount>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <HighestScore>k__BackingField; // 0x36
	[CompilerGenerated]
	private bool <IsRateValid>k__BackingField; // 0x38

	// Properties
	public CardGameResultData ResultData { get; set; }
	public Dictionary<int, short> AccumulationScore { get; set; }
	public int MyRate { get; set; }
	public byte AccumulationCount { get; set; }
	public short HighestScore { get; set; }
	public bool IsRateValid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EA4A8 Offset: 0x35E64A8 VA: 0x35EA4A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EA4B0 Offset: 0x35E64B0 VA: 0x35EA4B0
	public CardGameResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x35EA4B8 Offset: 0x35E64B8 VA: 0x35EA4B8
	public void set_ResultData(CardGameResultData value) { }

	[CompilerGenerated]
	// RVA: 0x35EA4C0 Offset: 0x35E64C0 VA: 0x35EA4C0
	public Dictionary<int, short> get_AccumulationScore() { }

	[CompilerGenerated]
	// RVA: 0x35EA4C8 Offset: 0x35E64C8 VA: 0x35EA4C8
	public void set_AccumulationScore(Dictionary<int, short> value) { }

	[CompilerGenerated]
	// RVA: 0x35EA4D0 Offset: 0x35E64D0 VA: 0x35EA4D0
	public int get_MyRate() { }

	[CompilerGenerated]
	// RVA: 0x35EA4D8 Offset: 0x35E64D8 VA: 0x35EA4D8
	public void set_MyRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EA4E0 Offset: 0x35E64E0 VA: 0x35EA4E0
	public byte get_AccumulationCount() { }

	[CompilerGenerated]
	// RVA: 0x35EA4E8 Offset: 0x35E64E8 VA: 0x35EA4E8
	public void set_AccumulationCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35EA4F0 Offset: 0x35E64F0 VA: 0x35EA4F0
	public short get_HighestScore() { }

	[CompilerGenerated]
	// RVA: 0x35EA4F8 Offset: 0x35E64F8 VA: 0x35EA4F8
	public void set_HighestScore(short value) { }

	[CompilerGenerated]
	// RVA: 0x35EA500 Offset: 0x35E6500 VA: 0x35EA500
	public bool get_IsRateValid() { }

	[CompilerGenerated]
	// RVA: 0x35EA508 Offset: 0x35E6508 VA: 0x35EA508
	public void set_IsRateValid(bool value) { }

	// RVA: 0x35EA514 Offset: 0x35E6514 VA: 0x35EA514 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EA51C Offset: 0x35E651C VA: 0x35EA51C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EA524 Offset: 0x35E6524 VA: 0x35EA524 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EA8A0 Offset: 0x35E68A0 VA: 0x35EA8A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

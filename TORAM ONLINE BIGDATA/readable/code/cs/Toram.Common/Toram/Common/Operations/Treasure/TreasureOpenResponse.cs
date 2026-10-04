// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Treasure
public class TreasureOpenResponse : OperationResponseBase // TypeDefIndex: 11394
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <KeyNum>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <LapseSecond>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <TreasureNo>k__BackingField; // 0x30

	// Properties
	public RewardResponseDatav2 RewardData { get; set; }
	public int KeyNum { get; set; }
	public int LapseSecond { get; set; }
	public byte TreasureNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37003F4 Offset: 0x36FC3F4 VA: 0x37003F4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37003FC Offset: 0x36FC3FC VA: 0x37003FC
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x3700404 Offset: 0x36FC404 VA: 0x3700404
	public void set_RewardData(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x370040C Offset: 0x36FC40C VA: 0x370040C
	public int get_KeyNum() { }

	[CompilerGenerated]
	// RVA: 0x3700414 Offset: 0x36FC414 VA: 0x3700414
	public void set_KeyNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x370041C Offset: 0x36FC41C VA: 0x370041C
	public int get_LapseSecond() { }

	[CompilerGenerated]
	// RVA: 0x3700424 Offset: 0x36FC424 VA: 0x3700424
	public void set_LapseSecond(int value) { }

	[CompilerGenerated]
	// RVA: 0x370042C Offset: 0x36FC42C VA: 0x370042C
	public byte get_TreasureNo() { }

	[CompilerGenerated]
	// RVA: 0x3700434 Offset: 0x36FC434 VA: 0x3700434
	public void set_TreasureNo(byte value) { }

	// RVA: 0x370043C Offset: 0x36FC43C VA: 0x370043C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3700444 Offset: 0x36FC444 VA: 0x3700444 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370044C Offset: 0x36FC44C VA: 0x370044C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37006E4 Offset: 0x36FC6E4 VA: 0x37006E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

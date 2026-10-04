// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class DailyDartsGameEnterResponse : OperationRequestBase // TypeDefIndex: 12009
{
	// Fields
	[CompilerGenerated]
	private byte <DartsNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardData[] <RewardItem>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 21)]
	public byte DartsNum { get; set; }
	[PacketClass(Code = 123, IsOptional = True)]
	public RewardData[] RewardItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37765D4 Offset: 0x37725D4 VA: 0x37765D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37765DC Offset: 0x37725DC VA: 0x37765DC
	public byte get_DartsNum() { }

	[CompilerGenerated]
	// RVA: 0x37765E4 Offset: 0x37725E4 VA: 0x37765E4
	public void set_DartsNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37765EC Offset: 0x37725EC VA: 0x37765EC
	public void set_RewardItem(RewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37765F4 Offset: 0x37725F4 VA: 0x37765F4
	public RewardData[] get_RewardItem() { }

	// RVA: 0x37765FC Offset: 0x37725FC VA: 0x37765FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3776604 Offset: 0x3772604 VA: 0x3776604 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377660C Offset: 0x377260C VA: 0x377660C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37767DC Offset: 0x37727DC VA: 0x37767DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

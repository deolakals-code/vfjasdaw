// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Exchange
public class ExchangeRunResponse : OperationResponseBase // TypeDefIndex: 11666
{
	// Fields
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UsedTotalPoint>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ExchangeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ExchangeNo>k__BackingField; // 0x2A
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<short, byte> <UpdateRewardList>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <UsedTotalItemA>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <UsedTotalItemB>k__BackingField; // 0x44
	[CompilerGenerated]
	private int <UsedTotalItemC>k__BackingField; // 0x48

	// Properties
	public int Point { get; set; }
	public int UsedTotalPoint { get; set; }
	public short ExchangeId { get; set; }
	public short ExchangeNo { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public Dictionary<short, byte> UpdateRewardList { get; set; }
	public int UsedTotalItemA { get; set; }
	public int UsedTotalItemB { get; set; }
	public int UsedTotalItemC { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372DF58 Offset: 0x3729F58 VA: 0x372DF58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372DF60 Offset: 0x3729F60 VA: 0x372DF60
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x372DF68 Offset: 0x3729F68 VA: 0x372DF68
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x372DF70 Offset: 0x3729F70 VA: 0x372DF70
	public int get_UsedTotalPoint() { }

	[CompilerGenerated]
	// RVA: 0x372DF78 Offset: 0x3729F78 VA: 0x372DF78
	public void set_UsedTotalPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x372DF80 Offset: 0x3729F80 VA: 0x372DF80
	public short get_ExchangeId() { }

	[CompilerGenerated]
	// RVA: 0x372DF88 Offset: 0x3729F88 VA: 0x372DF88
	public void set_ExchangeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x372DF90 Offset: 0x3729F90 VA: 0x372DF90
	public short get_ExchangeNo() { }

	[CompilerGenerated]
	// RVA: 0x372DF98 Offset: 0x3729F98 VA: 0x372DF98
	public void set_ExchangeNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x372DFA0 Offset: 0x3729FA0 VA: 0x372DFA0
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x372DFA8 Offset: 0x3729FA8 VA: 0x372DFA8
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x372DFB0 Offset: 0x3729FB0 VA: 0x372DFB0
	public Dictionary<short, byte> get_UpdateRewardList() { }

	[CompilerGenerated]
	// RVA: 0x372DFB8 Offset: 0x3729FB8 VA: 0x372DFB8
	public void set_UpdateRewardList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x372DFC0 Offset: 0x3729FC0 VA: 0x372DFC0
	public int get_UsedTotalItemA() { }

	[CompilerGenerated]
	// RVA: 0x372DFC8 Offset: 0x3729FC8 VA: 0x372DFC8
	public void set_UsedTotalItemA(int value) { }

	[CompilerGenerated]
	// RVA: 0x372DFD0 Offset: 0x3729FD0 VA: 0x372DFD0
	public int get_UsedTotalItemB() { }

	[CompilerGenerated]
	// RVA: 0x372DFD8 Offset: 0x3729FD8 VA: 0x372DFD8
	public void set_UsedTotalItemB(int value) { }

	[CompilerGenerated]
	// RVA: 0x372DFE0 Offset: 0x3729FE0 VA: 0x372DFE0
	public int get_UsedTotalItemC() { }

	[CompilerGenerated]
	// RVA: 0x372DFE8 Offset: 0x3729FE8 VA: 0x372DFE8
	public void set_UsedTotalItemC(int value) { }

	// RVA: 0x372DFF0 Offset: 0x3729FF0 VA: 0x372DFF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372DFF8 Offset: 0x3729FF8 VA: 0x372DFF8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372E000 Offset: 0x372A000 VA: 0x372E000 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372E484 Offset: 0x372A484 VA: 0x372E484 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

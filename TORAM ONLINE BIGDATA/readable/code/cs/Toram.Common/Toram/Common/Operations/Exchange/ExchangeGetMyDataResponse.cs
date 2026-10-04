// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Exchange
public class ExchangeGetMyDataResponse : OperationResponseBase // TypeDefIndex: 11667
{
	// Fields
	[CompilerGenerated]
	private short <ExchangeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <UsedTotalPoint>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<short, byte> <AlreadyExchList>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <UsedTotalItemA>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <UsedTotalItemB>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <UsedTotalItemC>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 200)]
	public short ExchangeId { get; set; }
	[PacketParameter(Code = 205)]
	public int Point { get; set; }
	[PacketParameter(Code = 221)]
	public int UsedTotalPoint { get; set; }
	[PacketParameter(Code = 144)]
	public int TotalPoint { get; }
	[PacketParameter(Code = 213)]
	public Dictionary<short, byte> AlreadyExchList { get; set; }
	public int UsedTotalItemA { get; set; }
	public int UsedTotalItemB { get; set; }
	public int UsedTotalItemC { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372E688 Offset: 0x372A688 VA: 0x372E688
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372E690 Offset: 0x372A690 VA: 0x372E690
	public short get_ExchangeId() { }

	[CompilerGenerated]
	// RVA: 0x372E698 Offset: 0x372A698 VA: 0x372E698
	public void set_ExchangeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x372E6A0 Offset: 0x372A6A0 VA: 0x372E6A0
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x372E6A8 Offset: 0x372A6A8 VA: 0x372E6A8
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x372E6B0 Offset: 0x372A6B0 VA: 0x372E6B0
	public int get_UsedTotalPoint() { }

	[CompilerGenerated]
	// RVA: 0x372E6B8 Offset: 0x372A6B8 VA: 0x372E6B8
	public void set_UsedTotalPoint(int value) { }

	// RVA: 0x372E6C0 Offset: 0x372A6C0 VA: 0x372E6C0
	public int get_TotalPoint() { }

	[CompilerGenerated]
	// RVA: 0x372E6CC Offset: 0x372A6CC VA: 0x372E6CC
	public Dictionary<short, byte> get_AlreadyExchList() { }

	[CompilerGenerated]
	// RVA: 0x372E6D4 Offset: 0x372A6D4 VA: 0x372E6D4
	public void set_AlreadyExchList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x372E6DC Offset: 0x372A6DC VA: 0x372E6DC
	public int get_UsedTotalItemA() { }

	[CompilerGenerated]
	// RVA: 0x372E6E4 Offset: 0x372A6E4 VA: 0x372E6E4
	public void set_UsedTotalItemA(int value) { }

	[CompilerGenerated]
	// RVA: 0x372E6EC Offset: 0x372A6EC VA: 0x372E6EC
	public int get_UsedTotalItemB() { }

	[CompilerGenerated]
	// RVA: 0x372E6F4 Offset: 0x372A6F4 VA: 0x372E6F4
	public void set_UsedTotalItemB(int value) { }

	[CompilerGenerated]
	// RVA: 0x372E6FC Offset: 0x372A6FC VA: 0x372E6FC
	public int get_UsedTotalItemC() { }

	[CompilerGenerated]
	// RVA: 0x372E704 Offset: 0x372A704 VA: 0x372E704
	public void set_UsedTotalItemC(int value) { }

	// RVA: 0x372E70C Offset: 0x372A70C VA: 0x372E70C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372E910 Offset: 0x372A910 VA: 0x372E910
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372EA34 Offset: 0x372AA34 VA: 0x372EA34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372EA3C Offset: 0x372AA3C VA: 0x372EA3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372EA44 Offset: 0x372AA44 VA: 0x372EA44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372EC18 Offset: 0x372AC18 VA: 0x372EC18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

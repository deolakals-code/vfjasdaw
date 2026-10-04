// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaChestStartResponse : OperationResponseBase // TypeDefIndex: 11601
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ChestUniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <ElapsedTicks>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <OpenSec>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public int ChestUniqueId { get; set; }
	public long ElapsedTicks { get; set; }
	public short OpenSec { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37226FC Offset: 0x371E6FC VA: 0x37226FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3722704 Offset: 0x371E704 VA: 0x3722704
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x372270C Offset: 0x371E70C VA: 0x372270C
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3722714 Offset: 0x371E714 VA: 0x3722714
	public int get_ChestUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x372271C Offset: 0x371E71C VA: 0x372271C
	public void set_ChestUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3722724 Offset: 0x371E724 VA: 0x3722724
	public long get_ElapsedTicks() { }

	[CompilerGenerated]
	// RVA: 0x372272C Offset: 0x371E72C VA: 0x372272C
	public void set_ElapsedTicks(long value) { }

	[CompilerGenerated]
	// RVA: 0x3722734 Offset: 0x371E734 VA: 0x3722734
	public short get_OpenSec() { }

	[CompilerGenerated]
	// RVA: 0x372273C Offset: 0x371E73C VA: 0x372273C
	public void set_OpenSec(short value) { }

	// RVA: 0x3722744 Offset: 0x371E744 VA: 0x3722744 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372274C Offset: 0x371E74C VA: 0x372274C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3722754 Offset: 0x371E754 VA: 0x3722754 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37228A4 Offset: 0x371E8A4 VA: 0x37228A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

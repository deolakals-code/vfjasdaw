// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ChummingResponse : OperationResponseBase // TypeDefIndex: 11654
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ChummingCount>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 0)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 10)]
	public byte ChummingCount { get; set; }
	[PacketParameter(Code = 11)]
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372BFA4 Offset: 0x3727FA4 VA: 0x372BFA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372BFAC Offset: 0x3727FAC VA: 0x372BFAC
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x372BFB4 Offset: 0x3727FB4 VA: 0x372BFB4
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x372BFBC Offset: 0x3727FBC VA: 0x372BFBC
	public byte get_ChummingCount() { }

	[CompilerGenerated]
	// RVA: 0x372BFC4 Offset: 0x3727FC4 VA: 0x372BFC4
	public void set_ChummingCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372BFCC Offset: 0x3727FCC VA: 0x372BFCC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x372BFD4 Offset: 0x3727FD4 VA: 0x372BFD4
	public void set_Gold(int value) { }

	// RVA: 0x372BFDC Offset: 0x3727FDC VA: 0x372BFDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372BFE4 Offset: 0x3727FE4 VA: 0x372BFE4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372BFEC Offset: 0x3727FEC VA: 0x372BFEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372C0F8 Offset: 0x37280F8 VA: 0x372C0F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

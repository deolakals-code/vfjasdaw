// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongLeaveRoomResponse : OperationResponseBase // TypeDefIndex: 12348
{
	// Fields
	[CompilerGenerated]
	private MahjongRecordData <Record>k__BackingField; // 0x20

	// Properties
	[CLSCompliant(False)]
	public MahjongRecordData Record { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F8AB0 Offset: 0x35F4AB0 VA: 0x35F8AB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F8AB8 Offset: 0x35F4AB8 VA: 0x35F8AB8
	public MahjongRecordData get_Record() { }

	[CompilerGenerated]
	// RVA: 0x35F8AC0 Offset: 0x35F4AC0 VA: 0x35F8AC0
	public void set_Record(MahjongRecordData value) { }

	// RVA: 0x35F8AC8 Offset: 0x35F4AC8 VA: 0x35F8AC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F8AD0 Offset: 0x35F4AD0 VA: 0x35F8AD0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F8AD8 Offset: 0x35F4AD8 VA: 0x35F8AD8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F8B60 Offset: 0x35F4B60 VA: 0x35F8B60 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

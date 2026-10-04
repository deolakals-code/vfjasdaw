// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongJoinRoom : OperationRequestBase // TypeDefIndex: 12351
{
	// Fields
	[CompilerGenerated]
	private int <RoomId>k__BackingField; // 0x20

	// Properties
	public int RoomId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F93D8 Offset: 0x35F53D8 VA: 0x35F93D8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F93E0 Offset: 0x35F53E0 VA: 0x35F93E0
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35F93E8 Offset: 0x35F53E8 VA: 0x35F93E8
	public void set_RoomId(int value) { }

	// RVA: 0x35F93F0 Offset: 0x35F53F0 VA: 0x35F93F0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F93F8 Offset: 0x35F53F8 VA: 0x35F93F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F9400 Offset: 0x35F5400 VA: 0x35F9400 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F94A0 Offset: 0x35F54A0 VA: 0x35F94A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

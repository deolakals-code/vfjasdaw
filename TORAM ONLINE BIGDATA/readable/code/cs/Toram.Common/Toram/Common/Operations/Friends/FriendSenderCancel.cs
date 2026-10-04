// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendSenderCancel : PacketBase // TypeDefIndex: 11645
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x372AA34 Offset: 0x3726A34 VA: 0x372AA34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372AA3C Offset: 0x3726A3C VA: 0x372AA3C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x372AA44 Offset: 0x3726A44 VA: 0x372AA44
	public void set_TargetId(int value) { }

	// RVA: 0x372AA4C Offset: 0x3726A4C VA: 0x372AA4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372AA54 Offset: 0x3726A54 VA: 0x372AA54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372AB74 Offset: 0x3726B74 VA: 0x372AB74 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

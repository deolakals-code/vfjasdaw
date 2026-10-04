// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendRemove : PacketBase // TypeDefIndex: 11639
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3729AC8 Offset: 0x3725AC8 VA: 0x3729AC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3729AD0 Offset: 0x3725AD0 VA: 0x3729AD0
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3729AD8 Offset: 0x3725AD8 VA: 0x3729AD8
	public void set_TargetId(int value) { }

	// RVA: 0x3729AE0 Offset: 0x3725AE0 VA: 0x3729AE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3729AE8 Offset: 0x3725AE8 VA: 0x3729AE8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3729C08 Offset: 0x3725C08 VA: 0x3729C08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

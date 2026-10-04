// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class StopMoveEvent : PacketBase // TypeDefIndex: 12610
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362FD50 Offset: 0x362BD50 VA: 0x362FD50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362FD58 Offset: 0x362BD58 VA: 0x362FD58
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x362FD60 Offset: 0x362BD60 VA: 0x362FD60
	public void set_AvatarUuid(int value) { }

	// RVA: 0x362FD68 Offset: 0x362BD68 VA: 0x362FD68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362FD70 Offset: 0x362BD70 VA: 0x362FD70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x362FE90 Offset: 0x362BE90 VA: 0x362FE90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

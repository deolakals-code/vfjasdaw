// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomState : PacketBase // TypeDefIndex: 11758
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37436F0 Offset: 0x373F6F0 VA: 0x37436F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37436F8 Offset: 0x373F6F8 VA: 0x37436F8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3743700 Offset: 0x373F700 VA: 0x3743700
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3743708 Offset: 0x373F708 VA: 0x3743708
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3743710 Offset: 0x373F710 VA: 0x3743710
	public void set_ArchetypeType(byte value) { }

	// RVA: 0x3743718 Offset: 0x373F718 VA: 0x3743718 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3743720 Offset: 0x373F720 VA: 0x3743720 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3743898 Offset: 0x373F898 VA: 0x3743898 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class UpdateEntreeStaging : PacketBase // TypeDefIndex: 11760
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <EntreeStagingFlag>k__BackingField; // 0x25

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 161)]
	public byte EntreeStagingFlag { get; set; }

	// Methods

	// RVA: 0x3743E4C Offset: 0x373FE4C VA: 0x3743E4C
	public void .ctor() { }

	// RVA: 0x3743E54 Offset: 0x373FE54 VA: 0x3743E54 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3743E5C Offset: 0x373FE5C VA: 0x3743E5C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3743E64 Offset: 0x373FE64 VA: 0x3743E64
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3743E6C Offset: 0x373FE6C VA: 0x3743E6C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3743E74 Offset: 0x373FE74 VA: 0x3743E74
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3743E7C Offset: 0x373FE7C VA: 0x3743E7C
	public byte get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x3743E84 Offset: 0x373FE84 VA: 0x3743E84
	public void set_EntreeStagingFlag(byte value) { }

	// RVA: 0x3743E8C Offset: 0x373FE8C VA: 0x3743E8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3744050 Offset: 0x3740050 VA: 0x3744050 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

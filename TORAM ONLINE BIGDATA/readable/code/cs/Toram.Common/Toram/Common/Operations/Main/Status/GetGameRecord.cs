// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class GetGameRecord : PacketBase // TypeDefIndex: 12079
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x378307C Offset: 0x377F07C VA: 0x378307C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3783084 Offset: 0x377F084 VA: 0x3783084
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x378308C Offset: 0x377F08C VA: 0x378308C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3783094 Offset: 0x377F094 VA: 0x3783094
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x378309C Offset: 0x377F09C VA: 0x378309C
	public void set_ArchetypeType(byte value) { }

	// RVA: 0x37830A4 Offset: 0x377F0A4 VA: 0x37830A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37830AC Offset: 0x377F0AC VA: 0x37830AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3783250 Offset: 0x377F250 VA: 0x3783250 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

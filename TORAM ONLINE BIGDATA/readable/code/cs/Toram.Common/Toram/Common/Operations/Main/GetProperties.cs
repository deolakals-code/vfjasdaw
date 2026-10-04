// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class GetProperties : PacketBase // TypeDefIndex: 11899
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 56, IsOptional = True)]
	public int PropertiesRevision { get; set; }

	// Methods

	// RVA: 0x37610C0 Offset: 0x375D0C0 VA: 0x37610C0
	public void .ctor() { }

	// RVA: 0x37610C8 Offset: 0x375D0C8 VA: 0x37610C8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37610D0 Offset: 0x375D0D0 VA: 0x37610D0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37610D8 Offset: 0x375D0D8 VA: 0x37610D8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37610E0 Offset: 0x375D0E0 VA: 0x37610E0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x37610E8 Offset: 0x375D0E8 VA: 0x37610E8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37610F0 Offset: 0x375D0F0 VA: 0x37610F0
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x37610F8 Offset: 0x375D0F8 VA: 0x37610F8
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x3761100 Offset: 0x375D100 VA: 0x3761100 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37612F0 Offset: 0x375D2F0 VA: 0x37612F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

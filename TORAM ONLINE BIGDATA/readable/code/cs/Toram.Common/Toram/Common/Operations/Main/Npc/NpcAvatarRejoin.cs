// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Npc
public class NpcAvatarRejoin : PacketBase // TypeDefIndex: 11908
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65)]
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3762BAC Offset: 0x375EBAC VA: 0x3762BAC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3762BB4 Offset: 0x375EBB4 VA: 0x3762BB4
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3762BBC Offset: 0x375EBBC VA: 0x3762BBC
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3762BC4 Offset: 0x375EBC4 VA: 0x3762BC4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3762BCC Offset: 0x375EBCC VA: 0x3762BCC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3762BD4 Offset: 0x375EBD4 VA: 0x3762BD4
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3762BDC Offset: 0x375EBDC VA: 0x3762BDC
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3762BE4 Offset: 0x375EBE4 VA: 0x3762BE4
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3762BEC Offset: 0x375EBEC VA: 0x3762BEC
	public void set_Rotation(short value) { }

	// RVA: 0x3762BF4 Offset: 0x375EBF4 VA: 0x3762BF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3762BFC Offset: 0x375EBFC VA: 0x3762BFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3762E64 Offset: 0x375EE64 VA: 0x3762E64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

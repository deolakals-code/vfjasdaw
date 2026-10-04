// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Npc
public class NpcAvatarJoin : PacketBase // TypeDefIndex: 11906
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
	[PacketParameter(Code = 54)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65)]
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37621B0 Offset: 0x375E1B0 VA: 0x37621B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37621B8 Offset: 0x375E1B8 VA: 0x37621B8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x37621C0 Offset: 0x375E1C0 VA: 0x37621C0
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37621C8 Offset: 0x375E1C8 VA: 0x37621C8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x37621D0 Offset: 0x375E1D0 VA: 0x37621D0
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37621D8 Offset: 0x375E1D8 VA: 0x37621D8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37621E0 Offset: 0x375E1E0 VA: 0x37621E0
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x37621E8 Offset: 0x375E1E8 VA: 0x37621E8
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x37621F0 Offset: 0x375E1F0 VA: 0x37621F0
	public void set_Rotation(short value) { }

	// RVA: 0x37621F8 Offset: 0x375E1F8 VA: 0x37621F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3762200 Offset: 0x375E200 VA: 0x3762200 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376243C Offset: 0x375E43C VA: 0x376243C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

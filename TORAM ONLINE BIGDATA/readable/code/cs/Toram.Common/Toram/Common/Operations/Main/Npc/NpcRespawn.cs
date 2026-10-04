// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Npc
public class NpcRespawn : PacketBase // TypeDefIndex: 11910
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3763678 Offset: 0x375F678 VA: 0x3763678
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3763680 Offset: 0x375F680 VA: 0x3763680
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3763688 Offset: 0x375F688 VA: 0x3763688
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3763690 Offset: 0x375F690 VA: 0x3763690
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3763698 Offset: 0x375F698 VA: 0x3763698
	public void set_ArchetypeId(int value) { }

	// RVA: 0x37636A0 Offset: 0x375F6A0 VA: 0x37636A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37636A8 Offset: 0x375F6A8 VA: 0x37636A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3763820 Offset: 0x375F820 VA: 0x3763820 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

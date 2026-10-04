// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Npc
public class NpcRespawnResponse : PacketBase // TypeDefIndex: 11911
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 25)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26)]
	public short Mp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3763930 Offset: 0x375F930 VA: 0x3763930
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3763938 Offset: 0x375F938 VA: 0x3763938
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3763940 Offset: 0x375F940 VA: 0x3763940
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3763948 Offset: 0x375F948 VA: 0x3763948
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3763950 Offset: 0x375F950 VA: 0x3763950
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3763958 Offset: 0x375F958 VA: 0x3763958
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3763960 Offset: 0x375F960 VA: 0x3763960
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3763968 Offset: 0x375F968 VA: 0x3763968
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3763970 Offset: 0x375F970 VA: 0x3763970
	public void set_Mp(short value) { }

	// RVA: 0x3763978 Offset: 0x375F978 VA: 0x3763978 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3763980 Offset: 0x375F980 VA: 0x3763980 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3763B9C Offset: 0x375FB9C VA: 0x3763B9C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

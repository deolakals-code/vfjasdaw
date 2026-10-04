// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyFieldJoinEvent : PacketBase // TypeDefIndex: 12867
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366BB10 Offset: 0x3667B10 VA: 0x366BB10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366BB18 Offset: 0x3667B18 VA: 0x366BB18
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366BB20 Offset: 0x3667B20 VA: 0x366BB20
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366BB28 Offset: 0x3667B28 VA: 0x366BB28
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x366BB30 Offset: 0x3667B30 VA: 0x366BB30
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366BB38 Offset: 0x3667B38 VA: 0x366BB38
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366BB40 Offset: 0x3667B40 VA: 0x366BB40
	public void set_ArchetypeId(int value) { }

	// RVA: 0x366BB48 Offset: 0x3667B48 VA: 0x366BB48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366BB50 Offset: 0x3667B50 VA: 0x366BB50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366BD40 Offset: 0x3667D40 VA: 0x366BD40 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

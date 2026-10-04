// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyJoinEvent : PacketBase // TypeDefIndex: 12873
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366D1FC Offset: 0x36691FC VA: 0x366D1FC
	public void .ctor() { }

	// RVA: 0x366D204 Offset: 0x3669204 VA: 0x366D204
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366D20C Offset: 0x366920C VA: 0x366D20C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366D214 Offset: 0x3669214 VA: 0x366D214
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366D21C Offset: 0x366921C VA: 0x366D21C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x366D224 Offset: 0x3669224 VA: 0x366D224
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366D22C Offset: 0x366922C VA: 0x366D22C
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366D234 Offset: 0x3669234 VA: 0x366D234
	public void set_UserName(string value) { }

	// RVA: 0x366D23C Offset: 0x366923C VA: 0x366D23C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366D244 Offset: 0x3669244 VA: 0x366D244 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366D440 Offset: 0x3669440 VA: 0x366D440 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

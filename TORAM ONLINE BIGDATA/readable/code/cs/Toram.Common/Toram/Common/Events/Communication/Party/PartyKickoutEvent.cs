// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyKickoutEvent : PacketBase // TypeDefIndex: 12874
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366D568 Offset: 0x3669568 VA: 0x366D568
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366D570 Offset: 0x3669570 VA: 0x366D570
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366D578 Offset: 0x3669578 VA: 0x366D578
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366D580 Offset: 0x3669580 VA: 0x366D580
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x366D588 Offset: 0x3669588 VA: 0x366D588
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366D590 Offset: 0x3669590 VA: 0x366D590
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366D598 Offset: 0x3669598 VA: 0x366D598
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x366D5A0 Offset: 0x36695A0 VA: 0x366D5A0
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366D5A8 Offset: 0x36695A8 VA: 0x366D5A8
	public void set_PartyId(int value) { }

	// RVA: 0x366D5B0 Offset: 0x36695B0 VA: 0x366D5B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366D5B8 Offset: 0x36695B8 VA: 0x366D5B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366D7D4 Offset: 0x36697D4 VA: 0x366D7D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

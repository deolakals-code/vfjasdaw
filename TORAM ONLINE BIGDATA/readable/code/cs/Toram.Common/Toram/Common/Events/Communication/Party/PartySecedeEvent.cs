// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartySecedeEvent : PacketBase // TypeDefIndex: 12879
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

	// RVA: 0x366E59C Offset: 0x366A59C VA: 0x366E59C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366E5A4 Offset: 0x366A5A4 VA: 0x366E5A4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366E5AC Offset: 0x366A5AC VA: 0x366E5AC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366E5B4 Offset: 0x366A5B4 VA: 0x366E5B4
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x366E5BC Offset: 0x366A5BC VA: 0x366E5BC
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366E5C4 Offset: 0x366A5C4 VA: 0x366E5C4
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366E5CC Offset: 0x366A5CC VA: 0x366E5CC
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x366E5D4 Offset: 0x366A5D4 VA: 0x366E5D4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366E5DC Offset: 0x366A5DC VA: 0x366E5DC
	public void set_PartyId(int value) { }

	// RVA: 0x366E5E4 Offset: 0x366A5E4 VA: 0x366E5E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366E5EC Offset: 0x366A5EC VA: 0x366E5EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366E808 Offset: 0x366A808 VA: 0x366E808 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLoginEvent : PacketBase // TypeDefIndex: 12876
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366DBB0 Offset: 0x3669BB0 VA: 0x366DBB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366DBB8 Offset: 0x3669BB8 VA: 0x366DBB8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366DBC0 Offset: 0x3669BC0 VA: 0x366DBC0
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366DBC8 Offset: 0x3669BC8 VA: 0x366DBC8
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366DBD0 Offset: 0x3669BD0 VA: 0x366DBD0
	public void set_UserName(string value) { }

	// RVA: 0x366DBD8 Offset: 0x3669BD8 VA: 0x366DBD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366DBE0 Offset: 0x3669BE0 VA: 0x366DBE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366DD58 Offset: 0x3669D58 VA: 0x366DD58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLogoutEvent : PacketBase // TypeDefIndex: 12877
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

	// RVA: 0x366DE40 Offset: 0x3669E40 VA: 0x366DE40
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366DE48 Offset: 0x3669E48 VA: 0x366DE48
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366DE50 Offset: 0x3669E50 VA: 0x366DE50
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366DE58 Offset: 0x3669E58 VA: 0x366DE58
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366DE60 Offset: 0x3669E60 VA: 0x366DE60
	public void set_UserName(string value) { }

	// RVA: 0x366DE68 Offset: 0x3669E68 VA: 0x366DE68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366DE70 Offset: 0x3669E70 VA: 0x366DE70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366DFE8 Offset: 0x3669FE8 VA: 0x366DFE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

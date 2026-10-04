// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLinkStateEvent : PacketBase // TypeDefIndex: 12861
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <LeaderName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <MemberNum>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsLink>k__BackingField; // 0x31

	// Properties
	public int PartyId { get; set; }
	public string LeaderName { get; set; }
	public byte MemberNum { get; set; }
	public bool IsLink { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366AE6C Offset: 0x3666E6C VA: 0x366AE6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366AE74 Offset: 0x3666E74 VA: 0x366AE74
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366AE7C Offset: 0x3666E7C VA: 0x366AE7C
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366AE84 Offset: 0x3666E84 VA: 0x366AE84
	public string get_LeaderName() { }

	[CompilerGenerated]
	// RVA: 0x366AE8C Offset: 0x3666E8C VA: 0x366AE8C
	public void set_LeaderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x366AE94 Offset: 0x3666E94 VA: 0x366AE94
	public byte get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x366AE9C Offset: 0x3666E9C VA: 0x366AE9C
	public void set_MemberNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366AEA4 Offset: 0x3666EA4 VA: 0x366AEA4
	public bool get_IsLink() { }

	[CompilerGenerated]
	// RVA: 0x366AEAC Offset: 0x3666EAC VA: 0x366AEAC
	public void set_IsLink(bool value) { }

	// RVA: 0x366AEB8 Offset: 0x3666EB8 VA: 0x366AEB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366AEC0 Offset: 0x3666EC0 VA: 0x366AEC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366B0E8 Offset: 0x36670E8 VA: 0x366B0E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLinkConsentEvent : PacketBase // TypeDefIndex: 12858
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <LeaderName>k__BackingField; // 0x28

	// Properties
	public int PartyId { get; set; }
	public string LeaderName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366A4EC Offset: 0x36664EC VA: 0x366A4EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366A4F4 Offset: 0x36664F4 VA: 0x366A4F4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366A4FC Offset: 0x36664FC VA: 0x366A4FC
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366A504 Offset: 0x3666504 VA: 0x366A504
	public string get_LeaderName() { }

	[CompilerGenerated]
	// RVA: 0x366A50C Offset: 0x366650C VA: 0x366A50C
	public void set_LeaderName(string value) { }

	// RVA: 0x366A514 Offset: 0x3666514 VA: 0x366A514 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366A51C Offset: 0x366651C VA: 0x366A51C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366A694 Offset: 0x3666694 VA: 0x366A694 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

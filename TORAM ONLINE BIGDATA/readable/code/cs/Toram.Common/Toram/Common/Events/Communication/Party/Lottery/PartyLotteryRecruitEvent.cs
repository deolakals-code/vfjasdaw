// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Lottery
public class PartyLotteryRecruitEvent : PacketBase // TypeDefIndex: 12890
{
	// Fields
	[CompilerGenerated]
	private int <OrganizerAid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <OrganizerName>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <WinnerNums>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ExclusionLanguages>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 1)]
	public int OrganizerAid { get; set; }
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 100)]
	public string OrganizerName { get; set; }
	[PacketParameter(Code = 95)]
	public int[] WinnerNums { get; set; }
	[PacketParameter(Code = 213)]
	public short ExclusionLanguages { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367062C Offset: 0x366C62C VA: 0x367062C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3670634 Offset: 0x366C634 VA: 0x3670634
	public int get_OrganizerAid() { }

	[CompilerGenerated]
	// RVA: 0x367063C Offset: 0x366C63C VA: 0x367063C
	public void set_OrganizerAid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3670644 Offset: 0x366C644 VA: 0x3670644
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x367064C Offset: 0x366C64C VA: 0x367064C
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3670654 Offset: 0x366C654 VA: 0x3670654
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x367065C Offset: 0x366C65C VA: 0x367065C
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3670664 Offset: 0x366C664 VA: 0x3670664
	public string get_OrganizerName() { }

	[CompilerGenerated]
	// RVA: 0x367066C Offset: 0x366C66C VA: 0x367066C
	public void set_OrganizerName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3670674 Offset: 0x366C674 VA: 0x3670674
	public int[] get_WinnerNums() { }

	[CompilerGenerated]
	// RVA: 0x367067C Offset: 0x366C67C VA: 0x367067C
	public void set_WinnerNums(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3670684 Offset: 0x366C684 VA: 0x3670684
	public short get_ExclusionLanguages() { }

	[CompilerGenerated]
	// RVA: 0x367068C Offset: 0x366C68C VA: 0x367068C
	public void set_ExclusionLanguages(short value) { }

	// RVA: 0x3670694 Offset: 0x366C694 VA: 0x3670694 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367069C Offset: 0x366C69C VA: 0x367069C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36709C0 Offset: 0x366C9C0 VA: 0x36709C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

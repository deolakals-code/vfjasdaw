// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Lottery
public class HouseLotteryRecruitEvent : EventSubBase // TypeDefIndex: 12650
{
	// Fields
	[CompilerGenerated]
	private int <OrganizerAid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <OrganizerName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <WinnerNums>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ExclusionLanguages>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 1)]
	public int OrganizerAid { get; set; }
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 100)]
	public string OrganizerName { get; set; }
	[PacketParameter(Code = 95)]
	public int[] WinnerNums { get; set; }
	[PacketParameter(Code = 213)]
	public short ExclusionLanguages { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3639A6C Offset: 0x3635A6C VA: 0x3639A6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3639A74 Offset: 0x3635A74 VA: 0x3639A74
	public int get_OrganizerAid() { }

	[CompilerGenerated]
	// RVA: 0x3639A7C Offset: 0x3635A7C VA: 0x3639A7C
	public void set_OrganizerAid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3639A84 Offset: 0x3635A84 VA: 0x3639A84
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3639A8C Offset: 0x3635A8C VA: 0x3639A8C
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3639A94 Offset: 0x3635A94 VA: 0x3639A94
	public string get_OrganizerName() { }

	[CompilerGenerated]
	// RVA: 0x3639A9C Offset: 0x3635A9C VA: 0x3639A9C
	public void set_OrganizerName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3639AA4 Offset: 0x3635AA4 VA: 0x3639AA4
	public int[] get_WinnerNums() { }

	[CompilerGenerated]
	// RVA: 0x3639AAC Offset: 0x3635AAC VA: 0x3639AAC
	public void set_WinnerNums(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3639AB4 Offset: 0x3635AB4 VA: 0x3639AB4
	public short get_ExclusionLanguages() { }

	[CompilerGenerated]
	// RVA: 0x3639ABC Offset: 0x3635ABC VA: 0x3639ABC
	public void set_ExclusionLanguages(short value) { }

	// RVA: 0x3639AC4 Offset: 0x3635AC4 VA: 0x3639AC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3639ACC Offset: 0x3635ACC VA: 0x3639ACC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3639AD4 Offset: 0x3635AD4 VA: 0x3639AD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3639DB4 Offset: 0x3635DB4 VA: 0x3639DB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

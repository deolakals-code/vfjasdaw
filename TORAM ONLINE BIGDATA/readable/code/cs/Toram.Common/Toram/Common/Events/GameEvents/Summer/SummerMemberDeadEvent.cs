// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerMemberDeadEvent : EventSubBase // TypeDefIndex: 12694
{
	// Fields
	[CompilerGenerated]
	private SummerMemberData <Member>k__BackingField; // 0x20

	// Properties
	public SummerMemberData Member { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364389C Offset: 0x363F89C VA: 0x364389C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36438A4 Offset: 0x363F8A4 VA: 0x36438A4
	public SummerMemberData get_Member() { }

	[CompilerGenerated]
	// RVA: 0x36438AC Offset: 0x363F8AC VA: 0x36438AC
	public void set_Member(SummerMemberData value) { }

	// RVA: 0x36438B4 Offset: 0x363F8B4 VA: 0x36438B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36438BC Offset: 0x363F8BC VA: 0x36438BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36438C4 Offset: 0x363F8C4 VA: 0x36438C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364394C Offset: 0x363F94C VA: 0x364394C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

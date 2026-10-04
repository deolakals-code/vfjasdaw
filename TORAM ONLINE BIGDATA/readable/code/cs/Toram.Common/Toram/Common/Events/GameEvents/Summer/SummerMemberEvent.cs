// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerMemberEvent : EventSubBase // TypeDefIndex: 12695
{
	// Fields
	[CompilerGenerated]
	private SummerMemberData <Member>k__BackingField; // 0x20

	// Properties
	public SummerMemberData Member { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3643AE0 Offset: 0x363FAE0 VA: 0x3643AE0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3643AE8 Offset: 0x363FAE8 VA: 0x3643AE8
	public SummerMemberData get_Member() { }

	[CompilerGenerated]
	// RVA: 0x3643AF0 Offset: 0x363FAF0 VA: 0x3643AF0
	public void set_Member(SummerMemberData value) { }

	// RVA: 0x3643AF8 Offset: 0x363FAF8 VA: 0x3643AF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3643B00 Offset: 0x363FB00 VA: 0x3643B00 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3643B08 Offset: 0x363FB08 VA: 0x3643B08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3643C9C Offset: 0x363FC9C VA: 0x3643C9C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerPlayerRespawnEvent : EventSubBase // TypeDefIndex: 12697
{
	// Fields
	[CompilerGenerated]
	private SummerMemberData <Member>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28

	// Properties
	public SummerMemberData Member { get; set; }
	public int Hp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3643D4C Offset: 0x363FD4C VA: 0x3643D4C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3643D54 Offset: 0x363FD54 VA: 0x3643D54
	public SummerMemberData get_Member() { }

	[CompilerGenerated]
	// RVA: 0x3643D5C Offset: 0x363FD5C VA: 0x3643D5C
	public void set_Member(SummerMemberData value) { }

	[CompilerGenerated]
	// RVA: 0x3643D64 Offset: 0x363FD64 VA: 0x3643D64
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3643D6C Offset: 0x363FD6C VA: 0x3643D6C
	public void set_Hp(int value) { }

	// RVA: 0x3643D74 Offset: 0x363FD74 VA: 0x3643D74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3643D7C Offset: 0x363FD7C VA: 0x3643D7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3643D84 Offset: 0x363FD84 VA: 0x3643D84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3643F98 Offset: 0x363FF98 VA: 0x3643F98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

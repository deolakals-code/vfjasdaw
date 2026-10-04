// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaMemberEvent : EventSubBase // TypeDefIndex: 12670
{
	// Fields
	[CompilerGenerated]
	private short <MemberNum>k__BackingField; // 0x20

	// Properties
	public short MemberNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363E108 Offset: 0x363A108 VA: 0x363E108
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363E110 Offset: 0x363A110 VA: 0x363E110
	public short get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x363E118 Offset: 0x363A118 VA: 0x363E118
	public void set_MemberNum(short value) { }

	// RVA: 0x363E120 Offset: 0x363A120 VA: 0x363E120 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363E128 Offset: 0x363A128 VA: 0x363E128 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363E130 Offset: 0x363A130 VA: 0x363E130 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363E1D0 Offset: 0x363A1D0 VA: 0x363E1D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

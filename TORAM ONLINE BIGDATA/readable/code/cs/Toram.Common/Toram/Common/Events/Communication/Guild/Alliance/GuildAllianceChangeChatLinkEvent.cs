// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.Alliance
public class GuildAllianceChangeChatLinkEvent : EventSubBase // TypeDefIndex: 12934
{
	// Fields
	[CompilerGenerated]
	private DateTime <ChatLinkDate>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 25)]
	public DateTime ChatLinkDate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367BF00 Offset: 0x3677F00 VA: 0x367BF00
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367BF08 Offset: 0x3677F08 VA: 0x367BF08
	public DateTime get_ChatLinkDate() { }

	[CompilerGenerated]
	// RVA: 0x367BF10 Offset: 0x3677F10 VA: 0x367BF10
	public void set_ChatLinkDate(DateTime value) { }

	// RVA: 0x367BF18 Offset: 0x3677F18 VA: 0x367BF18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367BF20 Offset: 0x3677F20 VA: 0x367BF20 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367BF28 Offset: 0x3677F28 VA: 0x367BF28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367C004 Offset: 0x3678004 VA: 0x367C004 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

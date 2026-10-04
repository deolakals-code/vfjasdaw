// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildUnreceivedMessage : OperationRequestBase // TypeDefIndex: 12375
{
	// Fields
	[CompilerGenerated]
	private DateTime <LatestGuildMsgTime>k__BackingField; // 0x20

	// Properties
	public DateTime LatestGuildMsgTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FCF60 Offset: 0x35F8F60 VA: 0x35FCF60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FCF68 Offset: 0x35F8F68 VA: 0x35FCF68
	public DateTime get_LatestGuildMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x35FCF70 Offset: 0x35F8F70 VA: 0x35FCF70
	public void set_LatestGuildMsgTime(DateTime value) { }

	// RVA: 0x35FCF78 Offset: 0x35F8F78 VA: 0x35FCF78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FCF80 Offset: 0x35F8F80 VA: 0x35FCF80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FCF88 Offset: 0x35F8F88 VA: 0x35FCF88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FD0C8 Offset: 0x35F90C8 VA: 0x35FD0C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

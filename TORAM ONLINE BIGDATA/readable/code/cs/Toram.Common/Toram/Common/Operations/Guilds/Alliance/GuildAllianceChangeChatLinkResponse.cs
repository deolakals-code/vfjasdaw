// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceChangeChatLinkResponse : OperationResponseBase // TypeDefIndex: 12469
{
	// Fields
	[CompilerGenerated]
	private GuildVariableData <ChatLinkData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 2)]
	public GuildVariableData ChatLinkData { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360C978 Offset: 0x3608978 VA: 0x360C978
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360C980 Offset: 0x3608980 VA: 0x360C980
	public GuildVariableData get_ChatLinkData() { }

	[CompilerGenerated]
	// RVA: 0x360C988 Offset: 0x3608988 VA: 0x360C988
	public void set_ChatLinkData(GuildVariableData value) { }

	// RVA: 0x360C990 Offset: 0x3608990 VA: 0x360C990 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360C998 Offset: 0x3608998 VA: 0x360C998 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360C9A0 Offset: 0x36089A0 VA: 0x360C9A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360CA28 Offset: 0x3608A28 VA: 0x360CA28 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

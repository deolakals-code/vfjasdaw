// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceInviteResponse : OperationResponseBase // TypeDefIndex: 12478
{
	// Fields
	[CompilerGenerated]
	private int <TargetGuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 0)]
	public int TargetGuildId { get; set; }
	[PacketParameter(Code = 6)]
	public string GuildName { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360DEB0 Offset: 0x3609EB0 VA: 0x360DEB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360DEB8 Offset: 0x3609EB8 VA: 0x360DEB8
	public int get_TargetGuildId() { }

	[CompilerGenerated]
	// RVA: 0x360DEC0 Offset: 0x3609EC0 VA: 0x360DEC0
	public void set_TargetGuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360DEC8 Offset: 0x3609EC8 VA: 0x360DEC8
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x360DED0 Offset: 0x3609ED0 VA: 0x360DED0
	public void set_GuildName(string value) { }

	// RVA: 0x360DED8 Offset: 0x3609ED8 VA: 0x360DED8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360DEE0 Offset: 0x3609EE0 VA: 0x360DEE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360DEE8 Offset: 0x3609EE8 VA: 0x360DEE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360DF9C Offset: 0x3609F9C VA: 0x360DF9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

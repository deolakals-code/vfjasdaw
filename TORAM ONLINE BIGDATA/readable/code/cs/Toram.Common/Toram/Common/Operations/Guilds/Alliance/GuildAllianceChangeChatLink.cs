// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceChangeChatLink : OperationRequestBase // TypeDefIndex: 12467
{
	// Fields
	[CompilerGenerated]
	private bool <IsChatLink>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 20)]
	public bool IsChatLink { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360C5A4 Offset: 0x36085A4 VA: 0x360C5A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360C5AC Offset: 0x36085AC VA: 0x360C5AC
	public bool get_IsChatLink() { }

	[CompilerGenerated]
	// RVA: 0x360C5B4 Offset: 0x36085B4 VA: 0x360C5B4
	public void set_IsChatLink(bool value) { }

	// RVA: 0x360C5C0 Offset: 0x36085C0 VA: 0x360C5C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360C5C8 Offset: 0x36085C8 VA: 0x360C5C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360C5D0 Offset: 0x36085D0 VA: 0x360C5D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360C670 Offset: 0x3608670 VA: 0x360C670 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

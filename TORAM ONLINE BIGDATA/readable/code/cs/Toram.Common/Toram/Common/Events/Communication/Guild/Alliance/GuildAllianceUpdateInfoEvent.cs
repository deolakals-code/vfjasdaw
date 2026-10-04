// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.Alliance
public class GuildAllianceUpdateInfoEvent : EventSubBase // TypeDefIndex: 12935
{
	// Fields
	[CompilerGenerated]
	private GuildInfoData <InfoData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 2)]
	public GuildInfoData InfoData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367C144 Offset: 0x3678144 VA: 0x367C144
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367C14C Offset: 0x367814C VA: 0x367C14C
	public GuildInfoData get_InfoData() { }

	[CompilerGenerated]
	// RVA: 0x367C154 Offset: 0x3678154 VA: 0x367C154
	public void set_InfoData(GuildInfoData value) { }

	// RVA: 0x367C15C Offset: 0x367815C VA: 0x367C15C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367C164 Offset: 0x3678164 VA: 0x367C164 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367C16C Offset: 0x367816C VA: 0x367C16C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367C1F4 Offset: 0x36781F4 VA: 0x367C1F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

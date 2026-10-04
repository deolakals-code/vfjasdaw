// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceConsentResponse : OperationResponseBase // TypeDefIndex: 12475
{
	// Fields
	[CompilerGenerated]
	private int <AllianceId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int AllianceId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360D6C4 Offset: 0x36096C4 VA: 0x360D6C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360D6CC Offset: 0x36096CC VA: 0x360D6CC
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x360D6D4 Offset: 0x36096D4 VA: 0x360D6D4
	public void set_AllianceId(int value) { }

	// RVA: 0x360D6DC Offset: 0x36096DC VA: 0x360D6DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360D6E4 Offset: 0x36096E4 VA: 0x360D6E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360D6EC Offset: 0x36096EC VA: 0x360D6EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360D78C Offset: 0x360978C VA: 0x360D78C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

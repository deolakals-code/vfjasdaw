// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceConsent : OperationRequestBase // TypeDefIndex: 12468
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

	// RVA: 0x360C790 Offset: 0x3608790 VA: 0x360C790
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360C798 Offset: 0x3608798 VA: 0x360C798
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x360C7A0 Offset: 0x36087A0 VA: 0x360C7A0
	public void set_AllianceId(int value) { }

	// RVA: 0x360C7A8 Offset: 0x36087A8 VA: 0x360C7A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360C7B0 Offset: 0x36087B0 VA: 0x360C7B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360C7B8 Offset: 0x36087B8 VA: 0x360C7B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360C858 Offset: 0x3608858 VA: 0x360C858 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

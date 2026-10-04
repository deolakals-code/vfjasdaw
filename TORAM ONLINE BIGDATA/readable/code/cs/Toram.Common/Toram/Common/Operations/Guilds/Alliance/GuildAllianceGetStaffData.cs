// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceGetStaffData : OperationRequestBase // TypeDefIndex: 12471
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int GuildId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360CD80 Offset: 0x3608D80 VA: 0x360CD80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360CD88 Offset: 0x3608D88 VA: 0x360CD88
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360CD90 Offset: 0x3608D90 VA: 0x360CD90
	public void set_GuildId(int value) { }

	// RVA: 0x360CD98 Offset: 0x3608D98 VA: 0x360CD98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360CDA0 Offset: 0x3608DA0 VA: 0x360CDA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360CDA8 Offset: 0x3608DA8 VA: 0x360CDA8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360CE48 Offset: 0x3608E48 VA: 0x360CE48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

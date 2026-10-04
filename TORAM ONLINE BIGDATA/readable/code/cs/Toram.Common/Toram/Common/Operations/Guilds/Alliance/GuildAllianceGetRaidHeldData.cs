// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceGetRaidHeldData : OperationRequestBase // TypeDefIndex: 12470
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

	// RVA: 0x360CB98 Offset: 0x3608B98 VA: 0x360CB98
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360CBA0 Offset: 0x3608BA0 VA: 0x360CBA0
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360CBA8 Offset: 0x3608BA8 VA: 0x360CBA8
	public void set_GuildId(int value) { }

	// RVA: 0x360CBB0 Offset: 0x3608BB0 VA: 0x360CBB0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360CBB8 Offset: 0x3608BB8 VA: 0x360CBB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360CBC0 Offset: 0x3608BC0 VA: 0x360CBC0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360CC60 Offset: 0x3608C60 VA: 0x360CC60 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

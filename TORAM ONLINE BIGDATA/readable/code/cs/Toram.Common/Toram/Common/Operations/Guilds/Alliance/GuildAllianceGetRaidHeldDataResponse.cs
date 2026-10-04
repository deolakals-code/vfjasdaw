// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceGetRaidHeldDataResponse : OperationResponseBase // TypeDefIndex: 12472
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RaidId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0x29

	// Properties
	[PacketParameter(Code = 0)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 36)]
	public int RaidId { get; set; }
	[PacketParameter(Code = 10)]
	public byte Element { get; set; }
	[PacketParameter(Code = 20)]
	public bool IsPractice { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360CF68 Offset: 0x3608F68 VA: 0x360CF68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360CF70 Offset: 0x3608F70 VA: 0x360CF70
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360CF78 Offset: 0x3608F78 VA: 0x360CF78
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360CF80 Offset: 0x3608F80 VA: 0x360CF80
	public int get_RaidId() { }

	[CompilerGenerated]
	// RVA: 0x360CF88 Offset: 0x3608F88 VA: 0x360CF88
	public void set_RaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360CF90 Offset: 0x3608F90 VA: 0x360CF90
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x360CF98 Offset: 0x3608F98 VA: 0x360CF98
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360CFA0 Offset: 0x3608FA0 VA: 0x360CFA0
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x360CFA8 Offset: 0x3608FA8 VA: 0x360CFA8
	public void set_IsPractice(bool value) { }

	// RVA: 0x360CFB4 Offset: 0x3608FB4 VA: 0x360CFB4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360CFBC Offset: 0x3608FBC VA: 0x360CFBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360CFC4 Offset: 0x3608FC4 VA: 0x360CFC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360D100 Offset: 0x3609100 VA: 0x360D100 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

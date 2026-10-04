// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class GuildGetHeldRaidDataResponse : OperationResponseBase // TypeDefIndex: 12435
{
	// Fields
	[CompilerGenerated]
	private GuildRaidHeldData[] <Helds>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Stamina>k__BackingField; // 0x28

	// Properties
	public GuildRaidHeldData[] Helds { get; set; }
	public int Stamina { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3607794 Offset: 0x3603794 VA: 0x3607794
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360779C Offset: 0x360379C VA: 0x360779C
	public GuildRaidHeldData[] get_Helds() { }

	[CompilerGenerated]
	// RVA: 0x36077A4 Offset: 0x36037A4 VA: 0x36077A4
	public void set_Helds(GuildRaidHeldData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36077AC Offset: 0x36037AC VA: 0x36077AC
	public int get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x36077B4 Offset: 0x36037B4 VA: 0x36077B4
	public void set_Stamina(int value) { }

	// RVA: 0x36077BC Offset: 0x36037BC VA: 0x36077BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36077C4 Offset: 0x36037C4 VA: 0x36077C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36077CC Offset: 0x36037CC VA: 0x36077CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36079A4 Offset: 0x36039A4 VA: 0x36079A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

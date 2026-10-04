// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class GuildHeldRaidResponse : OperationResponseBase // TypeDefIndex: 12437
{
	// Fields
	[CompilerGenerated]
	private int <RaidId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildRaidRandomPropertyData[] <PropertyList>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildRaidHeldData <RaidHeld>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildVariableData <Data>k__BackingField; // 0x40

	// Properties
	public int RaidId { get; set; }
	public GuildRaidRandomPropertyData[] PropertyList { get; set; }
	public GuildRaidHeldData RaidHeld { get; set; }
	public DateTime UpdateDate { get; set; }
	public GuildVariableData Data { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3607D88 Offset: 0x3603D88 VA: 0x3607D88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3607D90 Offset: 0x3603D90 VA: 0x3607D90
	public int get_RaidId() { }

	[CompilerGenerated]
	// RVA: 0x3607D98 Offset: 0x3603D98 VA: 0x3607D98
	public void set_RaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3607DA0 Offset: 0x3603DA0 VA: 0x3607DA0
	public GuildRaidRandomPropertyData[] get_PropertyList() { }

	[CompilerGenerated]
	// RVA: 0x3607DA8 Offset: 0x3603DA8 VA: 0x3607DA8
	public void set_PropertyList(GuildRaidRandomPropertyData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3607DB0 Offset: 0x3603DB0 VA: 0x3607DB0
	public GuildRaidHeldData get_RaidHeld() { }

	[CompilerGenerated]
	// RVA: 0x3607DB8 Offset: 0x3603DB8 VA: 0x3607DB8
	public void set_RaidHeld(GuildRaidHeldData value) { }

	[CompilerGenerated]
	// RVA: 0x3607DC0 Offset: 0x3603DC0 VA: 0x3607DC0
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x3607DC8 Offset: 0x3603DC8 VA: 0x3607DC8
	public void set_UpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3607DD0 Offset: 0x3603DD0 VA: 0x3607DD0
	public GuildVariableData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x3607DD8 Offset: 0x3603DD8 VA: 0x3607DD8
	public void set_Data(GuildVariableData value) { }

	// RVA: 0x3607DE0 Offset: 0x3603DE0 VA: 0x3607DE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3607DE8 Offset: 0x3603DE8 VA: 0x3607DE8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3607DF0 Offset: 0x3603DF0 VA: 0x3607DF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3608140 Offset: 0x3604140 VA: 0x3608140 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildHeldRaidEvent : EventSubBase // TypeDefIndex: 12907
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RaidId>k__BackingField; // 0x24
	[CompilerGenerated]
	private GuildRaidRandomPropertyData[] <PropertyList>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildRaidHeldData <RaidHeld>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildVariableData <Data>k__BackingField; // 0x40

	// Properties
	public int GuildId { get; set; }
	public int RaidId { get; set; }
	public GuildRaidRandomPropertyData[] PropertyList { get; set; }
	public GuildRaidHeldData RaidHeld { get; set; }
	public DateTime UpdateDate { get; set; }
	public GuildVariableData Data { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36742A8 Offset: 0x36702A8 VA: 0x36742A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36742B0 Offset: 0x36702B0 VA: 0x36742B0
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x36742B8 Offset: 0x36702B8 VA: 0x36742B8
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36742C0 Offset: 0x36702C0 VA: 0x36742C0
	public int get_RaidId() { }

	[CompilerGenerated]
	// RVA: 0x36742C8 Offset: 0x36702C8 VA: 0x36742C8
	public void set_RaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36742D0 Offset: 0x36702D0 VA: 0x36742D0
	public GuildRaidRandomPropertyData[] get_PropertyList() { }

	[CompilerGenerated]
	// RVA: 0x36742D8 Offset: 0x36702D8 VA: 0x36742D8
	public void set_PropertyList(GuildRaidRandomPropertyData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36742E0 Offset: 0x36702E0 VA: 0x36742E0
	public GuildRaidHeldData get_RaidHeld() { }

	[CompilerGenerated]
	// RVA: 0x36742E8 Offset: 0x36702E8 VA: 0x36742E8
	public void set_RaidHeld(GuildRaidHeldData value) { }

	[CompilerGenerated]
	// RVA: 0x36742F0 Offset: 0x36702F0 VA: 0x36742F0
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x36742F8 Offset: 0x36702F8 VA: 0x36742F8
	public void set_UpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3674300 Offset: 0x3670300 VA: 0x3674300
	public GuildVariableData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x3674308 Offset: 0x3670308 VA: 0x3674308
	public void set_Data(GuildVariableData value) { }

	// RVA: 0x3674310 Offset: 0x3670310 VA: 0x3674310 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3674318 Offset: 0x3670318 VA: 0x3674318 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3674320 Offset: 0x3670320 VA: 0x3674320 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36744EC Offset: 0x36704EC VA: 0x36744EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

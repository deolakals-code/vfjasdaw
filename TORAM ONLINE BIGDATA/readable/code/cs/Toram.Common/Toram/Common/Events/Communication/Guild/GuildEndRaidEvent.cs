// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildEndRaidEvent : EventSubBase // TypeDefIndex: 12906
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildRaidHeldData <RaidHeld>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildItemData <Item>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x40

	// Properties
	public int GuildId { get; set; }
	public GuildRaidHeldData RaidHeld { get; set; }
	public int Num { get; set; }
	public GuildItemData Item { get; set; }
	public DateTime UpdateDate { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3673D58 Offset: 0x366FD58 VA: 0x3673D58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3673D60 Offset: 0x366FD60 VA: 0x3673D60
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3673D68 Offset: 0x366FD68 VA: 0x3673D68
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3673D70 Offset: 0x366FD70 VA: 0x3673D70
	public GuildRaidHeldData get_RaidHeld() { }

	[CompilerGenerated]
	// RVA: 0x3673D78 Offset: 0x366FD78 VA: 0x3673D78
	public void set_RaidHeld(GuildRaidHeldData value) { }

	[CompilerGenerated]
	// RVA: 0x3673D80 Offset: 0x366FD80 VA: 0x3673D80
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x3673D88 Offset: 0x366FD88 VA: 0x3673D88
	public void set_Num(int value) { }

	[CompilerGenerated]
	// RVA: 0x3673D90 Offset: 0x366FD90 VA: 0x3673D90
	public GuildItemData get_Item() { }

	[CompilerGenerated]
	// RVA: 0x3673D98 Offset: 0x366FD98 VA: 0x3673D98
	public void set_Item(GuildItemData value) { }

	[CompilerGenerated]
	// RVA: 0x3673DA0 Offset: 0x366FDA0 VA: 0x3673DA0
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x3673DA8 Offset: 0x366FDA8 VA: 0x3673DA8
	public void set_UpdateDate(DateTime value) { }

	// RVA: 0x3673DB0 Offset: 0x366FDB0 VA: 0x3673DB0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3673DB8 Offset: 0x366FDB8 VA: 0x3673DB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3673DC0 Offset: 0x366FDC0 VA: 0x3673DC0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3673F5C Offset: 0x366FF5C VA: 0x3673F5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

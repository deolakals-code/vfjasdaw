// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildOpenBgmEvent : EventSubBase // TypeDefIndex: 12899
{
	// Fields
	[CompilerGenerated]
	private short <RecipeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildVariableData[] <Variables>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildItemData[] <Items>k__BackingField; // 0x30

	// Properties
	public short RecipeId { get; set; }
	public GuildVariableData[] Variables { get; set; }
	public GuildItemData[] Items { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36727C8 Offset: 0x366E7C8 VA: 0x36727C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36727D0 Offset: 0x366E7D0 VA: 0x36727D0
	public short get_RecipeId() { }

	[CompilerGenerated]
	// RVA: 0x36727D8 Offset: 0x366E7D8 VA: 0x36727D8
	public void set_RecipeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36727E0 Offset: 0x366E7E0 VA: 0x36727E0
	public GuildVariableData[] get_Variables() { }

	[CompilerGenerated]
	// RVA: 0x36727E8 Offset: 0x366E7E8 VA: 0x36727E8
	public void set_Variables(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36727F0 Offset: 0x366E7F0 VA: 0x36727F0
	public GuildItemData[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x36727F8 Offset: 0x366E7F8 VA: 0x36727F8
	public void set_Items(GuildItemData[] value) { }

	// RVA: 0x3672800 Offset: 0x366E800 VA: 0x3672800 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3672808 Offset: 0x366E808 VA: 0x3672808 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3672810 Offset: 0x366E810 VA: 0x3672810 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3672920 Offset: 0x366E920 VA: 0x3672920 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

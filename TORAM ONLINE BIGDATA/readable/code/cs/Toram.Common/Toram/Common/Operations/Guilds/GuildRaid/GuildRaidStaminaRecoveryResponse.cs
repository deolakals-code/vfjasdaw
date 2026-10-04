// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class GuildRaidStaminaRecoveryResponse : PacketBase // TypeDefIndex: 12436
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Stamina>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketClass(Code = 15)]
	public ItemDatav2[] ItemList { get; set; }
	[PacketParameter(Code = 10)]
	public int Stamina { get; set; }

	// Methods

	// RVA: 0x3607A80 Offset: 0x3603A80 VA: 0x3607A80
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3607A88 Offset: 0x3603A88 VA: 0x3607A88 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3607A90 Offset: 0x3603A90 VA: 0x3607A90
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3607A98 Offset: 0x3603A98 VA: 0x3607A98
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3607AA0 Offset: 0x3603AA0 VA: 0x3607AA0
	public int get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x3607AA8 Offset: 0x3603AA8 VA: 0x3607AA8
	public void set_Stamina(int value) { }

	// RVA: 0x3607AB0 Offset: 0x3603AB0 VA: 0x3607AB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3607C6C Offset: 0x3603C6C VA: 0x3607C6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

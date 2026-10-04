// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCreateResponse : PacketBase // TypeDefIndex: 12384
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x30

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FF124 Offset: 0x35FB124 VA: 0x35FF124
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FF12C Offset: 0x35FB12C VA: 0x35FF12C
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FF134 Offset: 0x35FB134 VA: 0x35FF134
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FF13C Offset: 0x35FB13C VA: 0x35FF13C
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x35FF144 Offset: 0x35FB144 VA: 0x35FF144
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FF14C Offset: 0x35FB14C VA: 0x35FF14C
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x35FF154 Offset: 0x35FB154 VA: 0x35FF154
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x35FF15C Offset: 0x35FB15C VA: 0x35FF15C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FF164 Offset: 0x35FB164 VA: 0x35FF164 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FF370 Offset: 0x35FB370 VA: 0x35FF370 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

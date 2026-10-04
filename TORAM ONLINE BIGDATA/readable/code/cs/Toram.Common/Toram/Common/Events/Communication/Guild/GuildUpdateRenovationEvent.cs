// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildUpdateRenovationEvent : EventSubBase // TypeDefIndex: 12908
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <OpenFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildVariableData[] <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildItemData[] <Items>k__BackingField; // 0x38

	// Properties
	public int GuildId { get; set; }
	public byte RenovationId { get; set; }
	public long OpenFlag { get; set; }
	public GuildVariableData[] Data { get; set; }
	public GuildItemData[] Items { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3674880 Offset: 0x3670880 VA: 0x3674880
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3674888 Offset: 0x3670888 VA: 0x3674888
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3674890 Offset: 0x3670890 VA: 0x3674890
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3674898 Offset: 0x3670898 VA: 0x3674898
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x36748A0 Offset: 0x36708A0 VA: 0x36748A0
	public void set_RenovationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36748A8 Offset: 0x36708A8 VA: 0x36748A8
	public long get_OpenFlag() { }

	[CompilerGenerated]
	// RVA: 0x36748B0 Offset: 0x36708B0 VA: 0x36748B0
	public void set_OpenFlag(long value) { }

	[CompilerGenerated]
	// RVA: 0x36748B8 Offset: 0x36708B8 VA: 0x36748B8
	public GuildVariableData[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x36748C0 Offset: 0x36708C0 VA: 0x36748C0
	public void set_Data(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36748C8 Offset: 0x36708C8 VA: 0x36748C8
	public GuildItemData[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x36748D0 Offset: 0x36708D0 VA: 0x36748D0
	public void set_Items(GuildItemData[] value) { }

	// RVA: 0x36748D8 Offset: 0x36708D8 VA: 0x36748D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36748E0 Offset: 0x36708E0 VA: 0x36748E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36748E8 Offset: 0x36708E8 VA: 0x36748E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3674A88 Offset: 0x3670A88 VA: 0x3674A88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

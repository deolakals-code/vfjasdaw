// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildOpenRenovationResponse : OperationResponseBase // TypeDefIndex: 12358
{
	// Fields
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <OpenFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildVariableData[] <Variables>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildItemData[] <Items>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 0)]
	public byte RenovationId { get; set; }
	[PacketParameter(Code = 2)]
	public long OpenFlag { get; set; }
	[PacketClass(Code = 29)]
	public GuildVariableData[] Variables { get; set; }
	[PacketClass(Code = 30)]
	public GuildItemData[] Items { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FA2EC Offset: 0x35F62EC VA: 0x35FA2EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FA2F4 Offset: 0x35F62F4 VA: 0x35FA2F4
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x35FA2FC Offset: 0x35F62FC VA: 0x35FA2FC
	public void set_RenovationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FA304 Offset: 0x35F6304 VA: 0x35FA304
	public long get_OpenFlag() { }

	[CompilerGenerated]
	// RVA: 0x35FA30C Offset: 0x35F630C VA: 0x35FA30C
	public void set_OpenFlag(long value) { }

	[CompilerGenerated]
	// RVA: 0x35FA314 Offset: 0x35F6314 VA: 0x35FA314
	public GuildVariableData[] get_Variables() { }

	[CompilerGenerated]
	// RVA: 0x35FA31C Offset: 0x35F631C VA: 0x35FA31C
	public void set_Variables(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35FA324 Offset: 0x35F6324 VA: 0x35FA324
	public GuildItemData[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x35FA32C Offset: 0x35F632C VA: 0x35FA32C
	public void set_Items(GuildItemData[] value) { }

	// RVA: 0x35FA334 Offset: 0x35F6334 VA: 0x35FA334 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FA33C Offset: 0x35F633C VA: 0x35FA33C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FA344 Offset: 0x35F6344 VA: 0x35FA344 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FA5CC Offset: 0x35F65CC VA: 0x35FA5CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

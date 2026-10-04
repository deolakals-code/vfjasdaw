// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestDiscardResponse : OperationResponseBase // TypeDefIndex: 12427
{
	// Fields
	[CompilerGenerated]
	private GuildOrderQuestData <NewQuestData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <NextType>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <RestockTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Stock>k__BackingField; // 0x38

	// Properties
	[PacketClass(Code = 29, IsOptional = True)]
	public GuildOrderQuestData NewQuestData { get; set; }
	[PacketParameter(Code = 1)]
	public byte NextType { get; set; }
	[PacketParameter(Code = 42)]
	public long RestockTime { get; set; }
	[PacketParameter(Code = 10)]
	public byte Stock { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3605A0C Offset: 0x3601A0C VA: 0x3605A0C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3605A14 Offset: 0x3601A14 VA: 0x3605A14
	public GuildOrderQuestData get_NewQuestData() { }

	[CompilerGenerated]
	// RVA: 0x3605A1C Offset: 0x3601A1C VA: 0x3605A1C
	public void set_NewQuestData(GuildOrderQuestData value) { }

	[CompilerGenerated]
	// RVA: 0x3605A24 Offset: 0x3601A24 VA: 0x3605A24
	public byte get_NextType() { }

	[CompilerGenerated]
	// RVA: 0x3605A2C Offset: 0x3601A2C VA: 0x3605A2C
	public void set_NextType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3605A34 Offset: 0x3601A34 VA: 0x3605A34
	public long get_RestockTime() { }

	[CompilerGenerated]
	// RVA: 0x3605A3C Offset: 0x3601A3C VA: 0x3605A3C
	public void set_RestockTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3605A44 Offset: 0x3601A44 VA: 0x3605A44
	public byte get_Stock() { }

	[CompilerGenerated]
	// RVA: 0x3605A4C Offset: 0x3601A4C VA: 0x3605A4C
	public void set_Stock(byte value) { }

	// RVA: 0x3605A54 Offset: 0x3601A54 VA: 0x3605A54 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3605A5C Offset: 0x3601A5C VA: 0x3605A5C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3605A64 Offset: 0x3601A64 VA: 0x3605A64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3605BA0 Offset: 0x3601BA0 VA: 0x3605BA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

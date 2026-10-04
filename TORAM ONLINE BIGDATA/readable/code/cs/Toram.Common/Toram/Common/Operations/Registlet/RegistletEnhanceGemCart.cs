// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Registlet
public class RegistletEnhanceGemCart : OperationRequestBase // TypeDefIndex: 11447
{
	// Fields
	[CompilerGenerated]
	private long <EnhanceUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <MaterialUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private long[] <MaterialUuidList>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 36)]
	public long EnhanceUuid { get; set; }
	[PacketParameter(Code = 37, IsOptional = True)]
	[Obsolete("rm21640:一括強化実装前のプロパティ。使用しない。実装後削除予定。")]
	public long MaterialUuid { get; set; }
	[PacketParameter(Code = 15, IsOptional = True)]
	public long[] MaterialUuidList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370C060 Offset: 0x3708060 VA: 0x370C060
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370C068 Offset: 0x3708068 VA: 0x370C068
	public long get_EnhanceUuid() { }

	[CompilerGenerated]
	// RVA: 0x370C070 Offset: 0x3708070 VA: 0x370C070
	public void set_EnhanceUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x370C078 Offset: 0x3708078 VA: 0x370C078
	public long get_MaterialUuid() { }

	[CompilerGenerated]
	// RVA: 0x370C080 Offset: 0x3708080 VA: 0x370C080
	public void set_MaterialUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x370C088 Offset: 0x3708088 VA: 0x370C088
	public long[] get_MaterialUuidList() { }

	[CompilerGenerated]
	// RVA: 0x370C090 Offset: 0x3708090 VA: 0x370C090
	public void set_MaterialUuidList(long[] value) { }

	// RVA: 0x370C098 Offset: 0x3708098 VA: 0x370C098 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370C0A0 Offset: 0x37080A0 VA: 0x370C0A0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370C0A8 Offset: 0x37080A8 VA: 0x370C0A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x370C18C Offset: 0x370818C VA: 0x370C18C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

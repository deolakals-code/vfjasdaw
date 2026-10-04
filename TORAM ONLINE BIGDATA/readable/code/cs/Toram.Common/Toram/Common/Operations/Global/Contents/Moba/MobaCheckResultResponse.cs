// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaCheckResultResponse : OperationResponseBase // TypeDefIndex: 11594
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaRecordData[] <Records>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobaGroupRecordData[] <Groups>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobaBattleRecordData <BattleRecord>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <TeamNo>k__BackingField; // 0x40

	// Properties
	public short ReturnCode { get; set; }
	public MobaRecordData[] Records { get; set; }
	public MobaGroupRecordData[] Groups { get; set; }
	public MobaBattleRecordData BattleRecord { get; set; }
	public byte TeamNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3721254 Offset: 0x371D254 VA: 0x3721254
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372125C Offset: 0x371D25C VA: 0x372125C
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3721264 Offset: 0x371D264 VA: 0x3721264
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x372126C Offset: 0x371D26C VA: 0x372126C
	public MobaRecordData[] get_Records() { }

	[CompilerGenerated]
	// RVA: 0x3721274 Offset: 0x371D274 VA: 0x3721274
	public void set_Records(MobaRecordData[] value) { }

	[CompilerGenerated]
	// RVA: 0x372127C Offset: 0x371D27C VA: 0x372127C
	public MobaGroupRecordData[] get_Groups() { }

	[CompilerGenerated]
	// RVA: 0x3721284 Offset: 0x371D284 VA: 0x3721284
	public void set_Groups(MobaGroupRecordData[] value) { }

	[CompilerGenerated]
	// RVA: 0x372128C Offset: 0x371D28C VA: 0x372128C
	public MobaBattleRecordData get_BattleRecord() { }

	[CompilerGenerated]
	// RVA: 0x3721294 Offset: 0x371D294 VA: 0x3721294
	public void set_BattleRecord(MobaBattleRecordData value) { }

	[CompilerGenerated]
	// RVA: 0x372129C Offset: 0x371D29C VA: 0x372129C
	public byte get_TeamNo() { }

	[CompilerGenerated]
	// RVA: 0x37212A4 Offset: 0x371D2A4 VA: 0x37212A4
	public void set_TeamNo(byte value) { }

	// RVA: 0x37212AC Offset: 0x371D2AC VA: 0x37212AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37212B4 Offset: 0x371D2B4 VA: 0x37212B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37212BC Offset: 0x371D2BC VA: 0x37212BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3721444 Offset: 0x371D444 VA: 0x3721444 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

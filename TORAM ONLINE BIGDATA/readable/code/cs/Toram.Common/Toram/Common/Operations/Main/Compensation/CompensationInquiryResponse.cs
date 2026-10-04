// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationInquiryResponse : OperationResponseBase // TypeDefIndex: 12036
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <OldValue>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x24

	// Properties
	[PacketClass(Code = 245, IsOptional = True)]
	public byte Type { get; set; }
	[PacketClass(Code = 195)]
	public byte OldValue { get; set; }
	[PacketClass(Code = 92)]
	public int Value { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377B308 Offset: 0x3777308 VA: 0x377B308
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377B310 Offset: 0x3777310 VA: 0x377B310
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x377B318 Offset: 0x3777318 VA: 0x377B318
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377B320 Offset: 0x3777320 VA: 0x377B320
	public byte get_OldValue() { }

	[CompilerGenerated]
	// RVA: 0x377B328 Offset: 0x3777328 VA: 0x377B328
	public void set_OldValue(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377B330 Offset: 0x3777330 VA: 0x377B330
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x377B338 Offset: 0x3777338 VA: 0x377B338
	public void set_Value(int value) { }

	// RVA: 0x377B340 Offset: 0x3777340 VA: 0x377B340
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377B344 Offset: 0x3777344 VA: 0x377B344
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377B348 Offset: 0x3777348 VA: 0x377B348 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377B350 Offset: 0x3777350 VA: 0x377B350 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377B358 Offset: 0x3777358 VA: 0x377B358 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377B548 Offset: 0x3777548 VA: 0x377B548 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventResultResponse : OperationResponseBase // TypeDefIndex: 11623
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Hp>k__BackingField; // 0x22
	[CompilerGenerated]
	private SummerResultData <ResultData>k__BackingField; // 0x28

	// Properties
	public byte EventType { get; set; }
	public short Hp { get; set; }
	public SummerResultData ResultData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3727198 Offset: 0x3723198 VA: 0x3727198
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37271A0 Offset: 0x37231A0 VA: 0x37271A0
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x37271A8 Offset: 0x37231A8 VA: 0x37271A8
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37271B0 Offset: 0x37231B0 VA: 0x37271B0
	public short get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x37271B8 Offset: 0x37231B8 VA: 0x37271B8
	public void set_Hp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37271C0 Offset: 0x37231C0 VA: 0x37271C0
	public SummerResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x37271C8 Offset: 0x37231C8 VA: 0x37271C8
	public void set_ResultData(SummerResultData value) { }

	// RVA: 0x37271D0 Offset: 0x37231D0 VA: 0x37271D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37271D8 Offset: 0x37231D8 VA: 0x37271D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37271E0 Offset: 0x37231E0 VA: 0x37271E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3727424 Offset: 0x3723424 VA: 0x3727424 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

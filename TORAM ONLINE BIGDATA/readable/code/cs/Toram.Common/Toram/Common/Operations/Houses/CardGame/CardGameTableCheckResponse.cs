// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameTableCheckResponse : OperationResponseBase // TypeDefIndex: 12277
{
	// Fields
	[CompilerGenerated]
	private Dictionary<int, byte> <Tables>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <EnterTable>k__BackingField; // 0x28

	// Properties
	public Dictionary<int, byte> Tables { get; set; }
	public int EnterTable { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EB308 Offset: 0x35E7308 VA: 0x35EB308
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EB310 Offset: 0x35E7310 VA: 0x35EB310
	public Dictionary<int, byte> get_Tables() { }

	[CompilerGenerated]
	// RVA: 0x35EB318 Offset: 0x35E7318 VA: 0x35EB318
	public void set_Tables(Dictionary<int, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x35EB320 Offset: 0x35E7320 VA: 0x35EB320
	public int get_EnterTable() { }

	[CompilerGenerated]
	// RVA: 0x35EB328 Offset: 0x35E7328 VA: 0x35EB328
	public void set_EnterTable(int value) { }

	// RVA: 0x35EB330 Offset: 0x35E7330 VA: 0x35EB330 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EB338 Offset: 0x35E7338 VA: 0x35EB338 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EB340 Offset: 0x35E7340 VA: 0x35EB340 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EB520 Offset: 0x35E7520 VA: 0x35EB520 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

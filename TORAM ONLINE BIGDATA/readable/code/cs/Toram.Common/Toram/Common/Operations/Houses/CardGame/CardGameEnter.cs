// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameEnter : OperationRequestBase // TypeDefIndex: 12270
{
	// Fields
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TableId>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <CreateFlag>k__BackingField; // 0x28

	// Properties
	public int ObjId { get; set; }
	public int TableId { get; set; }
	public bool CreateFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E9B38 Offset: 0x35E5B38 VA: 0x35E9B38
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E9B40 Offset: 0x35E5B40 VA: 0x35E9B40
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x35E9B48 Offset: 0x35E5B48 VA: 0x35E9B48
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E9B50 Offset: 0x35E5B50 VA: 0x35E9B50
	public int get_TableId() { }

	[CompilerGenerated]
	// RVA: 0x35E9B58 Offset: 0x35E5B58 VA: 0x35E9B58
	public void set_TableId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E9B60 Offset: 0x35E5B60 VA: 0x35E9B60
	public bool get_CreateFlag() { }

	[CompilerGenerated]
	// RVA: 0x35E9B68 Offset: 0x35E5B68 VA: 0x35E9B68
	public void set_CreateFlag(bool value) { }

	// RVA: 0x35E9B74 Offset: 0x35E5B74 VA: 0x35E9B74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E9B7C Offset: 0x35E5B7C VA: 0x35E9B7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E9B84 Offset: 0x35E5B84 VA: 0x35E9B84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E9D94 Offset: 0x35E5D94 VA: 0x35E9D94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaItemDrop : OperationRequestBase // TypeDefIndex: 11604
{
	// Fields
	[CompilerGenerated]
	private byte <EquipNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ItemId>k__BackingField; // 0x22

	// Properties
	public byte EquipNo { get; set; }
	public short ItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3723204 Offset: 0x371F204 VA: 0x3723204
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372320C Offset: 0x371F20C VA: 0x372320C
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x3723214 Offset: 0x371F214 VA: 0x3723214
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372321C Offset: 0x371F21C VA: 0x372321C
	public short get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3723224 Offset: 0x371F224 VA: 0x3723224
	public void set_ItemId(short value) { }

	// RVA: 0x372322C Offset: 0x371F22C VA: 0x372322C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3723234 Offset: 0x371F234 VA: 0x3723234 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372323C Offset: 0x371F23C VA: 0x372323C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3723318 Offset: 0x371F318 VA: 0x3723318 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

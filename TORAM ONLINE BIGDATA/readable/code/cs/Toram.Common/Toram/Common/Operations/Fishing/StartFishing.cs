// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class StartFishing : OperationRequestBase // TypeDefIndex: 11659
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int FieldId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372CBF4 Offset: 0x3728BF4 VA: 0x372CBF4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372CBFC Offset: 0x3728BFC VA: 0x372CBFC
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x372CC04 Offset: 0x3728C04 VA: 0x372CC04
	public void set_FieldId(int value) { }

	// RVA: 0x372CC0C Offset: 0x3728C0C VA: 0x372CC0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372CC14 Offset: 0x3728C14 VA: 0x372CC14 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372CC1C Offset: 0x3728C1C VA: 0x372CC1C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372CCBC Offset: 0x3728CBC VA: 0x372CCBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

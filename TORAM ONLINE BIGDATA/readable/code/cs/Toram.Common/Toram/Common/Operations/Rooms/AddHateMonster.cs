// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class AddHateMonster : OperationRequestBase // TypeDefIndex: 11737
{
	// Fields
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 88)]
	public int UniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373EFF0 Offset: 0x373AFF0 VA: 0x373EFF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373EFF8 Offset: 0x373AFF8 VA: 0x373EFF8
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x373F000 Offset: 0x373B000 VA: 0x373F000
	public void set_UniqueId(int value) { }

	// RVA: 0x373F008 Offset: 0x373B008 VA: 0x373F008 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373F010 Offset: 0x373B010 VA: 0x373F010 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373F018 Offset: 0x373B018 VA: 0x373F018 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373F0B8 Offset: 0x373B0B8 VA: 0x373F0B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

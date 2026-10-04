// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class SpecificCristaRemove : OperationRequestBase // TypeDefIndex: 12139
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SlotNo>k__BackingField; // 0x24

	// Properties
	public int TargetItemUuid { get; set; }
	public byte SlotNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378F414 Offset: 0x378B414 VA: 0x378F414
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378F41C Offset: 0x378B41C VA: 0x378F41C
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x378F424 Offset: 0x378B424 VA: 0x378F424
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378F42C Offset: 0x378B42C VA: 0x378F42C
	public byte get_SlotNo() { }

	[CompilerGenerated]
	// RVA: 0x378F434 Offset: 0x378B434 VA: 0x378F434
	public void set_SlotNo(byte value) { }

	// RVA: 0x378F43C Offset: 0x378B43C VA: 0x378F43C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378F444 Offset: 0x378B444 VA: 0x378F444 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378F44C Offset: 0x378B44C VA: 0x378F44C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378F528 Offset: 0x378B528 VA: 0x378F528 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

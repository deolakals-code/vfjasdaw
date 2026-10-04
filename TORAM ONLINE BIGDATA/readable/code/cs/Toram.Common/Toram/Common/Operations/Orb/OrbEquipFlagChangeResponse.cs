// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbEquipFlagChangeResponse : OperationResponseBase // TypeDefIndex: 11808
{
	// Fields
	[CompilerGenerated]
	private OrbEquipItemData <OrbEquip>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 79, IsOptional = True)]
	public OrbEquipItemData OrbEquip { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374F518 Offset: 0x374B518 VA: 0x374F518
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374F520 Offset: 0x374B520 VA: 0x374F520
	public OrbEquipItemData get_OrbEquip() { }

	[CompilerGenerated]
	// RVA: 0x374F528 Offset: 0x374B528 VA: 0x374F528
	public void set_OrbEquip(OrbEquipItemData value) { }

	// RVA: 0x374F530 Offset: 0x374B530 VA: 0x374F530
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374F64C Offset: 0x374B64C VA: 0x374F64C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374F6C8 Offset: 0x374B6C8 VA: 0x374F6C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374F6D0 Offset: 0x374B6D0 VA: 0x374F6D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374F6D8 Offset: 0x374B6D8 VA: 0x374F6D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374F770 Offset: 0x374B770 VA: 0x374F770 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

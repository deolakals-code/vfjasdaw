// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbStoreUpdateResponse : OperationResponseBase // TypeDefIndex: 11823
{
	// Fields
	[CompilerGenerated]
	private OrbItemData[] <OrbItem>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbEquipItemData[] <OrbEquip>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData[] OrbItem { get; set; }
	[PacketClass(Code = 79, IsOptional = True)]
	public OrbEquipItemData[] OrbEquip { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3751CB0 Offset: 0x374DCB0 VA: 0x3751CB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3751CB8 Offset: 0x374DCB8 VA: 0x3751CB8
	public OrbItemData[] get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x3751CC0 Offset: 0x374DCC0 VA: 0x3751CC0
	public void set_OrbItem(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3751CC8 Offset: 0x374DCC8 VA: 0x3751CC8
	public OrbEquipItemData[] get_OrbEquip() { }

	[CompilerGenerated]
	// RVA: 0x3751CD0 Offset: 0x374DCD0 VA: 0x3751CD0
	public void set_OrbEquip(OrbEquipItemData[] value) { }

	// RVA: 0x3751CD8 Offset: 0x374DCD8 VA: 0x3751CD8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3751E58 Offset: 0x374DE58 VA: 0x3751E58
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3751F20 Offset: 0x374DF20 VA: 0x3751F20 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3751F28 Offset: 0x374DF28 VA: 0x3751F28 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3751F30 Offset: 0x374DF30 VA: 0x3751F30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3751FC8 Offset: 0x374DFC8 VA: 0x3751FC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

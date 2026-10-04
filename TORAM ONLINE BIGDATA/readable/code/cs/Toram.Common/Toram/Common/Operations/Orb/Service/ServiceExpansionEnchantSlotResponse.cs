// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceExpansionEnchantSlotResponse : UnityHashBase // TypeDefIndex: 11865
{
	// Fields
	[CompilerGenerated]
	private byte <EquipType>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x1A

	// Properties
	[UnityHash(Code = 10)]
	public byte EquipType { get; set; }
	[UnityHash(Code = 11)]
	public byte Slot { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3759C88 Offset: 0x3755C88 VA: 0x3759C88
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3759C90 Offset: 0x3755C90 VA: 0x3759C90
	public byte get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x3759C98 Offset: 0x3755C98 VA: 0x3759C98
	public void set_EquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3759CA0 Offset: 0x3755CA0 VA: 0x3759CA0
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x3759CA8 Offset: 0x3755CA8 VA: 0x3759CA8
	public void set_Slot(byte value) { }

	// RVA: 0x3759CB0 Offset: 0x3755CB0 VA: 0x3759CB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3759CB8 Offset: 0x3755CB8 VA: 0x3759CB8 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x3759DE4 Offset: 0x3755DE4 VA: 0x3759DE4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

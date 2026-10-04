// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightChangeEquip : OperationRequestBase // TypeDefIndex: 12242
{
	// Fields
	[CompilerGenerated]
	private byte[] <Equip>k__BackingField; // 0x20

	// Properties
	public byte[] Equip { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E62D0 Offset: 0x35E22D0 VA: 0x35E62D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E62D8 Offset: 0x35E22D8 VA: 0x35E62D8
	public byte[] get_Equip() { }

	[CompilerGenerated]
	// RVA: 0x35E62E0 Offset: 0x35E22E0 VA: 0x35E62E0
	public void set_Equip(byte[] value) { }

	// RVA: 0x35E62E8 Offset: 0x35E22E8 VA: 0x35E62E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E62F0 Offset: 0x35E22F0 VA: 0x35E62F0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E62F8 Offset: 0x35E22F8 VA: 0x35E62F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E6364 Offset: 0x35E2364 VA: 0x35E6364 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

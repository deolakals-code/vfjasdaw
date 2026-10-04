// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemEquip : OperationRequestBase // TypeDefIndex: 11831
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, long> <Equips>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Cost>k__BackingField; // 0x28

	// Properties
	public Dictionary<byte, long> Equips { get; set; }
	public int Cost { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3752F84 Offset: 0x374EF84 VA: 0x3752F84
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3752F8C Offset: 0x374EF8C VA: 0x3752F8C
	public Dictionary<byte, long> get_Equips() { }

	[CompilerGenerated]
	// RVA: 0x3752F94 Offset: 0x374EF94 VA: 0x3752F94
	public void set_Equips(Dictionary<byte, long> value) { }

	[CompilerGenerated]
	// RVA: 0x3752F9C Offset: 0x374EF9C VA: 0x3752F9C
	public int get_Cost() { }

	[CompilerGenerated]
	// RVA: 0x3752FA4 Offset: 0x374EFA4 VA: 0x3752FA4
	public void set_Cost(int value) { }

	// RVA: 0x3752FAC Offset: 0x374EFAC VA: 0x3752FAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3752FB4 Offset: 0x374EFB4 VA: 0x3752FB4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3752FBC Offset: 0x374EFBC VA: 0x3752FBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x375317C Offset: 0x374F17C VA: 0x375317C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

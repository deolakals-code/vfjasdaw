// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class GetFoodPointResponse : OperationResponseBase // TypeDefIndex: 12256
{
	// Fields
	[CompilerGenerated]
	private int <FoodPoint>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 205)]
	public int FoodPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E7D6C Offset: 0x35E3D6C VA: 0x35E7D6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E7D74 Offset: 0x35E3D74 VA: 0x35E7D74
	public int get_FoodPoint() { }

	[CompilerGenerated]
	// RVA: 0x35E7D7C Offset: 0x35E3D7C VA: 0x35E7D7C
	public void set_FoodPoint(int value) { }

	// RVA: 0x35E7D84 Offset: 0x35E3D84 VA: 0x35E7D84
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7D88 Offset: 0x35E3D88 VA: 0x35E7D88
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7D8C Offset: 0x35E3D8C VA: 0x35E7D8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E7D94 Offset: 0x35E3D94 VA: 0x35E7D94 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E7D9C Offset: 0x35E3D9C VA: 0x35E7D9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7EBC Offset: 0x35E3EBC VA: 0x35E7EBC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

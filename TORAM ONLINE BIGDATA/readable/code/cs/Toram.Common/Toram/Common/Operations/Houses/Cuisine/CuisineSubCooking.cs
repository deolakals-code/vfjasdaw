// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineSubCooking : OperationRequestBase // TypeDefIndex: 12249
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Lv>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 101)]
	public byte Lv { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E7070 Offset: 0x35E3070 VA: 0x35E7070
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E7078 Offset: 0x35E3078 VA: 0x35E7078
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E7080 Offset: 0x35E3080 VA: 0x35E7080
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E7088 Offset: 0x35E3088 VA: 0x35E7088
	public byte get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x35E7090 Offset: 0x35E3090 VA: 0x35E7090
	public void set_Lv(byte value) { }

	// RVA: 0x35E7098 Offset: 0x35E3098 VA: 0x35E7098
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E709C Offset: 0x35E309C VA: 0x35E709C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E70A0 Offset: 0x35E30A0 VA: 0x35E70A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E70A8 Offset: 0x35E30A8 VA: 0x35E70A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E70B0 Offset: 0x35E30B0 VA: 0x35E70B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7228 Offset: 0x35E3228 VA: 0x35E7228 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

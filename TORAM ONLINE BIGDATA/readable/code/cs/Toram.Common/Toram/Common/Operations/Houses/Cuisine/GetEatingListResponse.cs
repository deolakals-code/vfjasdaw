// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class GetEatingListResponse : OperationResponseBase // TypeDefIndex: 12254
{
	// Fields
	[CompilerGenerated]
	private Dictionary<int, byte> <CuisineList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RemainingTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <MyCuisineFlag>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 213)]
	public Dictionary<int, byte> CuisineList { get; set; }
	[PacketParameter(Code = 172)]
	public int RemainingTime { get; set; }
	[PacketParameter(Code = 43)]
	public bool MyCuisineFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E79D8 Offset: 0x35E39D8 VA: 0x35E79D8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E79E0 Offset: 0x35E39E0 VA: 0x35E79E0
	public Dictionary<int, byte> get_CuisineList() { }

	[CompilerGenerated]
	// RVA: 0x35E79E8 Offset: 0x35E39E8 VA: 0x35E79E8
	public void set_CuisineList(Dictionary<int, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x35E79F0 Offset: 0x35E39F0 VA: 0x35E79F0
	public int get_RemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x35E79F8 Offset: 0x35E39F8 VA: 0x35E79F8
	public void set_RemainingTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E7A00 Offset: 0x35E3A00 VA: 0x35E7A00
	public bool get_MyCuisineFlag() { }

	[CompilerGenerated]
	// RVA: 0x35E7A08 Offset: 0x35E3A08 VA: 0x35E7A08
	public void set_MyCuisineFlag(bool value) { }

	// RVA: 0x35E7A14 Offset: 0x35E3A14 VA: 0x35E7A14
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7A18 Offset: 0x35E3A18 VA: 0x35E7A18
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7A1C Offset: 0x35E3A1C VA: 0x35E7A1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E7A24 Offset: 0x35E3A24 VA: 0x35E7A24 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E7A2C Offset: 0x35E3A2C VA: 0x35E7A2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7C44 Offset: 0x35E3C44 VA: 0x35E7C44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

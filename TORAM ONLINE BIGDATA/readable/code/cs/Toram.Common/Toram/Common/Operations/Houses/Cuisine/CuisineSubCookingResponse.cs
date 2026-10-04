// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineSubCookingResponse : OperationResponseBase // TypeDefIndex: 12250
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FoodPoint>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 205)]
	public int FoodPoint { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 180)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E7304 Offset: 0x35E3304 VA: 0x35E7304
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E730C Offset: 0x35E330C VA: 0x35E730C
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E7314 Offset: 0x35E3314 VA: 0x35E7314
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E731C Offset: 0x35E331C VA: 0x35E731C
	public int get_FoodPoint() { }

	[CompilerGenerated]
	// RVA: 0x35E7324 Offset: 0x35E3324 VA: 0x35E7324
	public void set_FoodPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E732C Offset: 0x35E332C VA: 0x35E732C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35E7334 Offset: 0x35E3334 VA: 0x35E7334
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E733C Offset: 0x35E333C VA: 0x35E733C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x35E7344 Offset: 0x35E3344 VA: 0x35E7344
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x35E734C Offset: 0x35E334C VA: 0x35E734C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7350 Offset: 0x35E3350 VA: 0x35E7350
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7354 Offset: 0x35E3354 VA: 0x35E7354 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E735C Offset: 0x35E335C VA: 0x35E735C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E7364 Offset: 0x35E3364 VA: 0x35E7364 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E75FC Offset: 0x35E35FC VA: 0x35E75FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

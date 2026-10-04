// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineDineOutResponse : OperationResponseBase // TypeDefIndex: 12260
{
	// Fields
	[CompilerGenerated]
	private Dictionary<int, byte> <CuisineList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RemainingTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <MyCuisineFlag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 213)]
	public Dictionary<int, byte> CuisineList { get; set; }
	[PacketParameter(Code = 172)]
	public int RemainingTime { get; set; }
	[PacketParameter(Code = 43)]
	public bool MyCuisineFlag { get; set; }
	[PacketParameter(Code = 180)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E8A6C Offset: 0x35E4A6C VA: 0x35E8A6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E8A74 Offset: 0x35E4A74 VA: 0x35E8A74
	public Dictionary<int, byte> get_CuisineList() { }

	[CompilerGenerated]
	// RVA: 0x35E8A7C Offset: 0x35E4A7C VA: 0x35E8A7C
	public void set_CuisineList(Dictionary<int, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x35E8A84 Offset: 0x35E4A84 VA: 0x35E8A84
	public int get_RemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x35E8A8C Offset: 0x35E4A8C VA: 0x35E8A8C
	public void set_RemainingTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E8A94 Offset: 0x35E4A94 VA: 0x35E8A94
	public bool get_MyCuisineFlag() { }

	[CompilerGenerated]
	// RVA: 0x35E8A9C Offset: 0x35E4A9C VA: 0x35E8A9C
	public void set_MyCuisineFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35E8AA8 Offset: 0x35E4AA8 VA: 0x35E8AA8
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x35E8AB0 Offset: 0x35E4AB0 VA: 0x35E8AB0
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x35E8AB8 Offset: 0x35E4AB8 VA: 0x35E8AB8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E8ABC Offset: 0x35E4ABC VA: 0x35E8ABC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E8AC0 Offset: 0x35E4AC0 VA: 0x35E8AC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E8AC8 Offset: 0x35E4AC8 VA: 0x35E8AC8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E8AD0 Offset: 0x35E4AD0 VA: 0x35E8AD0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E8D90 Offset: 0x35E4D90 VA: 0x35E8D90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

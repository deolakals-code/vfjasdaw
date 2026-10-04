// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineCleanUpResponse : OperationResponseBase // TypeDefIndex: 12245
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 180)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E6A00 Offset: 0x35E2A00 VA: 0x35E6A00
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E6A08 Offset: 0x35E2A08 VA: 0x35E6A08
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x35E6A10 Offset: 0x35E2A10 VA: 0x35E6A10
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x35E6A18 Offset: 0x35E2A18 VA: 0x35E6A18
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6A1C Offset: 0x35E2A1C VA: 0x35E6A1C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6A20 Offset: 0x35E2A20 VA: 0x35E6A20 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E6A28 Offset: 0x35E2A28 VA: 0x35E6A28 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E6A30 Offset: 0x35E2A30 VA: 0x35E6A30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6BA0 Offset: 0x35E2BA0 VA: 0x35E6BA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineChangeTypeResponse : OperationResponseBase // TypeDefIndex: 12248
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

	// RVA: 0x35E6E48 Offset: 0x35E2E48 VA: 0x35E6E48
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E6E50 Offset: 0x35E2E50 VA: 0x35E6E50
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x35E6E58 Offset: 0x35E2E58 VA: 0x35E6E58
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x35E6E60 Offset: 0x35E2E60 VA: 0x35E6E60
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6E64 Offset: 0x35E2E64 VA: 0x35E6E64
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6E68 Offset: 0x35E2E68 VA: 0x35E6E68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E6E70 Offset: 0x35E2E70 VA: 0x35E6E70 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E6E78 Offset: 0x35E2E78 VA: 0x35E6E78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6FE8 Offset: 0x35E2FE8 VA: 0x35E6FE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

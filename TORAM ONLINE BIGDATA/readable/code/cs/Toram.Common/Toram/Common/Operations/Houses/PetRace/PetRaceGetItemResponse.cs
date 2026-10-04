// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceGetItemResponse : OperationResponseBase // TypeDefIndex: 12220
{
	// Fields
	public int ItemBit; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E2B6C Offset: 0x35DEB6C VA: 0x35E2B6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E2B74 Offset: 0x35DEB74 VA: 0x35E2B74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E2B7C Offset: 0x35DEB7C VA: 0x35E2B7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E2B84 Offset: 0x35DEB84 VA: 0x35E2B84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E2CA4 Offset: 0x35DECA4 VA: 0x35E2CA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

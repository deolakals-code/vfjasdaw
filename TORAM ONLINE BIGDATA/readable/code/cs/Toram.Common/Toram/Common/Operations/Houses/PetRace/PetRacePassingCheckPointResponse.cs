// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRacePassingCheckPointResponse : OperationResponseBase // TypeDefIndex: 12226
{
	// Fields
	public byte NextCheckPoint; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E3890 Offset: 0x35DF890 VA: 0x35E3890
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E3898 Offset: 0x35DF898 VA: 0x35E3898 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E38A0 Offset: 0x35DF8A0 VA: 0x35E38A0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E38A8 Offset: 0x35DF8A8 VA: 0x35E38A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E39DC Offset: 0x35DF9DC VA: 0x35E39DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

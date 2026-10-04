// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceGoalResponse : OperationResponseBase // TypeDefIndex: 12225
{
	// Fields
	public Dictionary<int, int> Ranking; // 0x20
	public bool NewRecord; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E35C4 Offset: 0x35DF5C4 VA: 0x35E35C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E35CC Offset: 0x35DF5CC VA: 0x35E35CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E35D4 Offset: 0x35DF5D4 VA: 0x35E35D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E35DC Offset: 0x35DF5DC VA: 0x35E35DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E37D4 Offset: 0x35DF7D4 VA: 0x35E37D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.PetRace
public class PetRaceEndEvent : EventSubBase // TypeDefIndex: 12820
{
	// Fields
	public Dictionary<int, int> Ranking; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3660E50 Offset: 0x365CE50 VA: 0x3660E50
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3660E58 Offset: 0x365CE58 VA: 0x3660E58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3660E60 Offset: 0x365CE60 VA: 0x3660E60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3660E68 Offset: 0x365CE68 VA: 0x3660E68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3661000 Offset: 0x365D000 VA: 0x3661000 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceJoinPlayPhaseResponse : PetRaceJoinResponse // TypeDefIndex: 12231
{
	// Fields
	public int ElapsedMs; // 0x38
	public byte NextCheckPoint; // 0x3C
	public int RandomSeed; // 0x40
	public short RemainingSeconds; // 0x44
	public Dictionary<int, int> Ranking; // 0x48
	public int PetArchetypeId; // 0x50
	public int ItemBit; // 0x54

	// Properties
	public int GamePlayElapsedSecond { get; }

	// Methods

	// RVA: 0x35E47A8 Offset: 0x35E07A8 VA: 0x35E47A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E47B0 Offset: 0x35E07B0 VA: 0x35E47B0
	public int get_GamePlayElapsedSecond() { }

	// RVA: 0x35E47C0 Offset: 0x35E07C0 VA: 0x35E47C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E4B44 Offset: 0x35E0B44 VA: 0x35E4B44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AbnormalPoisonData : AbnormalData // TypeDefIndex: 1645
{
	// Fields
	private readonly byte poisonLevel; // 0x28

	// Properties
	public byte PoisonLevel { get; }

	// Methods

	// RVA: 0x20A02A8 Offset: 0x209C2A8 VA: 0x20A02A8
	public void .ctor(byte poisonLevel, float time, float resistTime, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A02D4 Offset: 0x209C2D4 VA: 0x20A02D4
	public byte get_PoisonLevel() { }

	// RVA: 0x20A02E8 Offset: 0x209C2E8 VA: 0x20A02E8
	public bool CheckMaxPoisonLevel() { }
}

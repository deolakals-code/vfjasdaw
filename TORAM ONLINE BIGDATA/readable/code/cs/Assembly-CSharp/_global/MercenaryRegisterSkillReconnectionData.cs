// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryRegisterSkillReconnectionData : MercenaryOperationReconectionBase // TypeDefIndex: 4933
{
	// Fields
	private StanceType type; // 0x10
	private Dictionary<short, byte> skills; // 0x18

	// Properties
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x25ED2A4 Offset: 0x25E92A4 VA: 0x25ED2A4
	public void .ctor(StanceType type, Dictionary<short, byte> skills) { }

	// RVA: 0x25ED2DC Offset: 0x25E92DC VA: 0x25ED2DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x25ED2E4 Offset: 0x25E92E4 VA: 0x25ED2E4 Slot: 8
	public override void Reconnection(Game engine) { }
}

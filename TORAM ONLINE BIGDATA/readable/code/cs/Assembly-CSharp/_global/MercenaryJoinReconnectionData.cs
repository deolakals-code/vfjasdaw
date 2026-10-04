// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryJoinReconnectionData : PatyOperationReconectionBase // TypeDefIndex: 5084
{
	// Fields
	private int gold; // 0x10
	private MercenaryEmploymentType type; // 0x14
	private int mercenaryId; // 0x18
	private DateTime register; // 0x20

	// Properties
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x25F00CC Offset: 0x25EC0CC VA: 0x25F00CC
	public void .ctor(int gold, MercenaryEmploymentType type, int mercenaryId, DateTime register) { }

	// RVA: 0x25F0118 Offset: 0x25EC118 VA: 0x25F0118 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x25F0120 Offset: 0x25EC120 VA: 0x25F0120 Slot: 8
	public override void Reconnection(Game engine) { }
}

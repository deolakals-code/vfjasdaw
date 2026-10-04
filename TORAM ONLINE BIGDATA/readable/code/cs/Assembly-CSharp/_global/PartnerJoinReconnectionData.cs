// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartnerJoinReconnectionData : PatyOperationReconectionBase // TypeDefIndex: 5085
{
	// Fields
	private byte partnerNo; // 0x10
	private StanceType type; // 0x14

	// Properties
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x25F013C Offset: 0x25EC13C VA: 0x25F013C
	public void .ctor(byte partnerNo, StanceType type) { }

	// RVA: 0x25F016C Offset: 0x25EC16C VA: 0x25F016C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x25F0174 Offset: 0x25EC174 VA: 0x25F0174 Slot: 8
	public override void Reconnection(Game engine) { }
}

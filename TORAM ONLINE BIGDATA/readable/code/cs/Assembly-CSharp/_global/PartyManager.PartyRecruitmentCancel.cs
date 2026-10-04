// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyManager.PartyRecruitmentCancel : PartyRecruitmentCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2195
{
	// Fields
	private Action<bool> initialize; // 0x18
	private Action callBack; // 0x20

	// Methods

	// RVA: 0x216A500 Offset: 0x2166500 VA: 0x216A500
	public void .ctor(byte frameNo, int targetAvatarUuid, Action<bool> intialize, Action callBack) { }

	// RVA: 0x216A544 Offset: 0x2166544 VA: 0x216A544
	public void .ctor(byte frameNo, int targetAvatarUuid) { }

	// RVA: 0x216A54C Offset: 0x216654C VA: 0x216A54C Slot: 13
	protected override void OnCandidateProblem(short returnCode) { }

	// RVA: 0x216A56C Offset: 0x216656C VA: 0x216A56C Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x216A58C Offset: 0x216658C VA: 0x216A58C Slot: 11
	protected override void OnNotRecruited(short returnCode) { }

	// RVA: 0x216A5AC Offset: 0x21665AC VA: 0x216A5AC Slot: 12
	protected override void OnSlotNotAvailable(short returnCode) { }

	// RVA: 0x216A5CC Offset: 0x21665CC VA: 0x216A5CC Slot: 10
	protected override void OnSuccess(PartyRecruitmentCancelResponse response) { }
}

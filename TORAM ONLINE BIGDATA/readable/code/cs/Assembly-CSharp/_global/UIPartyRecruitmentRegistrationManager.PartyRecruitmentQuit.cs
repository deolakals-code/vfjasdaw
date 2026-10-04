// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentRegistrationManager.PartyRecruitmentQuit : PartyRecruitmentQuitExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7713
{
	// Fields
	private UIPartyRecruitmentRegistrationManager uiManager; // 0x10

	// Methods

	// RVA: 0x1BEF020 Offset: 0x1BEB020 VA: 0x1BEF020
	public void .ctor(UIPartyRecruitmentRegistrationManager uiManager) { }

	// RVA: 0x1BEFF38 Offset: 0x1BEBF38 VA: 0x1BEFF38 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BEFF90 Offset: 0x1BEBF90 VA: 0x1BEFF90 Slot: 11
	protected override void OnNotRecruiting(short returnCode) { }

	// RVA: 0x1BEFFE8 Offset: 0x1BEBFE8 VA: 0x1BEFFE8 Slot: 10
	protected override void OnSuccess(PartyRecruitmentQuitResponse response) { }
}

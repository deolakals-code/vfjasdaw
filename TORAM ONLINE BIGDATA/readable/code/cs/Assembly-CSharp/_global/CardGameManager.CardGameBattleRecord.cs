// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CardGameManager.CardGameBattleRecord : CardGameBattleRecordExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 4263
{
	// Fields
	private CardGameManager manager; // 0x10
	private Action callback; // 0x18

	// Methods

	// RVA: 0x24BC30C Offset: 0x24B830C VA: 0x24BC30C
	public void .ctor(CardGameManager manager, Action callback) { }

	// RVA: 0x24C319C Offset: 0x24BF19C VA: 0x24C319C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x24C31A0 Offset: 0x24BF1A0 VA: 0x24C31A0 Slot: 12
	protected override void OnMemberNotFound() { }

	// RVA: 0x24C3250 Offset: 0x24BF250 VA: 0x24C3250 Slot: 10
	protected override void OnSuccess(CardGameBattleRecordResponse response) { }
}

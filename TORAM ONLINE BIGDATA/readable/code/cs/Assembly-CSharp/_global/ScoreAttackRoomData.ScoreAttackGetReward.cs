// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackRoomData.ScoreAttackGetReward : ScoreAttackGetRewardExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2466
{
	// Fields
	private Action<ScoreAttackGetRewardResponse> callBack; // 0x18
	private Action<string> errorCallBack; // 0x20

	// Methods

	// RVA: 0x21BC628 Offset: 0x21B8628 VA: 0x21BC628
	public void .ctor(byte week, byte rotationId, byte bossId, byte rankingType, Action<ScoreAttackGetRewardResponse> callBack, Action<string> errorCallBack) { }

	// RVA: 0x21BC66C Offset: 0x21B866C VA: 0x21BC66C Slot: 11
	protected override void OnCalculatingPeriod() { }

	// RVA: 0x21BC670 Offset: 0x21B8670 VA: 0x21BC670 Slot: 12
	protected override void OnDifferenceInformation() { }

	// RVA: 0x21BC6CC Offset: 0x21B86CC VA: 0x21BC6CC Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21BC728 Offset: 0x21B8728 VA: 0x21BC728 Slot: 10
	protected override void OnSuccess(ScoreAttackGetRewardResponse response) { }
}

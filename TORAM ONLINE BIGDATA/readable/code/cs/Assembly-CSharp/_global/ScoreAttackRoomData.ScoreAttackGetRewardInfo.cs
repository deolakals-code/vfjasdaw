// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackRoomData.ScoreAttackGetRewardInfo : ScoreAttackGetRewardInfoExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2467
{
	// Fields
	private Action<ScoreAttackGetRewardInfoResponse> callBack; // 0x10
	private Action<string> errorCallBack; // 0x18

	// Methods

	// RVA: 0x21BC74C Offset: 0x21B874C VA: 0x21BC74C
	public void .ctor(Action<ScoreAttackGetRewardInfoResponse> callBack, Action<string> errorCallBack) { }

	// RVA: 0x21BC790 Offset: 0x21B8790 VA: 0x21BC790 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21BC7EC Offset: 0x21B87EC VA: 0x21BC7EC Slot: 10
	protected override void OnSuccess(ScoreAttackGetRewardInfoResponse response) { }
}

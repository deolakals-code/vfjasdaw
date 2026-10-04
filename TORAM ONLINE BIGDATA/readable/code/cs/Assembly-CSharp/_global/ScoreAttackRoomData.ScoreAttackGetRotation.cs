// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackRoomData.ScoreAttackGetRotation : ScoreAttackGetRotationExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2463
{
	// Fields
	private Action<ScoreAttackGetRotationResponse> callBack; // 0x10
	private Action<string> errorCallBack; // 0x18

	// Methods

	// RVA: 0x21BC114 Offset: 0x21B8114 VA: 0x21BC114
	public void .ctor(Action<ScoreAttackGetRotationResponse> callBack, Action<string> errorCallBack) { }

	// RVA: 0x21BC158 Offset: 0x21B8158 VA: 0x21BC158 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21BC1B4 Offset: 0x21B81B4 VA: 0x21BC1B4 Slot: 11
	protected override void OnNotEnoughAccountProgress() { }

	// RVA: 0x21BC210 Offset: 0x21B8210 VA: 0x21BC210 Slot: 10
	protected override void OnSuccess(ScoreAttackGetRotationResponse response) { }
}

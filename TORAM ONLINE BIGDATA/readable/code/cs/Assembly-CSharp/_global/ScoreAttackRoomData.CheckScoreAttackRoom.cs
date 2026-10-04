// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackRoomData.CheckScoreAttackRoom : CheckScoreAttackRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2464
{
	// Fields
	private Action<CheckScoreAttackRoomResponse> callBack; // 0x18
	private Action<string> errorCallBack; // 0x20

	// Methods

	// RVA: 0x21BC014 Offset: 0x21B8014 VA: 0x21BC014
	public void .ctor(bool isSolo, byte bossId, Action<CheckScoreAttackRoomResponse> callBack, Action<string> errorCallBack, bool isIgnoreRotation = False) { }

	// RVA: 0x21BC234 Offset: 0x21B8234 VA: 0x21BC234 Slot: 13
	protected override void OnBossNotHeld() { }

	// RVA: 0x21BC290 Offset: 0x21B8290 VA: 0x21BC290 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21BC2EC Offset: 0x21B82EC VA: 0x21BC2EC Slot: 12
	protected override void OnMercenaryNotAllowed() { }

	// RVA: 0x21BC348 Offset: 0x21B8348 VA: 0x21BC348 Slot: 11
	protected override void OnNotEnoughAccountProgress() { }

	// RVA: 0x21BC3A4 Offset: 0x21B83A4 VA: 0x21BC3A4 Slot: 14
	protected override void OnNotHeld() { }

	// RVA: 0x21BC3DC Offset: 0x21B83DC VA: 0x21BC3DC Slot: 10
	protected override void OnSuccess(CheckScoreAttackRoomResponse response) { }
}

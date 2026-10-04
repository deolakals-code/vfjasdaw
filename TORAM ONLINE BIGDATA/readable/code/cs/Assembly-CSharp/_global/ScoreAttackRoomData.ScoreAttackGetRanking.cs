// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackRoomData.ScoreAttackGetRanking : ScoreAttackGetRankingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2465
{
	// Fields
	private Action<ScoreAttackGetRankingResponse> callBack; // 0x18
	private Action<string> errorCallBack; // 0x20

	// Methods

	// RVA: 0x21BC484 Offset: 0x21B8484 VA: 0x21BC484
	public void .ctor(byte week, byte rotationId, byte bossId, byte rankingType) { }

	// RVA: 0x21BC48C Offset: 0x21B848C VA: 0x21BC48C
	public void .ctor(byte week, byte rotationId, byte bossId, byte rankingType, Action<ScoreAttackGetRankingResponse> callBack, Action<string> errorCallBack) { }

	// RVA: 0x21BC4D0 Offset: 0x21B84D0 VA: 0x21BC4D0 Slot: 11
	protected override void OnCalculatingPeriod() { }

	// RVA: 0x21BC52C Offset: 0x21B852C VA: 0x21BC52C Slot: 12
	protected override void OnDifferenceInformation() { }

	// RVA: 0x21BC5A8 Offset: 0x21B85A8 VA: 0x21BC5A8 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21BC604 Offset: 0x21B8604 VA: 0x21BC604 Slot: 10
	protected override void OnSuccess(ScoreAttackGetRankingResponse response) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class XmasEventData2015 : GameEventDataBase // TypeDefIndex: 1875
{
	// Fields
	public const int SocksItemId = 102046;
	private Dictionary<byte, byte> socksStateData; // 0x18
	private Action<int> setEventCallBack; // 0x20
	private Action<int> getEventCallBack; // 0x28
	private RewardData[] rewardData; // 0x30

	// Properties
	public RewardData[] GetRewardData { get; }
	public override byte GameEventType { get; }

	// Methods

	// RVA: 0x20F8040 Offset: 0x20F4040 VA: 0x20F8040
	public RewardData[] get_GetRewardData() { }

	// RVA: 0x20F8048 Offset: 0x20F4048 VA: 0x20F8048 Slot: 4
	public override byte get_GameEventType() { }

	// RVA: 0x20F8050 Offset: 0x20F4050 VA: 0x20F8050 Slot: 5
	public override void Initialize(byte[] binary) { }

	// RVA: 0x20F8254 Offset: 0x20F4254 VA: 0x20F8254 Slot: 7
	public override void Clear() { }

	// RVA: 0x20F82C4 Offset: 0x20F42C4 VA: 0x20F82C4 Slot: 8
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20F8300 Offset: 0x20F4300 VA: 0x20F8300
	public byte GetSocksState(byte id) { }

	// RVA: 0x20F8378 Offset: 0x20F4378 VA: 0x20F8378 Slot: 9
	public override void GetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20F8524 Offset: 0x20F4524 VA: 0x20F8524 Slot: 10
	public override void ReceiveGetEvent(GetEventResponse response, short returnCode) { }

	// RVA: 0x20F88A8 Offset: 0x20F48A8 VA: 0x20F88A8 Slot: 11
	public override void SetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20F8A64 Offset: 0x20F4A64 VA: 0x20F8A64 Slot: 12
	public override void ReceiveSetEvent(SetEventResponse response, short returnCode) { }

	// RVA: 0x20F8D84 Offset: 0x20F4D84 VA: 0x20F8D84
	public void .ctor() { }
}

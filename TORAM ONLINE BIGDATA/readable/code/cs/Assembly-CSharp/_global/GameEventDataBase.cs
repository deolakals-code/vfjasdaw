// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class GameEventDataBase // TypeDefIndex: 1833
{
	// Fields
	private PlayerDataManager playerManager; // 0x10

	// Properties
	public abstract byte GameEventType { get; }
	protected PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_GameEventType();

	// RVA: 0x20EC05C Offset: 0x20E805C VA: 0x20EC05C
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Initialize(byte[] binary);

	// RVA: 0x20EC0E0 Offset: 0x20E80E0 VA: 0x20EC0E0 Slot: 6
	public virtual void OnEnter() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnFailure(byte operationCode, short returnCode);

	// RVA: 0x20EC0E4 Offset: 0x20E80E4 VA: 0x20EC0E4 Slot: 9
	public virtual void GetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20EC0E8 Offset: 0x20E80E8 VA: 0x20EC0E8 Slot: 10
	public virtual void ReceiveGetEvent(GetEventResponse response, short returnCode) { }

	// RVA: 0x20EC0EC Offset: 0x20E80EC VA: 0x20EC0EC Slot: 11
	public virtual void SetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20EC0F0 Offset: 0x20E80F0 VA: 0x20EC0F0 Slot: 12
	public virtual void ReceiveSetEvent(SetEventResponse response, short returnCode) { }

	// RVA: 0x20EB8D0 Offset: 0x20E78D0 VA: 0x20EB8D0
	protected void .ctor() { }
}

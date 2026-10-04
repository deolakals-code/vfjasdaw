// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents // TypeDefIndex: 16604
{
	// Fields
	[SerializeField]
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x37F94F8 Offset: 0x37F54F8 VA: 0x37F94F8
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x37F868C Offset: 0x37F468C VA: 0x37F868C
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x37F8A30 Offset: 0x37F4A30 VA: 0x37F8A30
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x37F9BCC Offset: 0x37F5BCC VA: 0x37F9BCC
	public void .ctor() { }
}

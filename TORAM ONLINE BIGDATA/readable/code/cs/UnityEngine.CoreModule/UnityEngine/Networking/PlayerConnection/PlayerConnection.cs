// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class PlayerConnection : ScriptableObject // TypeDefIndex: 16597
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField]
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x37F8124 Offset: 0x37F4124 VA: 0x37F8124
	public static PlayerConnection get_instance() { }

	// RVA: 0x37F8274 Offset: 0x37F4274 VA: 0x37F8274
	public bool get_isConnected() { }

	// RVA: 0x37F81B8 Offset: 0x37F41B8 VA: 0x37F81B8
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x37F8388 Offset: 0x37F4388 VA: 0x37F8388
	public void OnEnable() { }

	// RVA: 0x37F8310 Offset: 0x37F4310 VA: 0x37F8310
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x37F8448 Offset: 0x37F4448 VA: 0x37F8448 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x37F8884 Offset: 0x37F4884 VA: 0x37F8884 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x37F8B98 Offset: 0x37F4B98 VA: 0x37F8B98 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x37F8D38 Offset: 0x37F4D38 VA: 0x37F8D38 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x37F8D98 Offset: 0x37F4D98 VA: 0x37F8D98 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x37F8DF8 Offset: 0x37F4DF8 VA: 0x37F8DF8 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x37F8E58 Offset: 0x37F4E58 VA: 0x37F8E58 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x37F8FB0 Offset: 0x37F4FB0 VA: 0x37F8FB0 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x37F9108 Offset: 0x37F5108 VA: 0x37F9108
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x37F9344 Offset: 0x37F5344 VA: 0x37F9344 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCode]
	// RVA: 0x37F93E0 Offset: 0x37F53E0 VA: 0x37F93E0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCode]
	// RVA: 0x37F99A8 Offset: 0x37F59A8 VA: 0x37F99A8
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCode]
	// RVA: 0x37F9A80 Offset: 0x37F5A80 VA: 0x37F9A80
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x37F9B14 Offset: 0x37F5B14 VA: 0x37F9B14
	public void .ctor() { }
}

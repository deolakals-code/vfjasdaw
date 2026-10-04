// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 16313
{
	// Methods

	// RVA: 0x37E8848 Offset: 0x37E4848 VA: 0x37E8848 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x37E89C4 Offset: 0x37E49C4 VA: 0x37E89C4 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x37E8B44 Offset: 0x37E4B44 VA: 0x37E8B44 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x37E8B94 Offset: 0x37E4B94 VA: 0x37E8B94 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x37E8C54 Offset: 0x37E4C54 VA: 0x37E8C54 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x37E8D14 Offset: 0x37E4D14 VA: 0x37E8D14 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x37E8D64 Offset: 0x37E4D64 VA: 0x37E8D64 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x37E8DB4 Offset: 0x37E4DB4 VA: 0x37E8DB4 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	// RVA: 0x37E8D8C Offset: 0x37E4D8C VA: 0x37E8D8C
	private static bool IsConnected() { }

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	// RVA: 0x37E8D3C Offset: 0x37E4D3C VA: 0x37E8D3C
	private static void Initialize() { }

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	// RVA: 0x37E8C18 Offset: 0x37E4C18 VA: 0x37E8C18
	private static void RegisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	// RVA: 0x37E8CD8 Offset: 0x37E4CD8 VA: 0x37E8CD8
	private static void UnregisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	// RVA: 0x37E8970 Offset: 0x37E4970 VA: 0x37E8970
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	// RVA: 0x37E8AF0 Offset: 0x37E4AF0 VA: 0x37E8AF0
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	// RVA: 0x37E8B6C Offset: 0x37E4B6C VA: 0x37E8B6C
	private static void PollInternal() { }

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	// RVA: 0x37E8DDC Offset: 0x37E4DDC VA: 0x37E8DDC
	private static void DisconnectAll() { }

	// RVA: 0x37E8E04 Offset: 0x37E4E04 VA: 0x37E8E04
	public void .ctor() { }
}

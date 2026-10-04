// Assembly: Firebase.Messaging.dll
// Namespace: 
internal class FirebaseMessagingInternal.Listener : IDisposable // TypeDefIndex: 17720
{
	// Fields
	private FirebaseMessagingInternal.Listener.MessageReceivedDelegate messageReceivedDelegate; // 0x10
	private FirebaseMessagingInternal.Listener.TokenReceivedDelegate tokenReceivedDelegate; // 0x18
	private FirebaseApp app; // 0x20
	private static FirebaseMessagingInternal.Listener listener; // 0x0

	// Methods

	// RVA: 0x2667204 Offset: 0x2663204 VA: 0x2667204
	internal static FirebaseMessagingInternal.Listener Create() { }

	// RVA: 0x2667370 Offset: 0x2663370 VA: 0x2667370
	internal static void Destroy() { }

	// RVA: 0x26678CC Offset: 0x26638CC VA: 0x26678CC
	private void .ctor() { }

	// RVA: 0x2667D0C Offset: 0x2663D0C VA: 0x2667D0C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2667A20 Offset: 0x2663A20 VA: 0x2667A20 Slot: 4
	public void Dispose() { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternal.Listener.MessageReceivedDelegate))]
	// RVA: 0x2667744 Offset: 0x2663744 VA: 0x2667744
	private static bool MessageReceivedDelegateMethod(IntPtr message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternal.Listener.TokenReceivedDelegate))]
	// RVA: 0x266780C Offset: 0x266380C VA: 0x266780C
	private static void TokenReceivedDelegateMethod(string token) { }
}

// Assembly: Firebase.Messaging.dll
// Namespace: Firebase.Messaging
internal sealed class FirebaseMessagingInternal // TypeDefIndex: 17721
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static EventHandler<MessageReceivedEventArgs> MessageReceivedInternal; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static EventHandler<TokenReceivedEventArgs> TokenReceivedInternal; // 0x8
	private static FirebaseMessagingInternal.Listener listener; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x2666C98 Offset: 0x2662C98 VA: 0x2666C98
	internal static void add_MessageReceivedInternal(EventHandler<MessageReceivedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x2666D88 Offset: 0x2662D88 VA: 0x2666D88
	internal static void remove_MessageReceivedInternal(EventHandler<MessageReceivedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x2666E78 Offset: 0x2662E78 VA: 0x2666E78
	internal static void add_TokenReceivedInternal(EventHandler<TokenReceivedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x2666F6C Offset: 0x2662F6C VA: 0x2666F6C
	internal static void remove_TokenReceivedInternal(EventHandler<TokenReceivedEventArgs> value) { }

	// RVA: 0x2667060 Offset: 0x2663060 VA: 0x2667060
	internal static void CreateOrDestroyListener() { }

	// RVA: 0x2667624 Offset: 0x2663624 VA: 0x2667624
	private static void .cctor() { }

	// RVA: 0x266242C Offset: 0x265E42C VA: 0x266242C
	public static void add_MessageReceived(EventHandler<MessageReceivedEventArgs> value) { }

	// RVA: 0x26625C0 Offset: 0x265E5C0 VA: 0x26625C0
	public static void remove_MessageReceived(EventHandler<MessageReceivedEventArgs> value) { }

	// RVA: 0x2662754 Offset: 0x265E754 VA: 0x2662754
	public static void add_TokenReceived(EventHandler<TokenReceivedEventArgs> value) { }

	// RVA: 0x26628E8 Offset: 0x265E8E8 VA: 0x26628E8
	public static void remove_TokenReceived(EventHandler<TokenReceivedEventArgs> value) { }

	// RVA: 0x26621CC Offset: 0x265E1CC VA: 0x26621CC
	public static void SetTokenRegistrationOnInitEnabled(bool enable) { }

	// RVA: 0x26622D4 Offset: 0x265E2D4 VA: 0x26622D4
	public static Task<string> GetTokenAsync() { }

	// RVA: 0x2667678 Offset: 0x2663678 VA: 0x2667678
	private static void SetListenerCallbacks(FirebaseMessagingInternal.Listener.MessageReceivedDelegate messageCallback, FirebaseMessagingInternal.Listener.TokenReceivedDelegate tokenCallback) { }

	// RVA: 0x26674A4 Offset: 0x26634A4 VA: 0x26674A4
	private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled) { }

	// RVA: 0x2667570 Offset: 0x2663570 VA: 0x2667570
	private static void SendPendingEvents() { }
}

// Assembly: Firebase.Messaging.dll
// Namespace: Firebase.Messaging
public static class FirebaseMessaging // TypeDefIndex: 17701
{
	// Properties
	public static bool TokenRegistrationOnInitEnabled { set; }

	// Methods

	// RVA: 0x2662178 Offset: 0x265E178 VA: 0x2662178
	public static void set_TokenRegistrationOnInitEnabled(bool value) { }

	// RVA: 0x2662288 Offset: 0x265E288 VA: 0x2662288
	public static Task<string> GetTokenAsync() { }

	// RVA: 0x26623D8 Offset: 0x265E3D8 VA: 0x26623D8
	public static void add_MessageReceived(EventHandler<MessageReceivedEventArgs> value) { }

	// RVA: 0x266256C Offset: 0x265E56C VA: 0x266256C
	public static void remove_MessageReceived(EventHandler<MessageReceivedEventArgs> value) { }

	// RVA: 0x2662700 Offset: 0x265E700 VA: 0x2662700
	public static void add_TokenReceived(EventHandler<TokenReceivedEventArgs> value) { }

	// RVA: 0x2662894 Offset: 0x265E894 VA: 0x2662894
	public static void remove_TokenReceived(EventHandler<TokenReceivedEventArgs> value) { }
}

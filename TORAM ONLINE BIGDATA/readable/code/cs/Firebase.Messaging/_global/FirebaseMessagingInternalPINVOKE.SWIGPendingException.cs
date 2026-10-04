// Assembly: Firebase.Messaging.dll
// Namespace: 
public class FirebaseMessagingInternalPINVOKE.SWIGPendingException // TypeDefIndex: 17712
{
	// Fields
	[ThreadStatic]
	private static Exception pendingException; // 0x80000000
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Methods

	// RVA: 0x266621C Offset: 0x266221C VA: 0x266621C
	public static void Set(Exception e) { }

	// RVA: 0x2666098 Offset: 0x2662098 VA: 0x2666098
	public static Exception Retrieve() { }

	// RVA: 0x26669FC Offset: 0x26629FC VA: 0x26669FC
	private static void .cctor() { }
}

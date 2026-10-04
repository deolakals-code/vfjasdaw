// Assembly: Firebase.App.dll
// Namespace: 
public class AppUtilPINVOKE.SWIGPendingException // TypeDefIndex: 17233
{
	// Fields
	[ThreadStatic]
	private static Exception pendingException; // 0x80000000
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Properties
	public static bool Pending { get; }

	// Methods

	// RVA: 0x265278C Offset: 0x264E78C VA: 0x265278C
	public static bool get_Pending() { }

	// RVA: 0x2660300 Offset: 0x265C300 VA: 0x2660300
	public static void Set(Exception e) { }

	// RVA: 0x2652814 Offset: 0x264E814 VA: 0x2652814
	public static Exception Retrieve() { }

	// RVA: 0x2660AE0 Offset: 0x265CAE0 VA: 0x2660AE0
	private static void .cctor() { }
}

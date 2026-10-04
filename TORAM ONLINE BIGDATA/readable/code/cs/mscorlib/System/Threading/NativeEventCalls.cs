// Assembly: mscorlib.dll
// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 9932
{
	// Methods

	// RVA: 0x3056230 Offset: 0x3052230 VA: 0x3056230
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x3056284 Offset: 0x3052284 VA: 0x3056284
	private static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode) { }

	// RVA: 0x3056290 Offset: 0x3052290 VA: 0x3056290
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x3056380 Offset: 0x3052380 VA: 0x3056380
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x3056384 Offset: 0x3052384 VA: 0x3056384
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x3056474 Offset: 0x3052474 VA: 0x3056474
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x3056478 Offset: 0x3052478 VA: 0x3056478
	public static void CloseEvent_internal(IntPtr handle) { }
}

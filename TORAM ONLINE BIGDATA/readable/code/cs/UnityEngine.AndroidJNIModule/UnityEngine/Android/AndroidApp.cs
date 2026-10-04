// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
[NativeHeader("Modules/AndroidJNI/Public/AndroidApp.bindings.h")]
[StaticAccessor("AndroidApp", 2)]
[NativeConditional("PLATFORM_ANDROID")]
internal static class AndroidApp // TypeDefIndex: 17070
{
	// Fields
	private static AndroidJavaObject m_Context; // 0x0
	private static AndroidJavaObject m_Activity; // 0x8

	// Properties
	public static AndroidJavaObject Context { get; }
	public static AndroidJavaObject Activity { get; }
	public static IntPtr UnityPlayerRaw { get; }

	// Methods

	// RVA: 0x37C6234 Offset: 0x37C2234 VA: 0x37C6234
	public static AndroidJavaObject get_Context() { }

	// RVA: 0x37C64DC Offset: 0x37C24DC VA: 0x37C64DC
	public static AndroidJavaObject get_Activity() { }

	// RVA: 0x37C6280 Offset: 0x37C2280 VA: 0x37C6280
	private static void AcquireContextAndActivity() { }

	[ThreadSafe]
	// RVA: 0x37B4DEC Offset: 0x37B0DEC VA: 0x37B4DEC
	public static IntPtr get_UnityPlayerRaw() { }
}

// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[NativeConditional("PLATFORM_ANDROID")]
[UsedByNativeCode]
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
public static class AndroidJNIHelper // TypeDefIndex: 17058
{
	// Properties
	public static bool debug { get; set; }

	// Methods

	// RVA: 0x37B449C Offset: 0x37B049C VA: 0x37B449C
	public static bool get_debug() { }

	// RVA: 0x37B44C4 Offset: 0x37B04C4 VA: 0x37B44C4
	public static void set_debug(bool value) { }

	// RVA: 0x37B4500 Offset: 0x37B0500 VA: 0x37B4500
	public static IntPtr GetConstructorID(IntPtr javaClass) { }

	// RVA: 0x37B4548 Offset: 0x37B0548 VA: 0x37B4548
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x37B4714 Offset: 0x37B0714 VA: 0x37B4714
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName) { }

	// RVA: 0x37B4778 Offset: 0x37B0778 VA: 0x37B4778
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature) { }

	// RVA: 0x37B4770 Offset: 0x37B0770 VA: 0x37B4770
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x37B4958 Offset: 0x37B0958 VA: 0x37B4958
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName) { }

	// RVA: 0x37B49BC Offset: 0x37B09BC VA: 0x37B49BC
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature) { }

	// RVA: 0x37B49B4 Offset: 0x37B09B4 VA: 0x37B49B4
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x37B4C9C Offset: 0x37B0C9C VA: 0x37B4C9C
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x37B4CF8 Offset: 0x37B0CF8 VA: 0x37B4CF8
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x37B4E9C Offset: 0x37B0E9C VA: 0x37B4E9C
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x37B5A70 Offset: 0x37B1A70 VA: 0x37B5A70
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x37B6080 Offset: 0x37B2080 VA: 0x37B6080
	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x37B6190 Offset: 0x37B2190 VA: 0x37B6190
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x37B6354 Offset: 0x37B2354 VA: 0x37B6354
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x37B6358 Offset: 0x37B2358 VA: 0x37B6358
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x37B6398 Offset: 0x37B2398 VA: 0x37B6398
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x37B6408 Offset: 0x37B2408 VA: 0x37B6408
	public static string GetSignature(object obj) { }

	// RVA: 0x37B7328 Offset: 0x37B3328 VA: 0x37B7328
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268AC24 Offset: 0x2686C24 VA: 0x268AC24
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x268AC5C Offset: 0x2686C5C VA: 0x268AC5C
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x268AC94 Offset: 0x2686C94 VA: 0x268AC94
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x268ACCC Offset: 0x2686CCC VA: 0x268ACCC
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x268AD04 Offset: 0x2686D04 VA: 0x268AD04
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x268AD3C Offset: 0x2686D3C VA: 0x268AD3C
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x268AD74 Offset: 0x2686D74 VA: 0x268AD74
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x268ADAC Offset: 0x2686DAC VA: 0x268ADAC
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x268ADE4 Offset: 0x2686DE4 VA: 0x268ADE4
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x268AE1C Offset: 0x2686E1C VA: 0x268AE1C
	|-AndroidJNIHelper.ConvertFromJNIArray<ulong>
	|
	|-RVA: 0x268AE54 Offset: 0x2686E54 VA: 0x268AE54
	|-AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268B050 Offset: 0x2687050 VA: 0x268B050
	|-AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x268B0A8 Offset: 0x26870A8 VA: 0x268B0A8
	|-AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x268B100 Offset: 0x2687100 VA: 0x268B100
	|-AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x268B158 Offset: 0x2687158 VA: 0x268B158
	|-AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x268B1B0 Offset: 0x26871B0 VA: 0x268B1B0
	|-AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x268B208 Offset: 0x2687208 VA: 0x268B208
	|-AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x268B260 Offset: 0x2687260 VA: 0x268B260
	|-AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x268B2B8 Offset: 0x26872B8 VA: 0x268B2B8
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x268B310 Offset: 0x2687310 VA: 0x268B310
	|-AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x268B368 Offset: 0x2687368 VA: 0x268B368
	|-AndroidJNIHelper.GetMethodID<ulong>
	|
	|-RVA: 0x268B3C0 Offset: 0x26873C0 VA: 0x268B3C0
	|-AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268AF5C Offset: 0x2686F5C VA: 0x268AF5C
	|-AndroidJNIHelper.GetFieldID<int>
	|
	|-RVA: 0x268AFAC Offset: 0x2686FAC VA: 0x268AFAC
	|-AndroidJNIHelper.GetFieldID<object>
	|
	|-RVA: 0x268AFFC Offset: 0x2686FFC VA: 0x268AFFC
	|-AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268B41C Offset: 0x268741C VA: 0x268B41C
	|-AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37B7450 Offset: 0x37B3450 VA: 0x37B7450
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x37B7720 Offset: 0x37B3720 VA: 0x37B7720
	public static IntPtr Box(sbyte value) { }

	// RVA: 0x37B7788 Offset: 0x37B3788 VA: 0x37B7788
	public static IntPtr Box(short value) { }

	// RVA: 0x37B77F0 Offset: 0x37B37F0 VA: 0x37B77F0
	public static IntPtr Box(int value) { }

	// RVA: 0x37B7858 Offset: 0x37B3858 VA: 0x37B7858
	public static IntPtr Box(long value) { }

	// RVA: 0x37B78C0 Offset: 0x37B38C0 VA: 0x37B78C0
	public static IntPtr Box(float value) { }

	// RVA: 0x37B7928 Offset: 0x37B3928 VA: 0x37B7928
	public static IntPtr Box(double value) { }

	// RVA: 0x37B7990 Offset: 0x37B3990 VA: 0x37B7990
	public static IntPtr Box(char value) { }

	// RVA: 0x37B79F8 Offset: 0x37B39F8 VA: 0x37B79F8
	public static IntPtr Box(bool value) { }

	// RVA: 0x37B7A60 Offset: 0x37B3A60 VA: 0x37B7A60
	private static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature) { }

	// RVA: 0x37B7C54 Offset: 0x37B3C54 VA: 0x37B7C54
	public static void Unbox(IntPtr obj, out sbyte value) { }

	// RVA: 0x37B7D54 Offset: 0x37B3D54 VA: 0x37B7D54
	public static void Unbox(IntPtr obj, out short value) { }

	// RVA: 0x37B7E54 Offset: 0x37B3E54 VA: 0x37B7E54
	public static void Unbox(IntPtr obj, out int value) { }

	// RVA: 0x37B7F54 Offset: 0x37B3F54 VA: 0x37B7F54
	public static void Unbox(IntPtr obj, out long value) { }

	// RVA: 0x37B8054 Offset: 0x37B4054 VA: 0x37B8054
	public static void Unbox(IntPtr obj, out float value) { }

	// RVA: 0x37B8160 Offset: 0x37B4160 VA: 0x37B8160
	public static void Unbox(IntPtr obj, out double value) { }

	// RVA: 0x37B826C Offset: 0x37B426C VA: 0x37B826C
	public static void Unbox(IntPtr obj, out char value) { }

	// RVA: 0x37B836C Offset: 0x37B436C VA: 0x37B836C
	public static void Unbox(IntPtr obj, out bool value) { }
}

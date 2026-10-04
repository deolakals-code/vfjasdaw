// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
internal sealed class _AndroidJNIHelper // TypeDefIndex: 17069
{
	// Methods

	// RVA: 0x37B4E14 Offset: 0x37B0E14 VA: 0x37B4E14
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x37B4CA0 Offset: 0x37B0CA0 VA: 0x37B4CA0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCode]
	// RVA: 0x37C58C4 Offset: 0x37C18C4 VA: 0x37C58C4
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x37B5B00 Offset: 0x37B1B00 VA: 0x37B5B00
	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret) { }

	// RVA: 0x37C59DC Offset: 0x37C19DC VA: 0x37C59DC
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x37C2898 Offset: 0x37BE898 VA: 0x37C2898
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x37C1AF4 Offset: 0x37BDAF4 VA: 0x37C1AF4
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x37B61FC Offset: 0x37B21FC VA: 0x37B61FC
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x37B4EA0 Offset: 0x37B0EA0 VA: 0x37B4EA0
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2703AD8 Offset: 0x26FFAD8 VA: 0x2703AD8
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x2704214 Offset: 0x2700214 VA: 0x2704214
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x2704948 Offset: 0x2700948 VA: 0x2704948
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x2705078 Offset: 0x2701078 VA: 0x2705078
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x27057AC Offset: 0x27017AC VA: 0x27057AC
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x2705EE0 Offset: 0x2701EE0 VA: 0x2705EE0
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x2706614 Offset: 0x2702614 VA: 0x2706614
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x2706D74 Offset: 0x2702D74 VA: 0x2706D74
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x27074A8 Offset: 0x27034A8 VA: 0x27074A8
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x2707BD8 Offset: 0x2703BD8 VA: 0x2707BD8
	|-_AndroidJNIHelper.ConvertFromJNIArray<ulong>
	|
	|-RVA: 0x270830C Offset: 0x270430C VA: 0x270830C
	|-_AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37B6378 Offset: 0x37B2378 VA: 0x37B6378
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x37B63D0 Offset: 0x37B23D0 VA: 0x37B63D0
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2708D80 Offset: 0x2704D80 VA: 0x2708D80
	|-_AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x2708DE4 Offset: 0x2704DE4 VA: 0x2708DE4
	|-_AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x2708E48 Offset: 0x2704E48 VA: 0x2708E48
	|-_AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x2708EAC Offset: 0x2704EAC VA: 0x2708EAC
	|-_AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x2708F10 Offset: 0x2704F10 VA: 0x2708F10
	|-_AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x2708F74 Offset: 0x2704F74 VA: 0x2708F74
	|-_AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x2708FD8 Offset: 0x2704FD8 VA: 0x2708FD8
	|-_AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x270903C Offset: 0x270503C VA: 0x270903C
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x27090A0 Offset: 0x27050A0 VA: 0x27090A0
	|-_AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x2709104 Offset: 0x2705104 VA: 0x2709104
	|-_AndroidJNIHelper.GetMethodID<ulong>
	|
	|-RVA: 0x2709168 Offset: 0x2705168 VA: 0x2709168
	|-_AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2708BB8 Offset: 0x2704BB8 VA: 0x2708BB8
	|-_AndroidJNIHelper.GetFieldID<int>
	|
	|-RVA: 0x2708C50 Offset: 0x2704C50 VA: 0x2708C50
	|-_AndroidJNIHelper.GetFieldID<object>
	|
	|-RVA: 0x2708CE8 Offset: 0x2704CE8 VA: 0x2708CE8
	|-_AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37B454C Offset: 0x37B054C VA: 0x37B454C
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x37B4780 Offset: 0x37B0780 VA: 0x37B4780
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x37C6198 Offset: 0x37C2198 VA: 0x37C6198
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x37B49C4 Offset: 0x37B09C4 VA: 0x37B49C4
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x37B640C Offset: 0x37B240C VA: 0x37B640C
	public static string GetSignature(object obj) { }

	// RVA: 0x37B732C Offset: 0x37B332C VA: 0x37B732C
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27091D0 Offset: 0x27051D0 VA: 0x27091D0
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0x2709380 Offset: 0x2705380 VA: 0x2709380
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0x2709530 Offset: 0x2705530 VA: 0x2709530
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0x27096E0 Offset: 0x27056E0 VA: 0x27096E0
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0x2709890 Offset: 0x2705890 VA: 0x2709890
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0x2709A40 Offset: 0x2705A40 VA: 0x2709A40
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0x2709BF0 Offset: 0x2705BF0 VA: 0x2709BF0
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0x2709DA0 Offset: 0x2705DA0 VA: 0x2709DA0
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0x2709F50 Offset: 0x2705F50 VA: 0x2709F50
	|-_AndroidJNIHelper.GetSignature<float>
	|
	|-RVA: 0x270A100 Offset: 0x2706100 VA: 0x270A100
	|-_AndroidJNIHelper.GetSignature<ulong>
	|
	|-RVA: 0x270A2B0 Offset: 0x27062B0 VA: 0x270A2B0
	|-_AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C622C Offset: 0x37C222C VA: 0x37C622C
	public void .ctor() { }
}

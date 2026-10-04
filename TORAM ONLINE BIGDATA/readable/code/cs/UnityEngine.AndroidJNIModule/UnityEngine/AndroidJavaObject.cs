// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public class AndroidJavaObject : IDisposable // TypeDefIndex: 17066
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x37C3910 Offset: 0x37BF910 VA: 0x37C3910
	public void .ctor(string className, string[] args) { }

	// RVA: 0x37C3AD8 Offset: 0x37BFAD8 VA: 0x37C3AD8
	public void .ctor(string className, AndroidJavaObject[] args) { }

	// RVA: 0x37C3B98 Offset: 0x37BFB98 VA: 0x37C3B98
	public void .ctor(string className, AndroidJavaClass[] args) { }

	// RVA: 0x37C3C58 Offset: 0x37BFC58 VA: 0x37C3C58
	public void .ctor(string className, AndroidJavaProxy[] args) { }

	// RVA: 0x37C3D18 Offset: 0x37BFD18 VA: 0x37C3D18
	public void .ctor(string className, AndroidJavaRunnable[] args) { }

	// RVA: 0x37C3DD8 Offset: 0x37BFDD8 VA: 0x37C3DD8
	public void .ctor(string className, object[] args) { }

	// RVA: 0x37C2600 Offset: 0x37BE600 VA: 0x37C2600
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x37C3E0C Offset: 0x37BFE0C VA: 0x37C3E0C
	public void .ctor(IntPtr clazz, IntPtr constructorID, object[] args) { }

	// RVA: 0x37C3448 Offset: 0x37BF448 VA: 0x37C3448 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	public void Call<T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268BA5C Offset: 0x2687A5C VA: 0x268BA5C
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Call<T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268B9A4 Offset: 0x26879A4 VA: 0x268B9A4
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C408C Offset: 0x37C008C VA: 0x37C408C
	public void Call(string methodName, object[] args) { }

	// RVA: 0x37C40F0 Offset: 0x37C00F0 VA: 0x37C40F0
	public void Call(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	public void CallStatic<T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268C2A4 Offset: 0x26882A4 VA: 0x268C2A4
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void CallStatic<T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268C1EC Offset: 0x26881EC VA: 0x268C1EC
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C4288 Offset: 0x37C0288 VA: 0x37C4288
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x37C42EC Offset: 0x37C02EC VA: 0x37C42EC
	public void CallStatic(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	public FieldType Get<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268D4EC Offset: 0x26894EC VA: 0x268D4EC
	|-AndroidJavaObject.Get<int>
	|
	|-RVA: 0x268D52C Offset: 0x268952C VA: 0x268D52C
	|-AndroidJavaObject.Get<object>
	|
	|-RVA: 0x268D678 Offset: 0x2689678 VA: 0x268D678
	|-AndroidJavaObject.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType Get<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268D56C Offset: 0x268956C VA: 0x268D56C
	|-AndroidJavaObject.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268DAEC Offset: 0x2689AEC VA: 0x268DAEC
	|-AndroidJavaObject.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268DA0C Offset: 0x2689A0C VA: 0x268DA0C
	|-AndroidJavaObject.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268D77C Offset: 0x268977C VA: 0x268D77C
	|-AndroidJavaObject.GetStatic<int>
	|
	|-RVA: 0x268D7BC Offset: 0x26897BC VA: 0x268D7BC
	|-AndroidJavaObject.GetStatic<object>
	|
	|-RVA: 0x268D908 Offset: 0x2689908 VA: 0x268D908
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268D7FC Offset: 0x26897FC VA: 0x268D7FC
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStatic<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268DCA4 Offset: 0x2689CA4 VA: 0x268DCA4
	|-AndroidJavaObject.SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStatic<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268DBC4 Offset: 0x2689BC4 VA: 0x268DBC4
	|-AndroidJavaObject.SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C3570 Offset: 0x37BF570 VA: 0x37C3570
	public IntPtr GetRawObject() { }

	// RVA: 0x37C449C Offset: 0x37C049C VA: 0x37C449C
	public IntPtr GetRawClass() { }

	// RVA: 0x37C44D4 Offset: 0x37C04D4 VA: 0x37C44D4
	public AndroidJavaObject CloneReference() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType, T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268BCA4 Offset: 0x2687CA4 VA: 0x268BCA4
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType, T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268BB14 Offset: 0x2687B14 VA: 0x268BB14
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268B458 Offset: 0x2687458 VA: 0x268B458
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x268B4A8 Offset: 0x26874A8 VA: 0x268B4A8
	|-AndroidJavaObject.Call<char>
	|
	|-RVA: 0x268B4F8 Offset: 0x26874F8 VA: 0x268B4F8
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x268B548 Offset: 0x2687548 VA: 0x268B548
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x268B598 Offset: 0x2687598 VA: 0x268B598
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x268B5E8 Offset: 0x26875E8 VA: 0x268B5E8
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x268B638 Offset: 0x2687638 VA: 0x268B638
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0x268B688 Offset: 0x2687688 VA: 0x268B688
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x268B6D8 Offset: 0x26876D8 VA: 0x268B6D8
	|-AndroidJavaObject.Call<float>
	|
	|-RVA: 0x268B728 Offset: 0x2687728 VA: 0x268B728
	|-AndroidJavaObject.Call<ulong>
	|
	|-RVA: 0x268B890 Offset: 0x2687890 VA: 0x268B890
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268B778 Offset: 0x2687778 VA: 0x268B778
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268C4EC Offset: 0x26884EC VA: 0x268C4EC
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType, T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268C35C Offset: 0x268835C VA: 0x268C35C
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268BE30 Offset: 0x2687E30 VA: 0x268BE30
	|-AndroidJavaObject.CallStatic<bool>
	|
	|-RVA: 0x268BE80 Offset: 0x2687E80 VA: 0x268BE80
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x268BED0 Offset: 0x2687ED0 VA: 0x268BED0
	|-AndroidJavaObject.CallStatic<long>
	|
	|-RVA: 0x268BF20 Offset: 0x2687F20 VA: 0x268BF20
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x268BF70 Offset: 0x2687F70 VA: 0x268BF70
	|-AndroidJavaObject.CallStatic<float>
	|
	|-RVA: 0x268C0D8 Offset: 0x26880D8 VA: 0x268C0D8
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268BFC0 Offset: 0x2687FC0 VA: 0x268BFC0
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C4714 Offset: 0x37C0714 VA: 0x37C4714
	protected void DebugPrint(string msg) { }

	// RVA: 0x37C479C Offset: 0x37C079C VA: 0x37C479C
	protected void DebugPrint(string call, string methodName, string signature, object[] args) { }

	// RVA: 0x37C39D8 Offset: 0x37BF9D8 VA: 0x37C39D8
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x37C3EA4 Offset: 0x37BFEA4 VA: 0x37C3EA4
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x37C39D0 Offset: 0x37BF9D0 VA: 0x37C39D0
	internal void .ctor() { }

	// RVA: 0x37C4AA4 Offset: 0x37C0AA4 VA: 0x37C4AA4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x37C4B44 Offset: 0x37C0B44 VA: 0x37C4B44 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x37C4090 Offset: 0x37C0090 VA: 0x37C4090
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x37C40F4 Offset: 0x37C00F4 VA: 0x37C40F4
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268EE0C Offset: 0x268AE0C VA: 0x268EE0C
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x269004C Offset: 0x268C04C VA: 0x269004C
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x2691150 Offset: 0x268D150 VA: 0x2691150
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x269224C Offset: 0x268E24C VA: 0x269224C
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x2693348 Offset: 0x268F348 VA: 0x2693348
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x2694440 Offset: 0x2690440 VA: 0x2694440
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x26954A4 Offset: 0x26914A4 VA: 0x26954A4
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x26965A0 Offset: 0x26925A0 VA: 0x26965A0
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x26976A4 Offset: 0x26936A4 VA: 0x26976A4
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x269879C Offset: 0x269479C VA: 0x269879C
	|-AndroidJavaObject._Call<ulong>
	|
	|-RVA: 0x26998BC Offset: 0x26958BC VA: 0x26998BC
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268DD7C Offset: 0x2689D7C VA: 0x268DD7C
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x268EE80 Offset: 0x268AE80 VA: 0x268EE80
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x26900C0 Offset: 0x268C0C0 VA: 0x26900C0
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x26911C4 Offset: 0x268D1C4 VA: 0x26911C4
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x26922C0 Offset: 0x268E2C0 VA: 0x26922C0
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x26933BC Offset: 0x268F3BC VA: 0x26933BC
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x26944B4 Offset: 0x26904B4 VA: 0x26944B4
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x2695518 Offset: 0x2691518 VA: 0x2695518
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x2696614 Offset: 0x2692614 VA: 0x2696614
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x2697718 Offset: 0x2693718 VA: 0x2697718
	|-AndroidJavaObject._Call<ulong>
	|
	|-RVA: 0x2698810 Offset: 0x2694810 VA: 0x2698810
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _Get<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A0A1C Offset: 0x269CA1C VA: 0x26A0A1C
	|-AndroidJavaObject._Get<int>
	|
	|-RVA: 0x26A1418 Offset: 0x269D418 VA: 0x26A1418
	|-AndroidJavaObject._Get<object>
	|
	|-RVA: 0x26A2088 Offset: 0x269E088 VA: 0x26A2088
	|-AndroidJavaObject._Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _Get<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A0058 Offset: 0x269C058 VA: 0x26A0058
	|-AndroidJavaObject._Get<int>
	|
	|-RVA: 0x26A0A7C Offset: 0x269CA7C VA: 0x26A0A7C
	|-AndroidJavaObject._Get<object>
	|
	|-RVA: 0x26A1478 Offset: 0x269D478 VA: 0x26A1478
	|-AndroidJavaObject._Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _Set<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A52CC Offset: 0x26A12CC VA: 0x26A52CC
	|-AndroidJavaObject._Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _Set<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A4328 Offset: 0x26A0328 VA: 0x26A4328
	|-AndroidJavaObject._Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C428C Offset: 0x37C028C VA: 0x37C428C
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x37C42F0 Offset: 0x37C02F0 VA: 0x37C42F0
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x269AA94 Offset: 0x2696A94 VA: 0x269AA94
	|-AndroidJavaObject._CallStatic<bool>
	|
	|-RVA: 0x269BB90 Offset: 0x2697B90 VA: 0x269BB90
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x269CC88 Offset: 0x2698C88 VA: 0x269CC88
	|-AndroidJavaObject._CallStatic<long>
	|
	|-RVA: 0x269DCEC Offset: 0x2699CEC VA: 0x269DCEC
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x269EDF0 Offset: 0x269ADF0 VA: 0x269EDF0
	|-AndroidJavaObject._CallStatic<float>
	|
	|-RVA: 0x269FF10 Offset: 0x269BF10 VA: 0x269FF10
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2699A04 Offset: 0x2695A04 VA: 0x2699A04
	|-AndroidJavaObject._CallStatic<bool>
	|
	|-RVA: 0x269AB08 Offset: 0x2696B08 VA: 0x269AB08
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x269BC04 Offset: 0x2697C04 VA: 0x269BC04
	|-AndroidJavaObject._CallStatic<long>
	|
	|-RVA: 0x269CCFC Offset: 0x2698CFC VA: 0x269CCFC
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x269DD60 Offset: 0x2699D60 VA: 0x269DD60
	|-AndroidJavaObject._CallStatic<float>
	|
	|-RVA: 0x269EE64 Offset: 0x269AE64 VA: 0x269EE64
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A2B84 Offset: 0x269EB84 VA: 0x26A2B84
	|-AndroidJavaObject._GetStatic<int>
	|
	|-RVA: 0x26A3580 Offset: 0x269F580 VA: 0x26A3580
	|-AndroidJavaObject._GetStatic<object>
	|
	|-RVA: 0x26A41F0 Offset: 0x26A01F0 VA: 0x26A41F0
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A21C0 Offset: 0x269E1C0 VA: 0x26A21C0
	|-AndroidJavaObject._GetStatic<int>
	|
	|-RVA: 0x26A2BE4 Offset: 0x269EBE4 VA: 0x26A2BE4
	|-AndroidJavaObject._GetStatic<object>
	|
	|-RVA: 0x26A35E0 Offset: 0x269F5E0 VA: 0x26A35E0
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _SetStatic<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A638C Offset: 0x26A238C VA: 0x26A638C
	|-AndroidJavaObject._SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _SetStatic<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A53E8 Offset: 0x26A13E8 VA: 0x26A53E8
	|-AndroidJavaObject._SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C34B4 Offset: 0x37BF4B4 VA: 0x37C34B4
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x37C4BA0 Offset: 0x37C0BA0 VA: 0x37C4BA0
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268C678 Offset: 0x2688678 VA: 0x268C678
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<bool>
	|
	|-RVA: 0x268C7C0 Offset: 0x26887C0 VA: 0x268C7C0
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<char>
	|
	|-RVA: 0x268C8FC Offset: 0x26888FC VA: 0x268C8FC
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<double>
	|
	|-RVA: 0x268CA34 Offset: 0x2688A34 VA: 0x268CA34
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<short>
	|
	|-RVA: 0x268CB70 Offset: 0x2688B70 VA: 0x268CB70
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<int>
	|
	|-RVA: 0x268CCAC Offset: 0x2688CAC VA: 0x268CCAC
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<long>
	|
	|-RVA: 0x268CDE8 Offset: 0x2688DE8 VA: 0x268CDE8
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<object>
	|
	|-RVA: 0x268CF04 Offset: 0x2688F04 VA: 0x268CF04
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<sbyte>
	|
	|-RVA: 0x268D040 Offset: 0x2689040 VA: 0x268D040
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<float>
	|
	|-RVA: 0x268D178 Offset: 0x2689178 VA: 0x268D178
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<ulong>
	|
	|-RVA: 0x268D2B4 Offset: 0x26892B4 VA: 0x268D2B4
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37C4484 Offset: 0x37C0484 VA: 0x37C4484
	protected IntPtr _GetRawObject() { }

	// RVA: 0x37C44B8 Offset: 0x37C04B8 VA: 0x37C44B8
	protected IntPtr _GetRawClass() { }
}

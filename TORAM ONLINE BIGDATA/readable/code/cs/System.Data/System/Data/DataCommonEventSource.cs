// Assembly: System.Data.dll
// Namespace: System.Data
[EventSource(Name = "System.Data.DataCommonEventSource")]
internal class DataCommonEventSource : EventSource // TypeDefIndex: 14673
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[Event(1, Level = 4)]
	// RVA: 0x31DE074 Offset: 0x31DA074 VA: 0x31DE074
	internal void Trace(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E5BE0 Offset: 0x27E1BE0 VA: 0x27E5BE0
	|-DataCommonEventSource.Trace<int>
	|
	|-RVA: 0x27E5CA4 Offset: 0x27E1CA4 VA: 0x27E5CA4
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0x27E5D50 Offset: 0x27E1D50 VA: 0x27E5D50
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E5E88 Offset: 0x27E1E88 VA: 0x27E5E88
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0x27E5F74 Offset: 0x27E1F74 VA: 0x27E5F74
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0x27E605C Offset: 0x27E205C VA: 0x27E605C
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0x27E6144 Offset: 0x27E2144 VA: 0x27E6144
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0x27E6234 Offset: 0x27E2234 VA: 0x27E6234
	|-DataCommonEventSource.Trace<int, object>
	|
	|-RVA: 0x27E6300 Offset: 0x27E2300 VA: 0x27E6300
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E6494 Offset: 0x27E2494 VA: 0x27E6494
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0x27E65AC Offset: 0x27E25AC VA: 0x27E65AC
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0x27E66C0 Offset: 0x27E26C0 VA: 0x27E66C0
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0x27E67D4 Offset: 0x27E27D4 VA: 0x27E67D4
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|
	|-RVA: 0x27E68CC Offset: 0x27E28CC VA: 0x27E68CC
	|-DataCommonEventSource.Trace<int, object, object>
	|
	|-RVA: 0x27E69A8 Offset: 0x27E29A8 VA: 0x27E69A8
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E6BA4 Offset: 0x27E2BA4 VA: 0x27E6BA4
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x27E6DD8 Offset: 0x27E2DD8 VA: 0x27E6DD8
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|
	|-RVA: 0x27E6FD4 Offset: 0x27E2FD4 VA: 0x27E6FD4
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E7330 Offset: 0x27E3330 VA: 0x27E7330
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|
	|-RVA: 0x27E75A0 Offset: 0x27E35A0 VA: 0x27E75A0
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E798C Offset: 0x27E398C VA: 0x27E798C
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x27E7CB8 Offset: 0x27E3CB8 VA: 0x27E7CB8
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(2, Level = 5)]
	// RVA: 0x31DE084 Offset: 0x31DA084 VA: 0x31DE084
	internal long EnterScope(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E48A4 Offset: 0x27E08A4 VA: 0x27E48A4
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0x27E4970 Offset: 0x27E0970 VA: 0x27E4970
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E4AB0 Offset: 0x27E0AB0 VA: 0x27E4AB0
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0x27E4BA4 Offset: 0x27E0BA4 VA: 0x27E4BA4
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0x27E4C94 Offset: 0x27E0C94 VA: 0x27E4C94
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0x27E4D84 Offset: 0x27E0D84 VA: 0x27E4D84
	|-DataCommonEventSource.EnterScope<int, object>
	|
	|-RVA: 0x27E4E58 Offset: 0x27E0E58 VA: 0x27E4E58
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E4FF4 Offset: 0x27E0FF4 VA: 0x27E4FF4
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0x27E5114 Offset: 0x27E1114 VA: 0x27E5114
	|-DataCommonEventSource.EnterScope<int, int, object>
	|
	|-RVA: 0x27E5214 Offset: 0x27E1214 VA: 0x27E5214
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0x27E5334 Offset: 0x27E1334 VA: 0x27E5334
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|
	|-RVA: 0x27E5438 Offset: 0x27E1438 VA: 0x27E5438
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E563C Offset: 0x27E163C VA: 0x27E563C
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0x27E587C Offset: 0x27E187C VA: 0x27E587C
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(3, Level = 5)]
	// RVA: 0x31DE148 Offset: 0x31DA148 VA: 0x31DE148
	internal void ExitScope(long scopeId) { }

	// RVA: 0x31DE158 Offset: 0x31DA158 VA: 0x31DE158
	public void .ctor() { }

	// RVA: 0x31DE160 Offset: 0x31DA160 VA: 0x31DE160
	private static void .cctor() { }
}

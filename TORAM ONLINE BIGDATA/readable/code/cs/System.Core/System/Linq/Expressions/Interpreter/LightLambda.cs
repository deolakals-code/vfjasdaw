// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal class LightLambda // TypeDefIndex: 15571
{
	// Fields
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Properties
	internal string DebugView { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal TRet Run0<TRet>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAF64 Offset: 0x26C6F64 VA: 0x26CAF64
	|-LightLambda.Run0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x316C548 Offset: 0x3168548 VA: 0x316C548
	internal void RunVoid0() { }

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun0<TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA348 Offset: 0x26C6348 VA: 0x26CA348
	|-LightLambda.MakeRun0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x316C68C Offset: 0x316868C VA: 0x316C68C
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	// RVA: -1 Offset: -1
	internal TRet Run1<T0, TRet>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CB104 Offset: 0x26C7104 VA: 0x26CB104
	|-LightLambda.Run1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid1<T0>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D13F4 Offset: 0x26CD3F4 VA: 0x26D13F4
	|-LightLambda.RunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA3AC Offset: 0x26C63AC VA: 0x26CA3AC
	|-LightLambda.MakeRun1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA988 Offset: 0x26C6988 VA: 0x26CA988
	|-LightLambda.MakeRunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CEC80 Offset: 0x26CAC80 VA: 0x26CEC80
	|-LightLambda.Run2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D4C2C Offset: 0x26D0C2C VA: 0x26D4C2C
	|-LightLambda.RunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA668 Offset: 0x26C6668 VA: 0x26CA668
	|-LightLambda.MakeRun2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAC44 Offset: 0x26C6C44 VA: 0x26CAC44
	|-LightLambda.MakeRunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CEF58 Offset: 0x26CAF58 VA: 0x26CEF58
	|-LightLambda.Run3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D4EA0 Offset: 0x26D0EA0 VA: 0x26D4EA0
	|-LightLambda.RunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA6CC Offset: 0x26C66CC VA: 0x26CA6CC
	|-LightLambda.MakeRun3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CACA8 Offset: 0x26C6CA8 VA: 0x26CACA8
	|-LightLambda.MakeRunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CF2C4 Offset: 0x26CB2C4 VA: 0x26CF2C4
	|-LightLambda.Run4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D51A8 Offset: 0x26D11A8 VA: 0x26D51A8
	|-LightLambda.RunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA730 Offset: 0x26C6730 VA: 0x26CA730
	|-LightLambda.MakeRun4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAD0C Offset: 0x26C6D0C VA: 0x26CAD0C
	|-LightLambda.MakeRunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CF6CC Offset: 0x26CB6CC VA: 0x26CF6CC
	|-LightLambda.Run5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D5548 Offset: 0x26D1548 VA: 0x26D5548
	|-LightLambda.RunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA794 Offset: 0x26C6794 VA: 0x26CA794
	|-LightLambda.MakeRun5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAD70 Offset: 0x26C6D70 VA: 0x26CAD70
	|-LightLambda.MakeRunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CFB68 Offset: 0x26CBB68 VA: 0x26CFB68
	|-LightLambda.Run6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D5980 Offset: 0x26D1980 VA: 0x26D5980
	|-LightLambda.RunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA7F8 Offset: 0x26C67F8 VA: 0x26CA7F8
	|-LightLambda.MakeRun6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CADD4 Offset: 0x26C6DD4 VA: 0x26CADD4
	|-LightLambda.MakeRunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D00A0 Offset: 0x26CC0A0 VA: 0x26D00A0
	|-LightLambda.Run7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D5E50 Offset: 0x26D1E50 VA: 0x26D5E50
	|-LightLambda.RunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA85C Offset: 0x26C685C VA: 0x26CA85C
	|-LightLambda.MakeRun7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAE38 Offset: 0x26C6E38 VA: 0x26CAE38
	|-LightLambda.MakeRunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D0670 Offset: 0x26CC670 VA: 0x26D0670
	|-LightLambda.Run8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D63B8 Offset: 0x26D23B8 VA: 0x26D63B8
	|-LightLambda.RunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA8C0 Offset: 0x26C68C0 VA: 0x26CA8C0
	|-LightLambda.MakeRun8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAE9C Offset: 0x26C6E9C VA: 0x26CAE9C
	|-LightLambda.MakeRunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D0CDC Offset: 0x26CCCDC VA: 0x26D0CDC
	|-LightLambda.Run9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D69B4 Offset: 0x26D29B4 VA: 0x26D69B4
	|-LightLambda.RunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA924 Offset: 0x26C6924 VA: 0x26CA924
	|-LightLambda.MakeRun9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAF00 Offset: 0x26C6F00 VA: 0x26CAF00
	|-LightLambda.MakeRunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CB348 Offset: 0x26C7348 VA: 0x26CB348
	|-LightLambda.Run10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D15C8 Offset: 0x26CD5C8 VA: 0x26D15C8
	|-LightLambda.RunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA410 Offset: 0x26C6410 VA: 0x26CA410
	|-LightLambda.MakeRun10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA9EC Offset: 0x26C69EC VA: 0x26CA9EC
	|-LightLambda.MakeRunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CBB1C Offset: 0x26C7B1C VA: 0x26CBB1C
	|-LightLambda.Run11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D1D1C Offset: 0x26CDD1C VA: 0x26D1D1C
	|-LightLambda.RunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA474 Offset: 0x26C6474 VA: 0x26CA474
	|-LightLambda.MakeRun11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAA50 Offset: 0x26C6A50 VA: 0x26CAA50
	|-LightLambda.MakeRunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CC3A8 Offset: 0x26C83A8 VA: 0x26CC3A8
	|-LightLambda.Run12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D252C Offset: 0x26CE52C VA: 0x26D252C
	|-LightLambda.RunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA4D8 Offset: 0x26C64D8 VA: 0x26CA4D8
	|-LightLambda.MakeRun12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAAB4 Offset: 0x26C6AB4 VA: 0x26CAAB4
	|-LightLambda.MakeRunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CCCF0 Offset: 0x26C8CF0 VA: 0x26CCCF0
	|-LightLambda.Run13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D2DF4 Offset: 0x26CEDF4 VA: 0x26D2DF4
	|-LightLambda.RunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA53C Offset: 0x26C653C VA: 0x26CA53C
	|-LightLambda.MakeRun13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAB18 Offset: 0x26C6B18 VA: 0x26CAB18
	|-LightLambda.MakeRunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CD6D0 Offset: 0x26C96D0 VA: 0x26CD6D0
	|-LightLambda.Run14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D3778 Offset: 0x26CF778 VA: 0x26D3778
	|-LightLambda.RunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA5A0 Offset: 0x26C65A0 VA: 0x26CA5A0
	|-LightLambda.MakeRun14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CAB7C Offset: 0x26C6B7C VA: 0x26CAB7C
	|-LightLambda.MakeRunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CE15C Offset: 0x26CA15C VA: 0x26CE15C
	|-LightLambda.Run15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D4184 Offset: 0x26D0184 VA: 0x26D4184
	|-LightLambda.RunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CA604 Offset: 0x26C6604 VA: 0x26CA604
	|-LightLambda.MakeRun15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26CABE0 Offset: 0x26C6BE0 VA: 0x26CABE0
	|-LightLambda.MakeRunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x316C464 Offset: 0x3168464 VA: 0x316C464
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x316C708 Offset: 0x3168708 VA: 0x316C708
	internal string get_DebugView() { }

	// RVA: 0x316C8BC Offset: 0x31688BC VA: 0x316C8BC
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x316CA3C Offset: 0x3168A3C VA: 0x316CA3C
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x316D96C Offset: 0x316996C VA: 0x316D96C
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x316C4C0 Offset: 0x31684C0 VA: 0x316C4C0
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x316C628 Offset: 0x3168628 VA: 0x316C628
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D704C Offset: 0x26D304C VA: 0x26D704C
	|-LightLambda.RunVoidRef2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x316E2C4 Offset: 0x316A2C4 VA: 0x316E2C4
	public object Run(object[] arguments) { }

	// RVA: 0x316E42C Offset: 0x316A42C VA: 0x316E42C
	public object RunVoid(object[] arguments) { }

	// RVA: 0x316E588 Offset: 0x316A588 VA: 0x316E588
	private static void .cctor() { }
}

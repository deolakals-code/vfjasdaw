// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 15913
{
	// Fields
	private readonly DynamicProxy<T> _proxy; // 0x0

	// Properties
	private static Expression[] NoArgs { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression expression, T value, DynamicProxy<T> proxy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2919E90 Offset: 0x2915E90 VA: 0x2919E90
	|-DynamicProxyMetaObject<object>..ctor
	|
	|-RVA: 0x291CB88 Offset: 0x2918B88 VA: 0x291CB88
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool IsOverridden(string method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2919F54 Offset: 0x2915F54 VA: 0x2919F54
	|-DynamicProxyMetaObject<object>.IsOverridden
	|
	|-RVA: 0x291CCF4 Offset: 0x2918CF4 VA: 0x291CCF4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.IsOverridden
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291A024 Offset: 0x2916024 VA: 0x291A024
	|-DynamicProxyMetaObject<object>.BindGetMember
	|
	|-RVA: 0x291CDC4 Offset: 0x2918DC4 VA: 0x291CDC4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291A18C Offset: 0x291618C VA: 0x291A18C
	|-DynamicProxyMetaObject<object>.BindSetMember
	|
	|-RVA: 0x291CF4C Offset: 0x2918F4C VA: 0x291CF4C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetMember
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291A388 Offset: 0x2916388 VA: 0x291A388
	|-DynamicProxyMetaObject<object>.BindDeleteMember
	|
	|-RVA: 0x291D15C Offset: 0x291915C VA: 0x291D15C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291A4EC Offset: 0x29164EC VA: 0x291A4EC
	|-DynamicProxyMetaObject<object>.BindConvert
	|
	|-RVA: 0x291D2E0 Offset: 0x29192E0 VA: 0x291D2E0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindConvert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291A654 Offset: 0x2916654 VA: 0x291A654
	|-DynamicProxyMetaObject<object>.BindInvokeMember
	|
	|-RVA: 0x291D468 Offset: 0x2919468 VA: 0x291D468
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291A8DC Offset: 0x29168DC VA: 0x291A8DC
	|-DynamicProxyMetaObject<object>.BindCreateInstance
	|
	|-RVA: 0x291D728 Offset: 0x2919728 VA: 0x291D728
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291AA70 Offset: 0x2916A70 VA: 0x291AA70
	|-DynamicProxyMetaObject<object>.BindInvoke
	|
	|-RVA: 0x291D8D0 Offset: 0x29198D0 VA: 0x291D8D0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291AC04 Offset: 0x2916C04 VA: 0x291AC04
	|-DynamicProxyMetaObject<object>.BindBinaryOperation
	|
	|-RVA: 0x291DA78 Offset: 0x2919A78 VA: 0x291DA78
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291AE04 Offset: 0x2916E04 VA: 0x291AE04
	|-DynamicProxyMetaObject<object>.BindUnaryOperation
	|
	|-RVA: 0x291DC8C Offset: 0x2919C8C VA: 0x291DC8C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindUnaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291AF6C Offset: 0x2916F6C VA: 0x291AF6C
	|-DynamicProxyMetaObject<object>.BindGetIndex
	|
	|-RVA: 0x291DE14 Offset: 0x2919E14 VA: 0x291DE14
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291B100 Offset: 0x2917100 VA: 0x291B100
	|-DynamicProxyMetaObject<object>.BindSetIndex
	|
	|-RVA: 0x291DFBC Offset: 0x2919FBC VA: 0x291DFBC
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291B2BC Offset: 0x29172BC VA: 0x291B2BC
	|-DynamicProxyMetaObject<object>.BindDeleteIndex
	|
	|-RVA: 0x291E18C Offset: 0x291A18C VA: 0x291E18C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteIndex
	*/

	// RVA: -1 Offset: -1
	private static Expression[] get_NoArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291B44C Offset: 0x291744C VA: 0x291B44C
	|-DynamicProxyMetaObject<object>.get_NoArgs
	|
	|-RVA: 0x291E330 Offset: 0x291A330 VA: 0x291E330
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.get_NoArgs
	*/

	// RVA: -1 Offset: -1
	private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291B4D8 Offset: 0x29174D8 VA: 0x291B4D8
	|-DynamicProxyMetaObject<object>.GetArgs
	|
	|-RVA: 0x291E3BC Offset: 0x291A3BC VA: 0x291E3BC
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgs
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291B69C Offset: 0x291769C VA: 0x291B69C
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x291E580 Offset: 0x291A580 VA: 0x291E580
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291B804 Offset: 0x2917804 VA: 0x291B804
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x291E718 Offset: 0x291A718 VA: 0x291E718
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291BA20 Offset: 0x2917A20 VA: 0x291BA20
	|-DynamicProxyMetaObject<object>.Constant
	|
	|-RVA: 0x291E964 Offset: 0x291A964 VA: 0x291E964
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.Constant
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291BAB0 Offset: 0x2917AB0 VA: 0x291BAB0
	|-DynamicProxyMetaObject<object>.CallMethodWithResult
	|
	|-RVA: 0x291E9F4 Offset: 0x291A9F4 VA: 0x291E9F4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291BB2C Offset: 0x2917B2C VA: 0x291BB2C
	|-DynamicProxyMetaObject<object>.BuildCallMethodWithResult
	|
	|-RVA: 0x291EA7C Offset: 0x291AA7C VA: 0x291EA7C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BuildCallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291C120 Offset: 0x2918120 VA: 0x291C120
	|-DynamicProxyMetaObject<object>.CallMethodReturnLast
	|
	|-RVA: 0x291F0A0 Offset: 0x291B0A0 VA: 0x291F0A0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodReturnLast
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291C6FC Offset: 0x29186FC VA: 0x291C6FC
	|-DynamicProxyMetaObject<object>.CallMethodNoResult
	|
	|-RVA: 0x291F6A4 Offset: 0x291B6A4 VA: 0x291F6A4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodNoResult
	*/

	// RVA: -1 Offset: -1
	private BindingRestrictions GetRestrictions() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291CA3C Offset: 0x2918A3C VA: 0x291CA3C
	|-DynamicProxyMetaObject<object>.GetRestrictions
	|
	|-RVA: 0x291FA0C Offset: 0x291BA0C VA: 0x291FA0C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetRestrictions
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x291CB04 Offset: 0x2918B04 VA: 0x291CB04
	|-DynamicProxyMetaObject<object>.GetDynamicMemberNames
	|
	|-RVA: 0x291FAD4 Offset: 0x291BAD4 VA: 0x291FAD4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/
}

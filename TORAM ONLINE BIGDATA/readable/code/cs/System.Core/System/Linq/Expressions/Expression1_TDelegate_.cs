// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Expression1<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15305
{
	// Fields
	private object _par0; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FAE44 Offset: 0x29F6E44 VA: 0x29FAE44
	|-Expression1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FAE80 Offset: 0x29F6E80 VA: 0x29FAE80
	|-Expression1<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FAE88 Offset: 0x29F6E88 VA: 0x29FAE88
	|-Expression1<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FAF00 Offset: 0x29F6F00 VA: 0x29FAF00
	|-Expression1<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

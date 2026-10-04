// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15307
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0
	private readonly ParameterExpression _par2; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB254 Offset: 0x29F7254 VA: 0x29FB254
	|-Expression3<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB2C0 Offset: 0x29F72C0 VA: 0x29FB2C0
	|-Expression3<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB2C8 Offset: 0x29F72C8 VA: 0x29FB2C8
	|-Expression3<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB36C Offset: 0x29F736C VA: 0x29FB36C
	|-Expression3<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

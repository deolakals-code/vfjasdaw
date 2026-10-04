// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Expression2<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15306
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB014 Offset: 0x29F7014 VA: 0x29FB014
	|-Expression2<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB064 Offset: 0x29F7064 VA: 0x29FB064
	|-Expression2<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB06C Offset: 0x29F706C VA: 0x29FB06C
	|-Expression2<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB100 Offset: 0x29F7100 VA: 0x29FB100
	|-Expression2<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

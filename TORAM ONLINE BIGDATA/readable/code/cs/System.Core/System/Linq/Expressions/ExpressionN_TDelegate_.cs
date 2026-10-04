// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15308
{
	// Fields
	private IReadOnlyList<ParameterExpression> _parameters; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB9AC Offset: 0x29F79AC VA: 0x29FB9AC
	|-ExpressionN<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FB9E8 Offset: 0x29F79E8 VA: 0x29FB9E8
	|-ExpressionN<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBA88 Offset: 0x29F7A88 VA: 0x29FBA88
	|-ExpressionN<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBB30 Offset: 0x29F7B30 VA: 0x29FBB30
	|-ExpressionN<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

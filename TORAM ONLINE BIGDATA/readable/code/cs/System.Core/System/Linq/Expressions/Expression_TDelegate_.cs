// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 15302
{
	// Properties
	internal sealed override Type TypeCore { get; }
	internal override Type PublicType { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBBEC Offset: 0x29F7BEC VA: 0x29FBBEC
	|-Expression<object>..ctor
	|
	|-RVA: 0x29FBE08 Offset: 0x29F7E08 VA: 0x29FBE08
	|-Expression<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBBF4 Offset: 0x29F7BF4 VA: 0x29FBBF4
	|-Expression<object>.get_TypeCore
	|
	|-RVA: 0x29FBE10 Offset: 0x29F7E10 VA: 0x29FBE10
	|-Expression<__Il2CppFullySharedGenericType>.get_TypeCore
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Type get_PublicType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBC58 Offset: 0x29F7C58 VA: 0x29FBC58
	|-Expression<object>.get_PublicType
	|
	|-RVA: 0x29FBE74 Offset: 0x29F7E74 VA: 0x29FBE74
	|-Expression<__Il2CppFullySharedGenericType>.get_PublicType
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBCBC Offset: 0x29F7CBC VA: 0x29FBCBC
	|-Expression<object>.Compile
	|
	|-RVA: 0x29FBED8 Offset: 0x29F7ED8 VA: 0x29FBED8
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(bool preferInterpretation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBCD0 Offset: 0x29F7CD0 VA: 0x29FBCD0
	|-Expression<object>.Compile
	|
	|-RVA: 0x29FBF7C Offset: 0x29F7F7C VA: 0x29FBF7C
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 18
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBD9C Offset: 0x29F7D9C VA: 0x29FBD9C
	|-Expression<object>.Rewrite
	|
	|-RVA: 0x29FC0A4 Offset: 0x29F80A4 VA: 0x29FC0A4
	|-Expression<__Il2CppFullySharedGenericType>.Rewrite
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FBDB4 Offset: 0x29F7DB4 VA: 0x29FBDB4
	|-Expression<object>.Accept
	|
	|-RVA: 0x29FC0BC Offset: 0x29F80BC VA: 0x29FC0BC
	|-Expression<__Il2CppFullySharedGenericType>.Accept
	*/
}

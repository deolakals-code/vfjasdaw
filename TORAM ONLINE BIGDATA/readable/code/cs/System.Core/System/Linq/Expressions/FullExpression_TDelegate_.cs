// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate> // TypeDefIndex: 15309
{
	// Fields
	[CompilerGenerated]
	private readonly string <NameCore>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <TailCallCore>k__BackingField; // 0x0

	// Properties
	internal override string NameCore { get; }
	internal override bool TailCallCore { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A00E3C Offset: 0x29FCE3C VA: 0x2A00E3C
	|-FullExpression<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	internal override string get_NameCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A00E8C Offset: 0x29FCE8C VA: 0x2A00E8C
	|-FullExpression<__Il2CppFullySharedGenericType>.get_NameCore
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	internal override bool get_TailCallCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A00E94 Offset: 0x29FCE94 VA: 0x2A00E94
	|-FullExpression<__Il2CppFullySharedGenericType>.get_TailCallCore
	*/
}

// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ParameterExpressionProxy))]
public class ParameterExpression : Expression // TypeDefIndex: 15339
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	public bool IsByRef { get; }

	// Methods

	// RVA: 0x3140F58 Offset: 0x313CF58 VA: 0x3140F58
	internal void .ctor(string name) { }

	// RVA: 0x3140FCC Offset: 0x313CFCC VA: 0x3140FCC
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

	// RVA: 0x31416B4 Offset: 0x313D6B4 VA: 0x31416B4 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x3141720 Offset: 0x313D720 VA: 0x3141720 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3141728 Offset: 0x313D728 VA: 0x3141728
	public string get_Name() { }

	// RVA: 0x313A86C Offset: 0x313686C VA: 0x313A86C
	public bool get_IsByRef() { }

	// RVA: 0x3141730 Offset: 0x313D730 VA: 0x3141730 Slot: 10
	internal virtual bool GetIsByRef() { }

	// RVA: 0x3141738 Offset: 0x313D738 VA: 0x3141738 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

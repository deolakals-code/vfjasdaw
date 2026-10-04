// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 15301
{
	// Fields
	private readonly Expression _body; // 0x10

	// Properties
	public sealed override Type Type { get; }
	internal abstract Type TypeCore { get; }
	internal abstract Type PublicType { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	internal virtual string NameCore { get; }
	public Expression Body { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	internal virtual bool TailCallCore { get; }
	[ExcludeFromCodeCoverage]
	private int System.Linq.Expressions.IParameterProvider.ParameterCount { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ParameterCount { get; }

	// Methods

	// RVA: 0x313E938 Offset: 0x313A938 VA: 0x313E938
	internal void .ctor(Expression body) { }

	// RVA: 0x313E9AC Offset: 0x313A9AC VA: 0x313E9AC Slot: 5
	public sealed override Type get_Type() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeCore();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Type get_PublicType();

	// RVA: 0x313E9B8 Offset: 0x313A9B8 VA: 0x313E9B8 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x313E9C0 Offset: 0x313A9C0 VA: 0x313E9C0
	public string get_Name() { }

	// RVA: 0x313E9D0 Offset: 0x313A9D0 VA: 0x313E9D0 Slot: 14
	internal virtual string get_NameCore() { }

	// RVA: 0x313E9D8 Offset: 0x313A9D8 VA: 0x313E9D8
	public Expression get_Body() { }

	// RVA: 0x313E9E0 Offset: 0x313A9E0 VA: 0x313E9E0
	public Type get_ReturnType() { }

	// RVA: 0x313EA68 Offset: 0x313AA68 VA: 0x313EA68
	public bool get_TailCall() { }

	// RVA: 0x313EA78 Offset: 0x313AA78 VA: 0x313EA78 Slot: 15
	internal virtual bool get_TailCallCore() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313EA80 Offset: 0x313AA80 VA: 0x313EA80 Slot: 10
	private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313EA90 Offset: 0x313AA90 VA: 0x313EA90 Slot: 16
	internal virtual ParameterExpression GetParameter(int index) { }

	// RVA: 0x313EAB8 Offset: 0x313AAB8 VA: 0x313EAB8 Slot: 11
	private int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	// RVA: 0x313EAC8 Offset: 0x313AAC8 VA: 0x313EAC8 Slot: 17
	internal virtual int get_ParameterCount() { }
}

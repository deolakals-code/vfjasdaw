// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.NewArrayExpressionProxy))]
public class NewArrayExpression : Expression // TypeDefIndex: 15335
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }

	// Methods

	// RVA: 0x3140D3C Offset: 0x313CD3C VA: 0x3140D3C
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x3140DC4 Offset: 0x313CDC4 VA: 0x3140DC4
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[CompilerGenerated]
	// RVA: 0x3140E5C Offset: 0x313CE5C VA: 0x3140E5C Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3140E64 Offset: 0x313CE64 VA: 0x3140E64
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x3140E6C Offset: 0x313CE6C VA: 0x3140E6C Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313CFA8 Offset: 0x3138FA8 VA: 0x313CFA8
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }
}

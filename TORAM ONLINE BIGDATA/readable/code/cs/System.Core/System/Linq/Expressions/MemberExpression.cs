// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MemberExpressionProxy))]
public class MemberExpression : Expression // TypeDefIndex: 15315
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x10

	// Properties
	public MemberInfo Member { get; }
	public Expression Expression { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x313ABEC Offset: 0x3136BEC VA: 0x313ABEC
	public MemberInfo get_Member() { }

	[CompilerGenerated]
	// RVA: 0x313EC90 Offset: 0x313AC90 VA: 0x313EC90
	public Expression get_Expression() { }

	// RVA: 0x313EC98 Offset: 0x313AC98 VA: 0x313EC98
	internal void .ctor(Expression expression) { }

	// RVA: 0x313ED0C Offset: 0x313AD0C VA: 0x313ED0C
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	// RVA: 0x313EDAC Offset: 0x313ADAC VA: 0x313EDAC
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	// RVA: 0x313EE4C Offset: 0x313AE4C VA: 0x313EE4C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313EE54 Offset: 0x313AE54 VA: 0x313EE54 Slot: 10
	internal virtual MemberInfo GetMember() { }

	// RVA: 0x313EE7C Offset: 0x313AE7C VA: 0x313EE7C Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313CD58 Offset: 0x3138D58 VA: 0x313CD58
	public MemberExpression Update(Expression expression) { }
}

// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 15283
{
	// Fields
	private readonly StringBuilder _out; // 0x10
	private Dictionary<object, int> _ids; // 0x18

	// Methods

	// RVA: 0x3139EE0 Offset: 0x3135EE0 VA: 0x3139EE0
	private void .ctor() { }

	// RVA: 0x3139F54 Offset: 0x3135F54 VA: 0x3139F54 Slot: 3
	public override string ToString() { }

	// RVA: 0x3139F74 Offset: 0x3135F74 VA: 0x3139F74
	private int GetLabelId(LabelTarget label) { }

	// RVA: 0x313A094 Offset: 0x3136094 VA: 0x313A094
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x3139F78 Offset: 0x3135F78 VA: 0x3139F78
	private int GetId(object o) { }

	// RVA: 0x313A098 Offset: 0x3136098 VA: 0x313A098
	private void Out(string s) { }

	// RVA: 0x313A0B4 Offset: 0x31360B4 VA: 0x313A0B4
	private void Out(char c) { }

	// RVA: 0x313A0D0 Offset: 0x31360D0 VA: 0x313A0D0
	internal static string ExpressionToString(Expression node) { }

	// RVA: 0x3132E94 Offset: 0x312EE94 VA: 0x3132E94
	internal static string CatchBlockToString(CatchBlock node) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C0040 Offset: 0x26BC040 VA: 0x26C0040
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C00B8 Offset: 0x26BC0B8 VA: 0x26C00B8
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: 0x313A148 Offset: 0x3136148 VA: 0x313A148 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x313A76C Offset: 0x313676C VA: 0x313A76C Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C03AC Offset: 0x26BC3AC VA: 0x26C03AC
	|-ExpressionStringBuilder.VisitLambda<object>
	|
	|-RVA: 0x26C0540 Offset: 0x26BC540 VA: 0x26C0540
	|-ExpressionStringBuilder.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x313A878 Offset: 0x3136878 VA: 0x313A878 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x313A978 Offset: 0x3136978 VA: 0x313A978 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x313AAF0 Offset: 0x3136AF0 VA: 0x313AAF0
	private void OutMember(Expression instance, MemberInfo member) { }

	// RVA: 0x313ABA0 Offset: 0x3136BA0 VA: 0x313ABA0 Slot: 17
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x313ABF8 Offset: 0x3136BF8 VA: 0x313ABF8 Slot: 12
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x313AD20 Offset: 0x3136D20 VA: 0x313AD20 Slot: 19
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x313AF28 Offset: 0x3136F28 VA: 0x313AF28 Slot: 20
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x313B050 Offset: 0x3137050 VA: 0x313B050 Slot: 24
	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x313B15C Offset: 0x313715C VA: 0x313B15C Slot: 25
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x313B5AC Offset: 0x31375AC VA: 0x313B5AC Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x313B8E8 Offset: 0x31378E8 VA: 0x313B8E8 Slot: 9
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x313B998 Offset: 0x3137998 VA: 0x313B998 Slot: 14
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x313BAD8 Offset: 0x3137AD8 VA: 0x313BAD8 Slot: 11
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x313BC30 Offset: 0x3137C30 VA: 0x313BC30 Slot: 16
	protected internal override Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x313BC90 Offset: 0x3137C90 VA: 0x313BC90 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x313BD98 Offset: 0x3137D98 VA: 0x313BD98 Slot: 23
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x313BDF8 Offset: 0x3137DF8 VA: 0x313BDF8 Slot: 18
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x313C0C8 Offset: 0x31380C8 VA: 0x313C0C8 Slot: 10
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x313BA1C Offset: 0x3137A1C VA: 0x313BA1C
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x313A650 Offset: 0x3136650 VA: 0x313A650
	private static bool IsBool(Expression node) { }
}

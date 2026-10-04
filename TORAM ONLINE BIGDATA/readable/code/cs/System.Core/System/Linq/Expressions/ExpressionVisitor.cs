// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
public abstract class ExpressionVisitor // TypeDefIndex: 15285
{
	// Methods

	// RVA: 0x3139F4C Offset: 0x3135F4C VA: 0x3139F4C
	protected void .ctor() { }

	// RVA: 0x313C2C4 Offset: 0x31382C4 VA: 0x313C2C4 Slot: 4
	public virtual Expression Visit(Expression node) { }

	// RVA: 0x313C2E8 Offset: 0x31382E8 VA: 0x313C2E8
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	// RVA: 0x313C55C Offset: 0x313855C VA: 0x313C55C
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	// RVA: 0x313C564 Offset: 0x3138564 VA: 0x313C564
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C0FB8 Offset: 0x26BCFB8 VA: 0x26C0FB8
	|-ExpressionVisitor.Visit<object>
	|
	|-RVA: 0x26C11C0 Offset: 0x26BD1C0 VA: 0x26C11C0
	|-ExpressionVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T VisitAndConvert<T>(T node, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C1604 Offset: 0x26BD604 VA: 0x26C1604
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C1708 Offset: 0x26BD708 VA: 0x26C1708
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: 0x313C56C Offset: 0x313856C VA: 0x313C56C Slot: 5
	protected internal virtual Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x313C7AC Offset: 0x31387AC VA: 0x313C7AC Slot: 6
	protected internal virtual Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x313C8A0 Offset: 0x31388A0 VA: 0x313C8A0 Slot: 7
	protected internal virtual Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x313C92C Offset: 0x313892C VA: 0x313C92C Slot: 8
	protected internal virtual Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x313C934 Offset: 0x3138934 VA: 0x313C934 Slot: 9
	protected internal virtual Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x313C93C Offset: 0x313893C VA: 0x313C93C Slot: 10
	protected internal virtual Expression VisitExtension(Expression node) { }

	// RVA: 0x313C964 Offset: 0x3138964 VA: 0x313C964 Slot: 11
	protected internal virtual Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x313CA7C Offset: 0x3138A7C VA: 0x313CA7C Slot: 12
	protected internal virtual Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x313CAFC Offset: 0x3138AFC VA: 0x313CAFC Slot: 13
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node) { }

	// RVA: 0x313CB04 Offset: 0x3138B04 VA: 0x313CB04 Slot: 14
	protected internal virtual Expression VisitLabel(LabelExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal virtual Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C19A0 Offset: 0x26BD9A0 VA: 0x26C19A0
	|-ExpressionVisitor.VisitLambda<object>
	|
	|-RVA: 0x26C1A50 Offset: 0x26BDA50 VA: 0x26C1A50
	|-ExpressionVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x313CBF8 Offset: 0x3138BF8 VA: 0x313CBF8 Slot: 16
	protected internal virtual Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x313CD28 Offset: 0x3138D28 VA: 0x313CD28 Slot: 17
	protected internal virtual Expression VisitMember(MemberExpression node) { }

	// RVA: 0x313CDEC Offset: 0x3138DEC VA: 0x313CDEC Slot: 18
	protected internal virtual Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x313CEDC Offset: 0x3138EDC VA: 0x313CEDC Slot: 19
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x313CF80 Offset: 0x3138F80 VA: 0x313CF80 Slot: 20
	protected internal virtual Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x313D0D0 Offset: 0x31390D0 VA: 0x313D0D0 Slot: 21
	protected internal virtual Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x313D0D8 Offset: 0x31390D8 VA: 0x313D0D8 Slot: 22
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x313D194 Offset: 0x3139194 VA: 0x313D194 Slot: 23
	protected internal virtual Expression VisitTry(TryExpression node) { }

	// RVA: 0x313D394 Offset: 0x3139394 VA: 0x313D394 Slot: 24
	protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x313D474 Offset: 0x3139474 VA: 0x313D474 Slot: 25
	protected internal virtual Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x313D570 Offset: 0x3139570 VA: 0x313D570
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	// RVA: 0x313C644 Offset: 0x3138644 VA: 0x313C644
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	// RVA: 0x313D67C Offset: 0x313967C VA: 0x313D67C
	private static void ValidateChildType(Type before, Type after, string methodName) { }
}

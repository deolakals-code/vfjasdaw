// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
public abstract class Expression // TypeDefIndex: 15257
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x31193F0 Offset: 0x31153F0 VA: 0x31193F0
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x311B374 Offset: 0x3117374 VA: 0x311B374
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x311B980 Offset: 0x3117980 VA: 0x311B980
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x311C1F8 Offset: 0x31181F8 VA: 0x311C1F8
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x311C6E8 Offset: 0x31186E8 VA: 0x311C6E8
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x311C904 Offset: 0x3118904 VA: 0x311C904
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x311B74C Offset: 0x311774C VA: 0x311B74C
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x311CB7C Offset: 0x3118B7C VA: 0x311CB7C
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x311C078 Offset: 0x3118078 VA: 0x311C078
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x311C11C Offset: 0x311811C VA: 0x311C11C
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x311BF20 Offset: 0x3117F20 VA: 0x311BF20
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x311CC48 Offset: 0x3118C48 VA: 0x311CC48
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x311CCD8 Offset: 0x3118CD8 VA: 0x311CCD8
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x311CDD8 Offset: 0x3118DD8 VA: 0x311CDD8
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x311CE5C Offset: 0x3118E5C VA: 0x311CE5C
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x311D584 Offset: 0x3119584 VA: 0x311D584
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x311D480 Offset: 0x3119480 VA: 0x311D480
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x311920C Offset: 0x311520C VA: 0x311920C
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x3117D60 Offset: 0x3113D60 VA: 0x3117D60
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x3123530 Offset: 0x311F530 VA: 0x3123530
	public static BinaryExpression Equal(Expression left, Expression right) { }

	// RVA: 0x31201DC Offset: 0x311C1DC VA: 0x31201DC
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x31179C4 Offset: 0x31139C4 VA: 0x31179C4
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x31239C4 Offset: 0x311F9C4 VA: 0x31239C4
	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	// RVA: 0x312030C Offset: 0x311C30C VA: 0x312030C
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x3117B4C Offset: 0x3113B4C VA: 0x3117B4C
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x312359C Offset: 0x311F59C VA: 0x312359C
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x311FF7C Offset: 0x311BF7C VA: 0x311FF7C
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x311FD1C Offset: 0x311BD1C VA: 0x311FD1C
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x31200AC Offset: 0x311C0AC VA: 0x31200AC
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x311FE4C Offset: 0x311BE4C VA: 0x311FE4C
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x3123A30 Offset: 0x311FA30 VA: 0x3123A30
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x3123C80 Offset: 0x311FC80 VA: 0x3123C80
	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	// RVA: 0x311F004 Offset: 0x311B004 VA: 0x311F004
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x311F750 Offset: 0x311B750 VA: 0x311F750
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3120690 Offset: 0x311C690 VA: 0x3120690
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x3123CE8 Offset: 0x311FCE8 VA: 0x3123CE8
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x311D748 Offset: 0x3119748 VA: 0x311D748
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3121194 Offset: 0x311D194 VA: 0x3121194
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311C470 Offset: 0x3118470 VA: 0x311C470
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x3122D44 Offset: 0x311ED44 VA: 0x3122D44
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311D998 Offset: 0x3119998 VA: 0x311D998
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x311DBEC Offset: 0x3119BEC VA: 0x311DBEC
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3122AA0 Offset: 0x311EAA0 VA: 0x3122AA0
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x3122FE8 Offset: 0x311EFE8 VA: 0x3122FE8
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311DE40 Offset: 0x3119E40 VA: 0x311DE40
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x311E53C Offset: 0x311A53C VA: 0x311E53C
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x31216DC Offset: 0x311D6DC VA: 0x31216DC
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311E790 Offset: 0x311A790 VA: 0x311E790
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3121E9C Offset: 0x311DE9C VA: 0x3121E9C
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311E094 Offset: 0x311A094 VA: 0x311E094
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3122140 Offset: 0x311E140 VA: 0x3122140
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x312328C Offset: 0x311F28C VA: 0x312328C
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311E2E8 Offset: 0x311A2E8 VA: 0x311E2E8
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3123E58 Offset: 0x311FE58 VA: 0x3123E58
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x3123F50 Offset: 0x311FF50 VA: 0x3123F50
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x3120F6C Offset: 0x311CF6C VA: 0x3120F6C
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3121C24 Offset: 0x311DC24 VA: 0x3121C24
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x3120D44 Offset: 0x311CD44 VA: 0x3120D44
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3122828 Offset: 0x311E828 VA: 0x3122828
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311EDB0 Offset: 0x311ADB0 VA: 0x311EDB0
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3121438 Offset: 0x311D438 VA: 0x3121438
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311F4FC Offset: 0x311B4FC VA: 0x311F4FC
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x31223E4 Offset: 0x311E3E4 VA: 0x31223E4
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x312043C Offset: 0x311C43C VA: 0x312043C
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3121980 Offset: 0x311D980 VA: 0x3121980
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x311E9E4 Offset: 0x311A9E4 VA: 0x311E9E4
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x3122688 Offset: 0x311E688 VA: 0x3122688
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x3120B4C Offset: 0x311CB4C VA: 0x3120B4C
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x31240C4 Offset: 0x31200C4 VA: 0x31240C4
	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	// RVA: 0x3124180 Offset: 0x3120180 VA: 0x3124180
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x3124270 Offset: 0x3120270 VA: 0x3124270
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x3124394 Offset: 0x3120394 VA: 0x3124394
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x31244E4 Offset: 0x31204E4 VA: 0x31244E4
	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	// RVA: 0x3124570 Offset: 0x3120570 VA: 0x3124570
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x31245F8 Offset: 0x31205F8 VA: 0x31245F8
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x31248C0 Offset: 0x31208C0 VA: 0x31248C0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x3124924 Offset: 0x3120924 VA: 0x3124924
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x3119818 Offset: 0x3115818 VA: 0x3119818
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x3124694 Offset: 0x3120694 VA: 0x3124694
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x312539C Offset: 0x312139C VA: 0x312539C
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x3125724 Offset: 0x3121724 VA: 0x3125724
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x3124AD8 Offset: 0x3120AD8 VA: 0x3124AD8
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x31258CC Offset: 0x31218CC VA: 0x31258CC
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x311AD24 Offset: 0x3116D24 VA: 0x311AD24
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x3125B58 Offset: 0x3121B58 VA: 0x3125B58
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x3125DE0 Offset: 0x3121DE0 VA: 0x3125DE0
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	// RVA: 0x3125F48 Offset: 0x3121F48 VA: 0x3125F48
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x311AAE0 Offset: 0x3116AE0 VA: 0x311AAE0
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x3125EA0 Offset: 0x3121EA0 VA: 0x3125EA0
	public static DefaultExpression Empty() { }

	// RVA: 0x3125FA4 Offset: 0x3121FA4 VA: 0x3125FA4
	public static DefaultExpression Default(Type type) { }

	// RVA: 0x3117720 Offset: 0x3113720 VA: 0x3117720
	protected void .ctor() { }

	// RVA: 0x3126060 Offset: 0x3122060 VA: 0x3126060 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x3126154 Offset: 0x3122154 VA: 0x3126154 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x3126248 Offset: 0x3122248 VA: 0x3126248 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x3126250 Offset: 0x3122250 VA: 0x3126250 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x3126298 Offset: 0x3122298 VA: 0x3126298 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x3126410 Offset: 0x3122410 VA: 0x3126410 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x312630C Offset: 0x312230C VA: 0x312630C
	public Expression ReduceAndCheck() { }

	// RVA: 0x3126438 Offset: 0x3122438 VA: 0x3126438 Slot: 3
	public override string ToString() { }

	// RVA: 0x3124990 Offset: 0x3120990 VA: 0x3124990
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x311B124 Offset: 0x3117124 VA: 0x311B124
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x3126440 Offset: 0x3122440 VA: 0x3126440
	public static GotoExpression Break(LabelTarget target) { }

	// RVA: 0x31265E4 Offset: 0x31225E4 VA: 0x31265E4
	public static GotoExpression Return(LabelTarget target) { }

	// RVA: 0x312669C Offset: 0x312269C VA: 0x312669C
	public static GotoExpression Return(LabelTarget target, Expression value) { }

	// RVA: 0x3126758 Offset: 0x3122758 VA: 0x3126758
	public static GotoExpression Goto(LabelTarget target, Type type) { }

	// RVA: 0x31267C4 Offset: 0x31227C4 VA: 0x31267C4
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x31264F8 Offset: 0x31224F8 VA: 0x31264F8
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x3126880 Offset: 0x3122880 VA: 0x3126880
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x3126A3C Offset: 0x3122A3C VA: 0x3126A3C
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x311998C Offset: 0x311598C VA: 0x311998C
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x3127130 Offset: 0x3123130 VA: 0x3127130
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x3126C7C Offset: 0x3122C7C VA: 0x3126C7C
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x3126BC8 Offset: 0x3122BC8 VA: 0x3126BC8
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x3127194 Offset: 0x3123194 VA: 0x3127194
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x3127250 Offset: 0x3123250 VA: 0x3127250
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x31277CC Offset: 0x31237CC VA: 0x31277CC
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x3127A34 Offset: 0x3123A34 VA: 0x3127A34
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x3127E80 Offset: 0x3123E80 VA: 0x3127E80
	internal static InvocationExpression Invoke(Expression expression) { }

	// RVA: 0x3119294 Offset: 0x3115294 VA: 0x3119294
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x31281A8 Offset: 0x31241A8 VA: 0x31281A8
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	// RVA: 0x312835C Offset: 0x312435C VA: 0x312835C
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x3128560 Offset: 0x3124560 VA: 0x3128560
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x31287BC Offset: 0x31247BC VA: 0x31287BC
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x3128A70 Offset: 0x3124A70 VA: 0x3128A70
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	// RVA: 0x3127F84 Offset: 0x3123F84 VA: 0x3127F84
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x312934C Offset: 0x312534C VA: 0x312934C
	public static LabelExpression Label(LabelTarget target) { }

	// RVA: 0x31293A4 Offset: 0x31253A4 VA: 0x31293A4
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x3129478 Offset: 0x3125478 VA: 0x3129478
	public static LabelTarget Label() { }

	// RVA: 0x31295E0 Offset: 0x31255E0 VA: 0x31295E0
	public static LabelTarget Label(string name) { }

	// RVA: 0x3129690 Offset: 0x3125690 VA: 0x3129690
	public static LabelTarget Label(Type type) { }

	// RVA: 0x312951C Offset: 0x312551C VA: 0x312951C
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x31296E8 Offset: 0x31256E8 VA: 0x31296E8
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BFC38 Offset: 0x26BBC38 VA: 0x26BFC38
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BFB4C Offset: 0x26BBB4C VA: 0x26BFB4C
	|-Expression.Lambda<object>
	|
	|-RVA: 0x26BFBC0 Offset: 0x26BBBC0 VA: 0x26BFBC0
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BFCAC Offset: 0x26BBCAC VA: 0x26BFCAC
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BFD30 Offset: 0x26BBD30 VA: 0x26BFD30
	|-Expression.Lambda<object>
	|
	|-RVA: 0x26BFEB8 Offset: 0x26BBEB8 VA: 0x26BFEB8
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3129B98 Offset: 0x3125B98 VA: 0x3129B98
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x3129C0C Offset: 0x3125C0C VA: 0x3129C0C
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x3129CEC Offset: 0x3125CEC VA: 0x3129CEC
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x312A384 Offset: 0x3126384 VA: 0x312A384
	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x312A4B0 Offset: 0x31264B0 VA: 0x312A4B0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x312A64C Offset: 0x312664C VA: 0x312A64C
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x311A4AC Offset: 0x31164AC VA: 0x311A4AC
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x312A7BC Offset: 0x31267BC VA: 0x312A7BC
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x3119654 Offset: 0x3115654 VA: 0x3119654
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x312AA70 Offset: 0x3126A70 VA: 0x312AA70
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x311A780 Offset: 0x3116780 VA: 0x311A780
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x311A8C8 Offset: 0x31168C8 VA: 0x311A8C8
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x312ABD4 Offset: 0x3126BD4 VA: 0x312ABD4
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x312ADEC Offset: 0x3126DEC VA: 0x312ADEC
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x312B06C Offset: 0x312706C VA: 0x312B06C
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x312B35C Offset: 0x312735C VA: 0x312B35C
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	// RVA: 0x312B430 Offset: 0x3127430 VA: 0x312B430
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x312BDBC Offset: 0x3127DBC VA: 0x312BDBC
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x312B3C4 Offset: 0x31273C4 VA: 0x312B3C4
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x312BEC8 Offset: 0x3127EC8 VA: 0x312BEC8
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x312C04C Offset: 0x312804C VA: 0x312C04C
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x312C23C Offset: 0x312823C VA: 0x312C23C
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x311A620 Offset: 0x3116620 VA: 0x311A620
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x312B498 Offset: 0x3127498 VA: 0x312B498
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x312AB40 Offset: 0x3126B40 VA: 0x312AB40
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x312C6E8 Offset: 0x31286E8 VA: 0x312C6E8
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x312797C Offset: 0x312397C VA: 0x312797C
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x3129344 Offset: 0x3125344 VA: 0x3129344
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x312818C Offset: 0x312418C VA: 0x312818C
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x3128194 Offset: 0x3124194 VA: 0x3128194
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x312819C Offset: 0x312419C VA: 0x312819C
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x3126BC0 Offset: 0x3122BC0 VA: 0x3126BC0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x312C498 Offset: 0x3128498 VA: 0x312C498
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x312C884 Offset: 0x3128884 VA: 0x312C884
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x312C7D0 Offset: 0x31287D0 VA: 0x312C7D0
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x312CAC4 Offset: 0x3128AC4 VA: 0x312CAC4
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x312CB28 Offset: 0x3128B28 VA: 0x312CB28
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x312CF54 Offset: 0x3128F54 VA: 0x312CF54
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x312D1F8 Offset: 0x31291F8 VA: 0x312D1F8
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x311A400 Offset: 0x3116400 VA: 0x311A400
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x31195DC Offset: 0x31155DC VA: 0x31195DC
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x312D250 Offset: 0x3129250 VA: 0x312D250
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x312D37C Offset: 0x312937C VA: 0x312D37C
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x312D3EC Offset: 0x31293EC VA: 0x312D3EC
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x312D620 Offset: 0x3129620 VA: 0x312D620
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x312DFCC Offset: 0x3129FCC VA: 0x312DFCC
	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	// RVA: 0x312E0CC Offset: 0x312A0CC VA: 0x312E0CC
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	// RVA: 0x312E1CC Offset: 0x312A1CC VA: 0x312E1CC
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x31303C0 Offset: 0x312C3C0 VA: 0x31303C0
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x3130544 Offset: 0x312C544 VA: 0x3130544
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x313086C Offset: 0x312C86C VA: 0x313086C
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x3130C10 Offset: 0x312CC10 VA: 0x3130C10
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x3130CC4 Offset: 0x312CCC4 VA: 0x3130CC4
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x3130DAC Offset: 0x312CDAC VA: 0x3130DAC
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x312E718 Offset: 0x312A718 VA: 0x312E718
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x312FB64 Offset: 0x312BB64 VA: 0x312FB64
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x312E8F0 Offset: 0x312A8F0 VA: 0x312E8F0
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x3131144 Offset: 0x312D144 VA: 0x3131144
	public static UnaryExpression Not(Expression expression) { }

	// RVA: 0x312EAC8 Offset: 0x312AAC8 VA: 0x312EAC8
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x312ECA4 Offset: 0x312ACA4 VA: 0x312ECA4
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x312EE44 Offset: 0x312AE44 VA: 0x312EE44
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x312EFE4 Offset: 0x312AFE4 VA: 0x312EFE4
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x312F8E4 Offset: 0x312B8E4 VA: 0x312F8E4
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x312FD04 Offset: 0x312BD04 VA: 0x312FD04
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x311AA78 Offset: 0x3116A78 VA: 0x311AA78
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x312F360 Offset: 0x312B360 VA: 0x312F360
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x312F570 Offset: 0x312B570 VA: 0x312F570
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x312F184 Offset: 0x312B184 VA: 0x312F184
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x312FA4C Offset: 0x312BA4C VA: 0x312FA4C
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x312F79C Offset: 0x312B79C VA: 0x312F79C
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x312FEE0 Offset: 0x312BEE0 VA: 0x312FEE0
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x3130080 Offset: 0x312C080 VA: 0x3130080
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x313119C Offset: 0x312D19C VA: 0x313119C
	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	// RVA: 0x3130220 Offset: 0x312C220 VA: 0x3130220
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x31302F0 Offset: 0x312C2F0 VA: 0x31302F0
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x3130288 Offset: 0x312C288 VA: 0x3130288
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x3130358 Offset: 0x312C358 VA: 0x3130358
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x31311F8 Offset: 0x312D1F8 VA: 0x31311F8
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x313148C Offset: 0x312D48C VA: 0x313148C
	private static void .cctor() { }
}

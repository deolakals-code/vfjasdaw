// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightCompiler // TypeDefIndex: 15561
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x315DF54 Offset: 0x3159F54 VA: 0x315DF54
	public void .ctor() { }

	// RVA: 0x315E180 Offset: 0x315A180 VA: 0x315E180
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x315E1AC Offset: 0x315A1AC VA: 0x315E1AC
	public InstructionList get_Instructions() { }

	// RVA: 0x315E1B4 Offset: 0x315A1B4 VA: 0x315E1B4
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x315E3FC Offset: 0x315A3FC VA: 0x315E3FC
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x315E72C Offset: 0x315A72C VA: 0x315E72C
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x315E7D4 Offset: 0x315A7D4 VA: 0x315E7D4
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x315E808 Offset: 0x315A808 VA: 0x315E808
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x315E930 Offset: 0x315A930 VA: 0x315E930
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x315EA50 Offset: 0x315AA50 VA: 0x315EA50
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x315EAA0 Offset: 0x315AAA0 VA: 0x315EAA0
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x315EB5C Offset: 0x315AB5C VA: 0x315EB5C
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x315EAE0 Offset: 0x315AAE0 VA: 0x315EAE0
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x315EBE4 Offset: 0x315ABE4 VA: 0x315EBE4
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x315EC40 Offset: 0x315AC40 VA: 0x315EC40
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x315EC94 Offset: 0x315AC94 VA: 0x315EC94
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x315ED50 Offset: 0x315AD50 VA: 0x315ED50
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x315EDD4 Offset: 0x315ADD4 VA: 0x315EDD4
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x315EF18 Offset: 0x315AF18 VA: 0x315EF18
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x315F3B0 Offset: 0x315B3B0 VA: 0x315F3B0
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x315F5DC Offset: 0x315B5DC VA: 0x315F5DC
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x315F6B0 Offset: 0x315B6B0 VA: 0x315F6B0
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x315F7A0 Offset: 0x315B7A0 VA: 0x315F7A0
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x315FA3C Offset: 0x315BA3C VA: 0x315FA3C
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x315FB04 Offset: 0x315BB04 VA: 0x315FB04
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x315FE7C Offset: 0x315BE7C VA: 0x315FE7C
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x315FF28 Offset: 0x315BF28 VA: 0x315FF28
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x316007C Offset: 0x315C07C VA: 0x316007C
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x3160FBC Offset: 0x315CFBC VA: 0x3160FBC
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x316102C Offset: 0x315D02C VA: 0x316102C
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x316109C Offset: 0x315D09C VA: 0x316109C
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x3160D88 Offset: 0x315CD88 VA: 0x3160D88
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x316122C Offset: 0x315D22C VA: 0x316122C
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x31621D4 Offset: 0x315E1D4 VA: 0x31621D4
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x316272C Offset: 0x315E72C VA: 0x316272C
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x3162784 Offset: 0x315E784 VA: 0x3162784
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x3162A60 Offset: 0x315EA60 VA: 0x3162A60
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x3162B94 Offset: 0x315EB94 VA: 0x3162B94
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x3162D78 Offset: 0x315ED78 VA: 0x3162D78
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x3162F60 Offset: 0x315EF60 VA: 0x3162F60
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x3162E00 Offset: 0x315EE00 VA: 0x3162E00
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x3162FE8 Offset: 0x315EFE8 VA: 0x3162FE8
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x316314C Offset: 0x315F14C VA: 0x316314C
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x3163830 Offset: 0x315F830 VA: 0x3163830
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x3163910 Offset: 0x315F910 VA: 0x3163910
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x3163B24 Offset: 0x315FB24 VA: 0x3163B24
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x3163E00 Offset: 0x315FE00 VA: 0x3163E00
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8FC4 Offset: 0x26C4FC4 VA: 0x26C8FC4
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0x26C9614 Offset: 0x26C5614 VA: 0x26C9614
	|-LightCompiler.CompileIntSwitchExpression<object>
	|
	|-RVA: 0x26C9C5C Offset: 0x26C5C5C VA: 0x26C9C5C
	|-LightCompiler.CompileIntSwitchExpression<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x316483C Offset: 0x316083C VA: 0x316483C
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x3164EBC Offset: 0x3160EBC VA: 0x3164EBC
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x3165058 Offset: 0x3161058 VA: 0x3165058
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x3163CD4 Offset: 0x315FCD4 VA: 0x3163CD4
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x3163DE0 Offset: 0x315FDE0 VA: 0x3163DE0
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x3165264 Offset: 0x3161264 VA: 0x3165264
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x3165230 Offset: 0x3161230 VA: 0x3165230
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x3163D58 Offset: 0x315FD58 VA: 0x3163D58
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x3165334 Offset: 0x3161334 VA: 0x3165334
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x31657C0 Offset: 0x31617C0 VA: 0x31657C0
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x31658F8 Offset: 0x31618F8 VA: 0x31658F8
	private void CheckRethrow() { }

	// RVA: 0x316594C Offset: 0x316194C VA: 0x316594C
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x3165A4C Offset: 0x3161A4C VA: 0x3165A4C
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x31665A4 Offset: 0x31625A4 VA: 0x31665A4
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x31667D8 Offset: 0x31627D8 VA: 0x31667D8
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x3166874 Offset: 0x3162874 VA: 0x3166874
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x3166DC8 Offset: 0x3162DC8 VA: 0x3166DC8
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x315F6A8 Offset: 0x315B6A8 VA: 0x315F6A8
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x3166FC8 Offset: 0x3162FC8 VA: 0x3166FC8
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x3161878 Offset: 0x315D878 VA: 0x3161878
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x316714C Offset: 0x316314C VA: 0x316714C
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x3167548 Offset: 0x3163548 VA: 0x3167548
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x31678F4 Offset: 0x31638F4 VA: 0x31678F4
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x3167994 Offset: 0x3163994 VA: 0x3167994
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x3167D04 Offset: 0x3163D04 VA: 0x3167D04
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x3168098 Offset: 0x3164098 VA: 0x3168098
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x3168240 Offset: 0x3164240 VA: 0x3168240
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x3168540 Offset: 0x3164540 VA: 0x3168540
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x3168768 Offset: 0x3164768 VA: 0x3168768
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x3168D20 Offset: 0x3164D20 VA: 0x3168D20
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x3168F8C Offset: 0x3164F8C VA: 0x3168F8C
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x3169008 Offset: 0x3165008 VA: 0x3169008
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x31693E8 Offset: 0x31653E8 VA: 0x31693E8
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x3169464 Offset: 0x3165464 VA: 0x3169464
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x3169968 Offset: 0x3165968 VA: 0x3169968
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x3169AE0 Offset: 0x3165AE0 VA: 0x3169AE0
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x3169DA0 Offset: 0x3165DA0 VA: 0x3169DA0
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x3169EC4 Offset: 0x3165EC4 VA: 0x3169EC4
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x3162B48 Offset: 0x315EB48 VA: 0x3162B48
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x316A0BC Offset: 0x31660BC VA: 0x316A0BC
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x315F3A4 Offset: 0x315B3A4 VA: 0x315F3A4
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x315F44C Offset: 0x315B44C VA: 0x315F44C
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x316A304 Offset: 0x3166304 VA: 0x316A304
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x315E3AC Offset: 0x315A3AC VA: 0x315E3AC
	private void Compile(Expression expr) { }

	// RVA: 0x316A9BC Offset: 0x31669BC VA: 0x316A9BC
	private static void .cctor() { }
}

// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxy(typeof(InstructionList.DebugView))]
internal sealed class InstructionList // TypeDefIndex: 15510
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }

	// Methods

	// RVA: 0x3153A70 Offset: 0x314FA70 VA: 0x3153A70
	public void Emit(Instruction instruction) { }

	// RVA: 0x3153B24 Offset: 0x314FB24 VA: 0x3153B24
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x3153BD0 Offset: 0x314FBD0 VA: 0x3153BD0
	public void UnEmit() { }

	// RVA: 0x3153CD8 Offset: 0x314FCD8 VA: 0x3153CD8
	public int get_Count() { }

	// RVA: 0x3153D20 Offset: 0x314FD20 VA: 0x3153D20
	public int get_CurrentStackDepth() { }

	// RVA: 0x3153D28 Offset: 0x314FD28 VA: 0x3153D28
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x3153D30 Offset: 0x314FD30 VA: 0x3153D30
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x3153D88 Offset: 0x314FD88 VA: 0x3153D88
	public InstructionArray ToArray() { }

	// RVA: 0x31540CC Offset: 0x31500CC VA: 0x31540CC
	public void EmitLoad(object value) { }

	// RVA: 0x3154628 Offset: 0x3150628 VA: 0x3154628
	public void EmitLoad(bool value) { }

	// RVA: 0x31540D4 Offset: 0x31500D4 VA: 0x31540D4
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x315479C Offset: 0x315079C VA: 0x315479C
	public void EmitDup() { }

	// RVA: 0x31547FC Offset: 0x31507FC VA: 0x31547FC
	public void EmitPop() { }

	// RVA: 0x315485C Offset: 0x315085C VA: 0x315485C
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x3154980 Offset: 0x3150980 VA: 0x3154980
	public void EmitLoadLocal(int index) { }

	// RVA: 0x3154B60 Offset: 0x3150B60 VA: 0x3154B60
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x3154BCC Offset: 0x3150BCC VA: 0x3154BCC
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x3154D9C Offset: 0x3150D9C VA: 0x3154D9C
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x3154F7C Offset: 0x3150F7C VA: 0x3154F7C
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x315515C Offset: 0x315115C VA: 0x315515C
	public void EmitAssignLocal(int index) { }

	// RVA: 0x315533C Offset: 0x315133C VA: 0x315533C
	public void EmitStoreLocal(int index) { }

	// RVA: 0x315551C Offset: 0x315151C VA: 0x315551C
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x3155588 Offset: 0x3151588 VA: 0x3155588
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x3155758 Offset: 0x3151758 VA: 0x3155758
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x31557C4 Offset: 0x31517C4 VA: 0x31557C4
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x3155994 Offset: 0x3151994 VA: 0x3155994
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x3155B74 Offset: 0x3151B74 VA: 0x3155B74
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x3155B8C Offset: 0x3151B8C VA: 0x3155B8C
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x3155CF0 Offset: 0x3151CF0 VA: 0x3155CF0
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x3155D5C Offset: 0x3151D5C VA: 0x3155D5C
	internal static Instruction Parameter(int index) { }

	// RVA: 0x3155DB8 Offset: 0x3151DB8 VA: 0x3155DB8
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x3155C94 Offset: 0x3151C94 VA: 0x3155C94
	internal static Instruction InitReference(int index) { }

	// RVA: 0x3155E14 Offset: 0x3151E14 VA: 0x3155E14
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x3155E70 Offset: 0x3151E70 VA: 0x3155E70
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x3155EDC Offset: 0x3151EDC VA: 0x3155EDC
	public void EmitGetArrayItem() { }

	// RVA: 0x3155F3C Offset: 0x3151F3C VA: 0x3155F3C
	public void EmitSetArrayItem() { }

	// RVA: 0x3155F9C Offset: 0x3151F9C VA: 0x3155F9C
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x3156008 Offset: 0x3152008 VA: 0x3156008
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x315607C Offset: 0x315207C VA: 0x315607C
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x31560F0 Offset: 0x31520F0 VA: 0x31560F0
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x3156128 Offset: 0x3152128 VA: 0x3156128
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x3156160 Offset: 0x3152160 VA: 0x3156160
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x3156198 Offset: 0x3152198 VA: 0x3156198
	public void EmitDiv(Type type) { }

	// RVA: 0x31561BC Offset: 0x31521BC VA: 0x31561BC
	public void EmitModulo(Type type) { }

	// RVA: 0x31561E0 Offset: 0x31521E0 VA: 0x31561E0
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x3156204 Offset: 0x3152204 VA: 0x3156204
	public void EmitAnd(Type type) { }

	// RVA: 0x3156228 Offset: 0x3152228 VA: 0x3156228
	public void EmitOr(Type type) { }

	// RVA: 0x315624C Offset: 0x315224C VA: 0x315624C
	public void EmitLeftShift(Type type) { }

	// RVA: 0x31565E4 Offset: 0x31525E4 VA: 0x31565E4
	public void EmitRightShift(Type type) { }

	// RVA: 0x3156608 Offset: 0x3152608 VA: 0x3156608
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x3156634 Offset: 0x3152634 VA: 0x3156634
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x3156660 Offset: 0x3152660 VA: 0x3156660
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x3157100 Offset: 0x3153100 VA: 0x3157100
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x3157BA0 Offset: 0x3153BA0 VA: 0x3157BA0
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x3157BC8 Offset: 0x3153BC8 VA: 0x3157BC8
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x3157BF0 Offset: 0x3153BF0 VA: 0x3157BF0
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x3157C74 Offset: 0x3153C74 VA: 0x3157C74
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x3157CF8 Offset: 0x3153CF8 VA: 0x3157CF8
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x3157D6C Offset: 0x3153D6C VA: 0x3157D6C
	public void EmitCast(Type toType) { }

	// RVA: 0x3157D90 Offset: 0x3153D90 VA: 0x3157D90
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x3157DFC Offset: 0x3153DFC VA: 0x3157DFC
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x3157E68 Offset: 0x3153E68 VA: 0x3157E68
	public void EmitNot(Type type) { }

	// RVA: 0x3157E8C Offset: 0x3153E8C VA: 0x3157E8C
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x3157EF8 Offset: 0x3153EF8 VA: 0x3157EF8
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x3157F74 Offset: 0x3153F74 VA: 0x3157F74
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x3157FF8 Offset: 0x3153FF8 VA: 0x3157FF8
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x3158064 Offset: 0x3154064 VA: 0x3158064
	public void EmitTypeEquals() { }

	// RVA: 0x31580C4 Offset: 0x31540C4 VA: 0x31580C4
	public void EmitArrayLength() { }

	// RVA: 0x3158124 Offset: 0x3154124 VA: 0x3158124
	public void EmitNegate(Type type) { }

	// RVA: 0x3158148 Offset: 0x3154148 VA: 0x3158148
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x315816C Offset: 0x315416C VA: 0x315816C
	public void EmitIncrement(Type type) { }

	// RVA: 0x315818C Offset: 0x315418C VA: 0x315818C
	public void EmitDecrement(Type type) { }

	// RVA: 0x31581B0 Offset: 0x31541B0 VA: 0x31581B0
	public void EmitTypeIs(Type type) { }

	// RVA: 0x315821C Offset: 0x315421C VA: 0x315821C
	public void EmitTypeAs(Type type) { }

	// RVA: 0x3158288 Offset: 0x3154288 VA: 0x3158288
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x31582A4 Offset: 0x31542A4 VA: 0x31582A4
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x31584F4 Offset: 0x31544F4 VA: 0x31584F4
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x315859C Offset: 0x315459C VA: 0x315859C
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x315861C Offset: 0x315461C VA: 0x315861C
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x3158644 Offset: 0x3154644 VA: 0x3158644
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x31586F0 Offset: 0x31546F0 VA: 0x31586F0
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x3153E60 Offset: 0x314FE60 VA: 0x3153E60
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x3158744 Offset: 0x3154744 VA: 0x3158744
	public BranchLabel MakeLabel() { }

	// RVA: 0x315886C Offset: 0x315486C VA: 0x315886C
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x3158950 Offset: 0x3154950 VA: 0x3158950
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x315899C Offset: 0x315499C VA: 0x315899C
	public int MarkRuntimeLabel() { }

	// RVA: 0x31589D8 Offset: 0x31549D8 VA: 0x31589D8
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x31589F8 Offset: 0x31549F8 VA: 0x31589F8
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x3158A9C Offset: 0x3154A9C VA: 0x3158A9C
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x3158ADC Offset: 0x3154ADC VA: 0x3158ADC
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x3158B48 Offset: 0x3154B48 VA: 0x3158B48
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x3158BCC Offset: 0x3154BCC VA: 0x3158BCC
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x3158C38 Offset: 0x3154C38 VA: 0x3158C38
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x3158CA4 Offset: 0x3154CA4 VA: 0x3158CA4
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x3158D10 Offset: 0x3154D10 VA: 0x3158D10
	public void EmitThrow() { }

	// RVA: 0x3158D70 Offset: 0x3154D70 VA: 0x3158D70
	public void EmitThrowVoid() { }

	// RVA: 0x3158DD0 Offset: 0x3154DD0 VA: 0x3158DD0
	public void EmitRethrow() { }

	// RVA: 0x3158E30 Offset: 0x3154E30 VA: 0x3158E30
	public void EmitRethrowVoid() { }

	// RVA: 0x3158E90 Offset: 0x3154E90 VA: 0x3158E90
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x3158EB4 Offset: 0x3154EB4 VA: 0x3158EB4
	public void EmitEnterTryCatch() { }

	// RVA: 0x3158ED4 Offset: 0x3154ED4 VA: 0x3158ED4
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x3158F5C Offset: 0x3154F5C VA: 0x3158F5C
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x3158FE0 Offset: 0x3154FE0 VA: 0x3158FE0
	public void EmitLeaveFinally() { }

	// RVA: 0x3159040 Offset: 0x3155040 VA: 0x3159040
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x31590C4 Offset: 0x31550C4 VA: 0x31590C4
	public void EmitLeaveFault() { }

	// RVA: 0x3159124 Offset: 0x3155124 VA: 0x3159124
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x3159184 Offset: 0x3155184 VA: 0x3159184
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x31591E4 Offset: 0x31551E4 VA: 0x31591E4
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x3159244 Offset: 0x3155244 VA: 0x3159244
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x31592A4 Offset: 0x31552A4 VA: 0x31592A4
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C59B4 Offset: 0x26C19B4 VA: 0x26C59B4
	|-InstructionList.EmitIntSwitch<int>
	|
	|-RVA: 0x26C5A1C Offset: 0x26C1A1C VA: 0x26C5A1C
	|-InstructionList.EmitIntSwitch<object>
	|
	|-RVA: 0x26C5A84 Offset: 0x26C1A84 VA: 0x26C5A84
	|-InstructionList.EmitIntSwitch<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3159330 Offset: 0x3155330 VA: 0x3159330
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x31593A4 Offset: 0x31553A4 VA: 0x31593A4
	public void .ctor() { }

	// RVA: 0x315942C Offset: 0x315542C VA: 0x315942C
	private static void .cctor() { }
}

// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CallInstruction : Instruction // TypeDefIndex: 15389
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ArgumentCount();

	// RVA: 0x31470CC Offset: 0x31430CC VA: 0x31470CC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314710C Offset: 0x314310C VA: 0x314710C
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x3147170 Offset: 0x3143170 VA: 0x3147170
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x3147300 Offset: 0x3143300 VA: 0x3147300
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x3147808 Offset: 0x3143808 VA: 0x3147808
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x3147828 Offset: 0x3143828 VA: 0x3147828
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x314784C Offset: 0x314384C VA: 0x314784C
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x3147874 Offset: 0x3143874 VA: 0x3147874 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3147880 Offset: 0x3143880 VA: 0x3147880
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x31479D8 Offset: 0x31439D8 VA: 0x31479D8
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0x3147A38 Offset: 0x3143A38 VA: 0x3147A38
	protected void .ctor() { }
}

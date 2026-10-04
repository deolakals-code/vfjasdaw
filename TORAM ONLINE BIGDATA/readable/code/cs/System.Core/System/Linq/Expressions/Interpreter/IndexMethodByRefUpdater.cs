// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 15567
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x316BFB0 Offset: 0x3167FB0 VA: 0x316BFB0
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x316C024 Offset: 0x3168024 VA: 0x316C024 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x316C28C Offset: 0x316828C VA: 0x316C28C Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

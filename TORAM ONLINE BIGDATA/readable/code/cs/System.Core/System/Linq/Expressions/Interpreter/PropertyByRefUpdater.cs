// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PropertyByRefUpdater : ByRefUpdater // TypeDefIndex: 15566
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly PropertyInfo _property; // 0x30

	// Methods

	// RVA: 0x316BD54 Offset: 0x3167D54 VA: 0x316BD54
	public void .ctor(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	// RVA: 0x316BDB4 Offset: 0x3167DB4 VA: 0x316BDB4 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x316BF18 Offset: 0x3167F18 VA: 0x316BF18 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

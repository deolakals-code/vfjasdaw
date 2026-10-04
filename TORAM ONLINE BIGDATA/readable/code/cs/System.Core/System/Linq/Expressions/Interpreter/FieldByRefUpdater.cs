// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 15565
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly FieldInfo _field; // 0x30

	// Methods

	// RVA: 0x316BBB8 Offset: 0x3167BB8 VA: 0x316BBB8
	public void .ctor(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	// RVA: 0x316BC18 Offset: 0x3167C18 VA: 0x316BC18 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x316BCBC Offset: 0x3167CBC VA: 0x316BCBC Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

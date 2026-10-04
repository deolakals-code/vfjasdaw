// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightDelegateCreator // TypeDefIndex: 15568
{
	// Fields
	private readonly LambdaExpression _lambda; // 0x10
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; // 0x18

	// Properties
	internal Interpreter Interpreter { get; }

	// Methods

	// RVA: 0x316C388 Offset: 0x3168388 VA: 0x316C388
	internal void .ctor(Interpreter interpreter, LambdaExpression lambda) { }

	[CompilerGenerated]
	// RVA: 0x316C3CC Offset: 0x31683CC VA: 0x316C3CC
	internal Interpreter get_Interpreter() { }

	// RVA: 0x316C3D4 Offset: 0x31683D4 VA: 0x316C3D4
	public Delegate CreateDelegate() { }

	// RVA: 0x316C3DC Offset: 0x31683DC VA: 0x316C3DC
	internal Delegate CreateDelegate(IStrongBox[] closure) { }
}

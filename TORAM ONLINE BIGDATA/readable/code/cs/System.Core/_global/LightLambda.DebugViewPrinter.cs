// Assembly: System.Core.dll
// Namespace: 
private class LightLambda.DebugViewPrinter // TypeDefIndex: 15569
{
	// Fields
	private readonly Interpreter _interpreter; // 0x10
	private readonly Dictionary<int, int> _tryStart; // 0x18
	private readonly Dictionary<int, string> _handlerEnter; // 0x20
	private readonly Dictionary<int, int> _handlerExit; // 0x28
	private string _indent; // 0x30

	// Methods

	// RVA: 0x316C774 Offset: 0x3168774 VA: 0x316C774
	public void .ctor(Interpreter interpreter) { }

	// RVA: 0x316E624 Offset: 0x316A624 VA: 0x316E624
	private void Analyze() { }

	// RVA: 0x316E8B0 Offset: 0x316A8B0 VA: 0x316E8B0
	private void AddTryStart(int index) { }

	// RVA: 0x316E984 Offset: 0x316A984 VA: 0x316E984
	private void AddHandlerExit(int index) { }

	// RVA: 0x316EA28 Offset: 0x316AA28 VA: 0x316EA28
	private void Indent() { }

	// RVA: 0x316EA68 Offset: 0x316AA68 VA: 0x316EA68
	private void Dedent() { }

	// RVA: 0x316EAA8 Offset: 0x316AAA8 VA: 0x316EAA8 Slot: 3
	public override string ToString() { }

	// RVA: 0x316EF84 Offset: 0x316AF84 VA: 0x316EF84
	private void EmitExits(StringBuilder sb, int index) { }
}

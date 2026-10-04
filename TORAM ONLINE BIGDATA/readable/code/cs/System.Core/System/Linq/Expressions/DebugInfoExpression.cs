// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.DebugInfoExpressionProxy))]
public class DebugInfoExpression : Expression // TypeDefIndex: 15279
{
	// Fields
	[CompilerGenerated]
	private readonly SymbolDocumentInfo <Document>k__BackingField; // 0x10

	// Properties
	[ExcludeFromCodeCoverage]
	public virtual int StartLine { get; }
	[ExcludeFromCodeCoverage]
	public virtual int EndLine { get; }
	public SymbolDocumentInfo Document { get; }
	[ExcludeFromCodeCoverage]
	public virtual bool IsClear { get; }

	// Methods

	// RVA: 0x31337A8 Offset: 0x312F7A8 VA: 0x31337A8 Slot: 10
	public virtual int get_StartLine() { }

	// RVA: 0x31337D0 Offset: 0x312F7D0 VA: 0x31337D0 Slot: 11
	public virtual int get_EndLine() { }

	[CompilerGenerated]
	// RVA: 0x31337F8 Offset: 0x312F7F8 VA: 0x31337F8
	public SymbolDocumentInfo get_Document() { }

	// RVA: 0x3133800 Offset: 0x312F800 VA: 0x3133800 Slot: 12
	public virtual bool get_IsClear() { }
}

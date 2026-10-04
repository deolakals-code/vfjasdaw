// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class LikeNode : BinaryNode // TypeDefIndex: 14725
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0x31FF6FC Offset: 0x31FB6FC VA: 0x31FF6FC
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x31FF700 Offset: 0x31FB700 VA: 0x31FF700 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x31FFC64 Offset: 0x31FBC64 VA: 0x31FFC64
	internal string AnalyzePattern(string pat) { }
}

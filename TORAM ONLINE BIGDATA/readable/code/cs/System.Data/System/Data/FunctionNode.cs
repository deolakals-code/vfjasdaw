// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 14662
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x31D68F0 Offset: 0x31D28F0 VA: 0x31D68F0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x31D6A48 Offset: 0x31D2A48 VA: 0x31D6A48
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x31D6C34 Offset: 0x31D2C34 VA: 0x31D6C34 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x31D70D8 Offset: 0x31D30D8 VA: 0x31D70D8 Slot: 6
	internal override object Eval() { }

	// RVA: 0x31D70EC Offset: 0x31D30EC VA: 0x31D70EC Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x31D9504 Offset: 0x31D5504 VA: 0x31D9504 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x31D9538 Offset: 0x31D5538 VA: 0x31D9538 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x31D95C8 Offset: 0x31D55C8 VA: 0x31D95C8 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x31D9644 Offset: 0x31D5644 VA: 0x31D9644 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x31D96C0 Offset: 0x31D56C0 VA: 0x31D96C0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x31D973C Offset: 0x31D573C VA: 0x31D973C Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x31D97C4 Offset: 0x31D57C4 VA: 0x31D97C4 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x31D7A68 Offset: 0x31D3A68 VA: 0x31D7A68
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x31D7D08 Offset: 0x31D3D08 VA: 0x31D7D08
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x31D9988 Offset: 0x31D5988 VA: 0x31D9988
	internal FunctionId get_Aggregate() { }

	// RVA: 0x31D9A24 Offset: 0x31D5A24 VA: 0x31D9A24
	internal bool get_IsAggregate() { }

	// RVA: 0x31D6F2C Offset: 0x31D2F2C VA: 0x31D6F2C
	internal void Check() { }

	// RVA: 0x31D9C58 Offset: 0x31D5C58 VA: 0x31D9C58
	private static void .cctor() { }
}

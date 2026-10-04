// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class AxisElement // TypeDefIndex: 13575
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x3414A1C Offset: 0x3410A1C VA: 0x3414A1C
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x3414A24 Offset: 0x3410A24 VA: 0x3414A24
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x3414A64 Offset: 0x3410A64 VA: 0x3414A64
	internal void SetDepth(int depth) { }

	// RVA: 0x3414A6C Offset: 0x3410A6C VA: 0x3414A6C
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x3414B98 Offset: 0x3410B98 VA: 0x3414B98
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }
}

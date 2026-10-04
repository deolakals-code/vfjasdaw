// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class AxisStack // TypeDefIndex: 13576
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x3414DBC Offset: 0x3410DBC VA: 0x3414DBC
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x3414DC4 Offset: 0x3410DC4 VA: 0x3414DC4
	internal int get_Length() { }

	// RVA: 0x3414DE8 Offset: 0x3410DE8 VA: 0x3414DE8
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x3414EB0 Offset: 0x3410EB0 VA: 0x3414EB0
	internal void Push(int depth) { }

	// RVA: 0x3414F50 Offset: 0x3410F50 VA: 0x3414F50
	internal void Pop() { }

	// RVA: 0x3414D40 Offset: 0x3410D40 VA: 0x3414D40
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x3414F90 Offset: 0x3410F90 VA: 0x3414F90
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x34150D8 Offset: 0x34110D8 VA: 0x34150D8
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x3415218 Offset: 0x3411218 VA: 0x3415218
	internal bool MoveToAttribute(string name, string URN, int depth) { }
}

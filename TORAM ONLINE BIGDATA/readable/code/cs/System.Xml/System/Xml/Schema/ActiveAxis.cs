// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class ActiveAxis // TypeDefIndex: 13577
{
	// Fields
	private int _currentDepth; // 0x10
	private bool _isActive; // 0x14
	private Asttree _axisTree; // 0x18
	private ArrayList _axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x341538C Offset: 0x341138C VA: 0x341538C
	public int get_CurrentDepth() { }

	// RVA: 0x3415394 Offset: 0x3411394 VA: 0x3415394
	internal void Reactivate() { }

	// RVA: 0x34153A8 Offset: 0x34113A8 VA: 0x34153A8
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x3415568 Offset: 0x3411568 VA: 0x3415568
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x34156A8 Offset: 0x34116A8 VA: 0x34156A8 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x34157B8 Offset: 0x34117B8 VA: 0x34157B8
	public bool MoveToAttribute(string localname, string URN) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 13590
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0x3419FC0 Offset: 0x3415FC0 VA: 0x3419FC0
	public int get_lastDepth() { }

	// RVA: 0x3419ED8 Offset: 0x3415ED8 VA: 0x3419ED8
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x341A068 Offset: 0x3416068 VA: 0x341A068 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x341A0B0 Offset: 0x34160B0 VA: 0x341A0B0
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x341A4CC Offset: 0x34164CC VA: 0x341A4CC
	public KeySequence PopKS() { }
}

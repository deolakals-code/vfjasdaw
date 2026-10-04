// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class DoubleLinkAxis : Axis // TypeDefIndex: 13578
{
	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x34158C4 Offset: 0x34118C4 VA: 0x34158C4
	internal Axis get_Next() { }

	// RVA: 0x34158CC Offset: 0x34118CC VA: 0x34158CC
	internal void set_Next(Axis value) { }

	// RVA: 0x34158D4 Offset: 0x34118D4 VA: 0x34158D4
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x3415964 Offset: 0x3411964 VA: 0x3415964
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }
}

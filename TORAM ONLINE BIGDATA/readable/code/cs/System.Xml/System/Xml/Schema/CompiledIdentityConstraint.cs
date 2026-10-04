// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint // TypeDefIndex: 13587
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x341979C Offset: 0x341579C VA: 0x341979C
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x34197A4 Offset: 0x34157A4 VA: 0x34197A4
	public Asttree get_Selector() { }

	// RVA: 0x34197AC Offset: 0x34157AC VA: 0x34197AC
	public Asttree[] get_Fields() { }

	// RVA: 0x34197B4 Offset: 0x34157B4 VA: 0x34197B4
	private void .ctor() { }

	// RVA: 0x341983C Offset: 0x341583C VA: 0x341983C
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x3419D2C Offset: 0x3415D2C VA: 0x3419D2C
	private static void .cctor() { }
}

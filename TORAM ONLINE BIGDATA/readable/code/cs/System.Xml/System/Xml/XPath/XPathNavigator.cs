// Assembly: System.Xml.dll
// Namespace: System.Xml.XPath
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 13482
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x33E3EC0 Offset: 0x33DFEC0 VA: 0x33E3EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x33E3ECC Offset: 0x33DFECC VA: 0x33E3ECC Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x33E4054 Offset: 0x33E0054 VA: 0x33E4054 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x33E4330 Offset: 0x33E0330 VA: 0x33E4330 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x33E453C Offset: 0x33E053C VA: 0x33E453C Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x33E4800 Offset: 0x33E0800 VA: 0x33E4800 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x33E4ACC Offset: 0x33E0ACC VA: 0x33E4ACC Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x33E4D98 Offset: 0x33E0D98 VA: 0x33E4D98 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x33E5064 Offset: 0x33E1064 VA: 0x33E5064 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x33E5330 Offset: 0x33E1330 VA: 0x33E5330 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33E561C Offset: 0x33E161C VA: 0x33E561C Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0x33E562C Offset: 0x33E162C VA: 0x33E562C Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x33E57D0 Offset: 0x33E17D0 VA: 0x33E57D0 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x33E59C0 Offset: 0x33E19C0 VA: 0x33E59C0 Slot: 22
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Prefix();

	// RVA: 0x33E5BDC Offset: 0x33E1BDC VA: 0x33E5BDC Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x33E5BE4 Offset: 0x33E1BE4 VA: 0x33E5BE4 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0x33E5C84 Offset: 0x33E1C84 VA: 0x33E5C84 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33E5CCC Offset: 0x33E1CCC VA: 0x33E5CCC
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x33E5CDC Offset: 0x33E1CDC VA: 0x33E5CDC
	protected void .ctor() { }

	// RVA: 0x33E5CE4 Offset: 0x33E1CE4 VA: 0x33E5CE4
	private static void .cctor() { }
}

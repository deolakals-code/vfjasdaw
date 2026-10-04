// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class TypedObject // TypeDefIndex: 13593
{
	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0x341A56C Offset: 0x341656C VA: 0x341A56C
	public int get_Dim() { }

	// RVA: 0x341A574 Offset: 0x3416574 VA: 0x341A574
	public bool get_IsList() { }

	// RVA: 0x341A57C Offset: 0x341657C VA: 0x341A57C
	public bool get_IsDecimal() { }

	// RVA: 0x341A598 Offset: 0x3416598 VA: 0x341A598
	public Decimal[] get_Dvalue() { }

	// RVA: 0x341A5B4 Offset: 0x34165B4 VA: 0x341A5B4
	public object get_Value() { }

	// RVA: 0x341A5BC Offset: 0x34165BC VA: 0x341A5BC
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x341A5C4 Offset: 0x34165C4 VA: 0x341A5C4
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x341A748 Offset: 0x3416748 VA: 0x341A748 Slot: 3
	public override string ToString() { }

	// RVA: 0x341A750 Offset: 0x3416750 VA: 0x341A750
	public void SetDecimal() { }

	// RVA: 0x341AAD8 Offset: 0x3416AD8 VA: 0x341AAD8
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x341ABEC Offset: 0x3416BEC VA: 0x341ABEC
	public bool Equals(TypedObject other) { }
}

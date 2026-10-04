// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 13748
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x332F4A0 Offset: 0x332B4A0 VA: 0x332F4A0
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x332F534 Offset: 0x332B534 VA: 0x332F534
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x332F5C4 Offset: 0x332B5C4 VA: 0x332F5C4
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x332F65C Offset: 0x332B65C VA: 0x332F65C
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x332F6EC Offset: 0x332B6EC VA: 0x332F6EC
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x332F77C Offset: 0x332B77C VA: 0x332F77C
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x332F830 Offset: 0x332B830 VA: 0x332F830
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x332FB28 Offset: 0x332BB28 VA: 0x332FB28
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x332FBDC Offset: 0x332BBDC VA: 0x332FBDC
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x332FE08 Offset: 0x332BE08 VA: 0x332FE08 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x332FE0C Offset: 0x332BE0C VA: 0x332FE0C Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x332FE14 Offset: 0x332BE14 VA: 0x332FE14 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x332FE3C Offset: 0x332BE3C VA: 0x332FE3C Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x3330004 Offset: 0x332C004 VA: 0x3330004 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x33300D4 Offset: 0x332C0D4 VA: 0x33300D4 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x33301B8 Offset: 0x332C1B8 VA: 0x33301B8 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x3330298 Offset: 0x332C298 VA: 0x3330298 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x3330370 Offset: 0x332C370 VA: 0x3330370 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x3330454 Offset: 0x332C454 VA: 0x3330454 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3330688 Offset: 0x332C688 VA: 0x3330688 Slot: 5
	public override string get_Value() { }

	// RVA: 0x3330780 Offset: 0x332C780 VA: 0x3330780 Slot: 3
	public override string ToString() { }

	// RVA: 0x332FA18 Offset: 0x332BA18 VA: 0x332FA18
	private string GetPrefixFromQName(string value) { }
}

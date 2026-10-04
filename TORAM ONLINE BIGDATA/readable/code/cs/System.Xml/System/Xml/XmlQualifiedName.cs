// Assembly: System.Xml.dll
// Namespace: System.Xml
[Serializable]
public class XmlQualifiedName // TypeDefIndex: 13471
{
	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x33E1E60 Offset: 0x33DDE60 VA: 0x33E1E60
	public void .ctor() { }

	// RVA: 0x33E1F5C Offset: 0x33DDF5C VA: 0x33E1F5C
	public void .ctor(string name) { }

	// RVA: 0x33E1EB4 Offset: 0x33DDEB4 VA: 0x33E1EB4
	public void .ctor(string name, string ns) { }

	// RVA: 0x33E1FBC Offset: 0x33DDFBC VA: 0x33E1FBC
	public string get_Namespace() { }

	// RVA: 0x33E1FC4 Offset: 0x33DDFC4 VA: 0x33E1FC4
	public string get_Name() { }

	// RVA: 0x33E1FCC Offset: 0x33DDFCC VA: 0x33E1FCC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x33E2220 Offset: 0x33DE220 VA: 0x33E2220
	public bool get_IsEmpty() { }

	// RVA: 0x33E225C Offset: 0x33DE25C VA: 0x33E225C Slot: 3
	public override string ToString() { }

	// RVA: 0x33E22CC Offset: 0x33DE2CC VA: 0x33E22CC Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x33E241C Offset: 0x33DE41C VA: 0x33E241C
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x33E23AC Offset: 0x33DE3AC VA: 0x33E23AC
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x33E2484 Offset: 0x33DE484 VA: 0x33E2484
	public static string ToString(string name, string ns) { }

	// RVA: 0x33E20A8 Offset: 0x33DE0A8 VA: 0x33E20A8
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x33E24F4 Offset: 0x33DE4F4 VA: 0x33E24F4
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x33E25B0 Offset: 0x33DE5B0 VA: 0x33E25B0
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0x33E25CC Offset: 0x33DE5CC VA: 0x33E25CC
	internal void Init(string name, string ns) { }

	// RVA: 0x33E2604 Offset: 0x33DE604 VA: 0x33E2604
	internal void SetNamespace(string ns) { }

	// RVA: 0x33E260C Offset: 0x33DE60C VA: 0x33E260C
	internal void Verify() { }

	// RVA: 0x33E269C Offset: 0x33DE69C VA: 0x33E269C
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x33E2708 Offset: 0x33DE708 VA: 0x33E2708
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x33E28B8 Offset: 0x33DE8B8 VA: 0x33E28B8
	internal XmlQualifiedName Clone() { }

	// RVA: 0x33E2938 Offset: 0x33DE938 VA: 0x33E2938
	private static void .cctor() { }
}

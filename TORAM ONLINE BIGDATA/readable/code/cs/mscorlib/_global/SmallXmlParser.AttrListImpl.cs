// Assembly: mscorlib.dll
// Namespace: 
private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 9450
{
	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x2E6843C Offset: 0x2E6443C VA: 0x2E6843C Slot: 4
	public int get_Length() { }

	// RVA: 0x2E68484 Offset: 0x2E64484 VA: 0x2E68484 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x2E684DC Offset: 0x2E644DC VA: 0x2E684DC Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x2E68534 Offset: 0x2E64534 VA: 0x2E68534 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x2E685F4 Offset: 0x2E645F4 VA: 0x2E685F4 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x2E68644 Offset: 0x2E64644 VA: 0x2E68644 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x2E67E4C Offset: 0x2E63E4C VA: 0x2E67E4C
	internal void Clear() { }

	// RVA: 0x2E6831C Offset: 0x2E6431C VA: 0x2E6831C
	internal void Add(string name, string value) { }

	// RVA: 0x2E66A60 Offset: 0x2E62A60 VA: 0x2E66A60
	public void .ctor() { }
}

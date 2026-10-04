// Assembly: mscorlib.dll
// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class SecurityElement // TypeDefIndex: 10075
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x2EA282C Offset: 0x2E9E82C VA: 0x2EA282C
	public void .ctor(string tag) { }

	// RVA: 0x2EA4578 Offset: 0x2EA0578 VA: 0x2EA4578
	public void .ctor(string tag, string text) { }

	// RVA: 0x2EA4840 Offset: 0x2EA0840 VA: 0x2EA4840
	public ArrayList get_Children() { }

	// RVA: 0x2EA4848 Offset: 0x2EA0848 VA: 0x2EA4848
	public string get_Tag() { }

	// RVA: 0x2EA4744 Offset: 0x2EA0744 VA: 0x2EA4744
	public void set_Text(string value) { }

	// RVA: 0x2EA2834 Offset: 0x2E9E834 VA: 0x2EA2834
	public void AddAttribute(string name, string value) { }

	// RVA: 0x2EA29D8 Offset: 0x2E9E9D8 VA: 0x2EA29D8
	public void AddChild(SecurityElement child) { }

	// RVA: 0x2EA4F10 Offset: 0x2EA0F10 VA: 0x2EA4F10
	public static string Escape(string str) { }

	// RVA: 0x2EA48CC Offset: 0x2EA08CC VA: 0x2EA48CC
	private static string Unescape(string str) { }

	// RVA: 0x2EA5118 Offset: 0x2EA1118 VA: 0x2EA5118
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x2EA5194 Offset: 0x2EA1194 VA: 0x2EA5194
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x2EA46C8 Offset: 0x2EA06C8 VA: 0x2EA46C8
	public static bool IsValidTag(string tag) { }

	// RVA: 0x2EA4850 Offset: 0x2EA0850 VA: 0x2EA4850
	public static bool IsValidText(string text) { }

	// RVA: 0x2EA5210 Offset: 0x2EA1210 VA: 0x2EA5210
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x2EA5334 Offset: 0x2EA1334 VA: 0x2EA5334 Slot: 3
	public override string ToString() { }

	// RVA: 0x2EA53B8 Offset: 0x2EA13B8 VA: 0x2EA53B8
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x2EA4A9C Offset: 0x2EA0A9C VA: 0x2EA4A9C
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x2EA5A0C Offset: 0x2EA1A0C VA: 0x2EA5A0C
	internal void set_m_strText(string value) { }

	// RVA: 0x2EA5A14 Offset: 0x2EA1A14 VA: 0x2EA5A14
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x2EA5C54 Offset: 0x2EA1C54 VA: 0x2EA5C54
	private static void .cctor() { }
}

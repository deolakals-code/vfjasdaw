// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScriptTextManagerData : TextManagerDataBase // TypeDefIndex: 5271
{
	// Fields
	private readonly Dictionary<int, Dictionary<int, string>> Texts; // 0x28
	private readonly Dictionary<int, string> Names; // 0x30

	// Methods

	// RVA: 0x261E194 Offset: 0x261A194 VA: 0x261E194
	public void .ctor() { }

	// RVA: 0x261DF40 Offset: 0x2619F40 VA: 0x261DF40
	public void .ctor(Dictionary<int, string> name, Dictionary<int, Dictionary<int, string>> text) { }

	// RVA: 0x261E270 Offset: 0x261A270 VA: 0x261E270
	public string GetName(int id) { }

	// RVA: 0x261E318 Offset: 0x261A318 VA: 0x261E318
	public string GetText(int scriptId, int id) { }

	// RVA: 0x261E430 Offset: 0x261A430 VA: 0x261E430
	public string GetNameFormat(int id, object[] args) { }

	// RVA: 0x261E4A0 Offset: 0x261A4A0 VA: 0x261E4A0
	public string GetTextFormat(int scriptId, int id, object[] args) { }
}

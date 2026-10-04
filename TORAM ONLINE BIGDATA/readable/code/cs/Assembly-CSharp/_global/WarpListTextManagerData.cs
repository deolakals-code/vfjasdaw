// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WarpListTextManagerData : TextManagerDataBase // TypeDefIndex: 5285
{
	// Fields
	private readonly Dictionary<int, string> names; // 0x28
	private readonly Dictionary<int, string> tags; // 0x30

	// Methods

	// RVA: 0x2622FE8 Offset: 0x261EFE8 VA: 0x2622FE8
	public void .ctor(Dictionary<int, string> names, Dictionary<int, string> tags) { }

	// RVA: 0x26231A4 Offset: 0x261F1A4 VA: 0x26231A4
	public string GetName(int loId) { }

	// RVA: 0x2623238 Offset: 0x261F238 VA: 0x2623238
	public string GetTag(int loId) { }

	// RVA: 0x26232CC Offset: 0x261F2CC VA: 0x26232CC
	public Dictionary<int, string> GetNames() { }

	// RVA: 0x26232D4 Offset: 0x261F2D4 VA: 0x26232D4
	public Dictionary<int, string> GetTags() { }
}

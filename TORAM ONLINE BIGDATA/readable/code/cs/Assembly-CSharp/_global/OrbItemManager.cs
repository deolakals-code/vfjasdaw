// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemManager // TypeDefIndex: 2150
{
	// Fields
	public static int[] ShortcutOrbItem; // 0x0
	private Dictionary<int, OrbItemData> orbItemList; // 0x10
	[CompilerGenerated]
	private List<OrbItemData> <CurrentOrbItemList>k__BackingField; // 0x18

	// Properties
	public List<OrbItemData> OrbItemList { get; }
	public List<OrbItemData> CurrentOrbItemList { get; set; }
	public int HaveOrbItemNum { get; }

	// Methods

	// RVA: 0x214F7C0 Offset: 0x214B7C0 VA: 0x214F7C0
	public List<OrbItemData> get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x214F82C Offset: 0x214B82C VA: 0x214F82C
	public List<OrbItemData> get_CurrentOrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x214F834 Offset: 0x214B834 VA: 0x214F834
	private void set_CurrentOrbItemList(List<OrbItemData> value) { }

	// RVA: 0x214F83C Offset: 0x214B83C VA: 0x214F83C
	public int get_HaveOrbItemNum() { }

	// RVA: 0x214F884 Offset: 0x214B884 VA: 0x214F884
	public void Initialize(OrbItemData[] orbItem) { }

	// RVA: 0x214F9D0 Offset: 0x214B9D0 VA: 0x214F9D0
	public bool ContainsItem(int itemId) { }

	// RVA: 0x214FA5C Offset: 0x214BA5C VA: 0x214FA5C
	public int GetOrbItemNum(int itemId) { }

	// RVA: 0x214FAE0 Offset: 0x214BAE0 VA: 0x214FAE0
	public void UpdateOrbItem(OrbItemData[] itemList) { }

	// RVA: 0x214FC08 Offset: 0x214BC08 VA: 0x214FC08
	public void RemoveOrbItem(int itemId) { }

	// RVA: 0x214F954 Offset: 0x214B954 VA: 0x214F954
	private void UpdateCurrentItemList() { }

	// RVA: 0x214FC68 Offset: 0x214BC68 VA: 0x214FC68
	public void .ctor() { }

	// RVA: 0x214FCF0 Offset: 0x214BCF0 VA: 0x214FCF0
	private static void .cctor() { }
}

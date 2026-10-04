// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseItemTextManager : TextManagerBase // TypeDefIndex: 5231
{
	// Fields
	private Dictionary<int, TextManagerDataSingle> TextData; // 0x18

	// Methods

	// RVA: 0x2611744 Offset: 0x260D744 VA: 0x2611744 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C4E8C Offset: 0x26C0E8C VA: 0x26C4E8C
	|-HouseItemTextManager.Get<object>
	*/

	// RVA: 0x2611BF0 Offset: 0x260DBF0 VA: 0x2611BF0
	public string GetItemName(HouseRecipeManager.RecipeData recipeData) { }

	// RVA: 0x2611BF8 Offset: 0x260DBF8 VA: 0x2611BF8
	public string GetItemName(int itemUid) { }

	// RVA: 0x2611C98 Offset: 0x260DC98 VA: 0x2611C98 Slot: 7
	public override void Clear() { }

	// RVA: 0x2611CF0 Offset: 0x260DCF0 VA: 0x2611CF0
	public void .ctor() { }
}

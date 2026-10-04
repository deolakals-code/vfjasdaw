// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightEquipListElement : MonoBehaviour // TypeDefIndex: 5839
{
	// Fields
	[SerializeField]
	private UISprite buttonIcon; // 0x20
	[SerializeField]
	private UISprite itemIcon; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private UILabel costLabel; // 0x38
	private byte id; // 0x40
	private SystemTextManager systemTextManager; // 0x48

	// Methods

	// RVA: 0x1805A48 Offset: 0x1801A48 VA: 0x1805A48
	public void Initialize(byte id, bool isEquip, bool isOverCost) { }

	// RVA: 0x1805D88 Offset: 0x1801D88 VA: 0x1805D88
	public void UpdateElement(bool isEquip, bool isOverCost) { }

	// RVA: 0x1805008 Offset: 0x1801008 VA: 0x1805008
	public static string GetIconSpriteName(BlackKnightCristaType type) { }

	// RVA: 0x1805F18 Offset: 0x1801F18 VA: 0x1805F18
	public void .ctor() { }
}

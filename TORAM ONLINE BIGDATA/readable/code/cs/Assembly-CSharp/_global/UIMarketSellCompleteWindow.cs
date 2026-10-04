// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketSellCompleteWindow : MonoBehaviour // TypeDefIndex: 8452
{
	// Fields
	[SerializeField]
	private ItemIcon itemIcon; // 0x20
	[SerializeField]
	private LocalizeText registerPriceLabel; // 0x28
	private Action callback; // 0x30
	private ItemTextManager itemTextManager; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private SkillTextManager skillTextManager; // 0x48

	// Methods

	// RVA: 0x1D69894 Offset: 0x1D65894 VA: 0x1D69894
	public void Initialize(ItemData itemData, int count, int allPrice, int fee, Action okCallback) { }

	// RVA: 0x1D69C78 Offset: 0x1D65C78 VA: 0x1D69C78
	public void Initialize(StarGemData data, int allPrice, int fee, Action okCallback) { }

	// RVA: 0x1D6A0F4 Offset: 0x1D660F4 VA: 0x1D6A0F4
	private void onClick() { }

	// RVA: 0x1D6A110 Offset: 0x1D66110 VA: 0x1D6A110
	public void .ctor() { }
}

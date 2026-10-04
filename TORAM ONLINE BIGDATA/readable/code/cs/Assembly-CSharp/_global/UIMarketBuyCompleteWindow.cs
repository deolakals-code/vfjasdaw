// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuyCompleteWindow : MonoBehaviour // TypeDefIndex: 8372
{
	// Fields
	[SerializeField]
	private LocalizeText messageLocalize; // 0x20
	[SerializeField]
	private LocalizeText possessionLocalize; // 0x28
	[SerializeField]
	private ItemIcon itemIcon; // 0x30
	private Action closeCallback; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private ItemTextManager itemTextManager; // 0x48
	private SkillTextManager skillTextManager; // 0x50

	// Methods

	// RVA: 0x1D366D0 Offset: 0x1D326D0 VA: 0x1D366D0
	private void Awake() { }

	// RVA: 0x1D36918 Offset: 0x1D32918 VA: 0x1D36918
	public void Initialize(UIMarketProductData product, int possessionSpina, Action callback) { }

	// RVA: 0x1D36E68 Offset: 0x1D32E68 VA: 0x1D36E68
	private void onClose() { }

	// RVA: 0x1D36EB0 Offset: 0x1D32EB0 VA: 0x1D36EB0
	public void .ctor() { }
}

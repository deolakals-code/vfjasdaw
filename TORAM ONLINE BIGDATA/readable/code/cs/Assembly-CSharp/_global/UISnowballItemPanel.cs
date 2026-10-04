// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballItemPanel : MonoBehaviour // TypeDefIndex: 6422
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x20
	[SerializeField]
	private UISprite itemIcon; // 0x28
	[SerializeField]
	private UILabel itemLabel; // 0x30
	[SerializeField]
	private UILabel itemExLabel; // 0x38
	[SerializeField]
	private UISprite bar; // 0x40
	private const int maxBarSize = 200;
	public const int MaxBarCount = 30;
	private float barSizeCount; // 0x48
	private SystemTextManager systemTextManager; // 0x50

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x192C49C Offset: 0x192849C VA: 0x192C49C
	public bool get_IsActive() { }

	// RVA: 0x192C4B8 Offset: 0x19284B8 VA: 0x192C4B8
	private void Start() { }

	// RVA: 0x192C5A0 Offset: 0x19285A0 VA: 0x192C5A0
	private void Update() { }

	// RVA: 0x192C8BC Offset: 0x19288BC VA: 0x192C8BC
	public void SetActive(bool isActive) { }

	// RVA: 0x192C8DC Offset: 0x19288DC VA: 0x192C8DC
	public void SetItemData(SnowballFightItemType type, int barSizeCount) { }

	// RVA: 0x192CBC4 Offset: 0x1928BC4 VA: 0x192CBC4
	public void UpdateItemData(SnowballFightItemType type, bool isValid) { }

	// RVA: 0x192CB2C Offset: 0x1928B2C VA: 0x192CB2C
	private string GetSpriteName(SnowballFightItemType type) { }

	// RVA: 0x192C61C Offset: 0x192861C VA: 0x192C61C
	private void SetBarSize(float percent) { }

	// RVA: 0x192CD54 Offset: 0x1928D54 VA: 0x192CD54
	public void .ctor() { }
}

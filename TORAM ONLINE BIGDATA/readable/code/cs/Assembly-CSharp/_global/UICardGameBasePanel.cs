// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UICardGameBasePanel // TypeDefIndex: 5672
{
	// Fields
	protected readonly string scrollWindowPrefabPath; // 0x10
	protected CardGameManager manager; // 0x18
	protected GameObject enterPanel; // 0x20
	protected UILabel[] nameLabel; // 0x28
	protected UILabel[] readyLabel; // 0x30
	protected GameObject partyPanel; // 0x38
	protected SystemTextManager systemTextManager; // 0x40
	protected UIImageButton startButton; // 0x48
	protected UILabel startButtonLabel; // 0x50
	private GameObject mainSetting; // 0x58
	protected UILabel[] mainSettingLabel; // 0x60
	protected UICardGameSettingElement settingBase; // 0x68
	protected Dictionary<UICardGameBasePanel.SettingType, UICardGameSettingElement> settingElement; // 0x70
	protected UIScrollWindow scrollWindow; // 0x78
	protected CardGameSettingData settingData; // 0x80

	// Properties
	public virtual bool IsReady { get; }
	public bool IsOpenSettingPanel { get; }

	// Methods

	// RVA: 0x17C352C Offset: 0x17BF52C VA: 0x17C352C Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x17C3534 Offset: 0x17BF534 VA: 0x17C3534
	public bool get_IsOpenSettingPanel() { }

	// RVA: 0x17C3594 Offset: 0x17BF594 VA: 0x17C3594
	public void .ctor(GameObject enterPanel, GameObject partyPanel, GameObject[] partyMemberObject, UIImageButton startButton, UICardGameSettingElement settingBase, GameObject mainSetting, UILabel[] mainSettingLabels) { }

	// RVA: 0x17C3A18 Offset: 0x17BFA18 VA: 0x17C3A18 Slot: 5
	public virtual byte Initialize() { }

	// RVA: 0x17C3C0C Offset: 0x17BFC0C VA: 0x17C3C0C Slot: 6
	public virtual void Disable() { }

	// RVA: 0x17C3A2C Offset: 0x17BFA2C VA: 0x17C3A2C
	public void InitSettingData() { }

	// RVA: 0x17C3DF4 Offset: 0x17BFDF4 VA: 0x17C3DF4
	public int GetSettingValue(UICardGameBasePanel.SettingType type) { }

	// RVA: 0x17C3E78 Offset: 0x17BFE78 VA: 0x17C3E78
	public void OpenSettingPanel() { }

	// RVA: 0x17C3C30 Offset: 0x17BFC30 VA: 0x17C3C30
	public void CloseSettingPanel() { }

	// RVA: 0x17C4444 Offset: 0x17C0444 VA: 0x17C4444
	protected void LoadScrollWindows() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool Update();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void BattleReady();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Cancel();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetActive(bool active);

	// RVA: 0x17C4564 Offset: 0x17C0564 VA: 0x17C4564
	private void CreateSettingElement(UICardGameBasePanel.SettingType setType, int value, int min, int max, int change, UICardGameSettingElement.SettingUnitType type, bool main) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract UICardGameSettingElement CreateSettingElement(string name, int value, int min, int max, int change, UICardGameSettingElement.SettingUnitType type, bool main);

	// RVA: 0x17C4688 Offset: 0x17C0688 VA: 0x17C4688
	protected void UpdateSettingValueLabel(CardGameSettingData setting) { }

	// RVA: 0x17C4828 Offset: 0x17C0828 VA: 0x17C4828
	protected void UpdateSettingData() { }

	// RVA: 0x17C49EC Offset: 0x17C09EC VA: 0x17C49EC Slot: 12
	public virtual void SynchronousGameSetting(CardGameSettingData setting) { }
}

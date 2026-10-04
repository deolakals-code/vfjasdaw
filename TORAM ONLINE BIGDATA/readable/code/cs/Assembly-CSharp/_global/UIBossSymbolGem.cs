// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossSymbolGem : MonoBehaviour // TypeDefIndex: 6381
{
	// Fields
	[SerializeField]
	private UILabel itemNameLabel; // 0x20
	[SerializeField]
	private UILabel itemNumLabel; // 0x28
	[SerializeField]
	private UIIcon itemIcon; // 0x30
	private int itemId; // 0x38
	private UIBossSymbolOldManager managerOld; // 0x40
	private UIBossSymbolManager manager; // 0x48
	private UIBossRaidSymbolManager managerRaid; // 0x50
	private UIHighRaidEnterManager managerHighRaid; // 0x58
	private UINaCollaborationEnterManager managerNaCollab; // 0x60

	// Methods

	// RVA: 0x1919410 Offset: 0x1915410 VA: 0x1919410
	public void Initialize(int itemId, string itemName, string itemNum, bool on, UIBossSymbolManager manager) { }

	// RVA: 0x1919548 Offset: 0x1915548 VA: 0x1919548
	public void Initialize(int itemId, string itemName, string itemNum, bool on, UIBossSymbolOldManager manager) { }

	// RVA: 0x19195CC Offset: 0x19155CC VA: 0x19195CC
	public void Initialize(int itemId, string itemName, string itemNum, bool on, UIBossRaidSymbolManager manager) { }

	// RVA: 0x1919650 Offset: 0x1915650 VA: 0x1919650
	public void Initialize(int itemId, string itemName, string itemNum, bool on, UIHighRaidEnterManager manager) { }

	// RVA: 0x19196D4 Offset: 0x19156D4 VA: 0x19196D4
	public void Initialize(int itemId, string itemName, string itemNum, bool on, UINaCollaborationEnterManager manager) { }

	// RVA: 0x1919494 Offset: 0x1915494 VA: 0x1919494
	public void SetItemUse(bool on) { }

	// RVA: 0x1919758 Offset: 0x1915758 VA: 0x1919758
	public void OnClick() { }

	// RVA: 0x1919ED4 Offset: 0x1915ED4 VA: 0x1919ED4
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpMaterialSearchWindow : PopBaseWindow // TypeDefIndex: 8792
{
	// Fields
	private MaterialSearchData[] searchData; // 0x20
	private int messageAction; // 0x28
	private ItemTextManager itemTextManager; // 0x30
	private FieldTextManager fieldTextManager; // 0x38
	private EnemyTextManager enemyTextManager; // 0x40
	private string titleText; // 0x48
	private UIScrollWindow window; // 0x50
	private const float defaultScrollPanelPosX = 2000;
	private const float defaultScrollPanelPosY = 0;
	private float scrollPanelPosX; // 0x58
	private float scrollPanelPosY; // 0x5C

	// Methods

	// RVA: 0x1E0D7D0 Offset: 0x1E097D0 VA: 0x1E0D7D0
	public void .ctor(MaterialSearchData[] data, string titleKey) { }

	// RVA: 0x1E0DACC Offset: 0x1E09ACC VA: 0x1E0DACC
	public void .ctor(MaterialSearchData[] data, string titleKey, float scrollPanelPosX, float scrollPanelPosY) { }

	// RVA: 0x1E0D81C Offset: 0x1E0981C VA: 0x1E0D81C
	private void Initialize(MaterialSearchData[] data, string titleKey, float scrollPanelPosX, float scrollPanelPosY) { }

	// RVA: 0x1E0DB20 Offset: 0x1E09B20 VA: 0x1E0DB20 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0E97C Offset: 0x1E0A97C VA: 0x1E0E97C
	private string GetDropFlagMessage(MaterialSearchManager.MaterialSearchFlag flag) { }

	// RVA: 0x1E0E6B8 Offset: 0x1E0A6B8 VA: 0x1E0E6B8
	private string GetItemName(int id) { }

	// RVA: 0x1E0E77C Offset: 0x1E0A77C VA: 0x1E0E77C
	private string GetFieldName(int id) { }

	// RVA: 0x1E0E898 Offset: 0x1E0A898 VA: 0x1E0E898
	private string GetEnemyName(int id) { }

	// RVA: 0x1E0EB40 Offset: 0x1E0AB40 VA: 0x1E0EB40 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0EB54 Offset: 0x1E0AB54 VA: 0x1E0EB54 Slot: 7
	public override int MessageCheck() { }
}

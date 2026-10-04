// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMusicSettingPanel : MonoBehaviour // TypeDefIndex: 7280
{
	// Fields
	[SerializeField]
	private UILabel musicLabel; // 0x20
	[SerializeField]
	private UISprite musicIcon; // 0x28
	[SerializeField]
	private UISprite musicSysIcon; // 0x30
	[SerializeField]
	private UIImageButton playButton; // 0x38
	[SerializeField]
	private UISprite playButtonIcon; // 0x40
	[SerializeField]
	private UISprite playButtonSysIcon; // 0x48
	[SerializeField]
	private UIImageButton setButton; // 0x50
	[SerializeField]
	private UILabel setButtonLabel; // 0x58
	[SerializeField]
	private GameObject downloadTextObj; // 0x60
	[SerializeField]
	private GameObject setTextObj; // 0x68
	private HouseItemTextManager houseTextDataManager; // 0x70
	private SystemTextManager systemTextDataManager; // 0x78
	private float updateTimer; // 0x80
	private bool isDownload; // 0x84
	private UIHouseMusicManager manager; // 0x88
	private HouseRecipeManager.RecipeData recipeData; // 0x90

	// Properties
	private HouseItemTextManager houseTextManager { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1AFDE60 Offset: 0x1AF9E60 VA: 0x1AFDE60
	private HouseItemTextManager get_houseTextManager() { }

	// RVA: 0x1AFDF4C Offset: 0x1AF9F4C VA: 0x1AFDF4C
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1AF8E98 Offset: 0x1AF4E98 VA: 0x1AF8E98
	public void SetMusicRecipe(UIHouseMusicManager manager, HouseRecipeManager.RecipeData recipeData) { }

	// RVA: 0x1AFE038 Offset: 0x1AFA038 VA: 0x1AFE038
	private void Update() { }

	// RVA: 0x1AFE0A4 Offset: 0x1AFA0A4 VA: 0x1AFE0A4
	public void OnMusicButtonClick() { }

	// RVA: 0x1AFE1F0 Offset: 0x1AFA1F0 VA: 0x1AFE1F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AFE1F8 Offset: 0x1AFA1F8 VA: 0x1AFE1F8
	private void <OnMusicButtonClick>b__22_0(int x) { }
}

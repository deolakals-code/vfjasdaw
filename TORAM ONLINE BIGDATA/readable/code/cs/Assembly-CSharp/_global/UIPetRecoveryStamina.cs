// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetRecoveryStamina : MonoBehaviour // TypeDefIndex: 7825
{
	// Fields
	[SerializeField]
	private UISprite[] windowStaminaIcon; // 0x20
	[SerializeField]
	private UISprite windowArrowSprite; // 0x28
	[SerializeField]
	private UILabel potionNumLabel; // 0x30
	[SerializeField]
	private GameObject redMesObj; // 0x38
	[SerializeField]
	private UIImageButton useButton; // 0x40
	private UIPetManager petManager; // 0x48
	private PetDataManager.PetViewData viewData; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private int orbItemNum; // 0x60
	private float loadingTimer; // 0x64
	private GameObject loadingObject; // 0x68
	private Action closeCallBack; // 0x70

	// Properties
	public Action SetCloseCallBack { set; }

	// Methods

	// RVA: 0x1C2E52C Offset: 0x1C2A52C VA: 0x1C2E52C
	private void UseButtonEnableToTrue() { }

	// RVA: 0x1C2E54C Offset: 0x1C2A54C VA: 0x1C2E54C
	public void set_SetCloseCallBack(Action value) { }

	// RVA: 0x1C2E554 Offset: 0x1C2A554 VA: 0x1C2E554
	public void Initiaize(UIPetManager manager, PetDataManager.PetViewData data) { }

	// RVA: 0x1C2E8B4 Offset: 0x1C2A8B4 VA: 0x1C2E8B4
	public void ClosePanel() { }

	// RVA: 0x1C2E9A4 Offset: 0x1C2A9A4 VA: 0x1C2E9A4
	private void onUse() { }

	[IteratorStateMachine(typeof(UIPetRecoveryStamina.<UsePotion>d__18))]
	// RVA: 0x1C2EAB4 Offset: 0x1C2AAB4 VA: 0x1C2EAB4
	private IEnumerator UsePotion() { }

	[IteratorStateMachine(typeof(UIPetRecoveryStamina.<CheckOrbItemNum>d__19))]
	// RVA: 0x1C2E848 Offset: 0x1C2A848 VA: 0x1C2E848
	private IEnumerator CheckOrbItemNum() { }

	[IteratorStateMachine(typeof(UIPetRecoveryStamina.<ConnectWait>d__20))]
	// RVA: 0x1C2EB70 Offset: 0x1C2AB70 VA: 0x1C2EB70
	private IEnumerator ConnectWait(OrbManager.ConnectFlag connectFlag) { }

	[IteratorStateMachine(typeof(UIPetRecoveryStamina.<PanelActive>d__21))]
	// RVA: 0x1C2E938 Offset: 0x1C2A938 VA: 0x1C2E938
	private IEnumerator PanelActive() { }

	// RVA: 0x1C2EC3C Offset: 0x1C2AC3C VA: 0x1C2EC3C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C2ECA0 Offset: 0x1C2ACA0 VA: 0x1C2ECA0
	private void <UsePotion>b__18_0(Game game, HousePetUsePotionResponse response) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingSubmergedItemMenuController : MonoBehaviour // TypeDefIndex: 7065
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x20
	[SerializeField]
	private GameObject duplicationContent; // 0x28
	private GameObject beforeUIObject; // 0x30
	private Action initializeMethod; // 0x38
	private FishingRandomTargetData[] randomTargetDatas; // 0x40
	private const float initialPositionY = -60;
	private const float positionYIncrement = -80;

	// Methods

	// RVA: 0x1A7F1A0 Offset: 0x1A7B1A0 VA: 0x1A7F1A0
	public void Initialize(Action callBack) { }

	// RVA: 0x1A7DD68 Offset: 0x1A79D68 VA: 0x1A7DD68
	public void ChangeDisplay(GameObject beforeObject) { }

	// RVA: 0x1A7C8C0 Offset: 0x1A788C0 VA: 0x1A7C8C0
	public string GetSubmergedItemLabel() { }

	// RVA: 0x1A883AC Offset: 0x1A843AC VA: 0x1A883AC
	private void SetRandomTargetDatas(FishingRandomTargetData[] randomTargetDatas) { }

	// RVA: 0x1A88324 Offset: 0x1A84324 VA: 0x1A88324
	private void CreateButtons(UIFishingGereSubmergedItemButtonController buttonController, FishingRandomTargetData targetData) { }

	// RVA: 0x1A883B4 Offset: 0x1A843B4 VA: 0x1A883B4
	public void .ctor() { }
}

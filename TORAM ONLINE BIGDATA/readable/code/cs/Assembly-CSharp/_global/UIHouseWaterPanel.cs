// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseWaterPanel : MonoBehaviour // TypeDefIndex: 7330
{
	// Fields
	[SerializeField]
	private GameObject waterIcon; // 0x20
	private UISprite[] waterStateIcon; // 0x28
	private GameObject[] waterStateIconBack; // 0x30
	[SerializeField]
	private UILabel waterLabel; // 0x38
	[SerializeField]
	private UIImageButton waterButton; // 0x40
	[SerializeField]
	private UILabel waterGrowthMaxLabel; // 0x48
	private UIHouseCultivationButton panelButton; // 0x50
	private bool isGrowthMax; // 0x58
	private byte waterNum; // 0x59
	private string localizeWord; // 0x60
	private float waiterTimer; // 0x68

	// Methods

	// RVA: 0x1B126F4 Offset: 0x1B0E6F4 VA: 0x1B126F4
	public void SetWaterLabel(UIHouseCultivationButton button, bool isWater, bool isGrowthMax, byte waterNum, string localize, int timer) { }

	// RVA: 0x1B129DC Offset: 0x1B0E9DC VA: 0x1B129DC
	private UISprite CreateWaterIcon(string spriteName, Vector3 pos, int addDepth, Transform parent) { }

	// RVA: 0x1B12C94 Offset: 0x1B0EC94 VA: 0x1B12C94
	public void UpdateWaterMax(int timer) { }

	[IteratorStateMachine(typeof(UIHouseWaterPanel.<UpdatingWaterMax>d__14))]
	// RVA: 0x1B12D18 Offset: 0x1B0ED18 VA: 0x1B12D18
	private IEnumerator UpdatingWaterMax(int num) { }

	// RVA: 0x1B12B58 Offset: 0x1B0EB58 VA: 0x1B12B58
	private void UpdateWaterTimer() { }

	// RVA: 0x1B12DBC Offset: 0x1B0EDBC VA: 0x1B12DBC
	private void Update() { }

	// RVA: 0x1B12E2C Offset: 0x1B0EE2C VA: 0x1B12E2C
	public void OnClickTargetWaterButton() { }

	// RVA: 0x1B12EDC Offset: 0x1B0EEDC VA: 0x1B12EDC
	public void .ctor() { }
}

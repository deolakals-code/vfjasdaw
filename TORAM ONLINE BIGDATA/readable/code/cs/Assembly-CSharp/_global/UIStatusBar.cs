// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStatusBar : MonoBehaviour // TypeDefIndex: 8056
{
	// Fields
	[SerializeField]
	private UISlider statusSlider; // 0x20
	private BoxCollider statusSliderCol; // 0x28
	[SerializeField]
	private UISprite sliderSprite; // 0x30
	[SerializeField]
	private UILabel sliderLabel; // 0x38
	[SerializeField]
	private GameObject leftButton; // 0x40
	private TweenScale leftButtonTweenScale; // 0x48
	[SerializeField]
	private GameObject rightButton; // 0x50
	private TweenScale rightButtonTweenScale; // 0x58
	private BoxCollider activeCol; // 0x60
	private int buildPoint; // 0x68
	private int maxPoint; // 0x6C
	private UIBuildPanel buildManager; // 0x70
	private int addPoint; // 0x78
	private int selectType; // 0x7C

	// Methods

	// RVA: 0x1CA6A48 Offset: 0x1CA2A48 VA: 0x1CA6A48
	public void Initialize(UIBuildPanel manager, int selectType, bool isLimitBreak) { }

	// RVA: 0x1CA6BD0 Offset: 0x1CA2BD0 VA: 0x1CA6BD0
	public void EnableBuildPoint(bool flag) { }

	// RVA: 0x1CA84C8 Offset: 0x1CA44C8 VA: 0x1CA84C8
	public void SetParameter(int buildPoint) { }

	// RVA: 0x1CA8B60 Offset: 0x1CA4B60 VA: 0x1CA8B60
	public void SetBuildParameter(int addPoint) { }

	// RVA: 0x1CA9364 Offset: 0x1CA5364 VA: 0x1CA9364
	public void SetMaxPoint(bool isLimitBreak) { }

	// RVA: 0x1CA8B18 Offset: 0x1CA4B18 VA: 0x1CA8B18
	public void SliderEnable(bool enable) { }

	// RVA: 0x1CB3730 Offset: 0x1CAF730 VA: 0x1CB3730
	private void OnAddStatus() { }

	// RVA: 0x1CB375C Offset: 0x1CAF75C VA: 0x1CB375C
	private void OnSubStatus() { }

	// RVA: 0x1CB3788 Offset: 0x1CAF788 VA: 0x1CB3788
	private void OnSliderChange(float param) { }

	// RVA: 0x1CB37F0 Offset: 0x1CAF7F0 VA: 0x1CB37F0
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1CB3818 Offset: 0x1CAF818 VA: 0x1CB3818
	private void OnPressThumb(GameObject go, bool pressed) { }

	// RVA: 0x1CB3840 Offset: 0x1CAF840 VA: 0x1CB3840
	private void OnDragThumb(GameObject go, Vector2 delta) { }

	// RVA: 0x1CB3868 Offset: 0x1CAF868 VA: 0x1CB3868
	private void OnPress(bool flag) { }

	// RVA: 0x1CB38A4 Offset: 0x1CAF8A4 VA: 0x1CB38A4
	public void .ctor() { }
}

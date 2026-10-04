// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetStatusBar : MonoBehaviour // TypeDefIndex: 7842
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
	private const int maxPoint = 255;
	private UIPetStatusConfirm statusConfirm; // 0x70
	private int addPoint; // 0x78
	private int selectType; // 0x7C

	// Methods

	// RVA: 0x1C39C00 Offset: 0x1C35C00 VA: 0x1C39C00
	public void Initialize(UIPetStatusConfirm confirm, int selectType) { }

	// RVA: 0x1C39DCC Offset: 0x1C35DCC VA: 0x1C39DCC
	public void EnableBuildPoint(bool flag) { }

	// RVA: 0x1C39F80 Offset: 0x1C35F80 VA: 0x1C39F80
	public void SetParameter(int buildPoint) { }

	// RVA: 0x1C3A07C Offset: 0x1C3607C VA: 0x1C3A07C
	public void SetBuildParameter(int addPoint) { }

	// RVA: 0x1C39D84 Offset: 0x1C35D84 VA: 0x1C39D84
	public void SliderEnable(bool enable) { }

	// RVA: 0x1C3A44C Offset: 0x1C3644C VA: 0x1C3A44C
	private void OnAddStatus() { }

	// RVA: 0x1C3A81C Offset: 0x1C3681C VA: 0x1C3A81C
	private void OnSubStatus() { }

	// RVA: 0x1C3A848 Offset: 0x1C36848 VA: 0x1C3A848
	private void OnSliderChange(float param) { }

	// RVA: 0x1C3A8B8 Offset: 0x1C368B8 VA: 0x1C3A8B8
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1C3A8E0 Offset: 0x1C368E0 VA: 0x1C3A8E0
	private void OnPressThumb(GameObject go, bool pressed) { }

	// RVA: 0x1C3A908 Offset: 0x1C36908 VA: 0x1C3A908
	private void OnDragThumb(GameObject go, Vector2 delta) { }

	// RVA: 0x1C3A930 Offset: 0x1C36930 VA: 0x1C3A930
	private void OnPress(bool flag) { }

	// RVA: 0x1C3A96C Offset: 0x1C3696C VA: 0x1C3A96C
	public void .ctor() { }
}

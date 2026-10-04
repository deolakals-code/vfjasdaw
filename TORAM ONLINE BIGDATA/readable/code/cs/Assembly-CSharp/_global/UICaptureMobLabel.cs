// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICaptureMobLabel : UINameLabel // TypeDefIndex: 8873
{
	// Fields
	private MobActionManagerBase mobActionManager; // 0x88
	[SerializeField]
	private GameObject timeObj; // 0x90
	[SerializeField]
	private GameObject tamingObj; // 0x98
	[SerializeField]
	private UILabel timeLabel; // 0xA0
	[SerializeField]
	private UISprite timeIcon; // 0xA8
	[SerializeField]
	private UISlider tamingColorBar; // 0xB0
	private UISprite tamingColorSprite; // 0xB8
	[SerializeField]
	private UISlider tamingBaseBar; // 0xC0
	[SerializeField]
	private UILabel taimingLabel; // 0xC8
	private ICaptureTimer captureTimer; // 0xD0
	private bool timeColorFlag; // 0xD8
	private Vector3 colorBarPos; // 0xDC
	private float endTime; // 0xE8

	// Methods

	// RVA: 0x1E3BA2C Offset: 0x1E37A2C VA: 0x1E3BA2C
	public void Initialize(Transform traceObject, ICaptureTimer cap) { }

	// RVA: 0x1E3BCB8 Offset: 0x1E37CB8 VA: 0x1E3BCB8 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E3C2DC Offset: 0x1E382DC VA: 0x1E3C2DC Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E3C488 Offset: 0x1E38488 VA: 0x1E3C488
	public void .ctor() { }
}

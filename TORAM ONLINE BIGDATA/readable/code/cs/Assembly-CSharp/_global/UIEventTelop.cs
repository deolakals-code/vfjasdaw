// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventTelop : MonoBehaviour // TypeDefIndex: 8909
{
	// Fields
	[SerializeField]
	private UIWidget[] frame; // 0x20
	[SerializeField]
	private UISprite back; // 0x28
	[SerializeField]
	private float backMaxAlpha; // 0x30
	[SerializeField]
	private GameObject frameCenter; // 0x38
	[SerializeField]
	private UILabel label; // 0x40
	[SerializeField]
	private GameObject labelCenter; // 0x48
	[SerializeField]
	private Vector3[] anchorOffset; // 0x50
	private float time; // 0x58
	private EventTelopFadeType frameOut; // 0x5C
	private EventTelopFadeType labelOut; // 0x60
	private bool fadeOut; // 0x64

	// Methods

	// RVA: 0x1E51A10 Offset: 0x1E4DA10 VA: 0x1E51A10
	public void Initialize(string text, float time, UIIruna2Anchor.Side pos, EventTelopFadeType frameIn, EventTelopFadeType frameOut, EventTelopFadeType labelIn, EventTelopFadeType labelOut) { }

	// RVA: 0x1E51EC4 Offset: 0x1E4DEC4 VA: 0x1E51EC4
	private void Update() { }

	// RVA: 0x1E51D5C Offset: 0x1E4DD5C VA: 0x1E51D5C
	private Vector3 GetFadePosition(EventTelopFadeType fadeType) { }

	// RVA: 0x1E51CA4 Offset: 0x1E4DCA4 VA: 0x1E51CA4
	private void FadeObject(UIWidget widge, float sAlpha, float eAlpha) { }

	// RVA: 0x1E51DD0 Offset: 0x1E4DDD0 VA: 0x1E51DD0
	private void ScrollObject(GameObject center, Vector3 sPos, Vector3 ePos) { }

	// RVA: 0x1E520BC Offset: 0x1E4E0BC VA: 0x1E520BC
	public void end() { }

	// RVA: 0x1E520C4 Offset: 0x1E4E0C4 VA: 0x1E520C4
	public void .ctor() { }
}

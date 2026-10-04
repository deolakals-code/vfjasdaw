// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongPlayerIconManager : MonoBehaviour // TypeDefIndex: 5918
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private GameObject psiNameObj; // 0x28
	[SerializeField]
	private UILabel psiNameLabel; // 0x30
	[SerializeField]
	private GameObject dangerDetection; // 0x38
	[SerializeField]
	private GameObject waremeIcon; // 0x40
	private SystemTextManager sys; // 0x48

	// Methods

	// RVA: 0x1843460 Offset: 0x183F460 VA: 0x1843460
	public void Initialize() { }

	// RVA: 0x1843580 Offset: 0x183F580 VA: 0x1843580
	public void SetData(string name, bool isPsi = False, MahjongPsiType psiType = 0, bool isWareme = False) { }

	// RVA: 0x1843814 Offset: 0x183F814 VA: 0x1843814
	public void ChangeDangerDetectionActive(bool flag) { }

	// RVA: 0x18438AC Offset: 0x183F8AC VA: 0x18438AC
	public void .ctor() { }
}

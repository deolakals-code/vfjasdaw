// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaTelopPanel : MonoBehaviour // TypeDefIndex: 6116
{
	// Fields
	[SerializeField]
	private GameObject panelObj; // 0x20
	[SerializeField]
	private UILabel label; // 0x28
	private MobaRoomData roomData; // 0x30
	private SystemTextManager systemTextManager; // 0x38

	// Methods

	// RVA: 0x188BF34 Offset: 0x1887F34 VA: 0x188BF34
	public static GameObject CreatePanel(MobaRoomData roomData) { }

	// RVA: 0x188C184 Offset: 0x1888184 VA: 0x188C184
	public void Open(string text, bool isVictorySE, bool isPlaySE) { }

	// RVA: 0x188C260 Offset: 0x1888260 VA: 0x188C260
	public void OpenTextOnly(string text) { }

	// RVA: 0x188C304 Offset: 0x1888304 VA: 0x188C304
	private void Start() { }

	// RVA: 0x188C464 Offset: 0x1888464 VA: 0x188C464
	private void Update() { }

	[IteratorStateMachine(typeof(UIMobaTelopPanel.<OpenResult>d__9))]
	// RVA: 0x188C1D4 Offset: 0x18881D4 VA: 0x188C1D4
	private IEnumerator OpenResult(bool isVictorySE, bool isPlaySE) { }

	[IteratorStateMachine(typeof(UIMobaTelopPanel.<OpenText>d__10))]
	// RVA: 0x188C298 Offset: 0x1888298 VA: 0x188C298
	private IEnumerator OpenText() { }

	// RVA: 0x188C568 Offset: 0x1888568 VA: 0x188C568
	public void .ctor() { }
}

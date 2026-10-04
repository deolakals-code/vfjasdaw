// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITreasureHuntPanel : MonoBehaviour // TypeDefIndex: 6363
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor informationAnchor; // 0x20
	[SerializeField]
	private UIIruna2Anchor treasureAnchor; // 0x28
	[SerializeField]
	private Transform logParent; // 0x30
	[SerializeField]
	private UILabel timeLeftLabel; // 0x38
	[SerializeField]
	private UILabel[] boxNumLabels; // 0x40
	[SerializeField]
	private UILabel errorMessageLabel; // 0x48
	[SerializeField]
	private GameObject logLabelObject; // 0x50
	[SerializeField]
	private GameObject startLabelObject; // 0x58
	private static readonly float fadeTime; // 0x0
	private TreasureHuntRoomData roomData; // 0x60
	private List<UILabel> logLabelList; // 0x68
	private UIPopBaseWindow descriptionPopWindow; // 0x70
	private UITreasureHuntPanel.State state; // 0x78
	private bool isStarted; // 0x7C

	// Methods

	// RVA: 0x190F2CC Offset: 0x190B2CC VA: 0x190F2CC
	public void Initialize() { }

	// RVA: 0x190F3AC Offset: 0x190B3AC VA: 0x190F3AC
	private void Update() { }

	// RVA: 0x190F6F0 Offset: 0x190B6F0 VA: 0x190F6F0
	public void TreasureHuntStart() { }

	// RVA: 0x190F7BC Offset: 0x190B7BC VA: 0x190F7BC
	public void CreateDescriptionWindow() { }

	// RVA: 0x190F8F0 Offset: 0x190B8F0 VA: 0x190F8F0
	public void SetTimeLeftLabel(string text) { }

	// RVA: 0x190F90C Offset: 0x190B90C VA: 0x190F90C
	public void SetBoxNumLabel(int index, string text) { }

	// RVA: 0x190F558 Offset: 0x190B558 VA: 0x190F558
	public void TreasureUIMove() { }

	// RVA: 0x190F95C Offset: 0x190B95C VA: 0x190F95C
	public void SetErrorMessageLabel(Vector3 pos) { }

	// RVA: 0x190FC74 Offset: 0x190BC74 VA: 0x190FC74
	public void SetLogLabel(string text) { }

	[IteratorStateMachine(typeof(UITreasureHuntPanel.<OpenDescriptionWindow>d__24))]
	// RVA: 0x190F4EC Offset: 0x190B4EC VA: 0x190F4EC
	private IEnumerator OpenDescriptionWindow() { }

	// RVA: 0x19102A8 Offset: 0x190C2A8 VA: 0x19102A8
	private void OnCloseDescriptionWindow() { }

	// RVA: 0x1910478 Offset: 0x190C478 VA: 0x1910478
	public void .ctor() { }

	// RVA: 0x1910500 Offset: 0x190C500 VA: 0x1910500
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x191054C Offset: 0x190C54C VA: 0x191054C
	private void <SetErrorMessageLabel>b__22_0() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongGameStartAnimController : MonoBehaviour // TypeDefIndex: 5900
{
	// Fields
	[SerializeField]
	private Animation anim; // 0x20
	[SerializeField]
	private GameObject[] seatObjs; // 0x28
	[SerializeField]
	private UILabel[] windLabels; // 0x30
	[SerializeField]
	private UILabel[] playerNameLabels; // 0x38
	private MahjongRoomData roomData; // 0x40
	private UIMahjongMainManager main; // 0x48

	// Methods

	// RVA: 0x183A34C Offset: 0x183634C VA: 0x183A34C
	public void Initialize(MahjongRoomData roomData, UIMahjongMainManager main) { }

	[IteratorStateMachine(typeof(UIMahjongGameStartAnimController.<WaitSE>d__7))]
	// RVA: 0x183A868 Offset: 0x1836868 VA: 0x183A868
	private IEnumerator WaitSE() { }

	// RVA: 0x183A8FC Offset: 0x18368FC VA: 0x183A8FC
	public void .ctor() { }
}

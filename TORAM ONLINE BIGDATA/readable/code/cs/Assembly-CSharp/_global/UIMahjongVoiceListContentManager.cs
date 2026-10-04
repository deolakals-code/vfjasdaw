// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongVoiceListContentManager : MonoBehaviour // TypeDefIndex: 5967
{
	// Fields
	[SerializeField]
	private GameObject playButton; // 0x20
	[SerializeField]
	private GameObject lockIcon; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private UILabel releaseConditionLabel; // 0x38
	[SerializeField]
	private UILabel newLabel; // 0x40
	private MahjongRoomData roomData; // 0x48
	private MahjongVoicePattern voicePattern; // 0x50
	private MahjongVoiceType voiceType; // 0x54
	private bool isNew; // 0x58
	private Action<int> voicePlayCallBack; // 0x60
	private bool isWaitVoicePlay; // 0x68

	// Properties
	public bool IsNew { get; }
	public UILabel NewLabel { get; }

	// Methods

	// RVA: 0x18568C8 Offset: 0x18528C8 VA: 0x18568C8
	public bool get_IsNew() { }

	// RVA: 0x18568D0 Offset: 0x18528D0 VA: 0x18568D0
	public UILabel get_NewLabel() { }

	// RVA: 0x18568D8 Offset: 0x18528D8 VA: 0x18568D8
	public void Initialize(MahjongRoomData roomData, MahjongVoicePattern voicePattern, MahjongVoiceType voiceType, bool isActive, bool isNew, Action<int> voicePlayCallBack) { }

	// RVA: 0x1856BA4 Offset: 0x1852BA4 VA: 0x1856BA4
	public void OnClickVoicePlay() { }

	[IteratorStateMachine(typeof(UIMahjongVoiceListContentManager.<WaitPlayVoice>d__17))]
	// RVA: 0x1856C58 Offset: 0x1852C58 VA: 0x1856C58
	private IEnumerator WaitPlayVoice(float time) { }

	// RVA: 0x1856CFC Offset: 0x1852CFC VA: 0x1856CFC
	public void .ctor() { }
}

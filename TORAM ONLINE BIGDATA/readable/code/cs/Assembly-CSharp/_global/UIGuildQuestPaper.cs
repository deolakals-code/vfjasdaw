// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildQuestPaper : MonoBehaviour // TypeDefIndex: 6667
{
	// Fields
	[SerializeField]
	private BoxCollider reportCollider; // 0x20
	[SerializeField]
	private UIIconBase targetIcon; // 0x28
	[SerializeField]
	private UILabel typeLabel; // 0x30
	[SerializeField]
	private UILabel textLabel; // 0x38
	[SerializeField]
	private UISprite backFrameSprite; // 0x40
	[SerializeField]
	private UISprite questTypeIcon; // 0x48
	[SerializeField]
	private GameObject clearIcon; // 0x50
	[SerializeField]
	private UIGuildQuestBoardManager manager; // 0x58
	[SerializeField]
	private Vector3 offset; // 0x60
	private bool isAchievement; // 0x6C
	private UIGuildQuestBoardManager.GuildQuestDataBase data; // 0x70
	private Vector3 p0; // 0x78
	private Vector3 p1; // 0x84
	private Vector3 v0; // 0x90
	private Vector3 v1; // 0x9C
	private float moveTimer; // 0xA8
	private float moveRate; // 0xAC
	private float moveWait; // 0xB0

	// Methods

	// RVA: 0x19A86DC Offset: 0x19A46DC VA: 0x19A86DC
	public void Initialize(UIGuildQuestBoardManager.GuildQuestDataBase questData, bool isAchievement, string targetText) { }

	// RVA: 0x19A8844 Offset: 0x19A4844 VA: 0x19A8844
	public void FadeInAnimation(float timer) { }

	// RVA: 0x19A9EF4 Offset: 0x19A5EF4 VA: 0x19A9EF4
	public void DiscardQuestAnimation() { }

	// RVA: 0x19AB368 Offset: 0x19A7368 VA: 0x19AB368
	public void ReorderQuestAnimation() { }

	// RVA: 0x19A88D0 Offset: 0x19A48D0 VA: 0x19A88D0
	public void InitializeNonQuest() { }

	// RVA: 0x19AEC44 Offset: 0x19AAC44 VA: 0x19AEC44
	private void Update() { }

	// RVA: 0x19AED44 Offset: 0x19AAD44 VA: 0x19AED44
	private Vector3 GetCurve(float t) { }

	// RVA: 0x19AEC10 Offset: 0x19AAC10 VA: 0x19AEC10
	private void SetMoveEvent(float wait, float leng, Vector3 startPos, Vector3 startVec, Vector3 endPos, Vector3 endVec) { }

	// RVA: 0x19AEE34 Offset: 0x19AAE34 VA: 0x19AEE34
	public void OnClickPopQuest() { }

	// RVA: 0x19AEEC0 Offset: 0x19AAEC0 VA: 0x19AEEC0
	public void .ctor() { }
}

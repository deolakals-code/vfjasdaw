// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LinkAnimationObject : MonoBehaviour // TypeDefIndex: 3978
{
	// Fields
	[SerializeField]
	private int id; // 0x20
	[SerializeField]
	private Transform target; // 0x28
	[SerializeField]
	private Transform[] motionBone; // 0x30
	[SerializeField]
	private int flag; // 0x38
	[SerializeField]
	private int height; // 0x3C
	[SerializeField]
	private int startMotionId; // 0x40
	[SerializeField]
	private int loopMotionId; // 0x44
	[SerializeField]
	private int endMotionId; // 0x48
	[SerializeField]
	private int waitMotionId; // 0x4C
	private Transform moveBone; // 0x50
	private Vector3 savePosition; // 0x58
	protected Dictionary<string, Transform> motionBones; // 0x68
	private List<LinkAnimationObject.LinkBone> linkList; // 0x70
	private Animation objAnimation; // 0x78
	private bool updateCheck; // 0x80
	private byte step; // 0x81
	private bool man; // 0x82

	// Properties
	public int Id { get; }
	public Transform Target { get; }
	protected virtual int PlayWaitMotionId { get; }

	// Methods

	// RVA: 0x242A4A8 Offset: 0x24264A8 VA: 0x242A4A8
	public int get_Id() { }

	// RVA: 0x242A4B0 Offset: 0x24264B0 VA: 0x242A4B0
	public Transform get_Target() { }

	// RVA: 0x242A530 Offset: 0x2426530 VA: 0x242A530 Slot: 4
	protected virtual int get_PlayWaitMotionId() { }

	// RVA: 0x242A538 Offset: 0x2426538 VA: 0x242A538
	private void Start() { }

	// RVA: 0x242A558 Offset: 0x2426558 VA: 0x242A558
	protected void Init() { }

	// RVA: 0x242A664 Offset: 0x2426664 VA: 0x242A664
	public bool CheckFlag(LinkAnimationObject.Flag checkFlag) { }

	// RVA: 0x242A674 Offset: 0x2426674 VA: 0x242A674
	public bool SetDynamicId(int dynamicId) { }

	// RVA: 0x242A690 Offset: 0x2426690 VA: 0x242A690
	public void AttachmentBone(SkinnedMeshRenderer render, int height, bool man) { }

	// RVA: 0x242AB3C Offset: 0x2426B3C VA: 0x242AB3C
	public void Detach() { }

	// RVA: 0x242ABCC Offset: 0x2426BCC VA: 0x242ABCC
	private void DetachBone() { }

	// RVA: 0x242AA98 Offset: 0x2426A98 VA: 0x242AA98
	private string PlayMotionName(int id) { }

	// RVA: 0x242AD58 Offset: 0x2426D58 VA: 0x242AD58 Slot: 5
	protected virtual void CreateDictionary() { }

	// RVA: 0x242AE48 Offset: 0x2426E48 VA: 0x242AE48
	protected void Update() { }

	// RVA: 0x242B028 Offset: 0x2427028 VA: 0x242B028
	protected void CheckWaitMotion() { }

	// RVA: 0x242B0B8 Offset: 0x24270B8 VA: 0x242B0B8
	private void OnBecameVisible() { }

	// RVA: 0x242B0C0 Offset: 0x24270C0 VA: 0x242B0C0
	private void OnBecameInvisible() { }

	// RVA: 0x242B0C8 Offset: 0x24270C8 VA: 0x242B0C8
	private void LateUpdate() { }

	// RVA: 0x242B250 Offset: 0x2427250 VA: 0x242B250
	private void OnWillRenderObject() { }

	// RVA: 0x242B0E4 Offset: 0x24270E4 VA: 0x242B0E4
	private bool BoneLinkUpdate() { }

	// RVA: 0x242B260 Offset: 0x2427260 VA: 0x242B260
	public void .ctor() { }
}

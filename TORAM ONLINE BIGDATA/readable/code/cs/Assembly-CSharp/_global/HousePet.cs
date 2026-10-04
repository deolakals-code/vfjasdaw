// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HousePet : MonoBehaviour // TypeDefIndex: 3967
{
	// Fields
	private GameObject model; // 0x20
	private MobAnimation mobAnimation; // 0x28
	private CharacterMove characterMove; // 0x30
	private FieldCharacterShadow fieldShadow; // 0x38
	private byte index; // 0x40
	private bool isDestory; // 0x41
	private List<PetResponseData> petResponseData; // 0x48
	private HousePartitionManager partitionManager; // 0x50
	private bool initFlag; // 0x58
	[SerializeField]
	private float size; // 0x5C
	private List<byte> partTypes; // 0x60
	private bool invisible; // 0x68
	private float aiTimer; // 0x6C
	private List<Vector2> callRoute; // 0x70
	private GameObject player; // 0x78
	private float createWaitTimer; // 0x80
	[CompilerGenerated]
	private int <OwnerId>k__BackingField; // 0x84
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x88
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <IsOwner>k__BackingField; // 0x98
	[CompilerGenerated]
	private bool <IsStray>k__BackingField; // 0x99

	// Properties
	public int OwnerId { get; set; }
	public long Uuid { get; set; }
	public string Name { get; set; }
	public bool IsOwner { get; set; }
	public bool IsStray { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2426624 Offset: 0x2422624 VA: 0x2426624
	public int get_OwnerId() { }

	[CompilerGenerated]
	// RVA: 0x242662C Offset: 0x242262C VA: 0x242662C
	private void set_OwnerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2426634 Offset: 0x2422634 VA: 0x2426634
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x242663C Offset: 0x242263C VA: 0x242663C
	private void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x2426644 Offset: 0x2422644 VA: 0x2426644
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x242664C Offset: 0x242264C VA: 0x242664C
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x2426654 Offset: 0x2422654 VA: 0x2426654
	public bool get_IsOwner() { }

	[CompilerGenerated]
	// RVA: 0x242665C Offset: 0x242265C VA: 0x242665C
	private void set_IsOwner(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2426668 Offset: 0x2422668 VA: 0x2426668
	public bool get_IsStray() { }

	[CompilerGenerated]
	// RVA: 0x2426670 Offset: 0x2422670 VA: 0x2426670
	private void set_IsStray(bool value) { }

	// RVA: 0x242667C Offset: 0x242267C VA: 0x242667C
	private void Awake() { }

	// RVA: 0x24267B0 Offset: 0x24227B0 VA: 0x24267B0
	private void OnDestroy() { }

	// RVA: 0x24267BC Offset: 0x24227BC VA: 0x24267BC
	private void Update() { }

	// RVA: 0x2427084 Offset: 0x2423084 VA: 0x2427084
	public void FadeOutHouse() { }

	// RVA: 0x24270F0 Offset: 0x24230F0 VA: 0x24270F0
	public void SetNextPetResponseData(PetResponseData data) { }

	// RVA: 0x24271C8 Offset: 0x24231C8 VA: 0x24271C8
	public void UpdateOwner(int ownerId, bool owner, string name, Vector3 pos, float rot) { }

	// RVA: 0x2427298 Offset: 0x2423298 VA: 0x2427298
	public void SetPetData(PetEntityData petData, Vector3 pos, float rot) { }

	// RVA: 0x2427440 Offset: 0x2423440 VA: 0x2427440
	public void SetStrayPetData(int owenrId, PetModelData petModelData) { }

	// RVA: 0x2427518 Offset: 0x2423518 VA: 0x2427518
	public void UpdateStrayPetPosition() { }

	// RVA: 0x2427638 Offset: 0x2423638 VA: 0x2427638
	public void CallNameAction(string name) { }

	// RVA: 0x242792C Offset: 0x242392C VA: 0x242792C
	public void Call(GameObject target) { }

	// RVA: 0x2427EF8 Offset: 0x2423EF8 VA: 0x2427EF8
	public void UpdatePetModelColor(GameObject model, int[] color) { }

	// RVA: 0x2426680 Offset: 0x2422680 VA: 0x2426680
	private void Initialize() { }

	// RVA: 0x24269DC Offset: 0x24229DC VA: 0x24269DC
	private void NextAction() { }

	// RVA: 0x2428210 Offset: 0x2424210 VA: 0x2428210
	private Vector3 SearchNextPointMove() { }

	// RVA: 0x24289BC Offset: 0x24249BC VA: 0x24289BC
	private float PosMaxLimit(float pos, float limit, bool check, byte[] checkId) { }

	// RVA: 0x24288E8 Offset: 0x24248E8 VA: 0x24288E8
	private float PosMinLimit(float pos, float limit, bool check, byte[] checkId) { }

	[IteratorStateMachine(typeof(HousePet.<LoadModel>d__53))]
	// RVA: 0x2427398 Offset: 0x2423398 VA: 0x2427398
	private IEnumerator LoadModel(int modelId, int[] color, byte scale, byte index) { }

	// RVA: 0x2428AB8 Offset: 0x2424AB8 VA: 0x2428AB8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2428C20 Offset: 0x2424C20 VA: 0x2428C20
	private bool <CallNameAction>b__45_0(PetDataManager.PetViewData x) { }
}

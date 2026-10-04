// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CraneGameCharacterModelManager : MonoBehaviour // TypeDefIndex: 4298
{
	// Fields
	[SerializeField]
	private GameObject modelPositionObject; // 0x20
	private PlayerDataManager playerDataManager; // 0x28
	private UICharacterModelBaseManager modelManager; // 0x30
	private List<AnimationClip> animationClipList; // 0x38
	private byte genderType; // 0x40
	private List<Material> modelMaterials; // 0x48
	private readonly int shaderAlphaPropertyId; // 0x50

	// Methods

	// RVA: 0x24C6E18 Offset: 0x24C2E18 VA: 0x24C6E18
	private void Start() { }

	// RVA: 0x24C6E3C Offset: 0x24C2E3C VA: 0x24C6E3C
	private void OnDestroy() { }

	// RVA: 0x24C6EDC Offset: 0x24C2EDC VA: 0x24C6EDC
	public void Initialize() { }

	// RVA: 0x24C71F4 Offset: 0x24C31F4 VA: 0x24C71F4
	public void SetMaterialAlpha(bool isActive) { }

	// RVA: 0x24C7358 Offset: 0x24C3358 VA: 0x24C7358
	public void ChangeModelActive(bool isActive) { }

	// RVA: 0x24C6FC8 Offset: 0x24C2FC8 VA: 0x24C6FC8
	private void CreatCharacterModel() { }

	// RVA: 0x24C7404 Offset: 0x24C3404 VA: 0x24C7404
	private void UpdateModel() { }

	// RVA: 0x24C74D4 Offset: 0x24C34D4 VA: 0x24C74D4
	private void SetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x24C757C Offset: 0x24C357C VA: 0x24C757C
	private void FocusSetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	[IteratorStateMachine(typeof(CraneGameCharacterModelManager.<GetModelAllMaterial>d__16))]
	// RVA: 0x24C7460 Offset: 0x24C3460 VA: 0x24C7460
	private IEnumerator GetModelAllMaterial() { }

	// RVA: 0x24C77A0 Offset: 0x24C37A0 VA: 0x24C77A0
	public void .ctor() { }
}

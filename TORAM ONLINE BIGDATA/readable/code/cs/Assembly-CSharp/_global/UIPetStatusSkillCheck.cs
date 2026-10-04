// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetStatusSkillCheck : MonoBehaviour // TypeDefIndex: 7877
{
	// Fields
	[SerializeField]
	private UIIcon[] skillIcon; // 0x20
	[SerializeField]
	private GameObject[] skillLabelObj; // 0x28
	[SerializeField]
	private GameObject[] skillBarObj; // 0x30
	private UIPetStatusManager statusManager; // 0x38
	private int petId; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private SkillTextManager skillTextManager; // 0x50
	private readonly int[] storageExp; // 0x58

	// Methods

	// RVA: 0x1C460E8 Offset: 0x1C420E8 VA: 0x1C460E8
	public void InitPetCheckSkill(UIPetStatusManager manager, int id) { }

	// RVA: 0x1C4D128 Offset: 0x1C49128 VA: 0x1C4D128
	public void Initialize(PetSkillData[] skillData) { }

	// RVA: 0x1C4C7D0 Offset: 0x1C487D0 VA: 0x1C4C7D0
	private void SetSkillData(PetSkillData[] skillData) { }

	// RVA: 0x1C4D12C Offset: 0x1C4912C VA: 0x1C4D12C
	public void .ctor() { }
}

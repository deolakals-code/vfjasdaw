// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HousePetManager // TypeDefIndex: 1981
{
	// Fields
	private Dictionary<long, HousePet> petList; // 0x10
	private HousePet strayPet; // 0x18
	private List<long> removePet; // 0x20
	private List<PetSendData> pets; // 0x28
	public static readonly float SendMoveTime; // 0x0
	private float sendMoveTimer; // 0x30
	private string[] petNameIndex; // 0x38
	private long[] petIndexIds; // 0x40

	// Methods

	// RVA: 0x2126B74 Offset: 0x2122B74 VA: 0x2126B74
	public void ReceiveHousePetMove(PetResponseData[] petResponseData) { }

	// RVA: 0x2126C40 Offset: 0x2122C40 VA: 0x2126C40
	public void HousePetOwnershipUpdate() { }

	// RVA: 0x2126C90 Offset: 0x2122C90 VA: 0x2126C90
	public void UpdateHousePetOwner(int owenrId, bool focus, PetEntityData[] petsData, Vector3[] position) { }

	// RVA: 0x21278E4 Offset: 0x21238E4 VA: 0x21278E4
	public void UpdateStrayPetOwner(int owenrId, PetModelData petModelData) { }

	// RVA: 0x2127AFC Offset: 0x2123AFC VA: 0x2127AFC
	public void StrayPetClear() { }

	// RVA: 0x2127BB4 Offset: 0x2123BB4 VA: 0x2127BB4
	public void UpdateStratPetPosition() { }

	// RVA: 0x2127C38 Offset: 0x2123C38 VA: 0x2127C38
	public void UpdateResetPetPosition() { }

	// RVA: 0x2127FB8 Offset: 0x2123FB8 VA: 0x2127FB8
	public GameObject GetNearTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x212828C Offset: 0x212428C VA: 0x212828C
	public string GetPetName(int index) { }

	// RVA: 0x2128308 Offset: 0x2124308 VA: 0x2128308
	public void SayPetNameAction(ChatChannelType chatType, string inputText) { }

	// RVA: 0x2128514 Offset: 0x2124514 VA: 0x2128514
	public void Update(bool isEdit) { }

	// RVA: 0x2128930 Offset: 0x2124930 VA: 0x2128930
	public void OnEnter() { }

	// RVA: 0x21289B8 Offset: 0x21249B8 VA: 0x21289B8
	public void OnLeave() { }

	// RVA: 0x2128C50 Offset: 0x2124C50 VA: 0x2128C50
	public void .ctor() { }

	// RVA: 0x2128D88 Offset: 0x2124D88 VA: 0x2128D88
	private static void .cctor() { }
}

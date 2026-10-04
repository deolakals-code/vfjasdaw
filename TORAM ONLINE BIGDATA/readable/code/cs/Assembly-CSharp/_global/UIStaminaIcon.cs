// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStaminaIcon : MonoBehaviour // TypeDefIndex: 6573
{
	// Fields
	[SerializeField]
	private UISprite stamitaSprite; // 0x20
	[SerializeField]
	private UISprite systemStaminaIcon; // 0x28
	private PlayerDataManager playerDataManager; // 0x30
	private MercenaryActionManager mercenary; // 0x38
	private PetMemberActionManager pet; // 0x40
	private bool merceanryFlag; // 0x48
	private bool petFlag; // 0x49
	private int id; // 0x4C

	// Methods

	// RVA: 0x198B964 Offset: 0x1987964 VA: 0x198B964
	private void Start() { }

	// RVA: 0x198B988 Offset: 0x1987988 VA: 0x198B988
	public void Init(int id, byte type) { }

	// RVA: 0x198C5F8 Offset: 0x19885F8 VA: 0x198C5F8
	private void Update() { }

	// RVA: 0x198BB68 Offset: 0x1987B68 VA: 0x198BB68
	private void GetMerceanryActionManager() { }

	// RVA: 0x198C054 Offset: 0x1988054 VA: 0x198C054
	private void GetPetActionManager(int id) { }

	// RVA: 0x198BF24 Offset: 0x1987F24 VA: 0x198BF24
	private string GetMercenaryTirednessSpriteName() { }

	// RVA: 0x198C4A4 Offset: 0x19884A4 VA: 0x198C4A4
	public string GetPetStaminaSpriteName() { }

	// RVA: 0x198C6F4 Offset: 0x19886F4 VA: 0x198C6F4
	public void .ctor() { }
}

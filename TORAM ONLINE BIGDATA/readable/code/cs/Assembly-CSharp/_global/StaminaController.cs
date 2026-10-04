// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StaminaController : MonoBehaviour // TypeDefIndex: 6331
{
	// Fields
	[SerializeField]
	private UIWidget stamina_icon_prefab; // 0x20
	private List<GameObject> stamina_list; // 0x28
	private int have_statmina; // 0x30
	private int max_stamina; // 0x34
	private int repair_stamina; // 0x38

	// Properties
	public bool IsStaminaEmpty { get; }
	public int NowStamina { get; }
	public int MaxStamina { get; }
	public int RepairStamina { get; }
	public bool IsMaxStamina { get; }

	// Methods

	// RVA: 0x18E44A0 Offset: 0x18E04A0 VA: 0x18E44A0
	public bool get_IsStaminaEmpty() { }

	// RVA: 0x18EA6F8 Offset: 0x18E66F8 VA: 0x18EA6F8
	public int get_NowStamina() { }

	// RVA: 0x18EA700 Offset: 0x18E6700 VA: 0x18EA700
	public int get_MaxStamina() { }

	// RVA: 0x18EA708 Offset: 0x18E6708 VA: 0x18EA708
	public int get_RepairStamina() { }

	// RVA: 0x18E1ED8 Offset: 0x18DDED8 VA: 0x18E1ED8
	public bool get_IsMaxStamina() { }

	// RVA: 0x18EA710 Offset: 0x18E6710 VA: 0x18EA710
	private void Start() { }

	// RVA: 0x18E164C Offset: 0x18DD64C VA: 0x18E164C
	public void SetStaminaInfo(int _now_stamina, int _max_stamina, int _repaire_stamina) { }

	// RVA: 0x18E1EE8 Offset: 0x18DDEE8 VA: 0x18E1EE8
	public bool CheakExpenditure(int _cheak_num) { }

	// RVA: 0x18EA714 Offset: 0x18E6714 VA: 0x18EA714
	private void stamina_icon_create(int _now_stamina, int _max_stamina, int _repaire_stamina) { }

	// RVA: 0x18EAA94 Offset: 0x18E6A94 VA: 0x18EAA94
	public void .ctor() { }
}

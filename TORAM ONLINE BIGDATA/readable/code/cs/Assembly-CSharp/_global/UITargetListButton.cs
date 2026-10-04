// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITargetListButton : MonoBehaviour // TypeDefIndex: 6578
{
	// Fields
	[CompilerGenerated]
	private GameObject <TargetObject>k__BackingField; // 0x20
	[SerializeField]
	protected UILabel nameLabel; // 0x28
	[SerializeField]
	protected UISlider hpBar; // 0x30
	[CompilerGenerated]
	private UITargetListManager.TargetSortType <TargetType>k__BackingField; // 0x38
	protected UITargetListManager targetListManager; // 0x40
	protected PlayerDataManager playerDataManager; // 0x48
	protected IPlayerControl playerControl; // 0x50
	protected MobActionManagerBase mobActionManager; // 0x58
	protected UIButton uiButton; // 0x60
	protected UIImageButton uiImageButton; // 0x68

	// Properties
	public GameObject TargetObject { get; set; }
	public UITargetListManager.TargetSortType TargetType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x198DF4C Offset: 0x1989F4C VA: 0x198DF4C
	public GameObject get_TargetObject() { }

	[CompilerGenerated]
	// RVA: 0x198DF54 Offset: 0x1989F54 VA: 0x198DF54
	protected void set_TargetObject(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x198DF5C Offset: 0x1989F5C VA: 0x198DF5C
	public UITargetListManager.TargetSortType get_TargetType() { }

	[CompilerGenerated]
	// RVA: 0x198DF64 Offset: 0x1989F64 VA: 0x198DF64
	protected void set_TargetType(UITargetListManager.TargetSortType value) { }

	// RVA: 0x198DF6C Offset: 0x1989F6C VA: 0x198DF6C Slot: 4
	public virtual bool SetTargetList(UITargetListManager manager, GameObject target, UITargetListManager.TargetSortType targetType) { }

	// RVA: 0x198E738 Offset: 0x198A738 VA: 0x198E738
	private void Start() { }

	// RVA: 0x198E7CC Offset: 0x198A7CC VA: 0x198E7CC Slot: 5
	protected virtual void Update() { }

	// RVA: 0x198E9E8 Offset: 0x198A9E8 VA: 0x198E9E8
	private void OnClick() { }

	// RVA: 0x198EA0C Offset: 0x198AA0C VA: 0x198EA0C Slot: 6
	public virtual bool PushAction() { }

	// RVA: 0x198EB88 Offset: 0x198AB88 VA: 0x198EB88
	public void .ctor() { }
}

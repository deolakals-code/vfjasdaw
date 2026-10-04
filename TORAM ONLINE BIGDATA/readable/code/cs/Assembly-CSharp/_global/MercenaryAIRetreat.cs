// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryAIRetreat : AutoMemberAIRetreat // TypeDefIndex: 664
{
	// Fields
	private const float Range = 3;
	private int enemyRange; // 0x78
	private Vector3 moveDirection; // 0x7C
	private ItemDBData.ItemType weapon; // 0x88
	private Stopwatch sw; // 0x90
	private MercenaryAIRetreat.RetreatType type; // 0x98
	private bool resignation; // 0x9C
	private Vector3 oldPos; // 0xA0
	private float length; // 0xAC

	// Properties
	private ItemDBData.ItemType WeaponType { get; set; }

	// Methods

	[IteratorStateMachine(typeof(MercenaryAIRetreat.<GetParam>d__0))]
	// RVA: 0x19E92B0 Offset: 0x19E52B0 VA: 0x19E92B0 Slot: 4
	public override IEnumerable<string> GetParam() { }

	// RVA: 0x19E9324 Offset: 0x19E5324 VA: 0x19E9324
	private bool Resignation() { }

	// RVA: 0x19E9424 Offset: 0x19E5424 VA: 0x19E9424
	private ItemDBData.ItemType get_WeaponType() { }

	// RVA: 0x19E942C Offset: 0x19E542C VA: 0x19E942C
	public void set_WeaponType(ItemDBData.ItemType value) { }

	// RVA: 0x19E9448 Offset: 0x19E5448 VA: 0x19E9448
	private int calcRange(ItemDBData.ItemType weapon) { }

	// RVA: 0x19E9490 Offset: 0x19E5490 VA: 0x19E9490 Slot: 5
	public override AIActionType GetRetreat() { }

	// RVA: 0x19E9A08 Offset: 0x19E5A08 VA: 0x19E9A08 Slot: 6
	public override AIActionType CheckRetreat(Transform trans) { }

	// RVA: 0x19E9B50 Offset: 0x19E5B50 VA: 0x19E9B50 Slot: 7
	public override Vector3 GetRetreatDirection() { }

	// RVA: 0x19E9828 Offset: 0x19E5828 VA: 0x19E9828
	private bool CheckTargetSize(GameObject target, float enemyRange) { }

	// RVA: 0x19E9F48 Offset: 0x19E5F48 VA: 0x19E9F48 Slot: 8
	public override Vector3 GetIdleAction() { }

	// RVA: 0x19E97F0 Offset: 0x19E57F0 VA: 0x19E97F0
	private void TypeChange(MercenaryAIRetreat.RetreatType type) { }

	// RVA: 0x19E9F8C Offset: 0x19E5F8C VA: 0x19E9F8C
	public void .ctor() { }
}

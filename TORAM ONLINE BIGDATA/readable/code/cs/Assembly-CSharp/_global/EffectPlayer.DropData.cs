// Assembly: Assembly-CSharp.dll
// Namespace: 
private class EffectPlayer.DropData // TypeDefIndex: 237
{
	// Fields
	[CompilerGenerated]
	private int <ExpPoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <RareLevel>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <ExpTakeUid>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <ItemTakeUid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private GameObject <TargetMob>k__BackingField; // 0x20
	[CompilerGenerated]
	private Vector3 <TargetPosition>k__BackingField; // 0x28
	[CompilerGenerated]
	private Vector3 <BoxPosition>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <IsPartyDrop>k__BackingField; // 0x40
	private FadeAnimationManager fadeAnimationManager; // 0x48
	public List<EffectPlayer.DropItem> DropItemList; // 0x50

	// Properties
	public int ExpPoint { get; set; }
	public int RareLevel { get; set; }
	public int ExpTakeUid { get; set; }
	public int ItemTakeUid { get; set; }
	public GameObject TargetMob { get; set; }
	public Vector3 TargetPosition { get; set; }
	public Vector3 BoxPosition { get; set; }
	public bool IsPartyDrop { get; set; }
	public bool IsDropItemCheck { get; }

	// Methods

	// RVA: 0x22A8044 Offset: 0x22A4044 VA: 0x22A8044
	public void .ctor(GameObject target, Vector3 position, int expPoitn, int rareLevel, List<EffectPlayer.DropItem> dropItem, bool isParty) { }

	[CompilerGenerated]
	// RVA: 0x22ADAF0 Offset: 0x22A9AF0 VA: 0x22ADAF0
	private void set_ExpPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x22ADAF8 Offset: 0x22A9AF8 VA: 0x22ADAF8
	public int get_ExpPoint() { }

	[CompilerGenerated]
	// RVA: 0x22ADB00 Offset: 0x22A9B00 VA: 0x22ADB00
	private void set_RareLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB08 Offset: 0x22A9B08 VA: 0x22ADB08
	public int get_RareLevel() { }

	[CompilerGenerated]
	// RVA: 0x22ADB10 Offset: 0x22A9B10 VA: 0x22ADB10
	private void set_ExpTakeUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB18 Offset: 0x22A9B18 VA: 0x22ADB18
	public int get_ExpTakeUid() { }

	[CompilerGenerated]
	// RVA: 0x22ADB20 Offset: 0x22A9B20 VA: 0x22ADB20
	private void set_ItemTakeUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB28 Offset: 0x22A9B28 VA: 0x22ADB28
	public int get_ItemTakeUid() { }

	[CompilerGenerated]
	// RVA: 0x22ADB30 Offset: 0x22A9B30 VA: 0x22ADB30
	private void set_TargetMob(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB38 Offset: 0x22A9B38 VA: 0x22ADB38
	public GameObject get_TargetMob() { }

	[CompilerGenerated]
	// RVA: 0x22ADB40 Offset: 0x22A9B40 VA: 0x22ADB40
	private void set_TargetPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB4C Offset: 0x22A9B4C VA: 0x22ADB4C
	public Vector3 get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x22ADB58 Offset: 0x22A9B58 VA: 0x22ADB58
	private void set_BoxPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB64 Offset: 0x22A9B64 VA: 0x22ADB64
	public Vector3 get_BoxPosition() { }

	[CompilerGenerated]
	// RVA: 0x22ADB70 Offset: 0x22A9B70 VA: 0x22ADB70
	private void set_IsPartyDrop(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22ADB7C Offset: 0x22A9B7C VA: 0x22ADB7C
	public bool get_IsPartyDrop() { }

	// RVA: 0x22A6BFC Offset: 0x22A2BFC VA: 0x22A6BFC
	public bool get_IsDropItemCheck() { }

	// RVA: 0x22A8544 Offset: 0x22A4544 VA: 0x22A8544
	public void SetItemPBoxPosition(Vector3 pos) { }

	// RVA: 0x22A6EA0 Offset: 0x22A2EA0 VA: 0x22A6EA0
	public void SetExpTakeUid(int takeUid) { }

	// RVA: 0x22A6E98 Offset: 0x22A2E98 VA: 0x22A6E98
	public void SetItemTakeUid(int takeUid) { }

	// RVA: 0x22A6B74 Offset: 0x22A2B74 VA: 0x22A6B74
	public bool IsFadeCheck() { }

	// RVA: 0x22A7EA0 Offset: 0x22A3EA0 VA: 0x22A7EA0
	public bool LevelUpCheck() { }
}

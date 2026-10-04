// Assembly: Assembly-CSharp.dll
// Namespace: MobBuffer
public class JumpBackShotMarkingBuff : MobBuffBase // TypeDefIndex: 9303
{
	// Fields
	[CompilerGenerated]
	private bool <IsSelf>k__BackingField; // 0x25
	private readonly int archetypeId; // 0x28
	private readonly int sLv; // 0x2C
	private int free; // 0x30
	private int takeUid; // 0x34
	private Dictionary<ArchetypeUid, JumpBackShotMarkingBuff.MarkingData> markingDataList; // 0x38
	private GameObject actor; // 0x40
	private JumpBackShotMarkingBuff.MarkingData targetMarkingEffect; // 0x48

	// Properties
	public override MobBuffId Id { get; }
	public bool IsSelf { get; set; }

	// Methods

	// RVA: 0x1EB9A78 Offset: 0x1EB5A78 VA: 0x1EB9A78 Slot: 4
	public override MobBuffId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1EB9A80 Offset: 0x1EB5A80 VA: 0x1EB9A80
	public bool get_IsSelf() { }

	[CompilerGenerated]
	// RVA: 0x1EB9A88 Offset: 0x1EB5A88 VA: 0x1EB9A88
	private void set_IsSelf(bool value) { }

	// RVA: 0x1EB9A94 Offset: 0x1EB5A94 VA: 0x1EB9A94
	public void .ctor(int archetypeId, int sLv, int mDex, int mStr) { }

	// RVA: 0x1EB9BE4 Offset: 0x1EB5BE4 VA: 0x1EB9BE4
	public void .ctor(int mineArchetypeId, MobBuffData buffData) { }

	// RVA: 0x1EBA0F4 Offset: 0x1EB60F4 VA: 0x1EBA0F4 Slot: 6
	public override void Update() { }

	// RVA: 0x1EBA6A8 Offset: 0x1EB66A8 VA: 0x1EBA6A8 Slot: 7
	public override int GetValue() { }

	// RVA: 0x1EBA6B0 Offset: 0x1EB66B0 VA: 0x1EBA6B0 Slot: 8
	public override MobBuffData GetSendData() { }

	// RVA: 0x1EBA4B0 Offset: 0x1EB64B0 VA: 0x1EBA4B0
	public void BufferEnd() { }

	// RVA: 0x1EBA510 Offset: 0x1EB6510 VA: 0x1EBA510
	public void AddMarking(GameObject actor, bool other) { }

	// RVA: 0x1EBA7C0 Offset: 0x1EB67C0 VA: 0x1EBA7C0
	public void OtherToParty() { }

	// RVA: 0x1EBA870 Offset: 0x1EB6870 VA: 0x1EBA870
	public ArchetypeUid GetActiveMarkerArchetypeUid(out bool isMine) { }

	// RVA: 0x1EB9E34 Offset: 0x1EB5E34 VA: 0x1EB9E34
	private void UpdateAppliedEffect() { }

	[CompilerGenerated]
	// RVA: 0x1EBA8C4 Offset: 0x1EB68C4 VA: 0x1EBA8C4
	private void <Update>b__16_0(ArchetypeUid r) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BeragelungDebuffBase : MobBuffBase // TypeDefIndex: 851
{
	// Fields
	protected readonly int sendSkillLevel; // 0x28
	protected readonly int sendArchetypeId; // 0x2C
	protected BeragelungDebuffBase.DebuffData mainDebuffData; // 0x30
	protected Dictionary<int, BeragelungDebuffBase.DebuffData> debuffList; // 0x38

	// Methods

	// RVA: 0x1ECD574 Offset: 0x1EC9574 VA: 0x1ECD574
	public void .ctor(int archetypeId, int skillLevel) { }

	// RVA: 0x1ECD61C Offset: 0x1EC961C VA: 0x1ECD61C
	public void .ctor(int actorArchetypeId, MobBuffData buffData) { }

	// RVA: 0x1ECD848 Offset: 0x1EC9848 VA: 0x1ECD848 Slot: 6
	public override void Update() { }

	// RVA: 0x1ECDD88 Offset: 0x1EC9D88 VA: 0x1ECDD88 Slot: 8
	public override MobBuffData GetSendData() { }

	// RVA: 0x1ECDE00 Offset: 0x1EC9E00 VA: 0x1ECDE00
	public int GetActiveArchetypeId(out bool isMine) { }

	// RVA: 0x1ECDE38 Offset: 0x1EC9E38 VA: 0x1ECDE38
	public float GetLastDamageUpRate() { }

	// RVA: 0x1ECDE5C Offset: 0x1EC9E5C VA: 0x1ECDE5C
	public int GetAttackMpRecovery() { }

	// RVA: 0x1ECDE78 Offset: 0x1EC9E78 VA: 0x1ECDE78
	public int GetCriticalResist() { }

	[CompilerGenerated]
	// RVA: 0x1ECDE90 Offset: 0x1EC9E90 VA: 0x1ECDE90
	private void <Update>b__7_0(int x) { }
}

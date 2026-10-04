// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobaMobActionManagerBase : ServerMobActionManagerBase, IMobaCharacterAction // TypeDefIndex: 909
{
	// Fields
	[CompilerGenerated]
	private int <PopAreaNo>k__BackingField; // 0x154

	// Properties
	public bool IsSystemLock { get; }
	public int PopAreaNo { get; set; }

	// Methods

	// RVA: 0x1F017D0 Offset: 0x1EFD7D0 VA: 0x1F017D0
	public bool get_IsSystemLock() { }

	[CompilerGenerated]
	// RVA: 0x1F02100 Offset: 0x1EFE100 VA: 0x1F02100
	public int get_PopAreaNo() { }

	[CompilerGenerated]
	// RVA: 0x1F02108 Offset: 0x1EFE108 VA: 0x1F02108
	private void set_PopAreaNo(int value) { }

	// RVA: 0x1F02110 Offset: 0x1EFE110 VA: 0x1F02110 Slot: 79
	public override void UpdateHp(int hp) { }

	// RVA: 0x1F0221C Offset: 0x1EFE21C VA: 0x1F0221C Slot: 89
	public override bool MobToEnemy() { }

	// RVA: 0x1F02374 Offset: 0x1EFE374 VA: 0x1F02374 Slot: 78
	public override bool IsValidMatch(IMobIdData mobId) { }

	// RVA: 0x1F024D0 Offset: 0x1EFE4D0 VA: 0x1F024D0 Slot: 107
	public virtual void ReceivePlayerDamage(GameObject actor, SkillActionBase skill) { }

	// RVA: 0x1F024D8 Offset: 0x1EFE4D8 VA: 0x1F024D8 Slot: 106
	public void Subjugated(GameObject actar) { }

	// RVA: 0x1F024DC Offset: 0x1EFE4DC VA: 0x1F024DC
	public void SetPopAreaNo(int popAreaNo) { }

	// RVA: 0x1F024E4 Offset: 0x1EFE4E4 VA: 0x1F024E4
	private bool TargettingSearchMode() { }

	// RVA: 0x1F02590 Offset: 0x1EFE590 VA: 0x1F02590 Slot: 92
	public override bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F02644 Offset: 0x1EFE644 VA: 0x1F02644 Slot: 93
	public override bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F0270C Offset: 0x1EFE70C VA: 0x1F0270C Slot: 94
	public override bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F00ABC Offset: 0x1EFCABC VA: 0x1F00ABC
	protected void .ctor() { }
}

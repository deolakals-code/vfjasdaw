// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IInstallationAttackPattern // TypeDefIndex: 760
{
	// Properties
	public abstract MobAttackCategory InstallationCategory { get; }
	public abstract ElementType Element { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MobAttackCategory get_InstallationCategory();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ElementType get_Element();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Invalid();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsEnd();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetBulletModel(GameObject[] bulletModels);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetParentParameter(MobPatternBase parentPattern);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract GameObject GetTarget();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract GameObject GetBullet();
}

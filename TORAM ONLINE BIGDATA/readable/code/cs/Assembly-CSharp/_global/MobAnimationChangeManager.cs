// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobAnimationChangeManager // TypeDefIndex: 920
{
	// Fields
	private readonly EnemyMobActionManagerBase actionManager; // 0x10
	private Dictionary<MobAnimationType, byte> animations; // 0x18

	// Methods

	// RVA: 0x1F05338 Offset: 0x1F01338 VA: 0x1F05338
	public void .ctor(EnemyMobActionManagerBase actionManager) { }

	// RVA: 0x1F0561C Offset: 0x1F0161C VA: 0x1F0561C
	public int GetAnimationNo(int animationNo) { }

	// RVA: 0x1F05688 Offset: 0x1F01688 VA: 0x1F05688
	public void OnChangeStatus() { }

	// RVA: 0x1F053E4 Offset: 0x1F013E4 VA: 0x1F053E4
	private void InitializeAnimations() { }

	// RVA: 0x1F0549C Offset: 0x1F0149C VA: 0x1F0549C
	private void UpdateAnimations() { }
}

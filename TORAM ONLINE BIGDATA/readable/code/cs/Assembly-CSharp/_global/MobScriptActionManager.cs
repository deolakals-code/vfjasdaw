// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobScriptActionManager // TypeDefIndex: 1023
{
	// Fields
	private readonly EnemyMobActionManagerBase actionManager; // 0x10
	private List<byte> firstAddHateList; // 0x18

	// Methods

	// RVA: 0x1F36668 Offset: 0x1F32668 VA: 0x1F36668
	public void .ctor(EnemyMobActionManagerBase actionManager) { }

	// RVA: 0x1F36704 Offset: 0x1F32704 VA: 0x1F36704
	public void UpdateStatus() { }

	// RVA: 0x1F36754 Offset: 0x1F32754 VA: 0x1F36754
	public void Action(byte propertyUid, GameObject target) { }

	// RVA: 0x1F3685C Offset: 0x1F3285C VA: 0x1F3685C
	private void Hate(byte propertyUid, MobScriptActionManager.HateFlag flag, GameObject target) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobScreenEffectManager // TypeDefIndex: 1021
{
	// Fields
	private readonly EnemyMobActionManagerBase actorAction; // 0x10
	private bool prevInArea; // 0x18
	private float damageRange; // 0x1C
	private float safeRange; // 0x20
	private GameObject screenEffectObject; // 0x28
	private int screenEffectId; // 0x30
	private int screenEffectColor; // 0x34
	private bool loadComplete; // 0x38
	private bool first; // 0x39

	// Methods

	// RVA: 0x1F35E80 Offset: 0x1F31E80 VA: 0x1F35E80
	public void .ctor(EnemyMobActionManagerBase actorAction) { }

	// RVA: 0x1F35EB8 Offset: 0x1F31EB8 VA: 0x1F35EB8
	public void Update(PlayerActionManagerBase targetAction) { }

	// RVA: 0x1F36024 Offset: 0x1F32024 VA: 0x1F36024
	public void DrawScreenEffect() { }

	// RVA: 0x1F360AC Offset: 0x1F320AC VA: 0x1F360AC
	public void RemoveScreenEffect() { }

	// RVA: 0x1F36134 Offset: 0x1F32134 VA: 0x1F36134
	public void Clear() { }

	// RVA: 0x1F361A0 Offset: 0x1F321A0 VA: 0x1F361A0
	public void UpdateScreenEffectStatus(int type, int color, float safeRange, float damageRange) { }

	[IteratorStateMachine(typeof(MobScreenEffectManager.<Load>d__16))]
	// RVA: 0x1F361C8 Offset: 0x1F321C8 VA: 0x1F361C8
	public IEnumerator Load() { }

	// RVA: 0x1F35F84 Offset: 0x1F31F84 VA: 0x1F35F84
	private bool CheckRange(Vector3 targetPos, float targetSize) { }

	[CompilerGenerated]
	// RVA: 0x1F3625C Offset: 0x1F3225C VA: 0x1F3625C
	private void <Load>b__16_0(bool success, GameObject effectObject) { }
}

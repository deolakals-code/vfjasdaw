// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestRewardList : MonoBehaviour // TypeDefIndex: 7895
{
	// Fields
	[SerializeField]
	private UIIcon icon; // 0x20
	[SerializeField]
	private UILabel nameLabel; // 0x28
	private UIIruna2Label exNameLabel; // 0x30
	[SerializeField]
	private UILabel textLabel; // 0x38
	[SerializeField]
	private UILabel numLabel; // 0x40
	[SerializeField]
	private UISprite flashSprite; // 0x48

	// Methods

	// RVA: 0x1C59E60 Offset: 0x1C55E60 VA: 0x1C59E60
	public void RewardItem(int itemId, int num, byte check) { }

	// RVA: 0x1C5A474 Offset: 0x1C56474 VA: 0x1C5A474
	public void RewardOrbItem(int itemId, int num, byte check) { }

	// RVA: 0x1C5A870 Offset: 0x1C56870 VA: 0x1C5A870
	public void RewardGold(int gold, byte check) { }

	// RVA: 0x1C5AC50 Offset: 0x1C56C50 VA: 0x1C5AC50
	public void RewardExp(int exp, byte check) { }

	// RVA: 0x1C5B038 Offset: 0x1C57038 VA: 0x1C5B038
	public void RewardMaterial(int value, int num, byte check, int flashSpriteWidth) { }

	// RVA: 0x1C5B29C Offset: 0x1C5729C VA: 0x1C5B29C
	public void RewardTreasureHuntTest(int value, int flashSpriteWidth) { }

	// RVA: 0x1C5B69C Offset: 0x1C5769C VA: 0x1C5B69C
	public void RewardErr() { }

	// RVA: 0x1C5A314 Offset: 0x1C56314 VA: 0x1C5A314
	private void SetNameLabel(string label, Vector3 pos, UIWidget.Pivot pivot) { }

	// RVA: 0x1C5B94C Offset: 0x1C5794C VA: 0x1C5B94C
	public void RewardSystem(string text, string info, string iconSprite) { }

	// RVA: 0x1C5B294 Offset: 0x1C57294 VA: 0x1C5B294
	public void RewardSystem(string text, string info, string iconSprite, int flashSpriteWidth) { }

	// RVA: 0x1C5B958 Offset: 0x1C57958 VA: 0x1C5B958
	public void RewardSystem(string text, string info, string iconSprite, int flashSpriteWidth, int depth) { }

	// RVA: 0x1C5BC84 Offset: 0x1C57C84 VA: 0x1C5BC84
	public void BlackKnightLootBoxLabel(BlackKnightCristaId cristaId) { }

	// RVA: 0x1C5BF64 Offset: 0x1C57F64 VA: 0x1C5BF64
	public void RewardNaCollab(string text) { }

	// RVA: 0x1C5C274 Offset: 0x1C58274 VA: 0x1C5C274
	public void SetScaleTextLabel(Vector3 scale) { }

	[IteratorStateMachine(typeof(UIQuestRewardList.<StartStamp>d__20))]
	// RVA: 0x1C5C1F8 Offset: 0x1C581F8 VA: 0x1C5C1F8
	private IEnumerator StartStamp(float delay) { }

	// RVA: 0x1C5C2EC Offset: 0x1C582EC VA: 0x1C5C2EC
	public void .ctor() { }
}

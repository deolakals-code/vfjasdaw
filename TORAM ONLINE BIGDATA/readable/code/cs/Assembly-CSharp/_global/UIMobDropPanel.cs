// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobDropPanel : MonoBehaviour // TypeDefIndex: 7382
{
	// Fields
	[SerializeField]
	private GameObject mobModelParent; // 0x20
	[SerializeField]
	private UIScrollWindow itemScrollWindow; // 0x28
	[SerializeField]
	private UILabel mobExpLabel; // 0x30
	[SerializeField]
	private GameObject mobDropLabel; // 0x38
	[SerializeField]
	private Transform viewCamera; // 0x40
	[SerializeField]
	private GameObject bossIcon; // 0x48
	private ItemTextManager itemTextManager; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private readonly byte[] expPenalty; // 0x60
	private readonly short[] expBonus; // 0x68
	private int expBonusLevel; // 0x70
	private int expPenaltyLevel; // 0x74

	// Methods

	// RVA: 0x1B31D2C Offset: 0x1B2DD2C VA: 0x1B31D2C
	public void Initialize(GameObject model, float scale, int monsterDataId, List<int> questItem) { }

	// RVA: 0x1B32744 Offset: 0x1B2E744 VA: 0x1B32744
	private string GetItemName(ItemDBData db, int itemId) { }

	// RVA: 0x1B32858 Offset: 0x1B2E858 VA: 0x1B32858
	private int GetDiffLevelExp(int exp, int diffLevel) { }

	// RVA: 0x1B32998 Offset: 0x1B2E998 VA: 0x1B32998
	private byte GetExpPenalty(int diffValue) { }

	// RVA: 0x1B3291C Offset: 0x1B2E91C VA: 0x1B3291C
	public short GetExpBonus(int diffValue) { }

	// RVA: 0x1B32A14 Offset: 0x1B2EA14 VA: 0x1B32A14
	public void .ctor() { }
}

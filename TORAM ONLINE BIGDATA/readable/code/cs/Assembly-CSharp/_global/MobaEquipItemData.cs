// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaEquipItemData : ItemData // TypeDefIndex: 2042
{
	// Fields
	private static int[] weaponAtk; // 0x0
	private static Dictionary<byte, float> weaponRate; // 0x8
	private bool isUpdateCheck; // 0x84
	private int updateCount; // 0x88
	private readonly int MaxUpdateCount; // 0x8C

	// Methods

	// RVA: 0x213C9D0 Offset: 0x21389D0 VA: 0x213C9D0
	private float GetAtk(byte itemType, int updateCount) { }

	// RVA: 0x213CAD8 Offset: 0x2138AD8 VA: 0x213CAD8
	public void .ctor(ItemDatav2 itemData, byte count, byte refine) { }

	// RVA: 0x213CF70 Offset: 0x2138F70 VA: 0x213CF70
	public void .ctor(int type, byte refine, int updateCount, bool isUpdateCheck) { }

	// RVA: 0x213D124 Offset: 0x2139124 VA: 0x213D124
	public void .ctor(ItemData itemData, int updateCount) { }

	// RVA: 0x213D3F4 Offset: 0x21393F4 VA: 0x213D3F4
	public int UpdateAtk() { }

	// RVA: 0x213D4A0 Offset: 0x21394A0 VA: 0x213D4A0
	public bool TryBuyPrice(int gold, out int price) { }

	// RVA: 0x213D4EC Offset: 0x21394EC VA: 0x213D4EC
	public bool TrySellPrice(out int price) { }

	// RVA: 0x213D540 Offset: 0x2139540 VA: 0x213D540
	private static void .cctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GemCartBag // TypeDefIndex: 2288
{
	// Fields
	private List<GemCartData> bag; // 0x10
	private List<GemCartEquipData> equips; // 0x18
	private byte slotCount; // 0x20
	private GemCartData prevGemCartData; // 0x28

	// Properties
	public IList<GemCartData> Bag { get; }
	public int BagCount { get; }
	public bool IsMax { get; }
	public byte SlotCount { get; }
	public GemCartData PrevGemCartData { get; }
	public int MaxBagCount { get; }

	// Methods

	// RVA: 0x21795E4 Offset: 0x21755E4 VA: 0x21795E4
	public IList<GemCartData> get_Bag() { }

	// RVA: 0x2179634 Offset: 0x2175634 VA: 0x2179634
	public int get_BagCount() { }

	// RVA: 0x217967C Offset: 0x217567C VA: 0x217967C
	public bool get_IsMax() { }

	// RVA: 0x2179700 Offset: 0x2175700 VA: 0x2179700
	public byte get_SlotCount() { }

	// RVA: 0x2179708 Offset: 0x2175708 VA: 0x2179708
	public GemCartData get_PrevGemCartData() { }

	// RVA: 0x217969C Offset: 0x217569C VA: 0x217969C
	public int get_MaxBagCount() { }

	// RVA: 0x2179710 Offset: 0x2175710 VA: 0x2179710
	public void .ctor() { }

	// RVA: 0x2179890 Offset: 0x2175890 VA: 0x2179890
	public void AddGemCart(GemCartData gem) { }

	// RVA: 0x2179B38 Offset: 0x2175B38 VA: 0x2179B38
	public void AddGemCarts(GemCartData[] gems) { }

	// RVA: 0x2179CE4 Offset: 0x2175CE4 VA: 0x2179CE4
	public GemCartData GetGemCart(long uuid) { }

	// RVA: 0x2179DC0 Offset: 0x2175DC0 VA: 0x2179DC0
	public GemCartData GetGemCart(short id) { }

	// RVA: 0x2179E9C Offset: 0x2175E9C VA: 0x2179E9C
	public GemCartEquipData[] GetEquipGemCarts() { }

	// RVA: 0x2179EEC Offset: 0x2175EEC VA: 0x2179EEC
	public GemCartData[] GetSortGemCarts() { }

	// RVA: 0x217A00C Offset: 0x217600C VA: 0x217A00C
	public GemCartEquipData[] GetSortEquipGemCarts() { }

	// RVA: 0x217A12C Offset: 0x217612C VA: 0x217A12C
	public List<GemCartData> GetReinforceSortGemCarts(int id) { }

	// RVA: 0x217A53C Offset: 0x217653C VA: 0x217A53C
	public short[] GetIDEquipGemCart() { }

	// RVA: 0x217A65C Offset: 0x217665C VA: 0x217A65C
	public void Update(GemCartData[] gems) { }

	// RVA: 0x217A6E4 Offset: 0x21766E4 VA: 0x217A6E4
	public void Update(GemCartData gem) { }

	// RVA: 0x217A8C8 Offset: 0x21768C8 VA: 0x217A8C8
	public List<UpdateGemCartData> UpdateEquip(GemCartEquipData[] gems) { }

	// RVA: 0x217AC64 Offset: 0x2176C64 VA: 0x217AC64
	public void UpdateEquip(GemCartEquipData gem) { }

	// RVA: 0x217AF08 Offset: 0x2176F08 VA: 0x217AF08
	public void InitializeBag(GemCartData[] gems) { }

	// RVA: 0x217B06C Offset: 0x217706C VA: 0x217B06C
	public void InitializeEquip(GemCartEquipData[] equips, byte slot) { }

	// RVA: 0x217B300 Offset: 0x2177300 VA: 0x217B300
	public void Equip(byte equipNo, long uuid) { }

	// RVA: 0x217B5F8 Offset: 0x21775F8 VA: 0x217B5F8
	public void Remove(long uuid) { }

	// RVA: 0x217B7A0 Offset: 0x21777A0 VA: 0x217B7A0
	public void ClearEquip() { }

	// RVA: 0x217B810 Offset: 0x2177810 VA: 0x217B810
	public bool Break(GemCartData gemCart) { }

	// RVA: 0x217B944 Offset: 0x2177944 VA: 0x217B944
	public void Reinforce(long[] deleteGemCartUidList, GemCartData updateGemCart, out UpdateGemCartData sourceGemCart) { }

	// RVA: 0x217BD7C Offset: 0x2177D7C VA: 0x217BD7C
	public void UpdateSlotCount(byte slot) { }

	// RVA: 0x217BD84 Offset: 0x2177D84 VA: 0x217BD84
	public void UpdateData(GemCartData updateGemCart) { }

	// RVA: 0x2179954 Offset: 0x2175954 VA: 0x2179954
	private void SortBag() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemBag // TypeDefIndex: 3781
{
	// Fields
	private List<StarGemData> bag; // 0x10
	private List<StarGemEquipData> equips; // 0x18
	private int capacity; // 0x20
	private StarGemData prevStarGemData; // 0x28

	// Properties
	public IList<StarGemData> Bag { get; }
	public int BagCount { get; }
	public int Capacity { get; }
	public StarGemData PrevStarGemData { get; }

	// Methods

	// RVA: 0x23E3674 Offset: 0x23DF674 VA: 0x23E3674
	public IList<StarGemData> get_Bag() { }

	// RVA: 0x23E36C4 Offset: 0x23DF6C4 VA: 0x23E36C4
	public int get_BagCount() { }

	// RVA: 0x23E370C Offset: 0x23DF70C VA: 0x23E370C
	public int get_Capacity() { }

	// RVA: 0x23E3714 Offset: 0x23DF714 VA: 0x23E3714
	public StarGemData get_PrevStarGemData() { }

	// RVA: 0x23E371C Offset: 0x23DF71C VA: 0x23E371C
	public void .ctor() { }

	// RVA: 0x23E38AC Offset: 0x23DF8AC VA: 0x23E38AC
	public void AddStarGem(StarGemData gem) { }

	// RVA: 0x23E3B18 Offset: 0x23DFB18 VA: 0x23E3B18
	public void AddStarGem(StarGemData[] gems) { }

	// RVA: 0x23E3CD4 Offset: 0x23DFCD4 VA: 0x23E3CD4
	public StarGemData GetStarGem(long uuid) { }

	// RVA: 0x23E3DB0 Offset: 0x23DFDB0 VA: 0x23E3DB0
	public StarGemData[] GetStarGems(short skillId) { }

	// RVA: 0x23E3EA8 Offset: 0x23DFEA8 VA: 0x23E3EA8
	public StarGemEquipData[] GetEquipStarGem() { }

	// RVA: 0x23E3EF8 Offset: 0x23DFEF8 VA: 0x23E3EF8
	public StarGemData[] GetSortEquipStarGem() { }

	// RVA: 0x23E4030 Offset: 0x23E0030 VA: 0x23E4030
	public StarGemEquipData[] GetSortEquipStarGems() { }

	// RVA: 0x23E4118 Offset: 0x23E0118 VA: 0x23E4118
	public short[] GetSkillIDEquipStarGem() { }

	// RVA: 0x23E4238 Offset: 0x23E0238 VA: 0x23E4238
	public void Update(StarGemData[] gems) { }

	// RVA: 0x23E42C0 Offset: 0x23E02C0 VA: 0x23E42C0
	public void Update(StarGemData gem) { }

	// RVA: 0x23E44A4 Offset: 0x23E04A4 VA: 0x23E44A4
	public void UpdateBag(StarGemData[] gems) { }

	// RVA: 0x23E4750 Offset: 0x23E0750 VA: 0x23E4750
	public void InitializeBag(StarGemData[] gems, int capacity) { }

	// RVA: 0x23E48C4 Offset: 0x23E08C4 VA: 0x23E48C4
	public void InitializeEquip(StarGemEquipData[] equips) { }

	// RVA: 0x23E4A78 Offset: 0x23E0A78 VA: 0x23E4A78
	public void Equip(StarGemEquipData gem) { }

	// RVA: 0x23E4B58 Offset: 0x23E0B58 VA: 0x23E4B58
	public void Equip(byte equipNo, long uuid) { }

	// RVA: 0x23E4E74 Offset: 0x23E0E74 VA: 0x23E4E74
	public void Remove(long uuid) { }

	// RVA: 0x23E5188 Offset: 0x23E1188 VA: 0x23E5188
	public void EquipUpdate(StarGemData gem) { }

	// RVA: 0x23E5398 Offset: 0x23E1398 VA: 0x23E5398
	public void ClearEquip() { }

	// RVA: 0x23E5408 Offset: 0x23E1408 VA: 0x23E5408
	public bool Break(StarGemData starGem) { }

	// RVA: 0x23E553C Offset: 0x23E153C VA: 0x23E553C
	public void Reinforce(StarGemData deleteStarGem, StarGemData updateStarGem, out StarGemData sourceStarGem) { }

	// RVA: 0x23E5900 Offset: 0x23E1900 VA: 0x23E5900
	public bool Evolution(StarGemData starGem, out StarGemData prevGem) { }

	// RVA: 0x23E5B20 Offset: 0x23E1B20 VA: 0x23E5B20
	public void Duplication(out StarGemData[] deleteGems) { }

	// RVA: 0x23E3970 Offset: 0x23DF970 VA: 0x23E3970
	private void SortBag() { }

	// RVA: 0x23E5DA4 Offset: 0x23E1DA4 VA: 0x23E5DA4
	private int OrderBySortId(SkillId skillId) { }

	[CompilerGenerated]
	// RVA: 0x23E5E10 Offset: 0x23E1E10 VA: 0x23E5E10
	private bool <GetSortEquipStarGem>b__18_0(StarGemData g) { }

	[CompilerGenerated]
	// RVA: 0x23E5F00 Offset: 0x23E1F00 VA: 0x23E5F00
	private int <GetSortEquipStarGem>b__18_1(StarGemData g) { }

	[CompilerGenerated]
	// RVA: 0x23E5F18 Offset: 0x23E1F18 VA: 0x23E5F18
	private int <GetSortEquipStarGems>b__19_0(StarGemEquipData eq) { }

	[CompilerGenerated]
	// RVA: 0x23E5F30 Offset: 0x23E1F30 VA: 0x23E5F30
	private int <SortBag>b__35_0(StarGemData s) { }
}

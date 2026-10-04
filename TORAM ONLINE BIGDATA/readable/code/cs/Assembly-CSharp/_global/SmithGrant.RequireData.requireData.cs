// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class SmithGrant.RequireData.requireData // TypeDefIndex: 8476
{
	// Fields
	private List<Pair<int, int>> RequireMaterial; // 0x10
	[CompilerGenerated]
	private int <MaterialLv>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Potential>k__BackingField; // 0x1C
	private BonusType bonusType; // 0x20
	[CompilerGenerated]
	private ElementType <ElementType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <BonusValue>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsFixed>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <FixedBonusValue>k__BackingField; // 0x30

	// Properties
	public int MaterialLv { get; set; }
	public int Potential { get; set; }
	public BonusType BonusType { get; set; }
	public ElementType ElementType { get; set; }
	public int BonusValue { get; set; }
	public bool IsFixed { get; set; }
	public int FixedBonusValue { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D80CB8 Offset: 0x1D7CCB8 VA: 0x1D80CB8
	public int get_MaterialLv() { }

	[CompilerGenerated]
	// RVA: 0x1D80CC0 Offset: 0x1D7CCC0 VA: 0x1D80CC0
	public void set_MaterialLv(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D80CC8 Offset: 0x1D7CCC8 VA: 0x1D80CC8
	public int get_Potential() { }

	[CompilerGenerated]
	// RVA: 0x1D80CD0 Offset: 0x1D7CCD0 VA: 0x1D80CD0
	public void set_Potential(int value) { }

	// RVA: 0x1D7BC68 Offset: 0x1D77C68 VA: 0x1D7BC68
	public BonusType get_BonusType() { }

	// RVA: 0x1D80CD8 Offset: 0x1D7CCD8 VA: 0x1D80CD8
	public void set_BonusType(BonusType value) { }

	[CompilerGenerated]
	// RVA: 0x1D80CE0 Offset: 0x1D7CCE0 VA: 0x1D80CE0
	public ElementType get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x1D80CE8 Offset: 0x1D7CCE8 VA: 0x1D80CE8
	public void set_ElementType(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x1D80CF0 Offset: 0x1D7CCF0 VA: 0x1D80CF0
	public int get_BonusValue() { }

	[CompilerGenerated]
	// RVA: 0x1D80CF8 Offset: 0x1D7CCF8 VA: 0x1D80CF8
	public void set_BonusValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D80D00 Offset: 0x1D7CD00 VA: 0x1D80D00
	public bool get_IsFixed() { }

	[CompilerGenerated]
	// RVA: 0x1D80D08 Offset: 0x1D7CD08 VA: 0x1D80D08
	private void set_IsFixed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D80D14 Offset: 0x1D7CD14 VA: 0x1D80D14
	public int get_FixedBonusValue() { }

	[CompilerGenerated]
	// RVA: 0x1D80D1C Offset: 0x1D7CD1C VA: 0x1D80D1C
	private void set_FixedBonusValue(int value) { }

	// RVA: 0x1D80128 Offset: 0x1D7C128 VA: 0x1D80128
	public void .ctor() { }

	// RVA: 0x1D7DE90 Offset: 0x1D79E90 VA: 0x1D7DE90
	public void SetMaterialData(int type, int lv, int num) { }

	// RVA: 0x1D80D24 Offset: 0x1D7CD24 VA: 0x1D80D24
	public void SetMaterialPoint(int type, int num) { }

	// RVA: 0x1D80DA0 Offset: 0x1D7CDA0 VA: 0x1D80DA0
	public Pair<int, int> GetMaterialData(int type) { }

	// RVA: 0x1D80E20 Offset: 0x1D7CE20 VA: 0x1D80E20
	public List<Pair<int, int>> GetMaterialDatas() { }

	// RVA: 0x1D80A58 Offset: 0x1D7CA58 VA: 0x1D80A58
	public List<int> GetMaterialNums() { }

	// RVA: 0x1D80C7C Offset: 0x1D7CC7C VA: 0x1D80C7C
	public void InitBonus(BonusType bonustype, int bonusValue, bool isFixed) { }

	// RVA: 0x1D802A0 Offset: 0x1D7C2A0 VA: 0x1D802A0
	public int GetPotential(IPlayerStatusCalculator secondaryStatus) { }

	// RVA: 0x1D7DD1C Offset: 0x1D79D1C VA: 0x1D7DD1C
	public void Reset() { }
}

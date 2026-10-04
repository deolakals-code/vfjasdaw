// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ItemUseData : UnityHashBase // TypeDefIndex: 13185
{
	// Fields
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsSavingTechnique>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 33)]
	public int ItemUuid { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public bool IsSavingTechnique { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C1E70 Offset: 0x36BDE70 VA: 0x36C1E70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36C1E78 Offset: 0x36BDE78 VA: 0x36C1E78
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x36C1E80 Offset: 0x36BDE80 VA: 0x36C1E80
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C1E88 Offset: 0x36BDE88 VA: 0x36C1E88
	public bool get_IsSavingTechnique() { }

	[CompilerGenerated]
	// RVA: 0x36C1E90 Offset: 0x36BDE90 VA: 0x36C1E90
	public void set_IsSavingTechnique(bool value) { }

	// RVA: 0x36C1E9C Offset: 0x36BDE9C VA: 0x36C1E9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C1EA4 Offset: 0x36BDEA4 VA: 0x36C1EA4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C20B0 Offset: 0x36BE0B0 VA: 0x36C20B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

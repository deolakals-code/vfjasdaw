// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public class GmEventData : UnityHashBase // TypeDefIndex: 11248
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsDropBonus>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsExpBonus>k__BackingField; // 0x25

	// Properties
	[UnityHash(Code = 60)]
	public int FieldId { get; set; }
	[UnityHash(Code = 184)]
	public int MonsterUuid { get; set; }
	public bool IsDropBonus { get; set; }
	public bool IsExpBonus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36CEEE4 Offset: 0x36CAEE4 VA: 0x36CEEE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36CEEEC Offset: 0x36CAEEC VA: 0x36CEEEC
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x36CEEF4 Offset: 0x36CAEF4 VA: 0x36CEEF4
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CEEFC Offset: 0x36CAEFC VA: 0x36CEEFC
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x36CEF04 Offset: 0x36CAF04 VA: 0x36CEF04
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CEF0C Offset: 0x36CAF0C VA: 0x36CEF0C
	public bool get_IsDropBonus() { }

	[CompilerGenerated]
	// RVA: 0x36CEF14 Offset: 0x36CAF14 VA: 0x36CEF14
	public void set_IsDropBonus(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36CEF20 Offset: 0x36CAF20 VA: 0x36CEF20
	public bool get_IsExpBonus() { }

	[CompilerGenerated]
	// RVA: 0x36CEF28 Offset: 0x36CAF28 VA: 0x36CEF28
	public void set_IsExpBonus(bool value) { }

	// RVA: 0x36CEF34 Offset: 0x36CAF34 VA: 0x36CEF34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36CEF3C Offset: 0x36CAF3C VA: 0x36CEF3C Slot: 3
	public override string ToString() { }

	// RVA: 0x36CF12C Offset: 0x36CB12C VA: 0x36CF12C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36CF348 Offset: 0x36CB348 VA: 0x36CF348 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

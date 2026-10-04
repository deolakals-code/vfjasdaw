// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Orbs
public class OrbBonusData : UnityHashBase // TypeDefIndex: 11143
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <TimeLeft>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 91)]
	public int ItemId { get; set; }
	[UnityHash(Code = 195, IsOptional = True)]
	public int Value { get; set; }
	[UnityHash(Code = 172, IsOptional = True)]
	public DateTime TimeLeft { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C8E24 Offset: 0x35C4E24 VA: 0x35C8E24
	public void .ctor() { }

	// RVA: 0x35C8E2C Offset: 0x35C4E2C VA: 0x35C8E2C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35C8E34 Offset: 0x35C4E34 VA: 0x35C8E34
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35C8E3C Offset: 0x35C4E3C VA: 0x35C8E3C
	protected void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C8E44 Offset: 0x35C4E44 VA: 0x35C8E44
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x35C8E4C Offset: 0x35C4E4C VA: 0x35C8E4C
	protected void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C8E54 Offset: 0x35C4E54 VA: 0x35C8E54
	public DateTime get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x35C8E5C Offset: 0x35C4E5C VA: 0x35C8E5C
	protected void set_TimeLeft(DateTime value) { }

	// RVA: 0x35C8E64 Offset: 0x35C4E64 VA: 0x35C8E64
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35C8F88 Offset: 0x35C4F88 VA: 0x35C8F88
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35C908C Offset: 0x35C508C VA: 0x35C908C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C9094 Offset: 0x35C5094 VA: 0x35C9094 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C9184 Offset: 0x35C5184 VA: 0x35C9184 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C938C Offset: 0x35C538C VA: 0x35C938C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

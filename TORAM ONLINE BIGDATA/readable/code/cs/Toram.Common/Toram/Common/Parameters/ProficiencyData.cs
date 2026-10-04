// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class ProficiencyData : UnityHashBase // TypeDefIndex: 11127
{
	// Fields
	[CompilerGenerated]
	private int <BlackSmith>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Alchemy>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 49)]
	public int BlackSmith { get; set; }
	[UnityHash(Code = 50)]
	public int Alchemy { get; set; }

	// Methods

	// RVA: 0x35C324C Offset: 0x35BF24C VA: 0x35C324C
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x35C3254 Offset: 0x35BF254 VA: 0x35C3254 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x35C325C Offset: 0x35BF25C VA: 0x35C325C
	public int get_BlackSmith() { }

	[CompilerGenerated]
	// RVA: 0x35C3264 Offset: 0x35BF264 VA: 0x35C3264
	public void set_BlackSmith(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C326C Offset: 0x35BF26C VA: 0x35C326C
	public int get_Alchemy() { }

	[CompilerGenerated]
	// RVA: 0x35C3274 Offset: 0x35BF274 VA: 0x35C3274
	public void set_Alchemy(int value) { }

	// RVA: 0x35C327C Offset: 0x35BF27C VA: 0x35C327C Slot: 3
	public override string ToString() { }

	// RVA: 0x35C331C Offset: 0x35BF31C VA: 0x35C331C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C34D0 Offset: 0x35BF4D0 VA: 0x35C34D0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

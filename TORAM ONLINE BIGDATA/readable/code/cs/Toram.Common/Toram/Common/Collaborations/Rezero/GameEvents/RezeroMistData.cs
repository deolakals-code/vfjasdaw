// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.Rezero.GameEvents
public class RezeroMistData : UnityHashBase // TypeDefIndex: 13059
{
	// Fields
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x19
	[CompilerGenerated]
	private List<short[]> <PositionList>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 200)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 213, IsOptional = True)]
	public List<short[]> PositionList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3699C1C Offset: 0x3695C1C VA: 0x3699C1C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3699C24 Offset: 0x3695C24 VA: 0x3699C24
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x3699C2C Offset: 0x3695C2C VA: 0x3699C2C
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3699C34 Offset: 0x3695C34 VA: 0x3699C34
	public List<short[]> get_PositionList() { }

	[CompilerGenerated]
	// RVA: 0x3699C3C Offset: 0x3695C3C VA: 0x3699C3C
	public void set_PositionList(List<short[]> value) { }

	// RVA: 0x3699C44 Offset: 0x3695C44 VA: 0x3699C44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3699C4C Offset: 0x3695C4C VA: 0x3699C4C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x369A0BC Offset: 0x36960BC VA: 0x369A0BC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

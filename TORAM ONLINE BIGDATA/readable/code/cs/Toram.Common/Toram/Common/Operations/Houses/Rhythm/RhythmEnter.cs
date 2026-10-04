// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Rhythm
public class RhythmEnter : OperationRequestBase // TypeDefIndex: 12213
{
	// Fields
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsEveryone>k__BackingField; // 0x24

	// Properties
	public int ObjId { get; set; }
	public bool IsEveryone { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E1CB4 Offset: 0x35DDCB4 VA: 0x35E1CB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E1CBC Offset: 0x35DDCBC VA: 0x35E1CBC
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x35E1CC4 Offset: 0x35DDCC4 VA: 0x35E1CC4
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E1CCC Offset: 0x35DDCCC VA: 0x35E1CCC
	public bool get_IsEveryone() { }

	[CompilerGenerated]
	// RVA: 0x35E1CD4 Offset: 0x35DDCD4 VA: 0x35E1CD4
	public void set_IsEveryone(bool value) { }

	// RVA: 0x35E1CE0 Offset: 0x35DDCE0 VA: 0x35E1CE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E1CE8 Offset: 0x35DDCE8 VA: 0x35E1CE8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E1CF0 Offset: 0x35DDCF0 VA: 0x35E1CF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E1E68 Offset: 0x35DDE68 VA: 0x35E1E68 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

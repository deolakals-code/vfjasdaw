// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobHateData : UnityHashBase // TypeDefIndex: 13172
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Hate>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 3)]
	public byte ArchetypeType { get; set; }
	[UnityHash(Code = 4)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 30)]
	public int Hate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BCFA8 Offset: 0x36B8FA8 VA: 0x36BCFA8
	public void .ctor() { }

	// RVA: 0x36BCFB0 Offset: 0x36B8FB0 VA: 0x36BCFB0
	public void .ctor(byte archetypeType, int archetypeId, int hate) { }

	[CompilerGenerated]
	// RVA: 0x36BCFEC Offset: 0x36B8FEC VA: 0x36BCFEC
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36BCFF4 Offset: 0x36B8FF4 VA: 0x36BCFF4
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BCFFC Offset: 0x36B8FFC VA: 0x36BCFFC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36BD004 Offset: 0x36B9004 VA: 0x36BD004
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BD00C Offset: 0x36B900C VA: 0x36BD00C
	public int get_Hate() { }

	[CompilerGenerated]
	// RVA: 0x36BD014 Offset: 0x36B9014 VA: 0x36BD014
	public void set_Hate(int value) { }

	// RVA: 0x36BD01C Offset: 0x36B901C VA: 0x36BD01C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BD024 Offset: 0x36B9024 VA: 0x36BD024 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BD234 Offset: 0x36B9234 VA: 0x36BD234 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobActionStartEventData : UnityHashBase // TypeDefIndex: 13165
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaMobResponseData <MobaMobData>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ActionPatternId>k__BackingField; // 0x30
	[CompilerGenerated]
	private short[] <TargetPosition>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <TargetRotation>k__BackingField; // 0x40
	[CompilerGenerated]
	private long[] <TargetArchetype>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <PersonaTargetArchetype>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte <AttackStartFlag>k__BackingField; // 0x58

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 20)]
	public MobResponseData MobData { get; set; }
	[UnityHash(Code = 98)]
	public MobaMobResponseData MobaMobData { get; set; }
	[UnityHash(Code = 29)]
	public short ActionPatternId { get; set; }
	[UnityHash(Code = 10, IsOptional = True)]
	public short[] TargetPosition { get; set; }
	[UnityHash(Code = 11, IsOptional = True)]
	public short TargetRotation { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public long[] TargetArchetype { get; set; }
	[UnityHash(Code = 89, IsOptional = True)]
	public long PersonaTargetArchetype { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public byte AttackStartFlag { get; set; }

	// Methods

	// RVA: 0x36BAF4C Offset: 0x36B6F4C VA: 0x36BAF4C
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36BAF54 Offset: 0x36B6F54 VA: 0x36BAF54 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36BAF5C Offset: 0x36B6F5C VA: 0x36BAF5C
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36BAF64 Offset: 0x36B6F64 VA: 0x36BAF64
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36BAF6C Offset: 0x36B6F6C VA: 0x36BAF6C
	public MobaMobResponseData get_MobaMobData() { }

	[CompilerGenerated]
	// RVA: 0x36BAF74 Offset: 0x36B6F74 VA: 0x36BAF74
	public void set_MobaMobData(MobaMobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36BAF7C Offset: 0x36B6F7C VA: 0x36BAF7C
	public short get_ActionPatternId() { }

	[CompilerGenerated]
	// RVA: 0x36BAF84 Offset: 0x36B6F84 VA: 0x36BAF84
	public void set_ActionPatternId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36BAF8C Offset: 0x36B6F8C VA: 0x36BAF8C
	public short[] get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x36BAF94 Offset: 0x36B6F94 VA: 0x36BAF94
	public void set_TargetPosition(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BAF9C Offset: 0x36B6F9C VA: 0x36BAF9C
	public short get_TargetRotation() { }

	[CompilerGenerated]
	// RVA: 0x36BAFA4 Offset: 0x36B6FA4 VA: 0x36BAFA4
	public void set_TargetRotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36BAFAC Offset: 0x36B6FAC VA: 0x36BAFAC
	public long[] get_TargetArchetype() { }

	[CompilerGenerated]
	// RVA: 0x36BAFB4 Offset: 0x36B6FB4 VA: 0x36BAFB4
	public void set_TargetArchetype(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BAFBC Offset: 0x36B6FBC VA: 0x36BAFBC
	public long get_PersonaTargetArchetype() { }

	[CompilerGenerated]
	// RVA: 0x36BAFC4 Offset: 0x36B6FC4 VA: 0x36BAFC4
	public void set_PersonaTargetArchetype(long value) { }

	[CompilerGenerated]
	// RVA: 0x36BAFCC Offset: 0x36B6FCC VA: 0x36BAFCC
	public byte get_AttackStartFlag() { }

	[CompilerGenerated]
	// RVA: 0x36BAFD4 Offset: 0x36B6FD4 VA: 0x36BAFD4
	public void set_AttackStartFlag(byte value) { }

	// RVA: 0x36BAFDC Offset: 0x36B6FDC VA: 0x36BAFDC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BB63C Offset: 0x36B763C VA: 0x36BB63C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

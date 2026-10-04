// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobActionStartData : UnityHashBase // TypeDefIndex: 13164
{
	// Fields
	[CompilerGenerated]
	private MobSendData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ActionPatternId>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <TargetPosition>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <TargetRotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private long[] <TargetArchetype>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <PersonaTargetArchetype>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <AttackStartFlag>k__BackingField; // 0x50

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 20)]
	public MobSendData MobData { get; set; }
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

	// RVA: 0x36BA6E8 Offset: 0x36B66E8 VA: 0x36BA6E8
	public void .ctor() { }

	// RVA: 0x36BA6F0 Offset: 0x36B66F0 VA: 0x36BA6F0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36BA6F8 Offset: 0x36B66F8 VA: 0x36BA6F8
	public MobSendData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36BA700 Offset: 0x36B6700 VA: 0x36BA700
	public void set_MobData(MobSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36BA708 Offset: 0x36B6708 VA: 0x36BA708
	public short get_ActionPatternId() { }

	[CompilerGenerated]
	// RVA: 0x36BA710 Offset: 0x36B6710 VA: 0x36BA710
	public void set_ActionPatternId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36BA718 Offset: 0x36B6718 VA: 0x36BA718
	public short[] get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x36BA720 Offset: 0x36B6720 VA: 0x36BA720
	public void set_TargetPosition(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BA728 Offset: 0x36B6728 VA: 0x36BA728
	public short get_TargetRotation() { }

	[CompilerGenerated]
	// RVA: 0x36BA730 Offset: 0x36B6730 VA: 0x36BA730
	public void set_TargetRotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36BA738 Offset: 0x36B6738 VA: 0x36BA738
	public long[] get_TargetArchetype() { }

	[CompilerGenerated]
	// RVA: 0x36BA740 Offset: 0x36B6740 VA: 0x36BA740
	public void set_TargetArchetype(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BA748 Offset: 0x36B6748 VA: 0x36BA748
	public long get_PersonaTargetArchetype() { }

	[CompilerGenerated]
	// RVA: 0x36BA750 Offset: 0x36B6750 VA: 0x36BA750
	public void set_PersonaTargetArchetype(long value) { }

	[CompilerGenerated]
	// RVA: 0x36BA758 Offset: 0x36B6758 VA: 0x36BA758
	public byte get_AttackStartFlag() { }

	[CompilerGenerated]
	// RVA: 0x36BA760 Offset: 0x36B6760 VA: 0x36BA760
	public void set_AttackStartFlag(byte value) { }

	// RVA: 0x36BA768 Offset: 0x36B6768 VA: 0x36BA768 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BACB4 Offset: 0x36B6CB4 VA: 0x36BACB4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

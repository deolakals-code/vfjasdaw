// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobAttackEventData : UnityHashBase // TypeDefIndex: 13162
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <AbnormalState>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <AbnormalStateTime>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <AbnormalValue>k__BackingField; // 0x2C
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 20)]
	public MobResponseData MobData { get; set; }
	[UnityHash(Code = 52, IsOptional = True)]
	public byte AbnormalState { get; set; }
	[UnityHash(Code = 53, IsOptional = True)]
	public short AbnormalStateTime { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public int AbnormalValue { get; set; }
	[UnityHash(Code = 21, IsOptional = True)]
	public MobResponseData[] MobList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B98FC Offset: 0x36B58FC VA: 0x36B98FC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B9904 Offset: 0x36B5904 VA: 0x36B9904
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36B990C Offset: 0x36B590C VA: 0x36B990C
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36B9914 Offset: 0x36B5914 VA: 0x36B9914
	public byte get_AbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36B991C Offset: 0x36B591C VA: 0x36B991C
	public void set_AbnormalState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B9924 Offset: 0x36B5924 VA: 0x36B9924
	public short get_AbnormalStateTime() { }

	[CompilerGenerated]
	// RVA: 0x36B992C Offset: 0x36B592C VA: 0x36B992C
	public void set_AbnormalStateTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B9934 Offset: 0x36B5934 VA: 0x36B9934
	public int get_AbnormalValue() { }

	[CompilerGenerated]
	// RVA: 0x36B993C Offset: 0x36B593C VA: 0x36B993C
	public void set_AbnormalValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B9944 Offset: 0x36B5944 VA: 0x36B9944
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36B994C Offset: 0x36B594C VA: 0x36B994C
	public void set_MobList(MobResponseData[] value) { }

	// RVA: 0x36B9954 Offset: 0x36B5954 VA: 0x36B9954 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B995C Offset: 0x36B595C VA: 0x36B995C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B9DB4 Offset: 0x36B5DB4 VA: 0x36B9DB4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

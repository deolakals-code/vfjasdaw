// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Data
public class BCollaborationRoomSyncData : RoomSyncDataBase // TypeDefIndex: 13080
{
	// Fields
	[CompilerGenerated]
	private bool <EntreeStagingFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <GameEnd>k__BackingField; // 0x29
	[CompilerGenerated]
	private int <TimeLeft>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <MaxHpCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x31
	[CompilerGenerated]
	private short <RetVal>k__BackingField; // 0x32
	[CompilerGenerated]
	private MobData <MobData>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 20)]
	public bool EntreeStagingFlag { get; set; }
	[UnityHash(Code = 41)]
	public byte GameEnd { get; set; }
	[UnityHash(Code = 28)]
	public int TimeLeft { get; set; }
	[UnityHash(Code = 10)]
	public byte MaxHpCount { get; set; }
	[UnityHash(Code = 11)]
	public byte CurrentHpCount { get; set; }
	[UnityHash(Code = 12, IsOptional = True)]
	public short RetVal { get; set; }
	[UnityHash(Code = 15, IsOptional = True)]
	public MobData MobData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x369EA9C Offset: 0x369AA9C VA: 0x369EA9C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369EAA4 Offset: 0x369AAA4 VA: 0x369EAA4
	public bool get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x369EAAC Offset: 0x369AAAC VA: 0x369EAAC
	public void set_EntreeStagingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x369EAB8 Offset: 0x369AAB8 VA: 0x369EAB8
	public byte get_GameEnd() { }

	[CompilerGenerated]
	// RVA: 0x369EAC0 Offset: 0x369AAC0 VA: 0x369EAC0
	public void set_GameEnd(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369EAC8 Offset: 0x369AAC8 VA: 0x369EAC8
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x369EAD0 Offset: 0x369AAD0 VA: 0x369EAD0
	public void set_TimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x369EAD8 Offset: 0x369AAD8 VA: 0x369EAD8
	public byte get_MaxHpCount() { }

	[CompilerGenerated]
	// RVA: 0x369EAE0 Offset: 0x369AAE0 VA: 0x369EAE0
	public void set_MaxHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369EAE8 Offset: 0x369AAE8 VA: 0x369EAE8
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x369EAF0 Offset: 0x369AAF0 VA: 0x369EAF0
	public void set_CurrentHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369EAF8 Offset: 0x369AAF8 VA: 0x369EAF8
	public short get_RetVal() { }

	[CompilerGenerated]
	// RVA: 0x369EB00 Offset: 0x369AB00 VA: 0x369EB00
	public void set_RetVal(short value) { }

	[CompilerGenerated]
	// RVA: 0x369EB08 Offset: 0x369AB08 VA: 0x369EB08
	public MobData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x369EB10 Offset: 0x369AB10 VA: 0x369EB10
	public void set_MobData(MobData value) { }

	// RVA: 0x369EB18 Offset: 0x369AB18 VA: 0x369EB18
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x369EC74 Offset: 0x369AC74 VA: 0x369EC74
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x369ED28 Offset: 0x369AD28 VA: 0x369ED28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369ED30 Offset: 0x369AD30 VA: 0x369ED30 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x369F0E4 Offset: 0x369B0E4 VA: 0x369F0E4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

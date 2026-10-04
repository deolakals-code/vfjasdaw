// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Defences
public class DefenceRoomSyncData : RoomSyncDataBase // TypeDefIndex: 11324
{
	// Fields
	[CompilerGenerated]
	private byte <EntreeStagingFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <GameEnd>k__BackingField; // 0x29
	[CompilerGenerated]
	private long <TimeLeft>k__BackingField; // 0x30
	[CompilerGenerated]
	private DefenceCrystalData[] <Crystals>k__BackingField; // 0x38
	[CompilerGenerated]
	private DefenceMobData[] <MobList>k__BackingField; // 0x40
	[CompilerGenerated]
	private DefenceScore <Score>k__BackingField; // 0x48

	// Properties
	[UnityHash(Code = 161, IsOptional = True)]
	public byte EntreeStagingFlag { get; set; }
	[UnityHash(Code = 141, IsOptional = True)]
	public byte GameEnd { get; set; }
	[UnityHash(Code = 172)]
	public long TimeLeft { get; set; }
	[UnityHash(Code = 199, IsOptional = True)]
	public DefenceCrystalData[] Crystals { get; set; }
	[UnityHash(Code = 89, IsOptional = True)]
	public DefenceMobData[] MobList { get; set; }
	[UnityHash(Code = 180, IsOptional = True)]
	public DefenceScore Score { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36DFD28 Offset: 0x36DBD28 VA: 0x36DFD28
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36DFD30 Offset: 0x36DBD30 VA: 0x36DFD30
	public byte get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x36DFD38 Offset: 0x36DBD38 VA: 0x36DFD38
	public void set_EntreeStagingFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DFD40 Offset: 0x36DBD40 VA: 0x36DFD40
	public byte get_GameEnd() { }

	[CompilerGenerated]
	// RVA: 0x36DFD48 Offset: 0x36DBD48 VA: 0x36DFD48
	public void set_GameEnd(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DFD50 Offset: 0x36DBD50 VA: 0x36DFD50
	public long get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36DFD58 Offset: 0x36DBD58 VA: 0x36DFD58
	public void set_TimeLeft(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DFD60 Offset: 0x36DBD60 VA: 0x36DFD60
	public DefenceCrystalData[] get_Crystals() { }

	[CompilerGenerated]
	// RVA: 0x36DFD68 Offset: 0x36DBD68 VA: 0x36DFD68
	public void set_Crystals(DefenceCrystalData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DFD70 Offset: 0x36DBD70 VA: 0x36DFD70
	public DefenceMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36DFD78 Offset: 0x36DBD78 VA: 0x36DFD78
	public void set_MobList(DefenceMobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DFD80 Offset: 0x36DBD80 VA: 0x36DFD80
	public DefenceScore get_Score() { }

	[CompilerGenerated]
	// RVA: 0x36DFD88 Offset: 0x36DBD88 VA: 0x36DFD88
	public void set_Score(DefenceScore value) { }

	// RVA: 0x36DFD90 Offset: 0x36DBD90 VA: 0x36DFD90
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36E0064 Offset: 0x36DC064 VA: 0x36E0064
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36E01D8 Offset: 0x36DC1D8 VA: 0x36E01D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36E01E0 Offset: 0x36DC1E0 VA: 0x36E01E0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36E0484 Offset: 0x36DC484 VA: 0x36E0484 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.Rezero.GameEvents
public class RezeroRoomSyncData : RoomSyncDataBase // TypeDefIndex: 13060
{
	// Fields
	[CompilerGenerated]
	private bool <EntreeStagingFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <GameEnd>k__BackingField; // 0x29
	[CompilerGenerated]
	private int <TimeLeft>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <TargetDamage>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TotalDamage>k__BackingField; // 0x34
	[CompilerGenerated]
	private RezeroBossData <MobData>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <RetVal>k__BackingField; // 0x40
	[CompilerGenerated]
	private RezeroMistData[] <MistList>k__BackingField; // 0x48
	[CompilerGenerated]
	private RezeroCrystalData <Crystal>k__BackingField; // 0x50

	// Properties
	[UnityHash(Code = 161)]
	public bool EntreeStagingFlag { get; set; }
	[UnityHash(Code = 141)]
	public byte GameEnd { get; set; }
	[UnityHash(Code = 172)]
	public int TimeLeft { get; set; }
	[UnityHash(Code = 199)]
	public int TargetDamage { get; set; }
	[UnityHash(Code = 180)]
	public int TotalDamage { get; set; }
	[UnityHash(Code = 89, IsOptional = True)]
	public RezeroBossData MobData { get; set; }
	[UnityHash(Code = 195, IsOptional = True)]
	public short RetVal { get; set; }
	[UnityHash(Code = 213, IsOptional = True)]
	public RezeroMistData[] MistList { get; set; }
	[UnityHash(Code = 76, IsOptional = True)]
	public RezeroCrystalData Crystal { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x369A5DC Offset: 0x36965DC VA: 0x369A5DC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369A5E4 Offset: 0x36965E4 VA: 0x369A5E4
	public bool get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x369A5EC Offset: 0x36965EC VA: 0x369A5EC
	public void set_EntreeStagingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x369A5F8 Offset: 0x36965F8 VA: 0x369A5F8
	public byte get_GameEnd() { }

	[CompilerGenerated]
	// RVA: 0x369A600 Offset: 0x3696600 VA: 0x369A600
	public void set_GameEnd(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369A608 Offset: 0x3696608 VA: 0x369A608
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x369A610 Offset: 0x3696610 VA: 0x369A610
	public void set_TimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x369A618 Offset: 0x3696618 VA: 0x369A618
	public int get_TargetDamage() { }

	[CompilerGenerated]
	// RVA: 0x369A620 Offset: 0x3696620 VA: 0x369A620
	public void set_TargetDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x369A628 Offset: 0x3696628 VA: 0x369A628
	public int get_TotalDamage() { }

	[CompilerGenerated]
	// RVA: 0x369A630 Offset: 0x3696630 VA: 0x369A630
	public void set_TotalDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x369A638 Offset: 0x3696638 VA: 0x369A638
	public RezeroBossData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x369A640 Offset: 0x3696640 VA: 0x369A640
	public void set_MobData(RezeroBossData value) { }

	[CompilerGenerated]
	// RVA: 0x369A648 Offset: 0x3696648 VA: 0x369A648
	public short get_RetVal() { }

	[CompilerGenerated]
	// RVA: 0x369A650 Offset: 0x3696650 VA: 0x369A650
	public void set_RetVal(short value) { }

	[CompilerGenerated]
	// RVA: 0x369A658 Offset: 0x3696658 VA: 0x369A658
	public RezeroMistData[] get_MistList() { }

	[CompilerGenerated]
	// RVA: 0x369A660 Offset: 0x3696660 VA: 0x369A660
	public void set_MistList(RezeroMistData[] value) { }

	[CompilerGenerated]
	// RVA: 0x369A668 Offset: 0x3696668 VA: 0x369A668
	public RezeroCrystalData get_Crystal() { }

	[CompilerGenerated]
	// RVA: 0x369A670 Offset: 0x3696670 VA: 0x369A670
	public void set_Crystal(RezeroCrystalData value) { }

	// RVA: 0x369A678 Offset: 0x3696678 VA: 0x369A678
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x369A970 Offset: 0x3696970 VA: 0x369A970
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x369AAD8 Offset: 0x3696AD8 VA: 0x369AAD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369AAE0 Offset: 0x3696AE0 VA: 0x369AAE0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x369AE94 Offset: 0x3696E94 VA: 0x369AE94 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

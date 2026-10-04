// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ItemDurationResponeData : UnityHashBase // TypeDefIndex: 13184
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <RemoveAbnormalState>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <RemoveAbnormalStateLocalId>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <DurationBonusType>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <DurationState>k__BackingField; // 0x3A

	// Properties
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	[UnityHash(Code = 52, IsOptional = True)]
	public byte[] RemoveAbnormalState { get; set; }
	public byte[] RemoveAbnormalStateLocalId { get; set; }
	[UnityHash(Code = 37)]
	public short DurationBonusType { get; set; }
	[UnityHash(Code = 58)]
	public byte DurationState { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C1848 Offset: 0x36BD848 VA: 0x36C1848
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C1850 Offset: 0x36BD850 VA: 0x36C1850
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36C1858 Offset: 0x36BD858 VA: 0x36C1858
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36C1860 Offset: 0x36BD860 VA: 0x36C1860
	public byte[] get_RemoveAbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36C1868 Offset: 0x36BD868 VA: 0x36C1868
	public void set_RemoveAbnormalState(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C1870 Offset: 0x36BD870 VA: 0x36C1870
	public byte[] get_RemoveAbnormalStateLocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C1878 Offset: 0x36BD878 VA: 0x36C1878
	public void set_RemoveAbnormalStateLocalId(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C1880 Offset: 0x36BD880 VA: 0x36C1880
	public short get_DurationBonusType() { }

	[CompilerGenerated]
	// RVA: 0x36C1888 Offset: 0x36BD888 VA: 0x36C1888
	public void set_DurationBonusType(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C1890 Offset: 0x36BD890 VA: 0x36C1890
	public byte get_DurationState() { }

	[CompilerGenerated]
	// RVA: 0x36C1898 Offset: 0x36BD898 VA: 0x36C1898
	public void set_DurationState(byte value) { }

	// RVA: 0x36C18A0 Offset: 0x36BD8A0 VA: 0x36C18A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C18A8 Offset: 0x36BD8A8 VA: 0x36C18A8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C1C84 Offset: 0x36BDC84 VA: 0x36C1C84 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomGroupSetting : UnityHashBase // TypeDefIndex: 11296
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <AreaLevel>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 43, IsOptional = True)]
	public byte Flag { get; set; }
	public bool IsForcibly { get; }
	[UnityHash(Code = 240)]
	public short AreaLevel { get; set; }
	[UnityHash(Code = 219)]
	public int GuildId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36D9F58 Offset: 0x36D5F58 VA: 0x36D9F58
	public void .ctor(short floorDepth, int guildId) { }

	// RVA: 0x36D9F8C Offset: 0x36D5F8C VA: 0x36D9F8C
	public void .ctor(bool isReinforce, short areaLevel) { }

	// RVA: 0x36D9FD4 Offset: 0x36D5FD4 VA: 0x36D9FD4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36D9FDC Offset: 0x36D5FDC VA: 0x36D9FDC
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36D9FE4 Offset: 0x36D5FE4 VA: 0x36D9FE4
	protected void set_Flag(byte value) { }

	// RVA: 0x36D9FEC Offset: 0x36D5FEC VA: 0x36D9FEC
	public bool get_IsForcibly() { }

	[CompilerGenerated]
	// RVA: 0x36D9FF8 Offset: 0x36D5FF8 VA: 0x36D9FF8
	public short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x36DA000 Offset: 0x36D6000 VA: 0x36DA000
	protected void set_AreaLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DA008 Offset: 0x36D6008 VA: 0x36DA008
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x36DA010 Offset: 0x36D6010 VA: 0x36DA010
	protected void set_GuildId(int value) { }

	// RVA: 0x36D9FC4 Offset: 0x36D5FC4 VA: 0x36D9FC4
	public void SetReinforce(bool isReinforce) { }

	// RVA: 0x36DA018 Offset: 0x36D6018 VA: 0x36DA018
	public void SetForcibly(bool isForcibly) { }

	// RVA: 0x36DA038 Offset: 0x36D6038 VA: 0x36DA038
	public bool SetAreaLevel(short areaLevel) { }

	// RVA: 0x36DA048 Offset: 0x36D6048 VA: 0x36DA048 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36DA050 Offset: 0x36D6050 VA: 0x36DA050 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DA344 Offset: 0x36D6344 VA: 0x36DA344 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

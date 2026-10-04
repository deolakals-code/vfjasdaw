// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class RemoveSkillBufferResponseData : UnityHashBase // TypeDefIndex: 13143
{
	// Fields
	[CompilerGenerated]
	private short[] <RemoveSkillBufferIds>k__BackingField; // 0x20
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28

	// Properties
	public short[] RemoveSkillBufferIds { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B21CC Offset: 0x36AE1CC VA: 0x36B21CC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B21D4 Offset: 0x36AE1D4 VA: 0x36B21D4
	public short[] get_RemoveSkillBufferIds() { }

	[CompilerGenerated]
	// RVA: 0x36B21DC Offset: 0x36AE1DC VA: 0x36B21DC
	public void set_RemoveSkillBufferIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B21E4 Offset: 0x36AE1E4 VA: 0x36B21E4
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36B21EC Offset: 0x36AE1EC VA: 0x36B21EC
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x36B21F4 Offset: 0x36AE1F4 VA: 0x36B21F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B21FC Offset: 0x36AE1FC VA: 0x36B21FC Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36B2320 Offset: 0x36AE320 VA: 0x36B2320 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

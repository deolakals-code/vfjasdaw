// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class EventMonsterDamageResponseData : UnityHashBase // TypeDefIndex: 13128
{
	// Fields
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x28

	// Properties
	public byte DamageId { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36ACA3C Offset: 0x36A8A3C VA: 0x36ACA3C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36ACA44 Offset: 0x36A8A44 VA: 0x36ACA44
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36ACA4C Offset: 0x36A8A4C VA: 0x36ACA4C
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36ACA54 Offset: 0x36A8A54 VA: 0x36ACA54
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36ACA5C Offset: 0x36A8A5C VA: 0x36ACA5C
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36ACA64 Offset: 0x36A8A64 VA: 0x36ACA64
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36ACA6C Offset: 0x36A8A6C VA: 0x36ACA6C
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x36ACA74 Offset: 0x36A8A74 VA: 0x36ACA74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36ACA7C Offset: 0x36A8A7C VA: 0x36ACA7C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36ACC10 Offset: 0x36A8C10 VA: 0x36ACC10 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class EventMobaAreaDamageData : UnityHashBase // TypeDefIndex: 13124
{
	// Fields
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x1C
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20

	// Properties
	public int Damage { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AB834 Offset: 0x36A7834 VA: 0x36AB834
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AB83C Offset: 0x36A783C VA: 0x36AB83C
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36AB844 Offset: 0x36A7844 VA: 0x36AB844
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AB84C Offset: 0x36A784C VA: 0x36AB84C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36AB854 Offset: 0x36A7854 VA: 0x36AB854
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x36AB85C Offset: 0x36A785C VA: 0x36AB85C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AB864 Offset: 0x36A7864 VA: 0x36AB864 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36AB9B8 Offset: 0x36A79B8 VA: 0x36AB9B8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

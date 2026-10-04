// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Roguelike
public class RoguelikeFixedDamageEvent : EventSubBase // TypeDefIndex: 12805
{
	// Fields
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28

	// Properties
	public MobResponseData[] MobList { get; set; }
	public int Damage { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365DD14 Offset: 0x3659D14 VA: 0x365DD14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365DD1C Offset: 0x3659D1C VA: 0x365DD1C
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365DD24 Offset: 0x3659D24 VA: 0x365DD24
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365DD2C Offset: 0x3659D2C VA: 0x365DD2C
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x365DD34 Offset: 0x3659D34 VA: 0x365DD34
	public void set_Damage(int value) { }

	// RVA: 0x365DD3C Offset: 0x3659D3C VA: 0x365DD3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365DD44 Offset: 0x3659D44 VA: 0x365DD44 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365DD4C Offset: 0x3659D4C VA: 0x365DD4C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365DE24 Offset: 0x3659E24 VA: 0x365DE24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

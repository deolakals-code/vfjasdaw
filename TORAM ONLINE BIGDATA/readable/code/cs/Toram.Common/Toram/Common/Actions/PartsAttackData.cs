// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class PartsAttackData : UnityHashBase // TypeDefIndex: 13118
{
	// Fields
	[CompilerGenerated]
	private MobSendData <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PartId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x2C

	// Properties
	[UnityHash(Code = 20)]
	public MobSendData Target { get; set; }
	[UnityHash(Code = 25)]
	public byte PartId { get; set; }
	[UnityHash(Code = 49)]
	public int Damage { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AA310 Offset: 0x36A6310 VA: 0x36AA310
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36AA318 Offset: 0x36A6318 VA: 0x36AA318
	public MobSendData get_Target() { }

	[CompilerGenerated]
	// RVA: 0x36AA320 Offset: 0x36A6320 VA: 0x36AA320
	public void set_Target(MobSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36AA328 Offset: 0x36A6328 VA: 0x36AA328
	public byte get_PartId() { }

	[CompilerGenerated]
	// RVA: 0x36AA330 Offset: 0x36A6330 VA: 0x36AA330
	public void set_PartId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AA338 Offset: 0x36A6338 VA: 0x36AA338
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36AA340 Offset: 0x36A6340 VA: 0x36AA340
	public void set_Damage(int value) { }

	// RVA: 0x36AA348 Offset: 0x36A6348 VA: 0x36AA348 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AA350 Offset: 0x36A6350 VA: 0x36AA350 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36AA5CC Offset: 0x36A65CC VA: 0x36AA5CC Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

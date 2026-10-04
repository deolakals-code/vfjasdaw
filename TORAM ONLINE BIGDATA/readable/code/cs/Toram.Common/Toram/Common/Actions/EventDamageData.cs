// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class EventDamageData : UnityHashBase // TypeDefIndex: 13182
{
	// Fields
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x21

	// Properties
	[UnityHash(Code = 50)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 49)]
	public int Damage { get; set; }
	[UnityHash(Code = 18)]
	public byte State { get; set; }
	[UnityHash(Code = 59)]
	public byte Flag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C1154 Offset: 0x36BD154 VA: 0x36C1154
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36C115C Offset: 0x36BD15C VA: 0x36C115C
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36C1164 Offset: 0x36BD164 VA: 0x36C1164
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C116C Offset: 0x36BD16C VA: 0x36C116C
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36C1174 Offset: 0x36BD174 VA: 0x36C1174
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C117C Offset: 0x36BD17C VA: 0x36C117C
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x36C1184 Offset: 0x36BD184 VA: 0x36C1184
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C118C Offset: 0x36BD18C VA: 0x36C118C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36C1194 Offset: 0x36BD194 VA: 0x36C1194
	public void set_Flag(byte value) { }

	// RVA: 0x36C119C Offset: 0x36BD19C VA: 0x36C119C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C11A4 Offset: 0x36BD1A4 VA: 0x36C11A4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C1410 Offset: 0x36BD410 VA: 0x36C1410 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

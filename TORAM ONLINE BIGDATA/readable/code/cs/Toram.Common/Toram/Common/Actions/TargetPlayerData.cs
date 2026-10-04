// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class TargetPlayerData : UnityHashBase // TypeDefIndex: 13210
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 3)]
	public byte ArchetypeType { get; set; }
	[UnityHash(Code = 4)]
	public int ArchetypeId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36E2310 Offset: 0x36DE310 VA: 0x36E2310
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36E2318 Offset: 0x36DE318 VA: 0x36E2318
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36E2320 Offset: 0x36DE320 VA: 0x36E2320
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36E2328 Offset: 0x36DE328 VA: 0x36E2328
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36E2330 Offset: 0x36DE330 VA: 0x36E2330
	public void set_ArchetypeId(int value) { }

	// RVA: 0x36E2338 Offset: 0x36DE338 VA: 0x36E2338 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36E2340 Offset: 0x36DE340 VA: 0x36E2340 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36E24EC Offset: 0x36DE4EC VA: 0x36E24EC Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

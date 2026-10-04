// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerBossPopEvent : EventSubBase // TypeDefIndex: 12699
{
	// Fields
	[CompilerGenerated]
	private byte <FieldType>k__BackingField; // 0x20
	[CompilerGenerated]
	private SummerBossData <BossData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public byte FieldType { get; set; }
	public SummerBossData BossData { get; set; }

	// Methods

	// RVA: 0x3644368 Offset: 0x3640368 VA: 0x3644368
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3644370 Offset: 0x3640370 VA: 0x3644370 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3644378 Offset: 0x3640378 VA: 0x3644378 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3644380 Offset: 0x3640380 VA: 0x3644380
	public byte get_FieldType() { }

	[CompilerGenerated]
	// RVA: 0x3644388 Offset: 0x3640388 VA: 0x3644388
	public void set_FieldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3644390 Offset: 0x3640390 VA: 0x3644390
	public SummerBossData get_BossData() { }

	[CompilerGenerated]
	// RVA: 0x3644398 Offset: 0x3640398 VA: 0x3644398
	public void set_BossData(SummerBossData value) { }

	// RVA: 0x36443A0 Offset: 0x36403A0 VA: 0x36443A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36445B4 Offset: 0x36405B4 VA: 0x36445B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

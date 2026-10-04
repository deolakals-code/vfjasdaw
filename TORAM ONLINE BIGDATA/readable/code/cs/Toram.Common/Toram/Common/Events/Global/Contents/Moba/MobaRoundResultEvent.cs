// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaRoundResultEvent : EventSubBase // TypeDefIndex: 12662
{
	// Fields
	[CompilerGenerated]
	private byte <Round>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaBattleRecordData <BattleRecord>k__BackingField; // 0x28

	// Properties
	public byte Round { get; set; }
	public MobaBattleRecordData BattleRecord { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363C954 Offset: 0x3638954 VA: 0x363C954
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363C95C Offset: 0x363895C VA: 0x363C95C
	public byte get_Round() { }

	[CompilerGenerated]
	// RVA: 0x363C964 Offset: 0x3638964 VA: 0x363C964
	public void set_Round(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363C96C Offset: 0x363896C VA: 0x363C96C
	public MobaBattleRecordData get_BattleRecord() { }

	[CompilerGenerated]
	// RVA: 0x363C974 Offset: 0x3638974 VA: 0x363C974
	public void set_BattleRecord(MobaBattleRecordData value) { }

	// RVA: 0x363C97C Offset: 0x363897C VA: 0x363C97C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363C984 Offset: 0x3638984 VA: 0x363C984 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363C98C Offset: 0x363898C VA: 0x363C98C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363CA50 Offset: 0x3638A50 VA: 0x363CA50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

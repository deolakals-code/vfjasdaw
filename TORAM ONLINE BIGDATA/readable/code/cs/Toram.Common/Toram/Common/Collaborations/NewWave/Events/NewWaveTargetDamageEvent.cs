// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveTargetDamageEvent : EventSubBase // TypeDefIndex: 13056
{
	// Fields
	[CompilerGenerated]
	private int <TargetHp>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x24

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 25)]
	public int TargetHp { get; set; }
	[PacketParameter(Code = 195)]
	public int Damage { get; set; }

	// Methods

	// RVA: 0x3699238 Offset: 0x3695238 VA: 0x3699238 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3699240 Offset: 0x3695240 VA: 0x3699240 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3699248 Offset: 0x3695248 VA: 0x3699248
	public int get_TargetHp() { }

	[CompilerGenerated]
	// RVA: 0x3699250 Offset: 0x3695250 VA: 0x3699250
	public void set_TargetHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3699258 Offset: 0x3695258 VA: 0x3699258
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x3699260 Offset: 0x3695260 VA: 0x3699260
	public void set_Damage(int value) { }

	// RVA: 0x3699268 Offset: 0x3695268 VA: 0x3699268
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3699270 Offset: 0x3695270 VA: 0x3699270
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3699274 Offset: 0x3695274 VA: 0x3699274
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3699278 Offset: 0x3695278 VA: 0x3699278 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36993E4 Offset: 0x36953E4 VA: 0x36993E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

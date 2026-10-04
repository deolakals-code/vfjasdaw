// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWavePopMobEvent : EventSubBase // TypeDefIndex: 13054
{
	// Fields
	[CompilerGenerated]
	private WaveMobData[] <MobList>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 89, IsOptional = True)]
	public WaveMobData[] MobList { get; set; }

	// Methods

	// RVA: 0x3698B50 Offset: 0x3694B50 VA: 0x3698B50 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3698B58 Offset: 0x3694B58 VA: 0x3698B58 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3698B60 Offset: 0x3694B60 VA: 0x3698B60
	public WaveMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3698B68 Offset: 0x3694B68 VA: 0x3698B68
	public void set_MobList(WaveMobData[] value) { }

	// RVA: 0x3698B70 Offset: 0x3694B70 VA: 0x3698B70
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698B78 Offset: 0x3694B78 VA: 0x3698B78
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698C78 Offset: 0x3694C78 VA: 0x3698C78
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698D04 Offset: 0x3694D04 VA: 0x3698D04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698D9C Offset: 0x3694D9C VA: 0x3698D9C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

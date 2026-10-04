// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Companions
public class PetLoginEvent : EventSubBase // TypeDefIndex: 12644
{
	// Fields
	[CompilerGenerated]
	private int <StrayMonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <StrayModelId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <StraySeedTime>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int StrayMonsterUuid { get; set; }
	public int StrayModelId { get; set; }
	public int StraySeedTime { get; set; }

	// Methods

	// RVA: 0x3638398 Offset: 0x3634398 VA: 0x3638398
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36383A0 Offset: 0x36343A0 VA: 0x36383A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36383A8 Offset: 0x36343A8 VA: 0x36383A8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36383B0 Offset: 0x36343B0 VA: 0x36383B0
	public int get_StrayMonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x36383B8 Offset: 0x36343B8 VA: 0x36383B8
	public void set_StrayMonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36383C0 Offset: 0x36343C0 VA: 0x36383C0
	public int get_StrayModelId() { }

	[CompilerGenerated]
	// RVA: 0x36383C8 Offset: 0x36343C8 VA: 0x36383C8
	public void set_StrayModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36383D0 Offset: 0x36343D0 VA: 0x36383D0
	public int get_StraySeedTime() { }

	[CompilerGenerated]
	// RVA: 0x36383D8 Offset: 0x36343D8 VA: 0x36383D8
	public void set_StraySeedTime(int value) { }

	// RVA: 0x36383E0 Offset: 0x36343E0 VA: 0x36383E0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36383E4 Offset: 0x36343E4 VA: 0x36383E4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36383E8 Offset: 0x36343E8 VA: 0x36383E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638598 Offset: 0x3634598 VA: 0x3638598 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

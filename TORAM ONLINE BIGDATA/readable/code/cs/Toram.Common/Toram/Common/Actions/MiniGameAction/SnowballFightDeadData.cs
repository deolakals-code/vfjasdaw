// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.MiniGameAction
public class SnowballFightDeadData : UnityHashBase // TypeDefIndex: 13229
{
	// Fields
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <TargetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private SnowballFightItemData <TransferItemData>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RemoveItemUid>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 4)]
	public int Uuid { get; set; }
	[UnityHash(Code = 22, IsOptional = True)]
	public int TargetUuid { get; set; }
	[UnityHash(Code = 35, IsOptional = True)]
	public SnowballFightItemData TransferItemData { get; set; }
	[UnityHash(Code = 33, IsOptional = True)]
	public byte RemoveItemUid { get; set; }
	public byte MiniGame { get; }

	// Methods

	// RVA: 0x36E6C8C Offset: 0x36E2C8C VA: 0x36E6C8C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36E6C94 Offset: 0x36E2C94 VA: 0x36E6C94
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x36E6C9C Offset: 0x36E2C9C VA: 0x36E6C9C
	public void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E6CA4 Offset: 0x36E2CA4 VA: 0x36E6CA4
	public int get_TargetUuid() { }

	[CompilerGenerated]
	// RVA: 0x36E6CAC Offset: 0x36E2CAC VA: 0x36E6CAC
	public void set_TargetUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E6CB4 Offset: 0x36E2CB4 VA: 0x36E6CB4
	public SnowballFightItemData get_TransferItemData() { }

	[CompilerGenerated]
	// RVA: 0x36E6CBC Offset: 0x36E2CBC VA: 0x36E6CBC
	public void set_TransferItemData(SnowballFightItemData value) { }

	[CompilerGenerated]
	// RVA: 0x36E6CC4 Offset: 0x36E2CC4 VA: 0x36E6CC4
	public byte get_RemoveItemUid() { }

	[CompilerGenerated]
	// RVA: 0x36E6CCC Offset: 0x36E2CCC VA: 0x36E6CCC
	public void set_RemoveItemUid(byte value) { }

	// RVA: 0x36E6CD4 Offset: 0x36E2CD4 VA: 0x36E6CD4 Slot: 7
	public byte get_MiniGame() { }

	// RVA: 0x36E6CDC Offset: 0x36E2CDC VA: 0x36E6CDC
	public void .ctor() { }

	// RVA: 0x36E6CE4 Offset: 0x36E2CE4 VA: 0x36E6CE4
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36E6CEC Offset: 0x36E2CEC VA: 0x36E6CEC Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36E6F4C Offset: 0x36E2F4C VA: 0x36E6F4C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

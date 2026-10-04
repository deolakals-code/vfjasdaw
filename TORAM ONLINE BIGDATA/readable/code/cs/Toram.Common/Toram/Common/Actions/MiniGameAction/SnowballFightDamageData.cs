// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.MiniGameAction
public class SnowballFightDamageData : UnityHashBase // TypeDefIndex: 13228
{
	// Fields
	[CompilerGenerated]
	private int <BallNo>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ThrowAvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <DamageAvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28
	[CompilerGenerated]
	private SnowballFightItemData <TransferItemData>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <RemoveItemUid>k__BackingField; // 0x38
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x40

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 33)]
	public int BallNo { get; set; }
	[UnityHash(Code = 4)]
	public int ThrowAvatarUuid { get; set; }
	[UnityHash(Code = 50)]
	public int DamageAvatarUuid { get; set; }
	[UnityHash(Code = 59)]
	public byte Flag { get; set; }
	[UnityHash(Code = 35, IsOptional = True)]
	public SnowballFightItemData TransferItemData { get; set; }
	[UnityHash(Code = 18, IsOptional = True)]
	public byte RemoveItemUid { get; set; }
	public byte MiniGame { get; }
	public short[] Position { get; set; }

	// Methods

	// RVA: 0x36E6458 Offset: 0x36E2458 VA: 0x36E6458 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36E6460 Offset: 0x36E2460 VA: 0x36E6460
	public int get_BallNo() { }

	[CompilerGenerated]
	// RVA: 0x36E6468 Offset: 0x36E2468 VA: 0x36E6468
	public void set_BallNo(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E6470 Offset: 0x36E2470 VA: 0x36E6470
	public int get_ThrowAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36E6478 Offset: 0x36E2478 VA: 0x36E6478
	public void set_ThrowAvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E6480 Offset: 0x36E2480 VA: 0x36E6480
	public int get_DamageAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36E6488 Offset: 0x36E2488 VA: 0x36E6488
	public void set_DamageAvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E6490 Offset: 0x36E2490 VA: 0x36E6490
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36E6498 Offset: 0x36E2498 VA: 0x36E6498
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36E64A0 Offset: 0x36E24A0 VA: 0x36E64A0
	public SnowballFightItemData get_TransferItemData() { }

	[CompilerGenerated]
	// RVA: 0x36E64A8 Offset: 0x36E24A8 VA: 0x36E64A8
	public void set_TransferItemData(SnowballFightItemData value) { }

	[CompilerGenerated]
	// RVA: 0x36E64B0 Offset: 0x36E24B0 VA: 0x36E64B0
	public byte get_RemoveItemUid() { }

	[CompilerGenerated]
	// RVA: 0x36E64B8 Offset: 0x36E24B8 VA: 0x36E64B8
	public void set_RemoveItemUid(byte value) { }

	// RVA: 0x36E64C0 Offset: 0x36E24C0 VA: 0x36E64C0 Slot: 7
	public byte get_MiniGame() { }

	[CompilerGenerated]
	// RVA: 0x36E64C8 Offset: 0x36E24C8 VA: 0x36E64C8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E64D0 Offset: 0x36E24D0 VA: 0x36E64D0
	public void set_Position(short[] value) { }

	// RVA: 0x36E64D8 Offset: 0x36E24D8 VA: 0x36E64D8
	public void .ctor() { }

	// RVA: 0x36E64E0 Offset: 0x36E24E0 VA: 0x36E64E0
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36E64E8 Offset: 0x36E24E8 VA: 0x36E64E8 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36E67DC Offset: 0x36E27DC VA: 0x36E67DC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}

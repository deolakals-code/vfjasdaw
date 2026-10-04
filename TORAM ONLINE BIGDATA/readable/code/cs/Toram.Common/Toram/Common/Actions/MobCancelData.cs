// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobCancelData : UnityHashBase, IMobIdData // TypeDefIndex: 13168
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ActionPatternId>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 22)]
	public int MobId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 24)]
	public int UniqueId { get; set; }
	[UnityHash(Code = 29)]
	public short ActionPatternId { get; set; }

	// Methods

	// RVA: 0x36BC144 Offset: 0x36B8144 VA: 0x36BC144
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36BC14C Offset: 0x36B814C VA: 0x36BC14C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36BC154 Offset: 0x36B8154 VA: 0x36BC154 Slot: 7
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36BC15C Offset: 0x36B815C VA: 0x36BC15C
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BC164 Offset: 0x36B8164 VA: 0x36BC164 Slot: 8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36BC16C Offset: 0x36B816C VA: 0x36BC16C
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BC174 Offset: 0x36B8174 VA: 0x36BC174 Slot: 9
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36BC17C Offset: 0x36B817C VA: 0x36BC17C
	public void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BC184 Offset: 0x36B8184 VA: 0x36BC184
	public short get_ActionPatternId() { }

	[CompilerGenerated]
	// RVA: 0x36BC18C Offset: 0x36B818C VA: 0x36BC18C
	public void set_ActionPatternId(short value) { }

	// RVA: 0x36BC194 Offset: 0x36B8194 VA: 0x36BC194 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BC414 Offset: 0x36B8414 VA: 0x36BC414 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}

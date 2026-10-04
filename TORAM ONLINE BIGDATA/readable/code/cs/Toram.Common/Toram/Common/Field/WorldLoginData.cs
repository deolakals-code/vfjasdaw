// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Field
public class WorldLoginData : BinaryBase // TypeDefIndex: 11200
{
	// Fields
	[CompilerGenerated]
	private byte <WorldType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LoginState>k__BackingField; // 0x20

	// Properties
	public byte WorldType { get; set; }
	public int WorldId { get; set; }
	public byte LoginState { get; set; }

	// Methods

	// RVA: 0x35D7224 Offset: 0x35D3224 VA: 0x35D7224
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35D722C Offset: 0x35D322C VA: 0x35D722C
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x35D7234 Offset: 0x35D3234 VA: 0x35D7234
	public void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D723C Offset: 0x35D323C VA: 0x35D723C
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x35D7244 Offset: 0x35D3244 VA: 0x35D7244
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D724C Offset: 0x35D324C VA: 0x35D724C
	public byte get_LoginState() { }

	[CompilerGenerated]
	// RVA: 0x35D7254 Offset: 0x35D3254 VA: 0x35D7254
	public void set_LoginState(byte value) { }

	// RVA: 0x35D725C Offset: 0x35D325C VA: 0x35D725C Slot: 3
	public override string ToString() { }

	// RVA: 0x35D7318 Offset: 0x35D3318 VA: 0x35D7318 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D7438 Offset: 0x35D3438 VA: 0x35D7438 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}

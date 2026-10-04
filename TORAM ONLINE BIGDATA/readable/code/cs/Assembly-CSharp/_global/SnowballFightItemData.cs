// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballFightItemData // TypeDefIndex: 4499
{
	// Fields
	public const float DefaultEffectTime = 30;
	private float leftTime; // 0x10
	[CompilerGenerated]
	private int <Uid>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x1A

	// Properties
	public int Uid { get; set; }
	public byte Type { get; set; }
	public bool IsValid { get; set; }
	public bool IsEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25072CC Offset: 0x25032CC VA: 0x25072CC
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x25072D4 Offset: 0x25032D4 VA: 0x25072D4
	private void set_Uid(int value) { }

	[CompilerGenerated]
	// RVA: 0x25072DC Offset: 0x25032DC VA: 0x25072DC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x25072E4 Offset: 0x25032E4 VA: 0x25072E4
	private void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x25072EC Offset: 0x25032EC VA: 0x25072EC
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x25072F4 Offset: 0x25032F4 VA: 0x25072F4
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2507300 Offset: 0x2503300 VA: 0x2507300
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x2507308 Offset: 0x2503308 VA: 0x2507308
	private void set_IsEnd(bool value) { }

	// RVA: 0x2507314 Offset: 0x2503314 VA: 0x2507314
	public void .ctor(int uid, byte type) { }

	// RVA: 0x2505AEC Offset: 0x2501AEC VA: 0x2505AEC
	public void Update() { }

	// RVA: 0x2505B74 Offset: 0x2501B74 VA: 0x2505B74
	public void Start(float time) { }

	// RVA: 0x2507348 Offset: 0x2503348 VA: 0x2507348
	public void End() { }

	// RVA: 0x2505C1C Offset: 0x2501C1C VA: 0x2505C1C
	public void Invalid() { }
}

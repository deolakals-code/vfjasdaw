// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkullShakerDebuff : MobBuffBase // TypeDefIndex: 861
{
	// Fields
	private const byte maxCount = 10;
	private byte count; // 0x25

	// Properties
	public override MobBuffId Id { get; }

	// Methods

	// RVA: 0x1ECFEA8 Offset: 0x1ECBEA8 VA: 0x1ECFEA8 Slot: 4
	public override MobBuffId get_Id() { }

	// RVA: 0x1ECFEB0 Offset: 0x1ECBEB0 VA: 0x1ECFEB0
	public void .ctor(int count) { }

	// RVA: 0x1ECFCC8 Offset: 0x1ECBCC8 VA: 0x1ECFCC8
	public void .ctor(MobBuffData buffData) { }

	// RVA: 0x1ECFF2C Offset: 0x1ECBF2C VA: 0x1ECFF2C Slot: 7
	public override int GetValue() { }

	// RVA: 0x1ECFF34 Offset: 0x1ECBF34 VA: 0x1ECFF34 Slot: 8
	public override MobBuffData GetSendData() { }
}

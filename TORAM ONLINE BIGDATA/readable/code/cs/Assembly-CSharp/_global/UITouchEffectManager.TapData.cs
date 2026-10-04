// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UITouchEffectManager.TapData // TypeDefIndex: 9052
{
	// Fields
	public Vector3 Position; // 0x10
	public float Scale; // 0x1C
	public UITouchEffectManager.TapData.FadeState State; // 0x20
	private bool isMiss; // 0x24
	[CompilerGenerated]
	private int <TapId>k__BackingField; // 0x28
	private byte lastUpdateFrame; // 0x2C

	// Properties
	public int TapId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EA3CA4 Offset: 0x1E9FCA4 VA: 0x1EA3CA4
	public int get_TapId() { }

	[CompilerGenerated]
	// RVA: 0x1EA3CAC Offset: 0x1E9FCAC VA: 0x1EA3CAC
	private void set_TapId(int value) { }

	// RVA: 0x1EA3938 Offset: 0x1E9F938 VA: 0x1EA3938
	public bool Initialize(int tapId, Vector3 pos, byte frame, bool isMiss) { }

	// RVA: 0x1EA38F8 Offset: 0x1E9F8F8 VA: 0x1EA38F8
	public void Trace(Vector3 pos, float deltaTime, byte frame) { }

	// RVA: 0x1EA38AC Offset: 0x1E9F8AC VA: 0x1EA38AC
	public void Update(float deltaTime, byte frame) { }

	// RVA: 0x1EA32B4 Offset: 0x1E9F2B4 VA: 0x1EA32B4
	public void .ctor() { }
}

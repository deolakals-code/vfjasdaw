// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIIruna2DragPinch.TounchData // TypeDefIndex: 104
{
	// Fields
	[CompilerGenerated]
	private int <TounchId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Vector2 <FirstPosition>k__BackingField; // 0x14
	public Vector2 LastPosition; // 0x1C
	private Vector2 oldFirstDelta; // 0x24

	// Properties
	public int TounchId { get; set; }
	public Vector2 FirstPosition { get; set; }
	public Vector2 NormalFirstDelta { get; }
	public Vector2 ModelCameratDelta { get; }
	public Vector2 Delta { get; }

	// Methods

	// RVA: 0x1ED8BD4 Offset: 0x1ED4BD4 VA: 0x1ED8BD4
	public void .ctor(Vector2 firstPosition, int tounchId) { }

	[CompilerGenerated]
	// RVA: 0x1ED9348 Offset: 0x1ED5348 VA: 0x1ED9348
	private void set_TounchId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ED9350 Offset: 0x1ED5350 VA: 0x1ED9350
	public int get_TounchId() { }

	[CompilerGenerated]
	// RVA: 0x1ED9358 Offset: 0x1ED5358 VA: 0x1ED9358
	private void set_FirstPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1ED9360 Offset: 0x1ED5360 VA: 0x1ED9360
	public Vector2 get_FirstPosition() { }

	// RVA: 0x1ED9368 Offset: 0x1ED5368 VA: 0x1ED9368
	public Vector2 get_NormalFirstDelta() { }

	// RVA: 0x1ED8518 Offset: 0x1ED4518 VA: 0x1ED8518
	public Vector2 get_ModelCameratDelta() { }

	// RVA: 0x1ED8670 Offset: 0x1ED4670 VA: 0x1ED8670
	public Vector2 get_Delta() { }

	// RVA: 0x1ED9254 Offset: 0x1ED5254 VA: 0x1ED9254
	public void LateUpdate() { }
}

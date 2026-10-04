// Assembly: UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch // TypeDefIndex: 17765
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; }
	public Vector2 rawPosition { get; }
	public Vector2 deltaPosition { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public TouchType type { get; }
	public float radius { get; }

	// Methods

	// RVA: 0x381659C Offset: 0x381259C VA: 0x381659C
	public int get_fingerId() { }

	// RVA: 0x38165A4 Offset: 0x38125A4 VA: 0x38165A4
	public Vector2 get_position() { }

	// RVA: 0x38165AC Offset: 0x38125AC VA: 0x38165AC
	public Vector2 get_rawPosition() { }

	// RVA: 0x38165B4 Offset: 0x38125B4 VA: 0x38165B4
	public Vector2 get_deltaPosition() { }

	// RVA: 0x38165BC Offset: 0x38125BC VA: 0x38165BC
	public int get_tapCount() { }

	// RVA: 0x38165C4 Offset: 0x38125C4 VA: 0x38165C4
	public TouchPhase get_phase() { }

	// RVA: 0x38165CC Offset: 0x38125CC VA: 0x38165CC
	public TouchType get_type() { }

	// RVA: 0x38165D4 Offset: 0x38125D4 VA: 0x38165D4
	public float get_radius() { }
}

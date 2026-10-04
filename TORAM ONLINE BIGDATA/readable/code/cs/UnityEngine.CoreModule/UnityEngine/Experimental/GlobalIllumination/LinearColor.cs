// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LinearColor // TypeDefIndex: 16667
{
	// Fields
	private float m_red; // 0x0
	private float m_green; // 0x4
	private float m_blue; // 0x8
	private float m_intensity; // 0xC

	// Properties
	public float red { get; set; }
	public float green { get; set; }
	public float blue { get; set; }

	// Methods

	// RVA: 0x37FD694 Offset: 0x37F9694 VA: 0x37FD694
	public float get_red() { }

	// RVA: 0x37FD69C Offset: 0x37F969C VA: 0x37FD69C
	public void set_red(float value) { }

	// RVA: 0x37FD748 Offset: 0x37F9748 VA: 0x37FD748
	public float get_green() { }

	// RVA: 0x37FD750 Offset: 0x37F9750 VA: 0x37FD750
	public void set_green(float value) { }

	// RVA: 0x37FD7FC Offset: 0x37F97FC VA: 0x37FD7FC
	public float get_blue() { }

	// RVA: 0x37FD804 Offset: 0x37F9804 VA: 0x37FD804
	public void set_blue(float value) { }

	// RVA: 0x37FD8B0 Offset: 0x37F98B0 VA: 0x37FD8B0
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x37FDBF8 Offset: 0x37F9BF8 VA: 0x37FDBF8
	public static LinearColor Black() { }
}

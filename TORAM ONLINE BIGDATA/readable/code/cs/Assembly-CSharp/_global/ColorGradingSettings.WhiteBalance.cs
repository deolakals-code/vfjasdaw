// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public struct ColorGradingSettings.WhiteBalance // TypeDefIndex: 4658
{
	// Fields
	[Tooltip("色温度 [ 0 ]")]
	[Range(-100, 100)]
	public float temperature; // 0x0
	[Tooltip("色合い [ 0 ]")]
	[Range(-100, 100)]
	public float tint; // 0x4
	[Tooltip("影響力 [ 100% ]")]
	[Range(0, 150)]
	public float power; // 0x8
}

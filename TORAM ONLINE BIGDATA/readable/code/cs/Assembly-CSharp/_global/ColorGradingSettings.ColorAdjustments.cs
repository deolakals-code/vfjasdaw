// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public struct ColorGradingSettings.ColorAdjustments // TypeDefIndex: 4657
{
	// Fields
	[Range(0, 10)]
	[Tooltip("露出 [ 0 ]")]
	public float exposure; // 0x0
	[Range(-100, 100)]
	[Tooltip("コントラスト [ 0 ]")]
	public float contrast; // 0x4
	[Tooltip("色味 [ white ]")]
	public Color filter; // 0x8
	[Range(-100, 100)]
	[Tooltip("彩度 [ 0 ]")]
	public float saturation; // 0x18
}

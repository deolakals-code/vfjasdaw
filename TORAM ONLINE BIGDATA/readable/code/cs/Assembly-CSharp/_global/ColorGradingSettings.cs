// Assembly: Assembly-CSharp.dll
// Namespace: 
[CreateAssetMenu(fileName = "New ColorGradingSettings", menuName = "ScriptableObjects/ColorGradingSettings", order = 1)]
public class ColorGradingSettings : ScriptableObject // TypeDefIndex: 4660
{
	// Fields
	[Tooltip("露出・彩度・色相・色味の調整")]
	public bool useColorAdjustments; // 0x18
	public ColorGradingSettings.ColorAdjustments caParam; // 0x1C
	[Tooltip("ホワイトバランスの調整")]
	public bool useWhiteBalance; // 0x38
	public ColorGradingSettings.WhiteBalance wbParam; // 0x3C
	[Tooltip("チャンネルミキサー")]
	public bool useChannelMixer; // 0x48
	public ColorGradingSettings.ChannelMixer cmParam; // 0x4C

	// Methods

	// RVA: 0x2587AD4 Offset: 0x2583AD4 VA: 0x2587AD4
	public void .ctor() { }
}

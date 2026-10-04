// Assembly: System.dll
// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal // TypeDefIndex: 14553
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14

	// Properties
	internal static SettingsSectionInternal Section { get; }
	internal bool Ipv6Enabled { get; }

	// Methods

	// RVA: 0x344D024 Offset: 0x3449024 VA: 0x344D024
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x344D07C Offset: 0x344907C VA: 0x344D07C
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x344D084 Offset: 0x3449084 VA: 0x344D084
	public void .ctor() { }

	// RVA: 0x344D09C Offset: 0x344909C VA: 0x344D09C
	private static void .cctor() { }
}

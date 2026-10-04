// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public class AuthResponse // TypeDefIndex: 16811
{
	// Fields
	private readonly string _authCode; // 0x10
	private readonly List<AuthScope> _grantedScopes; // 0x18

	// Methods

	// RVA: 0x2E12CD0 Offset: 0x2E0ECD0 VA: 0x2E12CD0
	public void .ctor(string authCode, List<AuthScope> grantedScopes) { }

	// RVA: 0x2E31E38 Offset: 0x2E2DE38 VA: 0x2E31E38
	public List<AuthScope> GetGrantedScopes() { }

	// RVA: 0x2E31E40 Offset: 0x2E2DE40 VA: 0x2E31E40
	public string GetAuthCode() { }

	// RVA: 0x2E31E48 Offset: 0x2E2DE48 VA: 0x2E31E48 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E31F78 Offset: 0x2E2DF78 VA: 0x2E31F78 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E31FEC Offset: 0x2E2DFEC VA: 0x2E31FEC Slot: 3
	public override string ToString() { }
}

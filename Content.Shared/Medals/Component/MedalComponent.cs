using Robust.Shared.Audio;
using Robust.Shared.Prototypes;

namespace Content.Shared.Medals.Components;

[RegisterComponent, NetworkedComponent]
public sealed class MedalComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("implantAction")]
    public string? MedalSwagAction;


}

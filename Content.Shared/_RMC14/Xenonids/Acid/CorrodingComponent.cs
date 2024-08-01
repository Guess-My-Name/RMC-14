using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared._RMC14.Xenonids.Acid;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, AutoGenerateComponentPause]
[Access(typeof(XenoAcidSystem))]
public sealed partial class CorrodingComponent : Component
{
    [DataField, AutoNetworkedField]
    public EntityUid Acid;

    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer)), AutoNetworkedField, AutoPausedField]
    public TimeSpan CorrodesAt;

    [DataField, AutoNetworkedField]
    public TimeSpan StartedAt;

    [DataField, AutoNetworkedField]
    public TimeSpan TimeToCorrode;

    [DataField, AutoNetworkedField]
    public AcidStrength Strength = AcidStrength.Normal;
}

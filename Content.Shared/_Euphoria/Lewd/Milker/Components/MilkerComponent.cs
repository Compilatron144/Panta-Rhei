using Content.Shared.FixedPoint;
using Content.Shared.Whitelist;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;
using Robust.Shared.GameStates;
using Robust.Shared.Utility;
using System.Numerics;

namespace Content.Shared._Floof.Lewd.Milker;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class MilkerComponent : Component
{
    [DataField, AutoNetworkedField]
    public EntityUid? MilkedEntity; // Entity being milked
    [DataField]
    public EntityWhitelist MilkedEntityWhitelist; // Whitelist for valid milkable entities
    [DataField]
    public TimeSpan AttachDelay = TimeSpan.FromSeconds(5); // Delay to attach an entity
    [DataField]
    public string? MilkedSolution; // Solution of entity being milked
    [DataField]
    public string[] MilkedSolutionWhitelist = ["breasts", "udder"];
    [DataField]
    public FixedPoint2 MilkedAmount = 10; // Amount to be milked
    [DataField]
    public string PopupDataset;
    [DataField]
    public double PopupChance = 0.25;
    [DataField]
    public TimeSpan UpdateDelay = TimeSpan.FromSeconds(5);
    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    public TimeSpan NextUpdate = TimeSpan.FromSeconds(0);
    [DataField]
    public string Solution = "tank"; // Solution for fluids to be transfered too
    [DataField]
    public SpriteSpecifier TubeSprite = default!; // Sprite for the connection tube
    [DataField]
    public double TubeLength = 5; // Maximum length of the tube
    [DataField]
    public Vector2 TubeOffsetSource, TubeOffsetTarget = Vector2.Zero;
    public const string VisualsContainerName = "tube-visuals";
}

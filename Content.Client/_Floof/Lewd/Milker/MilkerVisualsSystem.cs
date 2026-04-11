using Content.Client.Physics;
using Robust.Client.Graphics;

namespace Content.Client._Floof.Lewd.Milker;

public sealed class MilkerVisualsSystem : EntitySystem
{
    [Dependency] private readonly IOverlayManager _overlay = default!;

    public override void Initialize()
    {
        base.Initialize();
        _overlay.AddOverlay(new MilkerVisualsOverlay(EntityManager));
    }

    public override void Shutdown()
    {
        base.Shutdown();
        _overlay.RemoveOverlay<MilkerVisualsOverlay>();
    }
}

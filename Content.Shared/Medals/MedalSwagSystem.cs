namespace Content.Shared.Medals;

public abstract class MedalSwagSystem : EntitySystem

{

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<MedalSwagComponent, MedalSwagEvent>(OnMedalSwag);
    }

    private void OnMedalSwag(EntityUid uid, MedalComponent component)
    {
        if (args.Neck == null)
            return;

        
    }













}

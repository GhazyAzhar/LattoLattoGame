using System;
using GoogleMobileAds.Api.Mediation;

public abstract class AmazonMediationExtras : MediationExtras {
    public const string AllPlacementsKey = "all_placements";

    public const string UserIdKey = "user_id";

    public const string SoundEnabledKey = "sound_enabled";

    public AmazonMediationExtras () : base () {  }

    public override string IOSMediationExtraBuilderClassName {
        get { return "AmazonExtrasBuilder"; }
    }

    public void SetAllPlacements (string[] allPlacements) {
        this.Extras.Add (AllPlacementsKey, String.Join (",", allPlacements));
    }

    public void SetUserId (string userId) {
        this.Extras.Add (UserIdKey, userId);
    }

    public void SetSoundEnabled (bool soundEnabled) {
        this.Extras.Add (SoundEnabledKey, soundEnabled.ToString ());
    }
}
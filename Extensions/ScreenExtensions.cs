﻿using GTA.Native;
using CWDM.Enums;

namespace CWDM.Extensions
{
    public static class ScreenExtensions
    {
        private static readonly string[] Eff =
        {
            "SwitchHUDIn",
            "SwitchHUDOut",
            "FocusIn",
            "FocusOut",
            "MinigameEndNeutral",
            "MinigameEndTrevor",
            "MinigameEndFranklin",
            "MinigameEndMichael",
            "MinigameTransitionOut",
            "MinigameTransitionIn",
            "SwitchShortNeutralIn",
            "SwitchShortFranklinIn",
            "SwitchShortTrevorIn",
            "SwitchShortMichaelIn",
            "SwitchOpenMichaelIn",
            "SwitchOpenFranklinIn",
            "SwitchOpenTrevorIn",
            "SwitchHUDMichaelOut",
            "SwitchHUDFranklinOut",
            "SwitchHUDTrevorOut",
            "SwitchShortFranklinMid",
            "SwitchShortMichaelMid",
            "SwitchShortTrevorMid",
            "DeathFailOut",
            "CamPushInNeutral",
            "CamPushInFranklin",
            "CamPushInMichael",
            "CamPushInTrevor",
            "SwitchSceneFranklin",
            "SwitchSceneTrevor",
            "SwitchSceneMichael",
            "SwitchSceneNeutral",
            "MP_Celeb_Win",
            "MP_Celeb_Win_Out",
            "MP_Celeb_Lose",
            "MP_Celeb_Lose_Out",
            "DeathFailNeutralIn",
            "DeathFailMPDark",
            "DeathFailMPIn",
            "MP_Celeb_Preload_Fade",
            "PeyoteEndOut",
            "PeyoteEndIn",
            "PeyoteIn",
            "PeyoteOut",
            "MP_race_crash",
            "SuccessFranklin",
            "SuccessTrevor",
            "SuccessMichael",
            "DrugsMichaelAliensFightIn",
            "DrugsMichaelAliensFight",
            "DrugsMichaelAliensFightOut",
            "DrugsTrevorClownsFightIn",
            "DrugsTrevorClownsFight",
            "DrugsTrevorClownsFightOut",
            "HeistCelebPass",
            "HeistCelebPassBW",
            "HeistCelebEnd",
            "HeistCelebToast",
            "MenuMGHeistIn",
            "MenuMGTournamentIn",
            "MenuMGSelectionIn",
            "ChopVision",
            "DMT_flight_intro",
            "DMT_flight",
            "DrugsDrivingIn",
            "DrugsDrivingOut",
            "SwitchOpenNeutralFIB5",
            "HeistLocate",
            "MP_job_load",
            "RaceTurbo",
            "MP_intro_logo",
            "HeistTripSkipFade",
            "MenuMGHeistOut",
            "MP_corona_switch",
            "MenuMGSelectionTint",
            "SuccessNeutral",
            "ExplosionJosh3",
            "SniperOverlay",
            "RampageOut",
            "Rampage",
            "Dont_tazeme_bro"
        };

        private static string EffectToString(ScreenEffect screenEffect)
        {
            if (screenEffect >= 0 && (int)screenEffect <= Eff.Length)
            {
                return Eff[(int)screenEffect];
            }

            return "INVALID";
        }

        public static void StartEffect(this ScreenEffect effectName, int duration = 0, bool looped = false)
        {
            Function.Call(Hash._START_SCREEN_EFFECT, EffectToString(effectName), duration, looped);
        }

        public static void StopEffect()
        {
            Function.Call(Hash._STOP_ALL_SCREEN_EFFECTS);
        }

        public static void StopEffect(this ScreenEffect screenEffect)
        {
            Function.Call(Hash._STOP_SCREEN_EFFECT, EffectToString(screenEffect));
        }

        public static bool EffectIsActive(this ScreenEffect screenEffect)
        {
            return Function.Call<bool>(Hash._GET_SCREEN_EFFECT_IS_ACTIVE, EffectToString(screenEffect));
        }
    }
}
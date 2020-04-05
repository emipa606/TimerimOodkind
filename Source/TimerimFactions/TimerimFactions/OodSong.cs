using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;


namespace TimerimFactions
{
    public class IncidentWorker_OodSong : IncidentWorker_PsychicEmanation
    {
        protected override void DoConditionAndLetter(Map map, int duration, Gender gender)
        {
            GameCondition_PsychicEmanation gameCondition_PsychicEmanation = (GameCondition_PsychicEmanation)GameConditionMaker.MakeCondition(GameConditionDefOf.PsychicSoothe, duration, 0);
            gameCondition_PsychicEmanation.gender = gender;
            map.gameConditionManager.RegisterCondition(gameCondition_PsychicEmanation);
            string text = "LetterIncidentOodSong".Translate(new object[]
            {
                gender.ToString().Translate().ToLower()
            });

            Find.LetterStack.ReceiveLetter("LetterLabelOodSong".Translate(), text, LetterDefOf.Good, null);
        }

    }
}


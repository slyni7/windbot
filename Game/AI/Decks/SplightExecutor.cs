using System;
using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;
using System.Linq;

namespace WindBot.Game.AI.Decks
{
    [Deck("Splight", "AI_Splight")]
    class SplightExecutor : DefaultExecutor
    {
        public class CardId
        {
            public const int NibiruThePrimalBeing = 27204311;
            public const int AshBlossomJoyousSpring = 14558127;
            public const int GhostOgreSnowRabbit = 59438930;
            public const int GhostBelleHauntedMansion = 73642296;
            public const int SplightJet = 13533678;
            public const int SplightRed = 75922381;
            public const int SplightBlue = 76145933;
            public const int SplightCarrot = 2311090;
            public const int SwapFrog = 9126351;
            public const int MaxxC = 23434538;
            public const int DeepSeaDiva = 78868119;
            public const int Ronintoadin = 1357146;
            public const int DupeFrog = 46239604;
            public const int DDCrow = 24508238;
            public const int EffectVeiler = 97268402;
            public const int PotOfDisparity = 84211599;
            public const int SplightStarter = 15443125;
            public const int CalledByTheGrave = 24224830;
            public const int CrossoutDesignator = 65681983;
            public const int SplightSmashers = 88836438;
            public const int InfiniteImpermanence = 10045474;
            public const int NegologiaAAZeus = 90448279;
            public const int DownerdMagician = 72167543;
            public const int ToadallyAwesome = 90809975;
            public const int SkyCavalryCentaurea = 36776089;
            public const int SpiritingAwayOnibimaru = 9486959;
            public const int GiganticSplight = 54498517;
            public const int CatShark = 84224627;
            public const int KnightmareUnicorn = 38342335;
            public const int DharcTheDarkCharmerUmbral = 8264361;
            public const int KnightmareCerberus = 75452921;
            public const int SplightElf = 27381364;
            public const int IPMasquerena = 65741786;
            public const int SalamangreatAlmiraj = 60303245;
        }
        public SplightExecutor(GameAI ai, Duel duel)
            : base(ai, duel)
        {
            AddExecutor(ExecutorType.Activate, CardId.AshBlossomJoyousSpring, DefaultAshBlossomAndJoyousSpring);
            AddExecutor(ExecutorType.Activate, CardId.GhostBelleHauntedMansion, DefaultGhostBelleAndHauntedMansion);
            AddExecutor(ExecutorType.Activate, CardId.CalledByTheGrave, DefaultCalledByTheGrave);
            AddExecutor(ExecutorType.Activate, CardId.CrossoutDesignator, CrossoutDesignatorEffect);
            AddExecutor(ExecutorType.Activate, CardId.ToadallyAwesome, ToadallyAwesomeEffect);
            AddExecutor(ExecutorType.Activate, CardId.SplightRed, SplightRedCounter);
            AddExecutor(ExecutorType.Activate, CardId.SplightCarrot, SplightCarrotCounter);
            AddExecutor(ExecutorType.Activate, CardId.GhostOgreSnowRabbit, DefaultGhostOgreAndSnowRabbit);
            AddExecutor(ExecutorType.Activate, CardId.EffectVeiler, DefaultEffectVeiler);
            AddExecutor(ExecutorType.Activate, CardId.InfiniteImpermanence, DefaultInfiniteImpermanence);
            AddExecutor(ExecutorType.Activate, CardId.NegologiaAAZeus, NegologiaAAZeusEffect);
            AddExecutor(ExecutorType.Activate, CardId.SplightSmashers, SplightSmashersEffect);
            AddExecutor(ExecutorType.Activate, CardId.NibiruThePrimalBeing, DefaultDarkHole);
            AddExecutor(ExecutorType.Activate, CardId.MaxxC, DefaultMaxxC);
            AddExecutor(ExecutorType.Activate, CardId.SplightElf, SplightElfEffect);
            AddExecutor(ExecutorType.SpSummon, CardId.DownerdMagician, DownerdMagicianSpSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.NegologiaAAZeus, NegologiaAAZeusSpSummon);
            AddExecutor(ExecutorType.Activate, CardId.SplightStarter, SplightStarterActivate);
            AddExecutor(ExecutorType.Activate, CardId.SplightBlue, SplightBlueEffect);
            AddExecutor(ExecutorType.Activate, CardId.SplightJet, SplightJetEffect);
            AddExecutor(ExecutorType.Activate, CardId.DeepSeaDiva);
            AddExecutor(ExecutorType.Activate, CardId.DupeFrog);
            AddExecutor(ExecutorType.Activate, CardId.Ronintoadin, RonintoadinEffect);

            AddExecutor(ExecutorType.SpSummon, CardId.SkyCavalryCentaurea, SkyCavalryCentaureaSpSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.ToadallyAwesome);
            AddExecutor(ExecutorType.SpSummon, CardId.SplightRed, SplightRedSpSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SplightCarrot, SplightCarrotSpSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SplightJet, SplightJetSpSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SplightBlue, SplightBlueSpSummon);
            AddExecutor(ExecutorType.Activate, CardId.SwapFrog, SwapFrogEffect);
            AddExecutor(ExecutorType.SpSummon, CardId.SwapFrog, SwapFrogSpSummon);
            AddExecutor(ExecutorType.Activate, CardId.GiganticSplight, GiganticSplightActivate);
            AddExecutor(ExecutorType.Summon, CardId.DeepSeaDiva, SplightNormalSummon);
            AddExecutor(ExecutorType.Summon, CardId.SwapFrog, SwapFrogSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.CatShark, CatSharkSpSummon);
            AddExecutor(ExecutorType.Activate, CardId.CatShark, CatSharkEffect);
            AddExecutor(ExecutorType.SpSummon, CardId.GiganticSplight, GiganticSplightSpSummon);
            AddExecutor(ExecutorType.Activate, CardId.PotOfDisparity, PotOfDisparityActivate);
            AddExecutor(ExecutorType.SpSummon, CardId.SplightElf, SplightElfSpSummon);
            AddExecutor(ExecutorType.Summon, CardId.SplightRed, SplightNormalSummon);
            AddExecutor(ExecutorType.Summon, CardId.SplightCarrot, SplightNormalSummon);
            AddExecutor(ExecutorType.Summon, CardId.DupeFrog, SplightNormalSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SalamangreatAlmiraj, SalamangreatAlmirajSpSummon);

            AddExecutor(ExecutorType.Repos, Repos);
            AddExecutor(ExecutorType.SpellSet, SpellSet);

            // cards got by Toadally Awesome
            /*AddExecutor(ExecutorType.Activate, OtherSpellEffect);
            AddExecutor(ExecutorType.Activate, OtherTrapEffect);
            AddExecutor(ExecutorType.Activate, OtherMonsterEffect);*/
        }


        public override bool OnSelectHand()
        {
            // go first
            return true;
        }

        private bool NormalSummoned = false;
        private bool SplightElfActivated = false;
        private bool SplightRedSummoned = false;
        private bool SplightRedActivated = false;
        private bool SplightCarrotSummoned = false;
        private bool SplightCarrotActivated = false;
        private bool SplightBlueSummoned = false;
        private bool SplightBlueActivated = false;
        private bool SplightJetSummoned = false;
        private bool SplightJetActivated = false;
        private bool SplightStarterUsed = false;
        private bool SwapFrogUsed = false;
        private bool SwapFrogSummoned = false;
        private bool GiganticSplightActivated = false;
        private bool GiganticSplightUsed = false;
        private bool CannotAAZeus = false;


        public override void OnNewTurn()
        {
            NormalSummoned = false;
            SplightElfActivated = false;
            SplightRedSummoned = false;
            SplightRedActivated = false;
            SplightCarrotSummoned = false;
            SplightCarrotActivated = false;
            SplightBlueSummoned = false;
            SplightBlueActivated = false;
            SplightJetSummoned = false;
            SplightJetActivated = false;
            SplightStarterUsed = false;
            SwapFrogUsed = false;
            SwapFrogSummoned = false;
            GiganticSplightActivated = false;
            GiganticSplightUsed = false;
            CannotAAZeus = false;
        }
        public override int OnSelectPlace(long cardId, int player, CardLocation location, int available)
        {
            if (location == CardLocation.MonsterZone)
            {
                if (cardId == CardId.ToadallyAwesome)
                    return 0x4;
                else
                    return available & ~0x4;
            }
            return 0;
        }
        private bool SplightNormalSummon()
        {
            NormalSummoned = true;
            return true;
        }
        private bool SkyCavalryCentaureaSpSummon()
        {
            if (Duel.Player == 0 && (Duel.Turn == 1 || Duel.Phase >= DuelPhase.Main2))
                return false;

            if (CannotAAZeus)
                return false;


            int[] materials = new[] {
                CardId.Ronintoadin,
                CardId.DeepSeaDiva,
                CardId.MaxxC,
                CardId.SplightJet,
                CardId.SplightBlue,
                CardId.SplightCarrot,
                CardId.SplightRed,
                CardId.SwapFrog,
                CardId.DupeFrog
            };
            if (SplightElfActivated)
                materials = new[] {
                CardId.SplightElf,
                CardId.Ronintoadin,
                CardId.DeepSeaDiva,
                CardId.MaxxC,
                CardId.SplightJet,
                CardId.SplightBlue,
                CardId.SplightCarrot,
                CardId.SplightRed,
                CardId.SwapFrog,
                CardId.DupeFrog
                };
            if (Bot.MonsterZone.GetMatchingCardsCount(card => card.IsCode(materials)) >= 2)
            {
                AI.SelectMaterials(materials);
                return true;
            }
            return false;
        }
        private bool DownerdMagicianSpSummon()
        {
            List<ClientCard> monsters = Bot.GetMonsters();
            int max = 0;
            foreach (ClientCard monster in monsters)
            {
                if (monster.Overlays.Count > max)
                    max = monster.Overlays.Count;
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.Overlays.Count == max)
                {
                    AI.SelectMaterials(monster);
                    return true;
                }
            }
            return false;
        }
        private bool NegologiaAAZeusSpSummon()
        {
            List<ClientCard> monsters = Bot.GetMonsters();
            int max = 0;
            foreach (ClientCard monster in monsters)
            {
                if (monster.Overlays.Count > max)
                    max = monster.Overlays.Count;
                if (monster.IsCode(CardId.DownerdMagician))
                {
                    AI.SelectMaterials(monster);
                    return true;
                }
            }
            if (max == 0)
                return false;
            foreach (ClientCard monster in monsters)
            {
                if (monster.Overlays.Count == max)
                {
                    AI.SelectMaterials(monster);
                    return true;
                }
            }
            return false;
        }
        private bool NegologiaAAZeusEffect()
        {
            SelectXYZDetach(Card.Overlays);
            return !Duel.CurrentChain.Any(card => card.Controller == 0 && card.IsCode(CardId.NegologiaAAZeus))
                && (Bot.GetMonsterCount() + Bot.GetSpellCount() <= Enemy.GetMonsterCount() + Enemy.GetSpellCount());
        }

        private bool CrossoutDesignatorEffect()
        {
            ClientCard LastChainCard = Util.GetLastChainCard();
            if (LastChainCard == null || Duel.LastChainPlayer != 1) return false;
            return CrossoutDesignatorCheck(LastChainCard, CardId.NibiruThePrimalBeing, 1)
                || CrossoutDesignatorCheck(LastChainCard, CardId.AshBlossomJoyousSpring, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.GhostOgreSnowRabbit, 1)
                || CrossoutDesignatorCheck(LastChainCard, CardId.SplightJet, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.SplightBlue, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.SwapFrog, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.MaxxC, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.DeepSeaDiva, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.EffectVeiler, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.PotOfDisparity, 2)
                || CrossoutDesignatorCheck(LastChainCard, CardId.SplightStarter, 3)
                || CrossoutDesignatorCheck(LastChainCard, CardId.CalledByTheGrave, 2)
                || CrossoutDesignatorCheck(LastChainCard, CardId.InfiniteImpermanence, 3)
                ;
        }
        private bool CrossoutDesignatorCheck(ClientCard LastChainCard, int id, int count)
        {
            if (LastChainCard.IsCode(id) && Bot.GetRemainingCount(id, count) > 0)
            {
                AI.SelectAnnounceID(id);
                return true;
            }
            return false;
        }

        private bool ToadallyAwesomeEffect()
        {
            if (Duel.CurrentChain.Count > 0)
            {
                // negate effect, select a cost for it
                List<ClientCard> monsters = Bot.GetMonsters();
                foreach (ClientCard monster in monsters)
                {
                    if (monster.IsCode(CardId.ToadallyAwesome))
                    {
                        AI.SelectCard(monster);
                        return true;
                    }
                }
                IList<int> suitableCost = new[] {
                    CardId.SwapFrog,
                    CardId.Ronintoadin
                };
                foreach (ClientCard monster in monsters)
                {
                    if (monster.IsCode(suitableCost))
                    {
                        AI.SelectCard(monster);
                        return true;
                    }
                }
                foreach (ClientCard monster in monsters)
                {
                    if (monster.IsCode(CardId.DupeFrog))
                    {
                        AI.SelectCard(monster);
                        return true;
                    }
                }
                List<ClientCard> hands = Bot.Hand.GetMonsters();
                if (Bot.HasInGraveyard(CardId.Ronintoadin) && !Bot.HasInGraveyard(CardId.DupeFrog) && !Bot.HasInGraveyard(CardId.SwapFrog))
                {
                    foreach (ClientCard monster in hands)
                    {
                        if (monster.IsCode(CardId.DupeFrog))
                        {
                            AI.SelectCard(monster);
                            return true;
                        }
                    }
                }
                foreach (ClientCard monster in hands)
                {
                    if (monster.IsCode(CardId.Ronintoadin, CardId.DupeFrog))
                    {
                        AI.SelectCard(monster);
                        return true;
                    }
                }
                foreach (ClientCard monster in hands)
                {
                    AI.SelectCard(monster);
                    return true;
                }
                return true;
            }
            else if (Card.Location == CardLocation.Grave)
            {
                if (Bot.GetRemainingCount(CardId.DeepSeaDiva, 3) > 0)
                {
                    AI.SelectCard(CardId.DeepSeaDiva);
                }
                else
                {
                    AI.SelectCard(
                        CardId.DupeFrog,
                        CardId.SwapFrog,
                        CardId.ToadallyAwesome,
                        CardId.Ronintoadin
                        );
                }
                return true;
            }
            else if (Duel.Phase == DuelPhase.Standby)
            {
                SelectXYZDetach(Card.Overlays);
                SwapFrogSummoned = true;
                if (Duel.Player == 0)
                {
                    AI.SelectNextCard(
                        CardId.SwapFrog,
                        CardId.Ronintoadin,
                        CardId.DupeFrog
                        );
                }
                else
                {
                    AI.SelectNextCard(
                        CardId.DupeFrog,
                        CardId.SwapFrog,
                        CardId.Ronintoadin
                        );
                    AI.SelectPosition(CardPosition.FaceUpDefence);
                }
                return true;
            }
            return true;
        }
        private void SelectXYZDetach(List<int> Overlays)
        {
              AI.SelectCard(
                   CardId.ToadallyAwesome,
                   CardId.Ronintoadin,
                   CardId.DupeFrog,
                   CardId.SwapFrog,
                   CardId.SplightRed,
                   CardId.SplightCarrot,
                   CardId.SplightBlue,
                   CardId.SplightJet,
                   CardId.DeepSeaDiva,
                   CardId.MaxxC,
                   CardId.SkyCavalryCentaurea,
                   CardId.DownerdMagician,
                   CardId.SplightElf,
                   CardId.DharcTheDarkCharmerUmbral
                   );
        }
        private bool SplightRedCounter()
        {
            SplightRedActivated = true;
            return SplightCounter();
        }
        private bool SplightCarrotCounter()
        {
            SplightCarrotActivated = true;
            return SplightCounter();
        }
        private bool SplightCounter()
        {
            List<ClientCard> monsters = Bot.GetMonsters();
            if (SplightRedActivated)
            {
                foreach (ClientCard monster in monsters)
                {
                    if (monster.IsCode(CardId.SplightRed))
                    {
                        AI.SelectCard(monster);
                        return true;
                    }
                }
            }
            if (SplightCarrotActivated)
            {
                foreach (ClientCard monster in monsters)
                {
                    if (monster.IsCode(CardId.SplightCarrot))
                    {
                        AI.SelectCard(monster);
                        return true;
                    }
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.MaxxC))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.DeepSeaDiva))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.SplightBlue))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.SplightJet))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.SplightRed))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.SplightCarrot))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.KnightmareCerberus))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.ToadallyAwesome))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.IPMasquerena))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.GiganticSplight))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.SplightElf))
                {
                    AI.SelectCard(monster);
                    return true;
                }
            }
            return true;
        }
        private bool SplightSmashersEffect()
        {

            if (Duel.LastChainPlayer == 0)
                return false;
                ClientCard target = Util.GetBestEnemyCard();
                if (target == null)
                    return false;

                int[] materials = new[] {
                    CardId.SplightStarter,
                    CardId.SplightBlue,
                    CardId.SplightJet,
                    CardId.SplightElf,
                    CardId.GiganticSplight,
                    CardId.SplightCarrot,
                    CardId.SplightRed
                };
                if (Bot.Graveyard.GetMatchingCardsCount(card => card.IsCode(materials)) >= 1)
                {
                    ;
                    AI.SelectCard(materials);
                }
                else
                    return false;

                int[] materials2 = new[] {
                    CardId.SplightBlue,
                    CardId.SplightJet,
                    CardId.SplightElf,
                    CardId.GiganticSplight,
                    CardId.SplightCarrot,
                    CardId.SplightRed
                };

                if (Bot.MonsterZone.GetMatchingCardsCount(card => card.IsCode(materials2)) >= 1)
                {
                    AI.SelectNextCard(materials2);
                }
                else
                    return false;
                ClientCard target3 = Util.GetBestEnemyCard();
                if (target == null)
                    return false;
                AI.SelectThirdCard(target3);
                return true;
            }

        private bool SplightElfEffect()
        {
            List<ClientCard> monsters = Bot.GetMonsters();
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.ToadallyAwesome) && (Duel.Player == 1))
                    return false;
            }
            if ((Enemy.GetMonsterCount() == 0) && (Duel.Player == 1))
                return false;
            if ((Enemy.GetMonsterCount() > 0) && Bot.HasInGraveyard(CardId.ToadallyAwesome))
            {
                SplightElfActivated = true;
                AI.SelectCard(CardId.ToadallyAwesome);
                return true;
            }
            if (Bot.HasInGraveyard(CardId.SwapFrog))
            {
                SplightElfActivated = true;
                SwapFrogSummoned = true;
                AI.SelectCard(CardId.SwapFrog);
                return true;
            }
            int[] materials = new[] {
                    CardId.DupeFrog,
                    CardId.IPMasquerena,
                    CardId.SplightCarrot,
                    CardId.SplightRed,
                    CardId.SplightBlue,
                    CardId.SplightJet,
                    CardId.SplightElf,
                    CardId.Ronintoadin,
                    CardId.GiganticSplight
            };
            if (Bot.Graveyard.GetMatchingCardsCount(card => card.IsCode(materials)) >= 1)
            {
                SplightElfActivated = true;
                AI.SelectCard(materials);
                return true;
            }
            return false;
        }
        private bool SplightStarterActivate()
        {
            if ((Bot.HasInMonstersZone(CardId.SkyCavalryCentaurea) || Bot.HasInMonstersZone(CardId.DownerdMagician))
                && (Duel.Player == 0))
                return false;
            int[] materials = new[] {
                    CardId.ToadallyAwesome,
                    CardId.DupeFrog,
                    CardId.SplightCarrot,
                    CardId.SplightRed,
                    CardId.SplightBlue,
                    CardId.SplightJet,
                    CardId.SwapFrog,
                    CardId.Ronintoadin,
                    CardId.GiganticSplight,
                    CardId.DeepSeaDiva,
                    CardId.CatShark,
                    CardId.MaxxC,
                    CardId.SkyCavalryCentaurea,
                    CardId.SpiritingAwayOnibimaru
            };
            if (((!NormalSummoned && (Bot.HasInHand(CardId.DeepSeaDiva) || Bot.HasInHand(CardId.SwapFrog))
                ) ||
                Bot.HasInMonstersZone(materials)
                    ) && (Duel.Player == 0))
            {
                if (Bot.HasInHand(CardId.SplightBlue) && !SplightBlueSummoned)
                    return false;
                if (Bot.HasInHand(CardId.SplightJet) && !SplightJetSummoned)
                    return false;
                if (Bot.HasInHand(CardId.SplightCarrot))
                    return false;
                if (Bot.HasInHand(CardId.SplightRed))
                    return false;
            }
            SplightStarterUsed = true;
            CannotAAZeus = true;
            if ((Bot.GetRemainingCount(CardId.SplightBlue, 3) > 0) && !SplightBlueActivated
                && !SplightBlueSummoned
                && !Bot.HasInHand(CardId.SplightBlue)
                )
            {
                AI.SelectCard(CardId.SplightBlue);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightRed, 3) > 0))
            {
                AI.SelectCard(CardId.SplightRed);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightJet, 3) > 0) && !SplightJetActivated
                && !SplightJetSummoned
                && !Bot.HasInHand(CardId.SplightJet)
                && Bot.HasInDeck(CardId.SplightSmashers)
                )
            {
                SplightJetActivated = true;
                AI.SelectCard(CardId.SplightJet);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightCarrot, 3) > 0))
            {
                AI.SelectCard(CardId.SplightCarrot);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightJet, 3) > 0) && !SplightJetActivated
                && !SplightJetSummoned)
            {
                SplightJetActivated = true;
                AI.SelectCard(CardId.SplightJet);
                return true;
            }
            return true;
        }
        private bool RonintoadinEffect()
        {
            AI.SelectCard(CardId.SwapFrog, CardId.DupeFrog);
            AI.SelectPosition(CardPosition.FaceUpDefence);
            return true;
        }
        private bool SplightBlueEffect()
        {
            SplightBlueActivated = true;
            if ((Bot.GetRemainingCount(CardId.SplightJet, 3) > 0) && !SplightJetActivated
                && !SplightJetSummoned && !Bot.HasInHand(CardId.SplightJet)
                && !Bot.HasInHand(CardId.SplightStarter) && !SplightStarterUsed
                )
            {
                AI.SelectCard(CardId.SplightJet);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightRed, 1) > 0))
            {
                AI.SelectCard(CardId.SplightRed);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightCarrot, 1) > 0))
            {
                AI.SelectCard(CardId.SplightCarrot);
                return true;
            }
            if ((Bot.GetRemainingCount(CardId.SplightJet, 3) > 0))
            {
                AI.SelectCard(CardId.SplightJet);
                return true;
            }
            return true;
        }
        private bool SplightJetEffect()
        {
            SplightJetActivated = true;
            if (Bot.HasInDeck(CardId.SplightStarter) &&
                !Bot.HasInHand(CardId.SplightStarter) && !SplightStarterUsed
                )
            {
                AI.SelectCard(CardId.SplightStarter);
                return true;
            }
            if (Bot.HasInDeck(CardId.SplightSmashers))
            {
                AI.SelectCard(CardId.SplightSmashers);
                return true;
            }
            if (Bot.HasInDeck(CardId.SplightStarter))
            {
                AI.SelectCard(CardId.SplightStarter);
                return true;
            }
            return true;
        }
        private bool SplightRedSpSummon()
        {
            SplightRedSummoned = true;
            return true;
        }
        private bool SplightCarrotSpSummon()
        {
            SplightCarrotSummoned = true;
            return true;
        }
        private bool SplightBlueSpSummon()
        {
            SplightBlueSummoned = true;
            return true;
        }
        private bool SplightJetSpSummon()
        {
            SplightJetSummoned = true;
            return true;
        }
        private bool SwapFrogEffect()
        {
            if (SwapFrogSummoned)
            {
                SwapFrogSummoned = false;
                if ((Bot.GetRemainingCount(CardId.SwapFrog, 3) > 0) || (Bot.GetRemainingCount(CardId.Ronintoadin, 1) > 0))
                {
                    AI.SelectCard(
                     CardId.Ronintoadin,
                     CardId.SwapFrog,
                     CardId.DupeFrog
                    );
                    return true;
                }
                return false;
            }
            else
            {
                if (!NormalSummoned || Bot.HasInMonstersZone(CardId.MaxxC)
                    || Bot.HasInHand(CardId.Ronintoadin) || Bot.HasInHand(CardId.DupeFrog)
                    || Bot.HasInHand(CardId.SwapFrog)) {
                    AI.SelectCard(
                         CardId.MaxxC,
                         CardId.SwapFrog
                        );
                    return true;
                }
            }
            return false;
        }
        private bool GiganticSplightActivate()
        {
            if ((Bot.HasInMonstersZone(CardId.SkyCavalryCentaurea) || Bot.HasInMonstersZone(CardId.DownerdMagician))
                && (Duel.Phase == DuelPhase.Main1))
                return false;
            if (!GiganticSplightActivated)
            {
                GiganticSplightActivated = true;
                AI.SelectCard(
                CardId.Ronintoadin,
                CardId.SwapFrog,
                CardId.DupeFrog,
                CardId.SplightCarrot,
                CardId.SplightRed,
                CardId.DeepSeaDiva,
                CardId.MaxxC,
                CardId.SplightJet,
                CardId.SplightBlue,
                CardId.SplightElf);
                //return true;
            }
            CannotAAZeus = true;
            int frog = 0;
            if (Bot.HasInMonstersZoneOrInGraveyard(CardId.SwapFrog))
                frog++;
            if (Bot.HasInMonstersZoneOrInGraveyard(CardId.Ronintoadin))
                frog++;
            if (!SplightElfActivated && (frog < 2) && (Bot.GetRemainingCount(CardId.SwapFrog, 3) > 0))
            {
                SwapFrogSummoned = true;
                AI.SelectNextCard(CardId.SwapFrog);
                return true;
            }
            else if ((Bot.GetRemainingCount(CardId.SplightBlue, 3) > 0) && !SplightBlueActivated
                && !Bot.HasInHand(CardId.SplightBlue))
            {
                AI.SelectNextCard(CardId.SplightBlue);
                return true;
            }
            else if ((Bot.GetRemainingCount(CardId.SplightJet, 3) > 0) && !SplightJetActivated
                && !Bot.HasInHand(CardId.SplightJet)
                && !Bot.HasInHand(CardId.SplightStarter) && !SplightStarterUsed)
            {
                AI.SelectNextCard(CardId.SplightJet);
                return true;
            }
            else if (Bot.GetRemainingCount(CardId.SplightRed, 1) > 0)
            {
                AI.SelectNextCard(CardId.SplightRed);
                return true;
            }
            else if ((Bot.GetRemainingCount(CardId.MaxxC, 3) > 0)
                && Bot.HasInMonstersZone(CardId.SwapFrog)
                && !SwapFrogUsed)
            {
                AI.SelectNextCard(CardId.MaxxC);
                return true;
            }
            else if (Bot.GetRemainingCount(CardId.SplightCarrot, 1) > 0)
            {
                AI.SelectNextCard(CardId.SplightCarrot);
                return true;
            }
            else if (Bot.GetRemainingCount(CardId.DeepSeaDiva, 3) > 0)
            {
                AI.SelectNextCard(CardId.DeepSeaDiva);
                return true;
            }
            return true;
        }
        private bool SwapFrogSpSummon()
        {
            SwapFrogSummoned = true;
            AI.SelectCard(
                CardId.Ronintoadin,
                 CardId.SwapFrog,
                 CardId.DeepSeaDiva,
                 CardId.DupeFrog
             );
            return true;
        }
        private bool SwapFrogSummon()
        {
            SwapFrogSummoned = true;
            NormalSummoned = true;
            return true;
        }
        private bool CatSharkSpSummon()
        {
            if ((Bot.HasInMonstersZone(CardId.ToadallyAwesome) || (Bot.HasInMonstersZone(CardId.GiganticSplight)))
                && Util.IsOneEnemyBetter(true)
                    && !Bot.HasInMonstersZone(new[]
                        {
                            CardId.CatShark,
                            CardId.GiganticSplight
                        }, true, true))
            {
                AI.SelectPosition(CardPosition.FaceUpDefence);
                return true;
            }
            return false;
        }

        private bool CatSharkEffect()
        {
            List<ClientCard> monsters = Bot.GetMonsters();
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.ToadallyAwesome) && monster.Attack <= 2200)
                {
                    SelectXYZDetach(Card.Overlays);
                    AI.SelectNextCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.SkyCavalryCentaurea) && monster.Attack <= 2000)
                {
                    SelectXYZDetach(Card.Overlays);
                    AI.SelectNextCard(monster);
                    return true;
                }
            }
            foreach (ClientCard monster in monsters)
            {
                if (monster.IsCode(CardId.GiganticSplight) && monster.Attack <= 3200)
                {
                    SelectXYZDetach(Card.Overlays);
                    AI.SelectNextCard(monster);
                    return true;
                }
            }
            return false;
        }
        private bool PotOfDisparityActivate()
        {
           int[] materials = new[] {
                    CardId.SpiritingAwayOnibimaru,
                    CardId.KnightmareCerberus,
                    CardId.DharcTheDarkCharmerUmbral,
                    CardId.IPMasquerena,
                    CardId.KnightmareUnicorn,
                    CardId.CatShark
            };
                if (Bot.ExtraDeck.GetMatchingCardsCount(card => card.IsCode(materials)) >= 3)
                {
                    AI.SelectCard(materials);
                    AI.SelectNumber(3);
                if (!SplightStarterUsed && Bot.GetRemainingCount(CardId.SplightStarter, 3) > 0)
                {
                    AI.SelectNextCard(CardId.SplightStarter);
                }
                else if (!NormalSummoned && Bot.GetRemainingCount(CardId.DeepSeaDiva, 3) > 1)
                {

                    AI.SelectNextCard(CardId.DeepSeaDiva);
                }
                else if (!NormalSummoned && Bot.GetRemainingCount(CardId.SwapFrog, 3) > 0
                    && Bot.GetRemainingCount(CardId.Ronintoadin, 1) > 0)
                {

                    AI.SelectNextCard(CardId.SwapFrog);
                }
                else if (!SplightBlueSummoned && !SplightBlueActivated
                    && Bot.GetRemainingCount(CardId.SplightBlue, 3) > 0
                    && !Bot.HasInHand(CardId.SplightBlue))
                {

                    AI.SelectNextCard(CardId.SplightBlue);
                }
                else if (!SplightJetSummoned && !SplightJetActivated
                    && !SplightStarterUsed
                    && Bot.GetRemainingCount(CardId.SplightJet, 3) > 0
                    && !Bot.HasInHand(CardId.SplightJet))
                {

                    AI.SelectNextCard(CardId.SplightJet);
                }
                else if (Bot.GetRemainingCount(CardId.SplightRed, 1) > 0)
                {

                    AI.SelectNextCard(CardId.SplightRed);
                }
                else if (Bot.GetRemainingCount(CardId.SplightCarrot, 1) > 0)
                {

                    AI.SelectNextCard(CardId.SplightCarrot);
                }
                else if (Bot.GetRemainingCount(CardId.MaxxC, 3) > 0
                    && !Bot.HasInHand(CardId.MaxxC))
                {

                    AI.SelectNextCard(CardId.MaxxC);
                }
                else if (Bot.GetRemainingCount(CardId.CrossoutDesignator, 1) > 0)
                {

                    AI.SelectNextCard(CardId.CrossoutDesignator);
                }
                else if (Bot.GetRemainingCount(CardId.AshBlossomJoyousSpring, 3) > 0
                    && !Bot.HasInHand(CardId.AshBlossomJoyousSpring))
                {

                    AI.SelectNextCard(CardId.AshBlossomJoyousSpring);
                }
                else if (Bot.GetRemainingCount(CardId.CalledByTheGrave, 2) > 0)
                {

                    AI.SelectNextCard(CardId.CalledByTheGrave);
                }
                return true;
                }
            return false;
        }
        private bool GiganticSplightSpSummon()
        {
            if (GiganticSplightActivated || Bot.HasInMonstersZone(CardId.GiganticSplight))
                return false;


            int[] materials = new[] {
                CardId.Ronintoadin,
                CardId.DeepSeaDiva,
                CardId.MaxxC,
                CardId.SplightJet,
                CardId.SplightBlue,
                CardId.SplightCarrot,
                CardId.SplightRed,
                CardId.SwapFrog,
                CardId.DupeFrog
            };
            if (SplightElfActivated)
                materials = new[] {
                CardId.SplightElf,
                CardId.Ronintoadin,
                CardId.DeepSeaDiva,
                CardId.MaxxC,
                CardId.SplightJet,
                CardId.SplightBlue,
                CardId.SplightCarrot,
                CardId.SplightRed,
                CardId.SwapFrog,
                CardId.DupeFrog
                };
            if (Bot.MonsterZone.GetMatchingCardsCount(card => card.IsCode(materials)) >= 2)
            {
                AI.SelectMaterials(materials);
                return true;
            }
            return false;
        }
        private bool SplightElfSpSummon()
        {
            if (SplightElfActivated || Bot.HasInMonstersZone(CardId.SplightElf))
                return false;

            int[] materials = new[] {
                CardId.SalamangreatAlmiraj,
                CardId.SwapFrog,
                CardId.Ronintoadin,
                CardId.DeepSeaDiva,
                CardId.MaxxC,
                CardId.SplightJet,
                CardId.SplightBlue,
                CardId.GiganticSplight,
                CardId.SplightCarrot,
                CardId.SplightRed,
                CardId.DupeFrog
            };
            if (Bot.MonsterZone.GetMatchingCardsCount(card => card.IsCode(materials)) >= 2)
            {
                AI.SelectMaterials(materials);
                return true;
            }
            return false;
        }
        private bool SalamangreatAlmirajSpSummon()
        {
            int[] materials = new[] {
                CardId.SwapFrog,
                CardId.DupeFrog
            };
            if (Bot.MonsterZone.GetMatchingCardsCount(card => card.IsCode(materials) && !card.IsSpecialSummoned) == 0
                || !Bot.HasInGraveyard(CardId.Ronintoadin))
                return false;
            AI.SelectMaterials(materials);
            return true;
        }
        private bool Repos()
        {
            if (Card.IsFacedown())
                return true;
            if (Card.IsDefense() && !Util.IsAllEnemyBetter(true) && Card.Attack >= Card.Defense)
                return true;
            return false;
        }
        private bool OtherSpellEffect()
        {
            foreach (CardExecutor exec in Executors)
            {
                if (exec.Type == Type && exec.CardId == Card.Id)
                    return false;
            }
            return Card.IsSpell();
        }

        private bool OtherTrapEffect()
        {
            foreach (CardExecutor exec in Executors)
            {
                if (exec.Type == Type && exec.CardId == Card.Id)
                    return false;
            }
            return Card.IsTrap() && DefaultTrap();
        }

        private bool OtherMonsterEffect()
        {
            foreach (CardExecutor exec in Executors)
            {
                if (exec.Type == Type && exec.CardId == Card.Id)
                    return false;
            }
            return Card.IsMonster();
        }
        public bool SpellSet()
        {
            if (Duel.Phase == DuelPhase.Main1 && Bot.HasAttackingMonster() && Duel.Turn > 1) return false;
            if ((Card.IsTrap() || Card.HasType(CardType.QuickPlay)))
            {
                List<int> avoid_list = new List<int>();
                int Impermanence_set = 0;
                for (int i = 0; i < 5; ++i)
                {
                    if (Enemy.SpellZone[i] != null && Enemy.SpellZone[i].IsFaceup() && Bot.SpellZone[4 - i] == null)
                    {
                        avoid_list.Add(4 - i);
                        Impermanence_set += (int)System.Math.Pow(2, 4 - i);
                    }
                }
                if (Bot.HasInHand(CardId.InfiniteImpermanence))
                {
                    if (Card.IsCode(CardId.InfiniteImpermanence))
                    {
                        AI.SelectPlace(Impermanence_set);
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                }
                return true;
            }
            return false;
        }
    }
}

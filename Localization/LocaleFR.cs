// <copyright file="LocaleFR.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleFR.cs
// French (fr-FR) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleFR : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleFR(Setting setting)
        {
            m_Setting = setting;
        }

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            string title = Mod.ShortName;

            if (!string.IsNullOrEmpty(Mod.ModVersion))
            {
                title = title + " (" + Mod.ModVersion + ")";
            }

            return new Dictionary<string, string>
            {
                // --------------------------
                // Mod title / tabs / groups
                // --------------------------

                { m_Setting.GetSettingsLocaleID(), title },

                // Tabs
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Transport public" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "À propos" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Capacité des dépôts (nombre max. de véhicules par dépôt)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Dépôt de bus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "Modifie le nombre de bus que chaque **dépôt de bus** peut entretenir ou générer.\n" +
                                    "**100%** = vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus.\n" +
                                    "S’applique au bâtiment de base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Dépôt de ferries" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "Modifie le nombre de ferries que chaque **dépôt de ferries** peut entretenir ou générer.\n" +
                                    "**100%** = vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus.\n" +
                                    "S’applique au bâtiment de base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Dépôt de métro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "Modifie le nombre de véhicules de métro que chaque **dépôt de métro** peut entretenir.\n" +
                                    "**100%** = vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus.\n" +
                                    "S’applique au bâtiment de base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Dépôt de taxis" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "Modifie le nombre de taxis que chaque **dépôt de taxis** peut entretenir.\n" +
                                    "**100%** = vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus.\n" +
                                    "Des valeurs élevées peuvent créer trop de circulation de taxis."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Dépôt de tramways" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "Modifie le nombre de tramways que chaque **dépôt de tramways** peut entretenir.\n" +
                                    "**100%** = vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus.\n" +
                                    "S’applique au bâtiment de base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Dépôt de trains" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "Modifie le nombre de trains que chaque **dépôt de trains** peut entretenir.\n" +
                                    "**100%** = vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus.\n" +
                                    "S’applique au bâtiment de base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Réinitialiser les dépôts" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Remet tous les curseurs de dépôt à **100%** (valeur par défaut / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Capacité passagers (nombre max. de personnes par véhicule)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Bus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "Modifie la capacité **passagers des bus**.\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Tramway" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "Modifie la capacité **passagers des tramways**.\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Train" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "Modifie la capacité **passagers des trains**.\n" +
                                    "S’applique aux locomotives et aux sections.\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Métro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "Modifie la capacité **passagers du métro**.\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Navire" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "Modifie la capacité des **navires de passagers** (pas les cargos).\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Ferry" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "Modifie la capacité **passagers des ferries**.\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Avion" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "Modifie la capacité **passagers des avions**.\n" +
                                    "**10%** = 10% des places vanilla.\n" +
                                    "**100%** = places vanilla (valeur par défaut du jeu).\n" +
                                    "**1000%** = 10× plus de places."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Doubler tous les passagers" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "Règle tous les curseurs passagers sur **200%**." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Réinitialiser les passagers" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Remet tous les curseurs passagers à **100%** (valeur par défaut / vanilla)." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Infos" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Liens d’aide" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Débogage / journalisation" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Journaux" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Nom affiché de ce mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Version" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Version actuelle du mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Ouvrir la page Paradox Mods de l’auteur." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Ouvrir le Discord de la communauté dans un navigateur." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Journaux de débogage détaillés" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "Envoie des détails supplémentaires dans le fichier journal de ce mod pour le débogage.\n" +
                                    "**Désactivez** cette option en jeu normal, car trop de journaux peut réduire les performances.\n" +
                                    "<Cela augmente seulement la journalisation et ne change aucune valeur de gameplay.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Ouvrir le journal" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "Ouvre le fichier journal de ce mod s’il existe. Sinon, ouvre le dossier Logs du jeu." },
            };
        }

        public void Unload()
        {
        }
    }
}

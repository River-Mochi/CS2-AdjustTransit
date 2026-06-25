// <copyright file="LocaleIT.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleIT.cs
// Italian (it-IT) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleIT : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleIT(Setting setting)
        {
            m_Setting = setting;
        }

        private static string DebugGroupName()
        {
#if DEBUG
            return "Debug / log";
#else
            return "Log";
#endif
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Trasporto pubblico" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Informazioni" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Capacità depositi (veicoli max per deposito)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Deposito autobus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "Modifica quanti autobus ogni **deposito autobus** può mantenere o generare.\n" +
                                    "**100%** = vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× in più.\n" +
                                    "Si applica all’edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Deposito traghetti" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "Modifica quanti traghetti ogni **deposito traghetti** può mantenere o generare.\n" +
                                    "**100%** = vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× in più.\n" +
                                    "Si applica all’edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Deposito metro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "Modifica quanti veicoli della metro ogni **deposito metro** può mantenere.\n" +
                                    "**100%** = vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× in più.\n" +
                                    "Si applica all’edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Deposito taxi" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "Modifica quanti taxi ogni **deposito taxi** può mantenere.\n" +
                                    "**100%** = vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× in più.\n" +
                                    "Valori alti possono creare traffico taxi eccessivo."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Deposito tram" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "Modifica quanti tram ogni **deposito tram** può mantenere.\n" +
                                    "**100%** = vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× in più.\n" +
                                    "Si applica all’edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Deposito treni" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "Modifica quanti treni ogni **deposito treni** può mantenere.\n" +
                                    "**100%** = vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× in più.\n" +
                                    "Si applica all’edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Ripristina depositi" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Riporta tutti gli slider dei depositi a **100%** (predefinito / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Capacità passeggeri (persone max per veicolo)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Autobus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "Modifica la capacità **passeggeri degli autobus**.\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Tram" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "Modifica la capacità **passeggeri dei tram**.\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Treno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "Modifica la capacità **passeggeri dei treni**.\n" +
                                    "Si applica a motrici e sezioni.\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Metro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "Modifica la capacità **passeggeri della metro**.\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Nave" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "Modifica la capacità delle **navi passeggeri** (non cargo).\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Traghetto" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "Modifica la capacità **passeggeri dei traghetti**.\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Aereo" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "Modifica la capacità **passeggeri degli aerei**.\n" +
                                    "**10%** = 10% dei posti vanilla.\n" +
                                    "**100%** = posti vanilla (predefinito del gioco).\n" +
                                    "**1000%** = 10× posti in più."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Raddoppia tutti i passeggeri" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "Imposta ogni slider passeggeri a **200%**." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Ripristina passeggeri" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Riporta tutti gli slider passeggeri a **100%** (predefinito / vanilla)." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Info" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Link di supporto" },
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), DebugGroupName() },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Nome visualizzato di questo mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Versione" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Versione attuale del mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Apre la pagina Paradox Mods dell’autore." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Apre il Discord della community nel browser." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Log di debug dettagliati" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "Invia dettagli aggiuntivi al file log di questo mod per il debug.\n" +
                                    "**Disattiva** durante il gioco normale, perché troppi log possono ridurre le prestazioni.\n" +
                                    "<Aumenta solo la registrazione dei log e non cambia valori di gameplay.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Apri log" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "Apre il file log di questo mod se esiste. Altrimenti apre la cartella Logs del gioco." },
            };
        }

        public void Unload()
        {
        }
    }
}

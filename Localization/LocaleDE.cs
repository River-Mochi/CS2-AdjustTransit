// <copyright file="LocaleDE.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleDE.cs
// German (de-DE) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleDE : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleDE(Setting setting)
        {
            m_Setting = setting;
        }

        private static string DebugGroupName()
        {
#if DEBUG
            return "Debug / Logging";
#else
            return "Logs";
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Öffentlicher Verkehr" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Info" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Depotkapazität (max. Fahrzeuge pro Depot)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Busdepot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "Ändert, wie viele Busse jedes **Busdepot** unterhalten oder spawnen kann.\n" +
                                    "**100%** = Vanilla (Spielstandard).\n" +
                                    "**1000%** = 10× mehr.\n" +
                                    "Gilt für das Basisgebäude."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Fährdepot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "Ändert, wie viele Fähren jedes **Fährdepot** unterhalten oder spawnen kann.\n" +
                                    "**100%** = Vanilla (Spielstandard).\n" +
                                    "**1000%** = 10× mehr.\n" +
                                    "Gilt für das Basisgebäude."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "U-Bahn-Depot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "Ändert, wie viele U-Bahn-Fahrzeuge jedes **U-Bahn-Depot** unterhalten kann.\n" +
                                    "**100%** = Vanilla (Spielstandard).\n" +
                                    "**1000%** = 10× mehr.\n" +
                                    "Gilt für das Basisgebäude."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Taxidepot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "Ändert, wie viele Taxis jedes **Taxidepot** unterhalten kann.\n" +
                                    "**100%** = Vanilla (Spielstandard).\n" +
                                    "**1000%** = 10× mehr.\n" +
                                    "Hohe Werte können zu sehr viel Taxiverkehr führen."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Straßenbahndepot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "Ändert, wie viele Straßenbahnen jedes **Straßenbahndepot** unterhalten kann.\n" +
                                    "**100%** = Vanilla (Spielstandard).\n" +
                                    "**1000%** = 10× mehr.\n" +
                                    "Gilt für das Basisgebäude."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Zugdepot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "Ändert, wie viele Züge jedes **Zugdepot** unterhalten kann.\n" +
                                    "**100%** = Vanilla (Spielstandard).\n" +
                                    "**1000%** = 10× mehr.\n" +
                                    "Gilt für das Basisgebäude."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Depots zurücksetzen" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Setzt alle Depot-Schieberegler auf **100%** zurück (Spielstandard / Vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Passagierkapazität (max. Personen pro Fahrzeug)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Bus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "Ändert die **Bus-Passagierkapazität**.\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Straßenbahn" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "Ändert die **Straßenbahn-Passagierkapazität**.\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Zug" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "Ändert die **Zug-Passagierkapazität**.\n" +
                                    "Gilt für Triebfahrzeuge und Abschnitte.\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "U-Bahn" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "Ändert die **U-Bahn-Passagierkapazität**.\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Schiff" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "Ändert die Kapazität von **Passagierschiffen** (keine Frachtschiffe).\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Fähre" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "Ändert die **Fähren-Passagierkapazität**.\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Flugzeug" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "Ändert die **Flugzeug-Passagierkapazität**.\n" +
                                    "**10%** = 10% der Vanilla-Sitze.\n" +
                                    "**100%** = Vanilla-Sitze (Spielstandard).\n" +
                                    "**1000%** = 10× mehr Sitze."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Alle Passagiere verdoppeln" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "Setzt jeden Passagier-Schieberegler auf **200%**." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Passagiere zurücksetzen" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Setzt alle Passagier-Schieberegler auf **100%** zurück (Spielstandard / Vanilla)." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Info" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Support-Links" },
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), DebugGroupName() },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Anzeigename dieses Mods." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Version" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Aktuelle Mod-Version." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Öffnet die Paradox-Mods-Seite des Autors." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Öffnet den Community-Discord im Browser." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Ausführliche Debug-Logs" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "Schreibt zusätzliche Details zur Fehlersuche in die Logdatei dieses Mods.\n" +
                                    "**Deaktivieren** für normales Spielen, da zu viele Logs die Leistung verringern können.\n" +
                                    "<Dies erhöht nur die Protokollierung und ändert keine Spielwerte.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Log öffnen" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "Öffnet die Logdatei dieses Mods, wenn sie existiert. Sonst wird der Logs-Ordner des Spiels geöffnet." },
            };
        }

        public void Unload()
        {
        }
    }
}

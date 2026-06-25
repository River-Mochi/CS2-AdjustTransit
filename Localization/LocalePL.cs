// <copyright file="LocalePL.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocalePL.cs
// Polish (pl-PL) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocalePL : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocalePL(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Transport publiczny" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Informacje" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Pojemność zajezdni (maks. pojazdów na zajezdnię)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Zajezdnia autobusowa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "Zmienia, ile autobusów może utrzymywać lub tworzyć każda **zajezdnia autobusowa**.\n" +
                                    "**100%** = vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej.\n" +
                                    "Dotyczy budynku podstawowego."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Zajezdnia promów" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "Zmienia, ile promów może utrzymywać lub tworzyć każda **zajezdnia promów**.\n" +
                                    "**100%** = vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej.\n" +
                                    "Dotyczy budynku podstawowego."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Zajezdnia metra" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "Zmienia, ile pojazdów metra może utrzymywać każda **zajezdnia metra**.\n" +
                                    "**100%** = vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej.\n" +
                                    "Dotyczy budynku podstawowego."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Zajezdnia taksówek" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "Zmienia, ile taksówek może utrzymywać każda **zajezdnia taksówek**.\n" +
                                    "**100%** = vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej.\n" +
                                    "Wysokie wartości mogą tworzyć nadmierny ruch taksówek."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Zajezdnia tramwajowa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "Zmienia, ile tramwajów może utrzymywać każda **zajezdnia tramwajowa**.\n" +
                                    "**100%** = vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej.\n" +
                                    "Dotyczy budynku podstawowego."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Zajezdnia kolejowa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "Zmienia, ile pociągów może utrzymywać każda **zajezdnia kolejowa**.\n" +
                                    "**100%** = vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej.\n" +
                                    "Dotyczy budynku podstawowego."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Resetuj zajezdnie" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Ustawia wszystkie suwaki zajezdni na **100%** (domyślna wartość / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Pojemność pasażerów (maks. osób na pojazd)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Autobus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "Zmienia pojemność **pasażerów autobusów**.\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Tramwaj" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "Zmienia pojemność **pasażerów tramwajów**.\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Pociąg" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "Zmienia pojemność **pasażerów pociągów**.\n" +
                                    "Dotyczy silników i sekcji.\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Metro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "Zmienia pojemność **pasażerów metra**.\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Statek" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "Zmienia pojemność **statków pasażerskich** (nie statków cargo).\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Prom" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "Zmienia pojemność **pasażerów promów**.\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Samolot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "Zmienia pojemność **pasażerów samolotów**.\n" +
                                    "**10%** = 10% miejsc vanilla.\n" +
                                    "**100%** = miejsca vanilla (domyślna wartość gry).\n" +
                                    "**1000%** = 10× więcej miejsc."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Podwój wszystkich pasażerów" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "Ustawia każdy suwak pasażerów na **200%**." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Resetuj pasażerów" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Ustawia wszystkie suwaki pasażerów na **100%** (domyślna wartość / vanilla)." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Informacje" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Linki wsparcia" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Debug / logi" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Logi" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Wyświetlana nazwa tego moda." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Wersja" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Aktualna wersja moda." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Otwiera stronę autora w Paradox Mods." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Otwiera Discord społeczności w przeglądarce." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Szczegółowe logi debug" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "Zapisuje dodatkowe informacje do pliku logu tego moda na potrzeby debugowania.\n" +
                                    "**Wyłącz** podczas normalnej gry, ponieważ zbyt dużo logów może obniżyć wydajność.\n" +
                                    "<To tylko zwiększa logowanie i nie zmienia wartości rozgrywki.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Otwórz log" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "Otwiera plik logu tego moda, jeśli istnieje. Jeśli nie, otwiera folder Logs gry." },
            };
        }

        public void Unload()
        {
        }
    }
}

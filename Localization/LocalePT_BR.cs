// <copyright file="LocalePT_BR.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocalePT_BR.cs
// Portuguese Brazil (pt-BR) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocalePT_BR : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocalePT_BR(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Transporte público" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Sobre" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Capacidade dos depósitos (máx. veículos por depósito)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Depósito de ônibus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "Altera quantos ônibus cada **depósito de ônibus** pode manter ou gerar.\n" +
                                    "**100%** = vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais.\n" +
                                    "Aplica-se ao prédio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Depósito de balsas" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "Altera quantas balsas cada **depósito de balsas** pode manter ou gerar.\n" +
                                    "**100%** = vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais.\n" +
                                    "Aplica-se ao prédio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Depósito de metrô" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "Altera quantos veículos de metrô cada **depósito de metrô** pode manter.\n" +
                                    "**100%** = vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais.\n" +
                                    "Aplica-se ao prédio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Depósito de táxis" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "Altera quantos táxis cada **depósito de táxis** pode manter.\n" +
                                    "**100%** = vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais.\n" +
                                    "Valores altos podem criar tráfego excessivo de táxis."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Depósito de bondes" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "Altera quantos bondes cada **depósito de bondes** pode manter.\n" +
                                    "**100%** = vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais.\n" +
                                    "Aplica-se ao prédio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Depósito de trens" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "Altera quantos trens cada **depósito de trens** pode manter.\n" +
                                    "**100%** = vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais.\n" +
                                    "Aplica-se ao prédio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Redefinir depósitos" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Define todos os controles de depósito de volta para **100%** (padrão / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Capacidade de passageiros (máx. pessoas por veículo)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Ônibus" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "Altera a capacidade de **passageiros dos ônibus**.\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Bonde" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "Altera a capacidade de **passageiros dos bondes**.\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Trem" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "Altera a capacidade de **passageiros dos trens**.\n" +
                                    "Aplica-se a motores e seções.\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Metrô" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "Altera a capacidade de **passageiros do metrô**.\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Navio" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "Altera a capacidade de **navios de passageiros** (não navios de carga).\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Balsa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "Altera a capacidade de **passageiros das balsas**.\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Avião" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "Altera a capacidade de **passageiros dos aviões**.\n" +
                                    "**10%** = 10% dos assentos vanilla.\n" +
                                    "**100%** = assentos vanilla (padrão do jogo).\n" +
                                    "**1000%** = 10× mais assentos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Dobrar todos os passageiros" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "Define todos os controles de passageiros para **200%**." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Redefinir passageiros" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Define todos os controles de passageiros de volta para **100%** (padrão / vanilla)." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Info" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Links de suporte" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Depuração / logs" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Logs" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Nome exibido deste mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Versão" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Versão atual do mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Abre a página do autor no Paradox Mods." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Abre o Discord da comunidade no navegador." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Logs de depuração detalhados" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "Envia detalhes extras para o arquivo de log deste mod para depuração.\n" +
                                    "**Desative** no jogo normal, pois logs excessivos podem reduzir o desempenho.\n" +
                                    "<Isso só aumenta os logs e não altera valores de gameplay.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Abrir log" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "Abre o arquivo de log deste mod se ele existir. Caso contrário, abre a pasta Logs do jogo." },
            };
        }

        public void Unload()
        {
        }
    }
}

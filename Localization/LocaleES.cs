// <copyright file="LocaleES.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleES.cs
// Spanish (es-ES) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleES : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleES(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Acerca de" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Capacidad de depósitos (vehículos máx. por depósito)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Depósito de autobuses" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "Cambia cuántos autobuses puede mantener o generar cada **depósito de autobuses**.\n" +
                                    "**100%** = vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más.\n" +
                                    "Se aplica al edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Depósito de ferris" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "Cambia cuántos ferris puede mantener o generar cada **depósito de ferris**.\n" +
                                    "**100%** = vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más.\n" +
                                    "Se aplica al edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Depósito de metro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "Cambia cuántos vehículos de metro puede mantener cada **depósito de metro**.\n" +
                                    "**100%** = vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más.\n" +
                                    "Se aplica al edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Depósito de taxis" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "Cambia cuántos taxis puede mantener cada **depósito de taxis**.\n" +
                                    "**100%** = vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más.\n" +
                                    "Los valores altos pueden crear demasiado tráfico de taxis."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Depósito de tranvías" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "Cambia cuántos tranvías puede mantener cada **depósito de tranvías**.\n" +
                                    "**100%** = vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más.\n" +
                                    "Se aplica al edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Depósito de trenes" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "Cambia cuántos trenes puede mantener cada **depósito de trenes**.\n" +
                                    "**100%** = vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más.\n" +
                                    "Se aplica al edificio base."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Restablecer depósitos" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Pone todos los controles de depósito en **100%** (valor predeterminado / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Capacidad de pasajeros (personas máx. por vehículo)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Autobús" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "Cambia la capacidad de **pasajeros de autobús**.\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Tranvía" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "Cambia la capacidad de **pasajeros de tranvía**.\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Tren" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "Cambia la capacidad de **pasajeros de tren**.\n" +
                                    "Se aplica a motores y secciones.\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Metro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "Cambia la capacidad de **pasajeros de metro**.\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Barco" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "Cambia la capacidad de **barcos de pasajeros** (no barcos de carga).\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Ferri" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "Cambia la capacidad de **pasajeros de ferri**.\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Avión" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "Cambia la capacidad de **pasajeros de avión**.\n" +
                                    "**10%** = 10% de los asientos vanilla.\n" +
                                    "**100%** = asientos vanilla (valor predeterminado del juego).\n" +
                                    "**1000%** = 10× más asientos."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Duplicar todos los pasajeros" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "Pone todos los controles de pasajeros en **200%**." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Restablecer pasajeros" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Pone todos los controles de pasajeros en **100%** (valor predeterminado / vanilla)." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Información" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Enlaces de ayuda" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Depuración / registros" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Registros" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Nombre mostrado de este mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Versión" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Versión actual del mod." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Abre la página de Paradox Mods del autor." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Abre el Discord de la comunidad en un navegador." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Registros de depuración detallados" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "Envía detalles adicionales al archivo de registro de este mod para depuración.\n" +
                                    "**Desactívalo** durante el juego normal, porque demasiados registros pueden reducir el rendimiento.\n" +
                                    "<Esto solo aumenta los registros y no cambia valores de juego.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Abrir registro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "Abre el archivo de registro de este mod si existe. Si no, abre la carpeta Logs del juego." },
            };
        }

        public void Unload()
        {
        }
    }
}

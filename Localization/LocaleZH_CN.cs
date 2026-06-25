// <copyright file="LocaleZH_CN.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleZH_CN.cs
// Simplified Chinese (zh-HANS) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleZH_CN : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleZH_CN(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "公共交通" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "关于" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "车库容量（每个车库最大车辆数）" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "公交车库" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "更改每个**公交车库**可维护或生成的公交车数量。\n" +
                                    "**100%** = 原版（游戏默认）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "适用于基础建筑。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "渡轮车库" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "更改每个**渡轮车库**可维护或生成的渡轮数量。\n" +
                                    "**100%** = 原版（游戏默认）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "适用于基础建筑。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "地铁车库" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "更改每个**地铁车库**可维护的地铁车辆数量。\n" +
                                    "**100%** = 原版（游戏默认）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "适用于基础建筑。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "出租车车库" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "更改每个**出租车车库**可维护的出租车数量。\n" +
                                    "**100%** = 原版（游戏默认）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "数值过高可能产生过多出租车交通。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "电车车库" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "更改每个**电车车库**可维护的电车数量。\n" +
                                    "**100%** = 原版（游戏默认）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "适用于基础建筑。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "火车车库" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "更改每个**火车车库**可维护的火车数量。\n" +
                                    "**100%** = 原版（游戏默认）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "适用于基础建筑。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "重置车库默认值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "将所有车库滑块恢复为 **100%**（游戏默认 / 原版）。" },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "乘客容量（每辆车最大人数）" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "公交车" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "更改**公交车乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "电车" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "更改**电车乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "火车" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "更改**火车乘客**容量。\n" +
                                    "适用于车头和车厢段。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "地铁" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "更改**地铁乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "船" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "更改**客船**容量（不包括货船）。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "渡轮" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "更改**渡轮乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "飞机" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "更改**飞机乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（游戏默认）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "所有乘客容量翻倍" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "将每个乘客滑块设置为 **200%**。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "重置乘客默认值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "将所有乘客滑块恢复为 **100%**（游戏默认 / 原版）。" },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "信息" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "支持链接" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "调试 / 日志" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "日志" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "模组" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "此模组的显示名称。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "版本" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "当前模组版本。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "打开作者的 Paradox Mods 页面。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "在浏览器中打开社区 Discord。" },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "详细调试日志" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "将额外细节写入此模组的日志文件，用于调试。\n" +
                                    "正常游玩时请**关闭**，过多日志可能降低性能。\n" +
                                    "<这只会增加日志记录，不会更改游戏数值。>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "打开日志" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "如果此模组的日志文件存在，则打开它。否则打开游戏 Logs 文件夹。" },
            };
        }

        public void Unload()
        {
        }
    }
}

// <copyright file="LocaleZH_HANT.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleZH_HANT.cs
// Traditional Chinese (zh-HANT) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleZH_HANT : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleZH_HANT(Setting setting)
        {
            m_Setting = setting;
        }

        private static string DebugGroupName()
        {
#if DEBUG
            return "偵錯 / 記錄";
#else
            return "記錄";
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "大眾運輸" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "關於" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "車庫容量（每個車庫最大車輛數）" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "公車車庫" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "變更每個**公車車庫**可維護或生成的公車數量。\n" +
                                    "**100%** = 原版（遊戲預設）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "套用於基礎建築。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "渡輪車庫" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "變更每個**渡輪車庫**可維護或生成的渡輪數量。\n" +
                                    "**100%** = 原版（遊戲預設）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "套用於基礎建築。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "捷運車庫" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "變更每個**捷運車庫**可維護的捷運車輛數量。\n" +
                                    "**100%** = 原版（遊戲預設）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "套用於基礎建築。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "計程車車庫" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "變更每個**計程車車庫**可維護的計程車數量。\n" +
                                    "**100%** = 原版（遊戲預設）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "數值過高可能造成過多計程車交通。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "路面電車車庫" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "變更每個**路面電車車庫**可維護的電車數量。\n" +
                                    "**100%** = 原版（遊戲預設）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "套用於基礎建築。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "火車車庫" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "變更每個**火車車庫**可維護的火車數量。\n" +
                                    "**100%** = 原版（遊戲預設）。\n" +
                                    "**1000%** = 10倍。\n" +
                                    "套用於基礎建築。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "重設車庫預設值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "將所有車庫滑桿重設為 **100%**（遊戲預設 / 原版）。" },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "乘客容量（每輛車最大人數）" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "公車" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "變更**公車乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "路面電車" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "變更**路面電車乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "火車" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "變更**火車乘客**容量。\n" +
                                    "套用於車頭與車廂段。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "捷運" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "變更**捷運乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "船舶" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "變更**客船**容量（不包含貨船）。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "渡輪" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "變更**渡輪乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "飛機" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "變更**飛機乘客**容量。\n" +
                                    "**10%** = 原版座位的10%。\n" +
                                    "**100%** = 原版座位（遊戲預設）。\n" +
                                    "**1000%** = 10倍座位。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "所有乘客容量加倍" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "將每個乘客滑桿設定為 **200%**。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "重設乘客預設值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "將所有乘客滑桿重設為 **100%**（遊戲預設 / 原版）。" },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "資訊" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "支援連結" },
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), DebugGroupName() },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "模組" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "此模組的顯示名稱。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "版本" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "目前模組版本。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "開啟作者的 Paradox Mods 頁面。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "在瀏覽器中開啟社群 Discord。" },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "詳細偵錯記錄" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "將額外細節寫入此模組的記錄檔，用於偵錯。\n" +
                                    "正常遊玩時請**關閉**，過多記錄可能降低效能。\n" +
                                    "<這只會增加記錄，不會變更遊戲數值。>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "開啟記錄" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "如果此模組的記錄檔存在，則開啟它。否則開啟遊戲 Logs 資料夾。" },
            };
        }

        public void Unload()
        {
        }
    }
}

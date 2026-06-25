// <copyright file="LocaleVI.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleVI.cs
// Vietnamese (vi-VN) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleVI : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleVI(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Giao thông công cộng" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Giới thiệu" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Sức chứa depot (số xe tối đa mỗi depot)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Depot xe buýt" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                    "Thay đổi số xe buýt mà mỗi **Bus Depot** có thể bảo trì hoặc tạo ra.\n" +
                    "**100%** = vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10×.\n" +
                    "Áp dụng cho tòa nhà chính."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Depot phà" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                    "Thay đổi số phà mà mỗi **Ferry Depot** có thể bảo trì hoặc tạo ra.\n" +
                    "**100%** = vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10×.\n" +
                    "Áp dụng cho tòa nhà chính."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Depot tàu điện ngầm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                    "Thay đổi số xe tàu điện ngầm mà mỗi **Subway Depot** có thể bảo trì.\n" +
                    "**100%** = vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10×.\n" +
                    "Áp dụng cho tòa nhà chính."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Depot taxi" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                    "Thay đổi số taxi mà mỗi **Taxi Depot** có thể bảo trì.\n" +
                    "**100%** = vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10×.\n" +
                    "Giá trị cao có thể tạo quá nhiều lưu lượng taxi."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Depot tram" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                    "Thay đổi số tram mà mỗi **Tram Depot** có thể bảo trì.\n" +
                    "**100%** = vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10×.\n" +
                    "Áp dụng cho tòa nhà chính."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Depot tàu hỏa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                    "Thay đổi số tàu mà mỗi **Train Depot** có thể bảo trì.\n" +
                    "**100%** = vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10×.\n" +
                    "Áp dụng cho tòa nhà chính."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Đặt lại depot về mặc định" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)),
                    "Đưa tất cả thanh trượt depot về **100%** (mặc định của game / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Sức chứa hành khách (số người tối đa mỗi xe)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Xe buýt" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                    "Thay đổi sức chứa **hành khách xe buýt**.\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Tram" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                    "Thay đổi sức chứa **hành khách tram**.\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Tàu hỏa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                    "Thay đổi sức chứa **hành khách tàu hỏa**.\n" +
                    "Áp dụng cho đầu máy và các toa/phần.\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Tàu điện ngầm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                    "Thay đổi sức chứa **hành khách tàu điện ngầm**.\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Tàu thủy" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                    "Thay đổi sức chứa **tàu chở khách** (không phải tàu hàng).\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Phà" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                    "Thay đổi sức chứa **hành khách phà**.\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Máy bay" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                    "Thay đổi sức chứa **hành khách máy bay**.\n" +
                    "**10%** = 10% số ghế vanilla.\n" +
                    "**100%** = số ghế vanilla (mặc định của game).\n" +
                    "**1000%** = nhiều hơn 10× số ghế."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Gấp đôi tất cả hành khách" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)),
                    "Đặt mọi thanh trượt hành khách thành **200%**."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Đặt lại tất cả hành khách" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)),
                    "Đưa tất cả thanh trượt hành khách về **100%** (mặc định của game / vanilla)."
                },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Thông tin" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Liên kết hỗ trợ" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Gỡ lỗi / Ghi log" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Logs" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Tên hiển thị của mod này." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Phiên bản" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Phiên bản mod hiện tại." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Mở trang Paradox Mods của tác giả." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Mở Discord cộng đồng trong trình duyệt." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Log gỡ lỗi chi tiết" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                    "Ghi thêm chi tiết vào file log của mod này để gỡ lỗi.\n" +
                    "**Tắt** khi chơi bình thường, vì quá nhiều log có thể làm giảm hiệu năng.\n" +
                    "<Tùy chọn này chỉ tăng ghi log và không thay đổi giá trị gameplay.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Mở log" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)),
                    "Mở file log của mod này nếu có. Nếu chưa có, mở thư mục Logs của game."
                },
            };
        }

        public void Unload()
        {
        }
    }
}

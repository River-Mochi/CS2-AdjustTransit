// <copyright file="LocaleKO.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleKO.cs
// Korean (ko-KR) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleKO : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleKO(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "대중교통" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "정보" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "차고지 용량(차고지당 최대 차량 수)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "버스 차고지" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                                    "각 **버스 차고지**가 유지하거나 생성할 수 있는 버스 수를 변경합니다.\n" +
                                    "**100%** = 바닐라(게임 기본값).\n" +
                                    "**1000%** = 10배.\n" +
                                    "기본 건물에 적용됩니다."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "페리 차고지" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                                    "각 **페리 차고지**가 유지하거나 생성할 수 있는 페리 수를 변경합니다.\n" +
                                    "**100%** = 바닐라(게임 기본값).\n" +
                                    "**1000%** = 10배.\n" +
                                    "기본 건물에 적용됩니다."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "지하철 차고지" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                                    "각 **지하철 차고지**가 유지할 수 있는 지하철 차량 수를 변경합니다.\n" +
                                    "**100%** = 바닐라(게임 기본값).\n" +
                                    "**1000%** = 10배.\n" +
                                    "기본 건물에 적용됩니다."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "택시 차고지" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                                    "각 **택시 차고지**가 유지할 수 있는 택시 수를 변경합니다.\n" +
                                    "**100%** = 바닐라(게임 기본값).\n" +
                                    "**1000%** = 10배.\n" +
                                    "높은 값은 택시 교통량을 과도하게 만들 수 있습니다."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "트램 차고지" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                                    "각 **트램 차고지**가 유지할 수 있는 트램 수를 변경합니다.\n" +
                                    "**100%** = 바닐라(게임 기본값).\n" +
                                    "**1000%** = 10배.\n" +
                                    "기본 건물에 적용됩니다."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "열차 차고지" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                                    "각 **열차 차고지**가 유지할 수 있는 열차 수를 변경합니다.\n" +
                                    "**100%** = 바닐라(게임 기본값).\n" +
                                    "**1000%** = 10배.\n" +
                                    "기본 건물에 적용됩니다."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "차고지 기본값으로 재설정" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "모든 차고지 슬라이더를 **100%**(게임 기본값 / 바닐라)로 되돌립니다." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "승객 용량(차량당 최대 인원)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "버스" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                                    "**버스 승객** 용량을 변경합니다.\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "트램" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                                    "**트램 승객** 용량을 변경합니다.\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "열차" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                                    "**열차 승객** 용량을 변경합니다.\n" +
                                    "기관차와 구간에 적용됩니다.\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "지하철" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                                    "**지하철 승객** 용량을 변경합니다.\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "선박" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                                    "**여객선** 용량을 변경합니다(화물선 제외).\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "페리" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                                    "**페리 승객** 용량을 변경합니다.\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "비행기" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                                    "**비행기 승객** 용량을 변경합니다.\n" +
                                    "**10%** = 바닐라 좌석의 10%.\n" +
                                    "**100%** = 바닐라 좌석(게임 기본값).\n" +
                                    "**1000%** = 좌석 10배."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "모든 승객 2배" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)), "모든 승객 슬라이더를 **200%**로 설정합니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "승객 기본값으로 재설정" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "모든 승객 슬라이더를 **100%**(게임 기본값 / 바닐라)로 되돌립니다." },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "정보" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "지원 링크" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "디버그 / 로그" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "로그" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "모드" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "이 모드의 표시 이름입니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "버전" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "현재 모드 버전입니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "제작자의 Paradox Mods 페이지를 엽니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "커뮤니티 Discord를 브라우저에서 엽니다." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "자세한 디버그 로그" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                                    "디버깅을 위해 이 모드의 로그 파일에 추가 정보를 기록합니다.\n" +
                                    "정상 플레이에서는 **끄세요**. 로그가 너무 많으면 성능이 낮아질 수 있습니다.\n" +
                                    "<로그만 늘리며 게임플레이 값은 변경하지 않습니다.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "로그 열기" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)), "이 모드의 로그 파일이 있으면 엽니다. 없으면 게임 Logs 폴더를 엽니다." },
            };
        }

        public void Unload()
        {
        }
    }
}

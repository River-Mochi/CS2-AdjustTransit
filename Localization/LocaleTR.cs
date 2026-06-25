// <copyright file="LocaleTR.cs" company="River-Mochi">
// Copyright (c) 2026 River-Mochi. All rights reserved.
// Licensed under the MIT License. You may not use this file except in compliance with this License.
// See LICENSE file in the project root for full license information.
// This notice and the MIT License notice must be kept with
// all copies or substantial portions of this code.
// ================= </copyright> ======================

// File: Localization/LocaleTR.cs
// Turkish (tr-TR) strings for Options UI.

namespace AdjustTransit
{
    using System.Collections.Generic;
    using Colossal;

    public sealed class LocaleTR : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleTR(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.PublicTransitTab), "Toplu Taşıma" },
                { m_Setting.GetOptionTabLocaleID(Setting.AboutTab), "Hakkında" },

                // --------------------
                // Public Transit tab
                // --------------------

                // Depot capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.DepotGroup), "Depo kapasitesi (depo başına azami araç)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusDepotScalar)), "Otobüs deposu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusDepotScalar)),
                    "Her **Otobüs Deposu**nun kaç otobüsü bakıma alabileceğini veya çıkarabileceğini değiştirir.\n" +
                    "**100%** = vanilla (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla.\n" +
                    "Ana binaya uygulanır."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryDepotScalar)), "Feribot deposu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryDepotScalar)),
                    "Her **Feribot Deposu**nun kaç feribotu bakıma alabileceğini veya çıkarabileceğini değiştirir.\n" +
                    "**100%** = vanilla (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla.\n" +
                    "Ana binaya uygulanır."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayDepotScalar)), "Metro deposu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayDepotScalar)),
                    "Her **Metro Deposu**nun kaç metro aracını bakıma alabileceğini değiştirir.\n" +
                    "**100%** = vanilla (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla.\n" +
                    "Ana binaya uygulanır."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TaxiDepotScalar)), "Taksi deposu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TaxiDepotScalar)),
                    "Her **Taksi Deposu**nun kaç taksiyi bakıma alabileceğini değiştirir.\n" +
                    "**100%** = vanilla (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla.\n" +
                    "Yüksek değerler aşırı taksi trafiği oluşturabilir."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramDepotScalar)), "Tramvay deposu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramDepotScalar)),
                    "Her **Tramvay Deposu**nun kaç tramvayı bakıma alabileceğini değiştirir.\n" +
                    "**100%** = vanilla (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla.\n" +
                    "Ana binaya uygulanır."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainDepotScalar)), "Tren deposu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainDepotScalar)),
                    "Her **Tren Deposu**nun kaç treni bakıma alabileceğini değiştirir.\n" +
                    "**100%** = vanilla (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla.\n" +
                    "Ana binaya uygulanır."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetDepotToVanillaButton)), "Depo varsayılanlarını sıfırla" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetDepotToVanillaButton)),
                    "Tüm depo kaydırıcılarını **100%** değerine döndürür (oyun varsayılanı / vanilla)." },

                // Passenger capacity sliders
                { m_Setting.GetOptionGroupLocaleID(Setting.PassengerGroup), "Yolcu kapasitesi (araç başına azami kişi)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BusPassengerScalar)), "Otobüs" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BusPassengerScalar)),
                    "**Otobüs yolcu** kapasitesini değiştirir.\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TramPassengerScalar)), "Tramvay" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TramPassengerScalar)),
                    "**Tramvay yolcu** kapasitesini değiştirir.\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TrainPassengerScalar)), "Tren" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TrainPassengerScalar)),
                    "**Tren yolcu** kapasitesini değiştirir.\n" +
                    "Lokomotiflere ve bölümlere uygulanır.\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.SubwayPassengerScalar)), "Metro" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.SubwayPassengerScalar)),
                    "**Metro yolcu** kapasitesini değiştirir.\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShipPassengerScalar)), "Gemi" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShipPassengerScalar)),
                    "**Yolcu gemisi** kapasitesini değiştirir (kargo gemileri değil).\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FerryPassengerScalar)), "Feribot" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FerryPassengerScalar)),
                    "**Feribot yolcu** kapasitesini değiştirir.\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirplanePassengerScalar)), "Uçak" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirplanePassengerScalar)),
                    "**Uçak yolcu** kapasitesini değiştirir.\n" +
                    "**10%** = vanilla koltukların %10’u.\n" +
                    "**100%** = vanilla koltuklar (oyun varsayılanı).\n" +
                    "**1000%** = 10× daha fazla koltuk."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DoublePassengersButton)), "Tüm yolcuları iki katına çıkar" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DoublePassengersButton)),
                    "Her yolcu kaydırıcısını **200%** yapar."
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetPassengerToVanillaButton)), "Tüm yolcuları sıfırla" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetPassengerToVanillaButton)),
                    "Tüm yolcu kaydırıcılarını **100%** değerine döndürür (oyun varsayılanı / vanilla)."
                },

                // -------------------
                // About tab
                // -------------------

                { m_Setting.GetOptionGroupLocaleID(Setting.AboutInfoGroup), "Bilgi" },
                { m_Setting.GetOptionGroupLocaleID(Setting.AboutLinksGroup), "Destek bağlantıları" },

#if DEBUG
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Debug / Günlükleme" },
#else
                { m_Setting.GetOptionGroupLocaleID(Setting.DebugGroup), "Günlükler" },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)), "Bu modun görünen adı." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Sürüm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)), "Geçerli mod sürümü." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadoxMods)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadoxMods)), "Yazarın Paradox Mods sayfasını açar." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)), "Topluluk Discord’unu tarayıcıda açar." },

#if DEBUG
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableDebugLogging)), "Ayrıntılı debug günlükleri" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableDebugLogging)),
                    "Hata ayıklama için bu modun günlük dosyasına ek ayrıntılar yazar.\n" +
                    "**Normal oyun için devre dışı bırakın**, çünkü aşırı günlükleme performansı düşürebilir.\n" +
                    "<Bu yalnızca günlüklemeyi artırır ve oyun değerlerini değiştirmez.>"
                },
#endif

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenLogButton)), "Günlüğü aç" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenLogButton)),
                    "Varsa bu modun günlük dosyasını açar. Yoksa oyunun Logs klasörünü açar."
                },
            };
        }

        public void Unload()
        {
        }
    }
}

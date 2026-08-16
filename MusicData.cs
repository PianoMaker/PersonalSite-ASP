    namespace PersonalSite.Data
    {
        public class MusicalWork
        {
            public string Section { get; set; } = "";
            public string Subsection { get; set; } = "";

            public string UkTitle { get; set; } = "";
            public string EnTitle { get; set; } = "";

            public string UkMeta { get; set; } = "";
            public string EnMeta { get; set; } = "";

            public List<WorkLink> Links { get; set; } = new();
        }

        public class WorkLink
        {
            public string Type { get; set; } = "";
            public string UkText { get; set; } = "";
            public string EnText { get; set; } = "";
            public string Url { get; set; } = "";
        }


        public static class MusicData
        {
            public static List<MusicalWork> Works { get; } = new()
            {

                // =====================================================
                // СЦЕНІЧНІ ТВОРИ
                // =====================================================

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Золота середина»",
                    EnTitle = "«Golden Middle»",
                    UkMeta = "вокально-хореографічний дивертисмент · 2003 · лібрето О. Толокна та автора",
                    EnMeta = "vocal and choreographic divertissement · 2003 · libretto by O. Tolokna and the composer"
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Вигнання з раю»",
                    EnTitle = "«The Expulsion from Paradise»",
                    UkMeta = "міні-опера на біблійний сюжет · 2002",
                    EnMeta = "mini-opera on a biblical subject · 2002"
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Райок по-українськи»",
                    EnTitle = "«Ukrainian rajok»",
                    UkMeta = "2004–2006",
                    EnMeta = "2004–2006",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ч. 1",
                            EnText = "Part 1",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d180d0b0d191d0ba-1-ed-2021.pdf"
                        },
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ч. 2",
                            EnText = "Part 2",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d180d0b0d0b9d0bed0ba-2.pdf"
                        },
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ч. 3",
                            EnText = "Part 3",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d180d0b0d0b9d0bed0ba-3.pdf"
                        },
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ч. 4",
                            EnText = "Part 4",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d180d0b0d0b9d0bed0ba-4.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Ходить гарбуз по городу»",
                    EnTitle = "«Ходить гарбуз по городу»",
                    UkMeta = "вокально-хореографічна сцена на народні слова · 2007",
                    EnMeta = "vocal and choreographic scene based on folk texts · 2007"
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Муха-цокотуха»",
                    EnTitle = "«Муха-цокотуха»",
                    UkMeta = "дитячий балет за мотивами казки К. Чуковського · 2008",
                    EnMeta = "children’s ballet based on the fairy tale K. Chukovsky · 2008"
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Маугліана»",
                    EnTitle = "«Maugliana»",
                    UkMeta = "дитячий балет за мотивами казки Р. Кіплінга · 2009",
                    EnMeta = "children’s ballet based on the fairy tale R. Kipling · 2009"
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Аліса в дивокраї»",
                    EnTitle = "«Alice on the Wonderland»",
                    UkMeta = "дитячий балет за мотивами казки Л. Керрола · 2011",
                    EnMeta = "children’s ballet based on the fairy tale L. Carroll · 2011"
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Різдвяна казка»",
                    EnTitle = "«Christmas carrol»",
                    UkMeta = "мюзикл за мотивами казки Ч. Діккенса · 2018 · лібрето Олени О’Лір",
                    EnMeta = "musical based on the fairy tale C. Dickens · 2018 · libretto by Olena O’Lir",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "відео",
                            EnText = "video",
                            Url = "https://www.youtube.com/watch?v=W2TjB6Kch9I"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "scene",
                    UkTitle = "«Кай і Герда»",
                    EnTitle = "«Кай і Герда»",
                    UkMeta = "дитячий мюзикл за мотивами казки Г. С. Андерсена · 2021 · сценарій — Оксана Дондик · лібрето — Олена О’Лір",
                    EnMeta = "children’s musical based on the fairy tale H. C. Andersen · 2021 · script by Oksana Dondyk · libretto by Olena O’Lir",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "відео",
                            EnText = "video",
                            Url = "https://www.youtube.com/watch?v=B6O8p78a5Y4"
                        }
                    }
                },


                // =====================================================
                // СИМФОНІЧНИЙ ОРКЕСТР
                // =====================================================

                new MusicalWork
                {
                    Section = "simphony",
                    UkTitle = "Симфонічна поема «Смуток над Дніпром»",
                    EnTitle = "«Смуток над Дніпром»",
                    UkMeta = "1996",
                    EnMeta = "Symphonic poem · 1996"
                },

                new MusicalWork
                {
                    Section = "simphony",
                    UkTitle = "Концерт для фортепіано з оркестром",
                    EnTitle = "Piano Concerto with orchestra",
                    UkMeta = "2002",
                    EnMeta = "2002"
                },

                new MusicalWork
                {
                    Section = "simphony",
                    UkTitle = "Симфонічна поема «2004»",
                    EnTitle = "«2004»",
                    UkMeta = "2006",
                    EnMeta = "Symphonic poem · 2006",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/2004-simphonic-poem.pdf"
                        },
                        new WorkLink
                        {
                            Type = "audio",
                            UkText = "аудіо",
                            EnText = "audio",
                            Url = "https://www.youtube.com/watch?v=gVBZaQBNiGA"
                        }
                    }
                },


                // =====================================================
                // КАМЕРНО-ВОКАЛЬНІ
                // =====================================================

                new MusicalWork
                {
                    Section = "vocal",
                    UkTitle = "Вокальний цикл на вірші Ліни Костенко",
                    EnTitle = "Vocal cycle to poems by Lina Kostenko",
                    UkMeta = "ноти",
                    EnMeta = "score",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ф-но",
                            EnText = "piano",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d09b-d09ad0bed181d182d0b5d0bdd0bad0be-d184d0bed180d182d0b5d0bfd196d0b0d0bdd0bdd196.pdf"
                        },
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "оркестр",
                            EnText = "orchestra",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d09b-d09ad0bed181d0182d0b5d0bdd0bad0be-d0bed180d0bad0b5d181d182d180.pdf"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "ф-но, В. Лук’янець",
                            EnText = "piano, В. Лук’янець",
                            Url = "https://www.youtube.com/watch?v=WAGVpm1taeo"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "оркестр, М. Саламін",
                            EnText = "orchestra, М. Саламін",
                            Url = "https://www.youtube.com/watch?v=F60hL-7gAes"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "vocal",
                    UkTitle = "Камерна кантата «Er selbst wird kommen»",
                    EnTitle = "Chamber cantata «Er selbst wird kommen»",
                    UkMeta = "1999",
                    EnMeta = "1999"
                },

                new MusicalWork
                {
                    Section = "vocal",
                    UkTitle = "«Садок вишневий»",
                    EnTitle = "«Садок вишневий»",
                    UkMeta = "на слова Олени О’Лір · 2019",
                    EnMeta = "words by Olena O’Lir · 2019",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d09b-d09ad0bed181d182d0b5d0bdd0bad0be-d184d0bed180d182d0b5d0bfd196d0b0d0bdd0bdd196.pdf"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "В. Лук’янець",
                            EnText = "В. Лук’янець",
                            Url = "https://www.youtube.com/watch?v=54DaEgX5r5U"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "О. Євсюкова",
                            EnText = "О. Євсюкова",
                            Url = "https://www.youtube.com/watch?v=rg1OGvHUmAg"
                        }
                    }
                },


                // =====================================================
                // ТРІО БАНДУРИСТОК
                // =====================================================

                new MusicalWork
                {
                    Section = "bandura",
                    UkTitle = "«Бандурою прикриюсь як щитом»",
                    EnTitle = "«Бандурою прикриюсь як щитом»",
                    UkMeta = "2012",
                    EnMeta = "2012",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "audio",
                            UkText = "аудіо",
                            EnText = "audio",
                            Url = "https://soundcloud.com/nf0mocjilsnz/banduroyu-prikriyus-yak-shchitom"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "bandura",
                    UkTitle = "«Ой чорна я си чорна»",
                    EnTitle = "«Oh, I Am Black»",
                    UkMeta = "2012",
                    EnMeta = "2012",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "audio",
                            UkText = "аудіо",
                            EnText = "audio",
                            Url = "https://soundcloud.com/nf0mocjilsnz/oj-chorna-ya-si-chorna"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "bandura",
                    UkTitle = "«І на оновленій землі»",
                    EnTitle = "«І на оновленій землі»",
                    UkMeta = "2025 · адаптація хору",
                    EnMeta = "2025 · choral adaptation"
                },


                // =====================================================
                // ЕСТРАДНІ
                // =====================================================

                new MusicalWork
                {
                    Section = "pop",
                    UkTitle = "«Гімн Вікіпедії»",
                    EnTitle = "«Hymn to Wikipedia»",
                    UkMeta = "для читця, вокального та інструментального ансамблів · 2016 · на тексти настанов і правил Вікіпедії",
                    EnMeta = "for narrator, vocal and instrumental ensembles · 2016 · to texts based on Wikipedia guidelines and rules",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/wikipedia-light.pdf"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "версія 1.0",
                            EnText = "version 1.0",
                            Url = "https://www.youtube.com/watch?v=UVK57ZRRICE"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "версія 1.1",
                            EnText = "version 1.1",
                            Url = "https://www.youtube.com/watch?v=4W0eZxwB12w"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "версія 2.0 (електронна)",
                            EnText = "version 2.0 (electronic)",
                            Url = "https://www.youtube.com/watch?v=7payAIi9sKE"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "pop",
                    UkTitle = "«Реформа»",
                    EnTitle = "«Reform»",
                    UkMeta = "текст Півтона Безвухого",
                    EnMeta = "text by Pivton Bezvukhy",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "соло Едгар Бондаренко",
                            EnText = "solo performance by Edgar Bondarenko",
                            Url = "https://www.youtube.com/watch?v=HD-H2kpNw8I"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "вокальний ансамбль «semplice», Павло Зубов",
                            EnText = "vocal ensemble “semplice”, Pavlo Zubov",
                            Url = "https://www.youtube.com/watch?v=7WAMjPz6WnQ"
                        }
                    }
                },


                // =====================================================
                // ХОР
                // =====================================================

                new MusicalWork
                {
                    Section = "choir",
                    UkTitle = "Хоровий диптих на слова Т. Шевченка",
                    EnTitle = "Choral diptych to words by T. Shevchenko",
                    UkMeta = "2005",
                    EnMeta = "2005",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d094d0b8d0bfd182d0b8d185-d0bdd0b0-d181d0bbd0bed0b2d0b0-d0a8d0b5d0b2d187d0b5d0bdd0bad0b0.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "choir",
                    UkTitle = "Чотири аранжування українських пісень",
                    EnTitle = "Four arrangements of Ukrainian songs",
                    UkMeta = "2016 · «Ой чий то кінь стоїть» · «Туман яром» · «Ой ти місяцю» · «Ой чорна я си чорна»",
                    EnMeta = "2016 · «Oi, Whose Horse Is Standing There» · «Fog over the Ravine» · «Oh, You Moon» · «Oh, I Am Black»",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "audio",
                            UkText = "аудіо",
                            EnText = "audio",
                            Url = "https://soundcloud.com/akadiemichniikamierniikhorkhrieshchatik/oj-chorna-ya-si-chorna"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "choir",
                    UkTitle = "«І на оновленій землі»",
                    EnTitle = "«І на оновленій землі»",
                    UkMeta = "слова Т. Шевченка · 2025",
                    EnMeta = "words by T. Shevchenko · 2025",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "відео, хор «Anima»",
                            EnText = "video, choir «Anima»",
                            Url = "https://www.youtube.com/watch?v=wriHnJoOS0s"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "choir",
                    UkTitle = "«Всевишній, всемогутній Судіє»",
                    EnTitle = "«Всевишній, всемогутній Судіє»",
                    UkMeta = "слова Олени О'Лір' · 2026",
                    EnMeta = "words by Olena O'Lir' · 2026",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "відео, хор «Anima»",
                            EnText = "video, choir «Anima»",
                            Url = "https://www.youtube.com/watch?v=ro69xVgX72Y"
                        }
                    }
                },


                // =====================================================
                // ФОРТЕПІАНО
                // =====================================================

               new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "Соната",
        EnTitle = "Sonata",
        UkMeta = "2002",
        EnMeta = "2002"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "«Калейдоскоп»",
        EnTitle = "“Kaleidoscope”",
        UkMeta = "1989",
        EnMeta = "1989",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d0bad0b0d0bbd0b5d0b9d0b4d0bed181d0bad0bed0bf.pdf"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "Варіації",
        EnTitle = "Variations",
        UkMeta = "1996",
        EnMeta = "1996"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "Диптих",
        EnTitle = "Diptych",
        UkMeta = "2002",
        EnMeta = "2002"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "Пара фраз на тему О. Костіна",
        EnTitle = "A Couple of Phrases on a Theme by O. Kostin",
        UkMeta = "2007",
        EnMeta = "2007"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "Прелюдія і фуга",
        EnTitle = "Prelude and Fugue",
        UkMeta = "2026",
        EnMeta = "2026"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "two-hands",
        UkTitle = "«Епітафія»",
        EnTitle = "“Epitaph”",
        UkMeta = "Пам'яті українців, що постраждали від польської агресії, 2026",
        EnMeta = "In memory of Ukrainians who suffered from Polish aggression, 2026"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Щедрик»",
        EnTitle = "“Shchedryk”",
        UkMeta = "за М. Леонтовичем",
        EnMeta = "after M. Leontovych",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d0a9d0b5d0b4d180d0b8d0ba-d184d0bdd0be.pdf"
            },
            new WorkLink
            {
                Type = "video",
                UkText = "відео",
                EnText = "video",
                Url = "https://www.youtube.com/watch?v=pj7qcL5hIK0"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Козака несуть»",
        EnTitle = "“They Carry the Cossack”",
        UkMeta = "за М. Леонтовичем",
        EnMeta = "after M. Leontovych",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d09ad0bed0b7d0b0d0bad0b0-d0bdd0b5d181d183d182d18c.pdf"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Дударик»",
        EnTitle = "“Dudaryk”",
        UkMeta = "за М. Леонтовичем",
        EnMeta = "after M. Leontovych",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d094d183d0b4d0b0d180d0b8d0ba3.pdf"
            },
            new WorkLink
            {
                Type = "video",
                UkText = "відео",
                EnText = "video",
                Url = "https://www.youtube.com/watch?v=Yp0UlAdhiog"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Бог ся рождає»",
        EnTitle = "“God Is Born”",
        UkMeta = "колядка",
        EnMeta = "carol",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d0b1d0bed0b3-d181d18f-d180d0bed0b6d0b4d0b0d194-d0b4d0b6d0b0d0b7.pdf"
            },
            new WorkLink
            {
                Type = "audio",
                UkText = "аудіо",
                EnText = "audio",
                Url = "https://soundcloud.com/nf0mocjilsnz/wav-4"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Нова радість стала»",
        EnTitle = "“A New Joy Has Come”",
        UkMeta = "колядка",
        EnMeta = "carol",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d09dd0bed0b2d0b0-d180d0b0d0b4d196d181d182d18c-d181d182d0b0d0bbd0b0-d184d0bdd0be-v2020.pdf"
            },
            new WorkLink
            {
                Type = "audio",
                UkText = "аудіо",
                EnText = "audio",
                Url = "https://soundcloud.com/nf0mocjilsnz/wav-2"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Радуйся»",
        EnTitle = "“Rejoice”",
        UkMeta = "колядка",
        EnMeta = "carol",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d0a0d0b0d0b4d183d0b9d181d18f3.pdf"
            },
            new WorkLink
            {
                Type = "audio",
                UkText = "аудіо",
                EnText = "audio",
                Url = "https://soundcloud.com/nf0mocjilsnz/wav-3"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Ой сивая та і зозуленька»",
        EnTitle = "“Oh, the Grey Cuckoo”",
        UkMeta = "",
        EnMeta = "",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d09ed0b9-d181d0b8d0b2d0b0d18f-d182d0b0-d196-d0b7d0bed0b7d183d0bbd0b5d0bdd18cd0bad0b0.pdf"
            },
            new WorkLink
            {
                Type = "audio",
                UkText = "аудіо",
                EnText = "audio",
                Url = "https://soundcloud.com/nf0mocjilsnz/wav-1"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Третій празник»",
        EnTitle = "“The Third Feast”",
        UkMeta = "",
        EnMeta = "",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d0a2d180d0b5d182d196d0b9-d0bfd180d0b0d0b7d0bdd0b8d0ba.pdf"
            },
            new WorkLink
            {
                Type = "audio",
                UkText = "аудіо",
                EnText = "audio",
                Url = "https://soundcloud.com/nf0mocjilsnz/wav"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Чичері»",
        EnTitle = "“Chycheri”",
        UkMeta = "«Ой Марічко, чичері» за М. Кречком",
        EnMeta = "“Oi Marichko, Chycheri” after M. Krechko",
        Links = new()
        {
            new WorkLink
            {
                Type = "audio",
                UkText = "аудіо",
                EnText = "audio",
                Url = "https://youtu.be/rA48ivF8suo"
            },
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d187d0b8d187d0b5d180d1962.pdf"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Галя»",
        EnTitle = "“Halya”",
        UkMeta = "«Несе галя воду»",
        EnMeta = "“Nese Halya Vodu”",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d093d0b0d0bbd18f.pdf"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "folk",
        UkTitle = "«Ой у лузі червона калина»",
        EnTitle = "“Oh, the Red Viburnum in the Meadow”",
        UkMeta = "",
        EnMeta = "",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d09ed0b9-d183-d0bbd183d0b7d196-d184d0bed0bdd0be-21-05.pdf"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "four-hands",
        UkTitle = "«Магістерія»",
        EnTitle = "“Magisteria”",
        UkMeta = "2000",
        EnMeta = "2000",
        Links = new()
        {
            new WorkLink
            {
                Type = "notes",
                UkText = "ноти",
                EnText = "score",
                Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d0a9d0b5d0b4d180d0b8d0ba-d184d0bdd0be.pdf"
            },
            new WorkLink
            {
                Type = "video",
                UkText = "відео",
                EnText = "video",
                Url = "https://www.youtube.com/watch?v=pj7qcL5hIK0"
            }
        }
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "four-hands",
        UkTitle = "«Черніана»",
        EnTitle = "“Czerniana”",
        UkMeta = "2001",
        EnMeta = "2001"
    },

    new MusicalWork
    {
        Section = "piano",
        Subsection = "four-hands",
        UkTitle = "«Разом»",
        EnTitle = "“Together”",
        UkMeta = "2013",
        EnMeta = "2013",
        Links = new()
        {
            new WorkLink
            {
                Type = "video",
                UkText = "відео",
                EnText = "video",
                Url = "https://youtu.be/J0dNPuhIQLE"
            }
        }
    },


                // =====================================================
                // АРАНЖУВАННЯ НАРОДНИХ ПІСЕНЬ
                // =====================================================

                new MusicalWork
                {
                    Section = "folk",
                    UkTitle = "Чотири народні пісні для голосу і фортепіано",
                    EnTitle = "Four folk songs for voice and piano",
                    UkMeta = "2014 · редакція 2022",
                    EnMeta = "2014 · revision 2022"
                },

                new MusicalWork
                {
                    Section = "folk",
                    UkTitle = "«Ой у лузі червона калина»",
                    EnTitle = "«Ой у лузі червона калина»",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d09ed0b9-d183-d0bbd183d0b7d196-v2022-fis.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "folk",
                    UkTitle = "«Лента за лентою»",
                    EnTitle = "«Лента за лентою»",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/06/d0bbd0b5d0bdd182d0b0-d0b7d0b0-d0bbd0b5d0bdd182d0bed18e-v2022-full-score.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "folk",
                    UkTitle = "«Ой у лісі на полянці»",
                    EnTitle = "«Ой у лісі на полянці»",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/06/d09ed0b9-d183-d0bbd196d181d196-v2022.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "folk",
                    UkTitle = "«За Україну»",
                    EnTitle = "«За Україну»",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d097d0b0-d0a3d0bad180d0b0d197d0bdd183-v2022-g.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "folk",
                    UkTitle = "«Зродились ми великої години»",
                    EnTitle = "«Зродились ми великої години»",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/07/d097d180d0bed0b4d0b8d0bbd0b8d181d18c-d0bcd0b8-d0b2d0b5d0bbd0b8d0bad0bed197-d0b3d0bed0b4d0b8d0bdd0b8.pdf"
                        }
                    }
                },


                // =====================================================
                // DVD
                // =====================================================

                new MusicalWork
                {
                    Section = "DVD",
                    UkTitle = "DVD2 cours de danse contemporaine",
                    EnTitle = "DVD2 cours de danse contemporaine",
                    UkMeta = "",
                    EnMeta = "",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "resource",
                            UkText = "DVD",
                            EnText = "DVD",
                            Url = "http://www.editionsbourgblanc.com/home/"
                        }
                    }
                },


                // =====================================================
                // POP & AI
                // =====================================================

                new MusicalWork
                {
                    Section = "POP",
                    UkTitle = "“Не позичай мені свою любов, не позичай”",
                    EnTitle = "“Не позичай мені свою любов, не позичай”",
                    UkMeta = "на слова С. Галябарди · 2009",
                    EnMeta = "words by S. Haliabarda · 2009",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "pdf",
                            EnText = "PDF",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d0bdd0b5-d0bfd0bed0b7d0b8d187d0b0d0b9-d0bcd0b5d0bbd0bed0b4d196d18f.-d0b2d0b8d0bfd180d0b0d0b2d0bbd0b5d0bdd0be.pdf"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "POP",
                    UkTitle = "«Мамо»",
                    EnTitle = "«Мамо»",
                    UkMeta = "фантазія на популярні теми, для хору і оркестру · 2010<br>версія для тріо бандуристок · 2010",
                    EnMeta = "fantasy on popular themes, for choir and orchestra · 2010<br>version for bandura trio · 2010"
                },

                new MusicalWork
                {
                    Section = "POP",
                    UkTitle = "«Шлях на обрії»",
                    EnTitle = "«Path to horizon»",
                    UkMeta = "музика для презентації автівок для скрипки, гобоя, тромбона, віолончелі і фортепіано",
                    EnMeta = "music for a car presentation for violin, oboe, trombone, cello and piano",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "audio",
                            UkText = "аудіо",
                            EnText = "audio",
                            Url = "https://xn----7sbbdnci1aowedigth08a.skysound7.com/t/15085689362120855012-%D0%B0%D0%BD%D0%B4%D1%80%D1%96%D0%B9-%D0%B1%D0%BE%D0%BD%D0%B4%D0%B0%D1%80%D0%B5%D0%BD%D0%BA%D0%BE-%D1%88%D0%BB%D1%8F%D1%85-%D0%BD%D0%B0-%D0%BE%D0%B1%D1%80%D1%96%D1%97/"
                        }
                    }
                },

                new MusicalWork
                {
                    Section = "POP",
                    UkTitle = "«Прекрасний Києве»",
                    EnTitle = "«Прекрасний Києве»",
                    UkMeta = "на слова М. Рильського · Es-moll, fis-moll",
                    EnMeta = "words by M. Rylskyi · Es-moll, fis-moll",
                    Links = new()
                    {
                        new WorkLink
                        {
                            Type = "notes",
                            UkText = "ноти",
                            EnText = "score",
                            Url = "https://andrijbondarenko.wordpress.com/wp-content/uploads/2022/03/d09fd180d0b5d0bad180d0b0d181d0bdd0b8d0b9-d09ad0b8d194d0b2d0b5-d182d180d0b0d0bdd181d0bfd0bed180d182-fis.pdf"
                        },
                        new WorkLink
                        {
                            Type = "video",
                            UkText = "відео",
                            EnText = "video",
                            Url = "https://www.youtube.com/watch?v=6F6CFhsQ9JY"
                        }
                    }
                }
            };
        }
    }